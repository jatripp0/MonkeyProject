using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

//using System.Windows.Forms.Timer;

namespace MonkeyProject
{
    /// <summary>
    /// This class contains the code to execute trials, by
    /// drawing circles to a canvas which act as buttons. The
    /// properties and behavior of the circles and trials are 
    /// defined by input parameters from the configuration panel.
    /// </summary>
    public partial class MonkeyAppWindow : Form
    {
        #region Class Fields

        /// <summary>
        /// Fields to define: circle position and size, trial start 
        /// time, min and max radius (if randomly generated), the
        /// file path for the data, trial count and duration, number
        /// of trials, number of trials completed, whether the trials
        /// are timed, the trial timer, whether the screen is pressed,
        /// the list which will contain the data log, and the color of the circle.
        /// </summary>
        private readonly Random r = new Random();

        private int boxX;
        private int boxY;
        private int boxHeight;
        private int boxWidth;
        private int radius;
        private int centerX;
        private int centerY;

        private DateTime trialStart;

        private readonly StartWindows sw;
        private readonly int min_radius;
        private readonly int max_radius;
        private readonly Color circleColor;

        private readonly string filePath;

        private int trialCount;
        private int trialTime;
        private int numTrials;
        private int trialsCompleted;
        private Boolean isTimed;
        private Timer timer;

        private Boolean isScreenPressed;
        private Boolean isCirclePressed;

        private Boolean soundEnabled;
        SoundPlayer player = new SoundPlayer(Resources.Resources.Clicker);

        private readonly List<RawDataField> ls;

        #endregion

        #region Class Constructors
        //This overloaded constructor is no longer used by the program. Consider Removing.
        /*public MonkeyAppWindow(StartWindows sw, string filePath, Boolean isTimed, int trialTime, int numTrials)
        {
            InitializeComponent();
            this.sw = sw;
            // Gets the minimum of the window
            int maxSquareLength = Math.Min(this.Width, this.Height);
            // max and min width of the circle
            this.max_radius = maxSquareLength / 4;
            this.min_radius = maxSquareLength / 20;

            this.filePath = filePath;

            this.trialCount = 0;

            this.isTimed = isTimed;
            this.trialTime = trialTime;
            this.numTrials = numTrials;
            this.trialsCompleted = 0;
            timer = new Timer();

            isScreenPressed = false;

            this.ls = new List<RawDataField>();
        }*/

        /// <summary>
        /// This is the constructor of the class, which will assign
        /// values to the class' fields from its parameters. 
        /// </summary>
        /// <param name="sw">Instance of start window, or configuration panel.</param>
        /// <param name="min_radius">Minimum circle radius (if circle generation is random)</param>
        /// <param name="max_radius">Maximum circle radius (if circle generation is random)</param>
        /// <param name="filePath">Designated file path for the data log to be generated.</param>
        /// <param name="isTimed">Boolean variable to determine if trials are timed.</param>
        /// <param name="trialTime">Duration of trials (if timed)</param>
        /// <param name="numTrials">Number of trials to be run (if timed)</param>
        public MonkeyAppWindow(StartWindows sw, int min_radius, int max_radius, string filePath, Boolean isTimed, int trialTime, int numTrials, Color circleColor, Boolean soundEnabled)
        {
            InitializeComponent();
            this.sw = sw;
            this.max_radius = max_radius;
            this.min_radius = min_radius;
            this.circleColor = circleColor;
            this.filePath = filePath;

            this.trialCount = 0;

            this.isTimed = isTimed;
            this.trialTime = trialTime;
            this.numTrials = numTrials;
            this.trialsCompleted = 0;
            timer = new Timer();

            isScreenPressed = false;
            isCirclePressed = false;

            this.soundEnabled = soundEnabled;

            this.ls = new List<RawDataField>();
        }

        #endregion

        #region Class Methods Which Handle Trial Execution

