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
        private StartWindows sw;

        private readonly int min_radius;
        private readonly int max_radius;

        public MonkeyAppWindow(StartWindows sw)
        {
            InitializeComponent();
            this.sw = sw;
            // Gets the minimum of the window
            int maxSquareLength = Math.Min(this.Width, this.Height);
            // max and min width of the circle
            this.max_radius = maxSquareLength / 4;
            this.min_radius = maxSquareLength / 20;
        }

        public MonkeyAppWindow(StartWindows sw, int min_radius, int max_radius)
        {
            InitializeComponent();
            this.sw = sw;
            this.max_radius = max_radius;
            this.min_radius = min_radius;

        }

        private void drawCircle()
        {
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
        private bool SaveFile()
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "CSV File (*.CSV)|*.csv";
            fd.OverwritePrompt = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.FileName;
                IEnumerable<String> dataLines = new string[] { };
                if (!File.Exists(path))
                {
                    dataLines = dataLines.Concat(new string[] { "Apple,Banana,Orange" });
                }
                //dataLines = dataLines.Concat(new string[] { countApple.ToString() + "," + countBanana.ToString() + "," + countOrange.ToString() });

                System.IO.File.AppendAllLines(path, dataLines);
                //countApple = countBanana = countOrange = 0;
                return true;
            }
            return false;
        }

        private void ShortcutHandler(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
            else if (e.KeyCode == Keys.Escape)
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
            SolidBrush sb = new SolidBrush(Color.CadetBlue);
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

            Console.WriteLine(distance);

            if (distance < radius)
            {
                drawCircle();
            }
        }

        private void MonkeyAppWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
