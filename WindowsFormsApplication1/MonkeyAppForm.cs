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

namespace MonkeyProject
{
    public partial class MonkeyAppWindow : Form
    {

        private readonly Random r = new Random();

        private int boxX;
        private int boxY;
        private int boxHeight;
        private int boxWidth;

        private DateTime trialStart;

        private readonly StartWindows sw;
        private readonly int min_radius;
        private readonly int max_radius;
        private readonly string filePath;

        private int trialCount;

        private readonly List<RawDataField> ls;

        public MonkeyAppWindow(StartWindows sw, string filePath)
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

            this.ls = new List<RawDataField>();
        }

        public MonkeyAppWindow(StartWindows sw, int min_radius, int max_radius, string filePath)
        {
            InitializeComponent();
            this.sw = sw;
            this.max_radius = max_radius;
            this.min_radius = min_radius;
            this.filePath = filePath;

            this.trialCount = 0;

            this.ls = new List<RawDataField>();
        }

        private void drawCircle()
        {
            trialStart = DateTime.Now;
            trialCount++;

            // generate random circle within the bounds
            boxWidth = r.Next(this.max_radius - this.min_radius) + this.min_radius;
            boxHeight = boxWidth;

            // calculate X and Y position to draw the circle using the canvas size
            boxX = r.Next(this.Width - boxWidth);
            boxY = r.Next(this.Height - boxHeight);

            this.Invalidate();
        }

        /// <summary>
        /// Displays a save dialog for a CSV file and writes to it. If the file
        /// already exists, the data will be appended. If not, the header will
        /// be written before the data is appended. Additionally, data for the
        /// number of button presses are reset if the file is written.
        /// </summary>
        /// <returns>true if file is written, false otherwise.</returns>

        private void ShortcutHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.C)
            {
                drawCircle();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                this.Invalidate();
            }
        }

        private void updateShapes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rect = new Rectangle(boxX, boxY, boxWidth, boxHeight);
            Console.WriteLine(rect.ToString());

            //g.DrawRectangle(Pens.Black, rect);
            //g.DrawEllipse(Pens.Black, rect);
            SolidBrush sb = new SolidBrush(Color.Black);
            g.FillEllipse(sb, rect);
        }

        private void MonkeyPress(object sender, MouseEventArgs e)
        {
            int centerX = boxX + (boxWidth / 2);
            int centerY = boxY + (boxHeight / 2);
            int x2 = e.X;
            int y2 = e.Y;

            int distance = (int)ShapeCalculator.PointDistance(centerX, centerY, x2, y2);
            int radius = (boxHeight / 2);

            DateTime trialEnd = DateTime.Now;
            TimeSpan ts = trialEnd.Subtract(trialStart);

            RawDataField rdf = new RawDataField();
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

            Console.WriteLine(distance);

            if (distance < radius)
            {
                rdf.IsPressed = true;
                drawCircle();
            }
            else
            {
                rdf.IsPressed = false;
            }
        }

        private void SaveResults()
        {
            List<String> dataLines = new List<String>();
            dataLines.Add(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", "Trial Number", "Start", "End", "Time", "CircleRadius", "ButtonX", "ButtonY", "ClickX", "ClickY", "Is Pressed", "Distance"));
            foreach (RawDataField rdf in ls)
            {
                String csvRow = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                    rdf.TrialNumber,
                    rdf.Start.ToString("yyyy/MM/dd HH:mm:ss"),
                    rdf.End.ToString("yyyy/MM/dd HH:mm:ss"),
                    rdf.Time.Milliseconds,
                    rdf.CircleRadius,
                    rdf.ButtonX, rdf.ButtonY, rdf.ClickX, rdf.ClickY,rdf.IsPressed, rdf.Distance);
                dataLines.Add(csvRow);
            }
            System.IO.File.WriteAllLines(filePath, dataLines);
        }

        private void MonkeyAppWindow_Load(object sender, EventArgs e)
        {

        }
    }

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
        public int TrialNumber { get; set; }

    }
}