        /// <summary>
        /// This method decides where on the screen a circle (button)
        /// should be drawn given the resolution of the screen and 
        /// the input size for the circle. It also increments the 
        /// trial cound and initializes a DateTime object to track when
        /// each circle is created.
        /// </summary>
        private void drawCircle()
        {
            trialStart = DateTime.Now;
            trialCount++;

            // generate random circle within the bounds
            boxWidth = r.Next(this.max_radius - this.min_radius) + this.min_radius;
            boxHeight = boxWidth;
            radius = (boxHeight / 2);

            // calculate X and Y position to draw the circle using the canvas size
            boxX = r.Next(this.Width - boxWidth);
            boxY = r.Next(this.Height - boxHeight);
            centerX = boxX + (boxWidth / 2);
            centerY = boxY + (boxHeight / 2);


            this.Invalidate();
        }

        /// <summary>
        /// Handles shortcuts to draw the circle/start the timer and to escape from the program.
        /// </summary>
        private void ShortcutHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.C)
            {
                if (isTimed == true)
                {
                    timer.Enabled = true;
                    timer.Start();
                    drawCircle();
                }
                else
                {
                    drawCircle();
                }
            }
        }

        /// <summary>
        /// This method is responsible for drawing the circle to the screen
        /// using the coordinates and dimensions set by the other methods.
        /// </summary>
        private void updateShapes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rect = new Rectangle(boxX, boxY, boxWidth, boxHeight);
            Console.WriteLine(rect.ToString());

            //g.DrawRectangle(Pens.Black, rect);
            //g.DrawEllipse(Pens.Black, rect);
            SolidBrush sb = new SolidBrush(circleColor);
            g.FillEllipse(sb, rect);
        }

        /// <summary>
        /// Handles data collection whenever a press, whether by mouse
        /// or by touch, is registered on the screen. This method also
        /// handles what should be done if the timer is enabled but a
        /// press is registered. In its current implementation, the 
        /// result will be that the timer's "Tick" event will be triggered,
        /// causing a circle to be drawn without waiting for the timer.
        /// </summary>
        private void MonkeyPress(object sender, MouseEventArgs e)
        {
            RawDataField rdf = new RawDataField();
            int centerScreenX = this.Width / 2;
            int centerScreenY = this.Height / 2;

            int x2 = e.X;
            int y2 = e.Y;

            int distance = (int)ShapeCalculator.PointDistance(centerX, centerY, x2, y2);

            DateTime trialEnd = DateTime.Now;
            TimeSpan ts = trialEnd.Subtract(trialStart);

            rdf.Start = trialStart;
            rdf.End = trialEnd;
            rdf.Time = ts;

            rdf.ClickX = x2;
            rdf.ClickY = y2;

            rdf.ButtonX = centerX;
            rdf.ButtonY = centerY;

            rdf.Distance = distance;
            rdf.CircleRadius = radius;

            rdf.TrialNumber = trialCount;

            ls.Add(rdf);

            if (centerX > centerScreenX)
            {
                if (centerY < centerScreenY)
                {
                    rdf.Quadrant = "Quadrant I";
                }
                else
                {
                    rdf.Quadrant = "Quadrant IV";
                }
            }
            else
            {
                if (centerY < centerScreenY)
                {
                    rdf.Quadrant = "Quadrant II";
                }
                else
                {
                    rdf.Quadrant = "Quadrant III";
                }
            }

            if (distance < radius)
            {
                isCirclePressed = true;
                rdf.IsPressed = true;
                rdf.IsTimedOut = false;
                if (soundEnabled == true)
                {
                    player.Play();
                }
                if (isTimed == true)
                {
                    resetTimer(); //resets the interval of the Timer so that trial durations are not interrupted by a redraw of the circle.
                    timer1_Tick(null, null);
                }
                else
                {
                    drawCircle();
                }
            }
            else
            {
                isCirclePressed = false;
                rdf.IsPressed = false;
                rdf.IsTimedOut = false;
            }

            if (x2 > centerScreenX)
            {
                if (y2 < centerScreenY)
                {
                    rdf.ClickQuadrant = "Quadrant I";
                }
                else
                {
                    rdf.ClickQuadrant = "Quadrant IV";
                }
            }
            else
            {
                if (y2 < centerScreenY)
                {
                    rdf.ClickQuadrant = "Quadrant II";
                }
                else
                {
                    rdf.ClickQuadrant = "Quadrant III";
                }
            }

            isScreenPressed = true;
        }

        /// <summary>
        /// On exit from the program, this method will be
        /// executed to save the collected data to a .csv 
        /// file at the path specified by the configuration
        /// panel.
        /// </summary>
        private void SaveResults()
        {
            List<String> dataLines = new List<String>();
            dataLines.Add(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", "Trial Number", "Trial Start Time", "Trial End Time", "Trial Duration (milliseconds)", "Button Radius", "Button X Position", "Button Y Position", "Button Quadrant", "Click X Position", "Click Y Position", "Click Quadrant","Is Button Pressed", "Click Distance from Button Center", "Is Trial Timed Out"));
            foreach (RawDataField rdf in ls)
            {
                String csvRow = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                    rdf.TrialNumber,
                    rdf.Start.ToString("yyyy/MM/dd HH:mm:ss"),
                    rdf.End.ToString("yyyy/MM/dd HH:mm:ss"),
                    rdf.Time.TotalMilliseconds,
                    rdf.CircleRadius,
                    rdf.ButtonX, rdf.ButtonY, rdf.Quadrant, rdf.ClickX, rdf.ClickY, rdf.ClickQuadrant, rdf.IsPressed, rdf.Distance, rdf.IsTimedOut);
                dataLines.Add(csvRow);
            }
            System.IO.File.WriteAllLines(filePath, dataLines);
        }

        /// <summary>
        /// On load, the properties of the trial timer, if used,
        /// are set and the timer is enabled.
        /// </summary>
        private void MonkeyAppWindow_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            if (isTimed == true)
            {
                timer.Interval = trialTime;
                timer.Tick += new EventHandler(timer1_Tick);
            }
        }

        /// <summary>
        /// "Tick" event for the timer, which is called every time the interval for the timer passes.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isScreenPressed == false)
            {
                RawDataField rdf = new RawDataField();
                int centerScreenX = this.Width / 2;
                int centerScreenY = this.Height / 2;

                rdf.IsPressed = false;
                rdf.IsTimedOut = true;
                DateTime trialEnd = DateTime.Now;
                TimeSpan ts = trialEnd.Subtract(trialStart);

                rdf.Start = trialStart;
                rdf.End = trialEnd;
                rdf.Time = ts;

                rdf.ButtonX = centerX;
                rdf.ButtonY = centerY;

                rdf.CircleRadius = radius;

                rdf.TrialNumber = trialCount;

                ls.Add(rdf);
            }
            else if (isScreenPressed == true)
            {
                if (isCirclePressed == false)
                {
                    RawDataField rdf = new RawDataField();
                    int centerScreenX = this.Width / 2;
                    int centerScreenY = this.Height / 2;

                    rdf.IsPressed = false;
                    rdf.IsTimedOut = true;
                    DateTime trialEnd = DateTime.Now;
                    TimeSpan ts = trialEnd.Subtract(trialStart);

                    rdf.Start = trialStart;
                    rdf.End = trialEnd;
                    rdf.Time = ts;

                    rdf.ButtonX = centerX;
                    rdf.ButtonY = centerY;

                    rdf.CircleRadius = radius;

                    rdf.TrialNumber = trialCount;

                    rdf.IsTimedOut = true;

                    ls.Add(rdf);
                }
            }

            trialsCompleted++;

            if (trialsCompleted < numTrials)
            {
                drawCircle();
            }
            else
            {
                timer.Enabled = false;
                this.Dispose();
            }
        }

        /// <summary>
        /// This method will reset the interval of the Timer used
        /// to control trial durations. Each time the button on the
        /// screen is pushed, the timer should reset.
        /// </summary>
        private void resetTimer()
        {
            timer.Stop();
            timer.Start();
        }

        #endregion

    }

    /// <summary>
    /// Class which holds all raw data fields collected by the application.
    /// </summary>
    class RawDataField
    {
        public int Distance { get; set; }
        public int CircleRadius { get; set; }
        public int ClickX { get; set; }
        public int ClickY { get; set; }
        public int ButtonX { get; set; }
        public int ButtonY { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Boolean IsPressed { get; set; }
        public Boolean IsTimedOut { get; set; }
        public int TrialNumber { get; set; }
        public String Quadrant { get; set; }
        public String ClickQuadrant { get; set; }

    }
}
