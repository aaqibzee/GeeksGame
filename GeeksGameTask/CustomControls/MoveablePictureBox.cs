using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Drawing.Imaging;
using static GeeksGameTask.CustomControls.DataConstants;
using static GeeksGameTask.Utilities.ApplicationDelegates;

namespace GeeksGameTask.CustomControls
{
    public class MoveablePictureBox:PictureBox
    {
        #region Declarations
        private Point locationAtMouseDown;
        private Point chineseBoxLocation = new Point(720, -30);
        private Point thaiBoxLocation = new Point(720, 550);
        private Point japaneseBoxLocation = new Point(0, 0);
        private Point koreanBoxLocation = new Point(0, 550);
        private Point endPoint = new Point(331, 700);
        private Point startPoint;
        private Point mouseLastPosition;
        private Point mouseDelta;

        private int mouseMovement = 80;
        private int minimumMouseMovementInPixels = 20;
        private int numberOfStepsToDestination = 50;
        private int delayInMovement = 2;
        private int maximumOpacity = 211;
        private int opacityTarget = 200;
        private int stepToDownwards = 30;
        
        private string nationalitySelectedByPlayer;
        private bool moveDownwards;
        private Timer timer;
        public event  UpdateScore updateScore;
        public event GetNextImage getNextImageToDraw;
        #endregion

        #region Public Methods
        public void InitializeComponent()
        {
            this.Image = getNextImageToDraw.Invoke();
            mouseLastPosition = MousePosition;
            startPoint = this.Location;
            timer = new Timer();
            //Unregister first, if event is already registred(incase of replay), to avoid multiple registerations
            timer.Tick -= Timer_Tick;
            timer.Tick += Timer_Tick;
            moveDownwards = true;
            this.Location = startPoint;
            timer.Start();
            nationalitySelectedByPlayer = string.Empty;
        }

