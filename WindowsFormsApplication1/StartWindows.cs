using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyProject
{
    public partial class StartWindows : Form
    {

        public StartWindows()
        {
            InitializeComponent();
        }

        private void StartWindows_Load(object sender, EventArgs e)
        {

        }

        private void beginTrial_Click(object sender, EventArgs e)
        {
            string path = filePath.Text + "\\" + subjectName.Text + ".csv"; 
            int min_radius, max_radius;
            min_radius = max_radius = (int)circleSizeSpinner.Value;
            if (randomSizeCheck.Checked)
            {
                min_radius = (int)circleSizeMin.Value;
                max_radius = (int)circleSizeMax.Value;
            }
            if (File.Exists(path))
            {
                string messageBoxText = "Do you want to overwrite the existing file? \n" + path;
                string caption = "Warning";
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            MonkeyAppWindow monkeyWindow = new MonkeyAppWindow(this, min_radius, max_radius, path);
            monkeyWindow.Show();
            this.Hide();
        }

        private void randomSizeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (randomSizeCheck.Checked)
            {
                minSizeLabel.Enabled = true;
                circleSizeMin.Enabled = true;
                maxSizeLabel.Enabled = true;
                circleSizeMax.Enabled = true;

                circleSizeLabel.Enabled = false;
                circleSizeSpinner.Enabled = false;
            }
            else
            {
                minSizeLabel.Enabled = false;
                circleSizeMin.Enabled = false;
                maxSizeLabel.Enabled = false;
                circleSizeMax.Enabled = false;

                circleSizeLabel.Enabled = true;
                circleSizeSpinner.Enabled = true;
            }
        }

        private void checkConditions()
        {
            bool everythingIsOK = true;
            if (randomSizeCheck.Checked)
            {
                if (circleSizeMin.Value > circleSizeMax.Value)
                {
                    everythingIsOK = false;
                }
            }

            if (subjectName.Text.Equals(String.Empty))
            {
                everythingIsOK = false;
            }
            if (filePath.Text.Equals(String.Empty))
            {
                everythingIsOK = false;
            }


            beginTrial.Enabled = everythingIsOK;
        }

        private void trialManual_CheckedChanged(object sender, EventArgs e)
        {
            if (trialManual.Checked)
            {
                trialTime.Enabled = false;
                secondsLabel.Enabled = false;
            }
            else
            {
                trialTimeLimited.Enabled = true;
                trialTime.Enabled = true;
                secondsLabel.Enabled = true;
            }
        }

        private void circleSizeMin_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void circleSizeMax_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void subjectName_TextChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void SelectDirectory()
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.SelectedPath;
                filePath.Text = path;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectDirectory();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

    }
}
