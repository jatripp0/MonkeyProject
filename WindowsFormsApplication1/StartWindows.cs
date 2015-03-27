using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MonkeyAppWindow monkeyWindow = new MonkeyAppWindow(this);
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
    }
}