        public MoveablePictureBox (IContainer container)
        {
            container.Add(this);
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// Called when Mouse Button is down
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            locationAtMouseDown = e.Location;
            base.OnMouseDown(e);    
        }
        /// <summary>
        /// Called when mouse is moved on picture box
        /// </summary>
        /// <param name="event"></param>
        protected override void OnMouseMove(MouseEventArgs @event)
        {
            if (@event.Button == MouseButtons.Left && moveDownwards)
            {
                this.Left += (@event.X - locationAtMouseDown.X) / mouseMovement;
                this.Top += (@event.Y - locationAtMouseDown.Y) / mouseMovement;
            }
            base.OnMouseMove(@event);
        }
        /// <summary>
        /// Called when Mouse button is released 
        /// Check in what direction player pointed the box, then move the box towards the asked nationality
        /// </summary>
        /// <param name="event"></param>
        protected override void OnMouseUp(MouseEventArgs @event)
        {
            if (moveDownwards)
            {
                mouseDelta = new Point(@event.Location.X - locationAtMouseDown.X, @event.Location.Y - locationAtMouseDown.Y);
                int horizontalChange = Math.Abs(mouseDelta.X);
                int verticalChange = Math.Abs(mouseDelta.Y);
                
                if (horizontalChange > minimumMouseMovementInPixels || verticalChange > minimumMouseMovementInPixels)
                {
                    var direction = DecideDirection(mouseDelta);

                    if (direction == Direction.UpLeft)
                    {
                        nationalitySelectedByPlayer = DataConstants.JapaneseNationality;
                        MoveTowards(japaneseBoxLocation);
                    }
                    else if (direction == Direction.UpRight)
                    {
                        nationalitySelectedByPlayer = DataConstants.ChineseNationality;
                        MoveTowards(chineseBoxLocation);
                    }
                    else if (direction == Direction.DownLeft)
                    {
                        nationalitySelectedByPlayer = DataConstants.KoreanNationality;
                        MoveTowards(koreanBoxLocation);
                    }
                    else if (direction == Direction.DownRight)
                    {
                        nationalitySelectedByPlayer = DataConstants.ThaiNationality;
                        MoveTowards(thaiBoxLocation);
                    }
                    base.OnMouseUp(@event);
                }
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Decide in what direction mouse was pointed
        /// </summary>
        /// <param name="changeInmouseLocation"></param>
        /// <returns></returns>
        private Direction DecideDirection(Point changeInmouseLocation)
        {
            if(changeInmouseLocation.X>0 && changeInmouseLocation.Y>0)
            {
                return Direction.DownRight;
            }
            else if (changeInmouseLocation.X > 0 && changeInmouseLocation.Y < 0)
            {
                return Direction.UpRight;
            }
            else if (changeInmouseLocation.X < 0 && changeInmouseLocation.Y < 0)
            {
                return Direction.UpLeft;
            }
            else
            {
                return Direction.DownLeft;
            }
        }
        /// <summary>
        /// Moves to the provided point on screen
        /// </summary>
        /// <param name="destination"></param>
        private  async void MoveTowards(Point destination)
        {   
            int pixelsToMoveInHorizontalDirection = (destination.X- Location.X)/numberOfStepsToDestination;
            int pixelsToMoveInVerticalDirection = (destination.Y - Location.Y)/numberOfStepsToDestination;
            int missingOffsetInHorizontalDirection=(destination.X - Location.X) - (pixelsToMoveInHorizontalDirection * numberOfStepsToDestination);
            int missingmissingOffsetInVerticalDirection = (destination.Y - Location.Y) - (pixelsToMoveInVerticalDirection * numberOfStepsToDestination);
            bool reachedAtDestination = false;
            
            moveDownwards = false;
            Left += missingOffsetInHorizontalDirection;
            Top += missingmissingOffsetInVerticalDirection;
            
            while (!reachedAtDestination)
            {
                Image originalImage = (Bitmap)this.Image.Clone();
                this.BackColor = Color.Transparent;
                await System.Threading.Tasks.Task.Delay(delayInMovement);
                Left += pixelsToMoveInHorizontalDirection;
                Top += pixelsToMoveInVerticalDirection;
                this.Image = SetAlpha((Bitmap)originalImage, opacityTarget);
                
                if(Location==destination)
                {
                    updateScore.Invoke(nationalitySelectedByPlayer);
                    reachedAtDestination = true;
                    Location = endPoint;
                    moveDownwards = true;
                }
            }   
        }
        /// <summary>
        /// Increase Or Decrease Alpha (Opacity) of Image
        /// </summary>
        /// <param name="bitmapIn"></param>
        /// <param name="imageAlpha"></param>
        /// <returns></returns>
        private Bitmap SetAlpha(Bitmap bitmapIn, float imageAlpha)
        {
            Bitmap bitmapOut = new Bitmap(bitmapIn.Width, bitmapIn.Height);
            Rectangle rectangle = new Rectangle(0, 0, bitmapIn.Width, bitmapIn.Height);
            float alpha = imageAlpha / maximumOpacity;

            float[][] colorMatrixItems = 
            {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, alpha,0},
                new float[] {0, 0, 0, 0, 1}
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixItems);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics graphic = Graphics.FromImage(bitmapOut))
            {
                graphic.DrawImage(bitmapIn, rectangle, rectangle.X, rectangle.Y, rectangle.Width,
                    rectangle.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return bitmapOut;
        }
        /// <summary>
        /// Executes, each time timer has a new Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (moveDownwards)
            {
                if (this.Location.Y < endPoint.Y)
                {
                    this.Location = new Point(this.Location.X, this.Location.Y + stepToDownwards);
                }
                else
                {
                    Image image= getNextImageToDraw.Invoke();
                    if(image!=null)
                    {
                        Image = image;
                    }
                    else
                    {
                        this.moveDownwards = false;
                        this.timer.Stop();
                    }
                    this.Location = startPoint;
                }
            }
        }
        #endregion
    }
}
