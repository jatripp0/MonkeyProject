using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MonkeyProject
{
    class CircleCanvas : Panel
    {
        private readonly Random r = new Random();

        private int boxX;
        private int boxY;
        private int boxHeight;
        private int boxWidth;

        private void drawCircle()
        {
            int maxSquareLength = Math.Min(this.Width, this.Height);

            int canvasWidth = maxSquareLength;
            int canvasHeight = maxSquareLength;

            int max_width = canvasWidth / 4;
            int max_height = canvasHeight / 4;

            int min_width = canvasWidth / 20;
            int min_height = canvasWidth / 20;

            boxWidth = r.Next(max_width - min_width) + min_width;
            //height = r.Next(max_height - min_height) + min_height;
            boxHeight = boxWidth;

            boxX = r.Next(this.Width - boxWidth);
            boxY = r.Next(this.Height - boxHeight);

            this.Invalidate();
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
    }
}
