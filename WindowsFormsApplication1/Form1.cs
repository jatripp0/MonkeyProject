using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MonkeyAppWindow : Form
    {
        public int countApple;
        public int countBanana;
        public int countOrange;

        public void WindowsFormsApplication1()
        {
            countApple = 0;
            countBanana = 0;
            countOrange = 0;
        }
        
        public MonkeyAppWindow()
        {
            InitializeComponent();

        }

        private void Apple_Click(object sender, EventArgs e)
        {
            ++countApple;
            countWriter();
        }

        private void Banana_Click(object sender, EventArgs e)
        {
            ++countBanana;
            countWriter();
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            ++countOrange;
            countWriter();
        }

        private void countWriter()
        {
            string[] dataLines = { "Apple:," + countApple.ToString(), "Banana:," + countBanana.ToString(), "Orange:," + countOrange.ToString() };
            System.IO.File.WriteAllLines(@"C:\Users\John\Documents\visual studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\Data.csv", dataLines);

        }
    }
}
