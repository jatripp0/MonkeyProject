using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyProject
{
    public partial class StartWindows : Form
    {
        #region Class Fields

        /// <summary>
        /// Fields which define the trial duration(s) in seconds,
        /// the number of trials, whether or not the trials are
        /// time based or not, and the output path of the data
        /// log file. Each of these fields are set to the
        /// corresponding values from the configuration panel.
        /// </summary>
        private Boolean isTimed;
        private int trialSeconds;
        private int numTrials;
        private string path;

        #endregion

        /// <summary>
        /// Initializes Configuration Panel
        /// </summary>
        public StartWindows()
        {
            InitializeComponent();
        }

        private void StartWindows_Load(object sender, EventArgs e)
        {

        }

        #region Configuration Panel Event Handlers

        /// <summary>
        /// Prepares configuration values and file path information to 
        /// be passed as parameters to the MonkeyAppForm. Also checks 
        /// for pre-existing files in the same directory and promts the 
        /// user to overwrite the file if desired.
        /// Finally, the MonkeyAppWindow is displayed and the configuration
        /// panel is hidden from view.
        /// </summary>
        private void beginTrial_Click(object sender, EventArgs e)
        {
            path = filePath.Text + "\\" + subjectName.Text + ".csv"; 
            int min_radius, max_radius;
            min_radius = max_radius = (int)circleSizeSpinner.Value;
            if (randomSizeCheck.Checked)
            {
                min_radius = (int)circleSizeMin.Value;
                max_radius = (int)circleSizeMax.Value;
            }
            if (IsFileLocked(path) == true)
            {
                return;
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
            MonkeyAppWindow monkeyWindow = new MonkeyAppWindow(this, min_radius, max_radius, path, isTimed, trialSeconds, numTrials);
            monkeyWindow.Show();
            this.Hide();
        }

        /// <summary>
        /// Enables or disables configuration panel controls relating
        /// to the size of the circle depending on whether the circle 
        /// is to be of a static diameter, or random within a set minimum
        /// and maximum diameter.
        /// </summary>
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

        /// <summary>
        /// Enables the "Begin" button only if each condition defined is met.
        /// </summary>
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

        /// <summary>
        /// Enables or disables configuration panel controls relating
        /// to the duration of each trial depending on whether or not
        /// the user sets the trials to be controlled manually, or to
        /// be controlled by a timer.
        /// </summary>
        private void trialManual_CheckedChanged(object sender, EventArgs e)
        {
            if (trialManual.Checked)
            {
                trialTime.Enabled = false;
                secondsLabel.Enabled = false;
                numTrialsLabel.Enabled = false;
                numTrialsUpDown.Enabled = false;
                isTimed = false;
            }
            else
            {
                trialTimeLimited.Enabled = true;
                trialTime.Enabled = true;
                secondsLabel.Enabled = true;
                numTrialsLabel.Enabled = true;
                numTrialsUpDown.Enabled = true;
                isTimed = true;
            }
        }

        /// <summary>
        /// Calls the checkConditions method any time the minimum random size
        /// of the circle is set, in case the "Begin" button should be disabled
        /// due to an invalid value.
        /// </summary>
        private void circleSizeMin_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        /// <summary>
        /// Calls the checkConditions method any time the maximum random size
        /// of the circle is set, in case the "Begin" button should be disabled
        /// due to an invalid value.
        /// </summary>
        private void circleSizeMax_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        /// <summary>
        /// Calls the checkConditions method any time the subject name of the
        /// session is set, in case the "Begin" button should be disabled due
        /// to an invalid value.
        /// </summary>
        private void subjectName_TextChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        /// <summary>
        /// Displays a folder browser dialog box to select the folder path for
        /// the session data file.
        /// </summary>
        private void SelectDirectory()
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.SelectedPath;
                filePath.Text = path;
            }
        }

        /// <summary>
        /// Calls the SelectDirectory method whenever the "Browse" button is pressed.
        /// </summary>
        private void browseButton_Click(object sender, EventArgs e)
        {
            SelectDirectory();
        }

        /// <summary>
        /// Calls the checkConditions method whenever the text of the folder
        /// path is changed in case the "Begin" button should be disabled due
        /// to an invalid value.
        /// </summary>
        private void folderPath_TextChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        /// <summary>
        /// Sets the duration of the trials to the value entered in the configuration
        /// panel, converted to milliseconds.
        /// </summary>
        private void trialTime_ValueChanged(object sender, EventArgs e)
        {
            trialSeconds = (int)trialTime.Value * 1000;
        }

        /// <summary>
        /// Sets the number of trials to be executed to the value entered in
        /// the configuration panel.
        /// </summary>
        private void numTrialsUpDown_ValueChanged(object sender, EventArgs e)
        {
            numTrials = (int)numTrialsUpDown.Value;
        }

        /// <summary>
        /// This method attempts to access the file at the path created by the
        /// configuration panel. If the file exists and is in use by another
        /// program, an error message is displayed and the user is instructed
        /// to close the application that is using the file. Pressing okay 
        /// returns the user to the configuration panel.
        /// </summary>
        /// <param name="filePath">Path of the data log file to be created.</param>
        /// <returns>Returns true if the file is locked, false if it is not.</returns>
        public bool IsFileLocked(string filePath)
        {
            try
            {
                using (File.Open(filePath, FileMode.Open)) { }
            }
            catch (IOException)
            {
                string messageBoxText = "The file is currently being used in another application. \n Please close the application and try again. \n" + path;
                string caption = "Warning";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);

                return true;
                //var errorCode = Marshal.GetHRForException(e) & ((1 << 16) - 1);

                //return errorCode == 32 || errorCode == 33;
            }

            return false;
        }

        #endregion
    }
}
