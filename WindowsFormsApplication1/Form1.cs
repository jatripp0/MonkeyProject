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
        }

        private void Banana_Click(object sender, EventArgs e)
        {
            ++countBanana;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            ++countOrange;
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
                dataLines = dataLines.Concat(new string[] { countApple.ToString() + "," + countBanana.ToString() + "," + countOrange.ToString() });

                System.IO.File.AppendAllLines(path, dataLines);
                countApple = countBanana = countOrange = 0;
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
        }
    }
}
