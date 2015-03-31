using System.Drawing;
using System.Windows.Forms;

namespace MonkeyProject
{
    partial class StartWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.subject = new System.Windows.Forms.Label();
            this.subjectName = new System.Windows.Forms.TextBox();
            this.circleSizeLabel = new System.Windows.Forms.Label();
            this.circleSizeSpinner = new System.Windows.Forms.NumericUpDown();
            this.minSizeLabel = new System.Windows.Forms.Label();
            this.circleSizeMin = new System.Windows.Forms.NumericUpDown();
            this.maxSizeLabel = new System.Windows.Forms.Label();
            this.circleSizeMax = new System.Windows.Forms.NumericUpDown();
            this.randomSizeCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.beginTrial = new System.Windows.Forms.Button();
            this.trialTime = new System.Windows.Forms.NumericUpDown();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.trialManual = new System.Windows.Forms.RadioButton();
            this.trialTimeLimited = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTrialsUpDown = new System.Windows.Forms.NumericUpDown();
            this.numTrialsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.circleColor = new System.Windows.Forms.Button();
            this.circleColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialTime)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrialsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(12, 69);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(178, 25);
            this.subject.TabIndex = 0;
            this.subject.Text = "Trial Subject Name";
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(201, 70);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(565, 26);
            this.subjectName.TabIndex = 1;
            this.subjectName.TextChanged += new System.EventHandler(this.subjectName_TextChanged);
            // 
            // circleSizeLabel
            // 
            this.circleSizeLabel.AutoSize = true;
            this.circleSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleSizeLabel.Location = new System.Drawing.Point(12, 122);
            this.circleSizeLabel.Name = "circleSizeLabel";
            this.circleSizeLabel.Size = new System.Drawing.Size(175, 25);
            this.circleSizeLabel.TabIndex = 2;
            this.circleSizeLabel.Text = "Circle Size (pixels)";
            // 
            // circleSizeSpinner
            // 
            this.circleSizeSpinner.Location = new System.Drawing.Point(194, 124);
            this.circleSizeSpinner.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.circleSizeSpinner.Name = "circleSizeSpinner";
            this.circleSizeSpinner.Size = new System.Drawing.Size(120, 26);
            this.circleSizeSpinner.TabIndex = 3;
            // 
            // minSizeLabel
            // 
            this.minSizeLabel.AutoSize = true;
            this.minSizeLabel.Enabled = false;
            this.minSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSizeLabel.Location = new System.Drawing.Point(12, 199);
            this.minSizeLabel.Name = "minSizeLabel";
            this.minSizeLabel.Size = new System.Drawing.Size(93, 25);
            this.minSizeLabel.TabIndex = 4;
            this.minSizeLabel.Text = "Min. Size";
            // 
            // circleSizeMin
            // 
            this.circleSizeMin.Enabled = false;
            this.circleSizeMin.Location = new System.Drawing.Point(110, 201);
            this.circleSizeMin.Name = "circleSizeMin";
            this.circleSizeMin.Size = new System.Drawing.Size(80, 26);
            this.circleSizeMin.TabIndex = 0;
            this.circleSizeMin.ValueChanged += new System.EventHandler(this.circleSizeMin_ValueChanged);
            // 
            // maxSizeLabel
            // 
            this.maxSizeLabel.AutoSize = true;
            this.maxSizeLabel.Enabled = false;
            this.maxSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSizeLabel.Location = new System.Drawing.Point(196, 199);
            this.maxSizeLabel.Name = "maxSizeLabel";
            this.maxSizeLabel.Size = new System.Drawing.Size(99, 25);
            this.maxSizeLabel.TabIndex = 5;
            this.maxSizeLabel.Text = "Max. Size";
            // 
            // circleSizeMax
            // 
            this.circleSizeMax.Enabled = false;
            this.circleSizeMax.Location = new System.Drawing.Point(300, 201);
            this.circleSizeMax.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.circleSizeMax.Name = "circleSizeMax";
            this.circleSizeMax.Size = new System.Drawing.Size(80, 26);
            this.circleSizeMax.TabIndex = 6;
            this.circleSizeMax.ValueChanged += new System.EventHandler(this.circleSizeMax_ValueChanged);
            // 
            // randomSizeCheck
            // 
            this.randomSizeCheck.AutoSize = true;
            this.randomSizeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomSizeCheck.Location = new System.Drawing.Point(16, 167);
            this.randomSizeCheck.Name = "randomSizeCheck";
            this.randomSizeCheck.Size = new System.Drawing.Size(155, 29);
            this.randomSizeCheck.TabIndex = 7;
            this.randomSizeCheck.Text = "Random Size";
            this.randomSizeCheck.UseVisualStyleBackColor = true;
            this.randomSizeCheck.CheckedChanged += new System.EventHandler(this.randomSizeCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trials Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trial Duration";
            // 
            // beginTrial
            // 
            this.beginTrial.Enabled = false;
            this.beginTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginTrial.Location = new System.Drawing.Point(300, 449);
            this.beginTrial.Name = "beginTrial";
            this.beginTrial.Size = new System.Drawing.Size(178, 52);
            this.beginTrial.TabIndex = 15;
            this.beginTrial.Text = "Begin";
            this.beginTrial.UseVisualStyleBackColor = true;
            this.beginTrial.Click += new System.EventHandler(this.beginTrial_Click);
            // 
            // trialTime
            // 
            this.trialTime.Enabled = false;
            this.trialTime.Location = new System.Drawing.Point(152, 58);
            this.trialTime.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.trialTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trialTime.Name = "trialTime";
            this.trialTime.Size = new System.Drawing.Size(96, 26);
            this.trialTime.TabIndex = 12;
            this.trialTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trialTime.ValueChanged += new System.EventHandler(this.trialTime_ValueChanged);
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Enabled = false;
            this.secondsLabel.Location = new System.Drawing.Point(254, 62);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(69, 20);
            this.secondsLabel.TabIndex = 13;
            this.secondsLabel.Text = "seconds";
            // 
            // trialManual
            // 
            this.trialManual.AutoSize = true;
            this.trialManual.Checked = true;
            this.trialManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialManual.Location = new System.Drawing.Point(16, 23);
            this.trialManual.Name = "trialManual";
            this.trialManual.Size = new System.Drawing.Size(102, 29);
            this.trialManual.TabIndex = 10;
            this.trialManual.TabStop = true;
            this.trialManual.Text = "Manual";
            this.trialManual.UseVisualStyleBackColor = true;
            this.trialManual.CheckedChanged += new System.EventHandler(this.trialManual_CheckedChanged);
            // 
            // trialTimeLimited
            // 
            this.trialTimeLimited.AutoSize = true;
            this.trialTimeLimited.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialTimeLimited.Location = new System.Drawing.Point(152, 22);
            this.trialTimeLimited.Name = "trialTimeLimited";
            this.trialTimeLimited.Size = new System.Drawing.Size(126, 29);
            this.trialTimeLimited.TabIndex = 11;
            this.trialTimeLimited.Text = "Time Limit";
            this.trialTimeLimited.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numTrialsUpDown);
            this.panel1.Controls.Add(this.numTrialsLabel);
            this.panel1.Controls.Add(this.trialTimeLimited);
            this.panel1.Controls.Add(this.trialTime);
            this.panel1.Controls.Add(this.secondsLabel);
            this.panel1.Controls.Add(this.trialManual);
            this.panel1.Location = new System.Drawing.Point(148, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 100);
            this.panel1.TabIndex = 16;
            // 
            // numTrialsUpDown
            // 
            this.numTrialsUpDown.Enabled = false;
            this.numTrialsUpDown.Location = new System.Drawing.Point(418, 25);
            this.numTrialsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrialsUpDown.Name = "numTrialsUpDown";
            this.numTrialsUpDown.Size = new System.Drawing.Size(120, 26);
            this.numTrialsUpDown.TabIndex = 21;
            this.numTrialsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrialsUpDown.ValueChanged += new System.EventHandler(this.numTrialsUpDown_ValueChanged);
            // 
            // numTrialsLabel
            // 
            this.numTrialsLabel.AutoSize = true;
            this.numTrialsLabel.Enabled = false;
            this.numTrialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrialsLabel.Location = new System.Drawing.Point(315, 24);
            this.numTrialsLabel.Name = "numTrialsLabel";
            this.numTrialsLabel.Size = new System.Drawing.Size(97, 25);
            this.numTrialsLabel.TabIndex = 20;
            this.numTrialsLabel.Text = "# of Trials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Folder Path";
            // 
            // filePath
            // 
            this.filePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.filePath.Location = new System.Drawing.Point(133, 23);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(375, 26);
            this.filePath.TabIndex = 18;
            this.filePath.TextChanged += new System.EventHandler(this.folderPath_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(514, 23);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(103, 41);
            this.browseButton.TabIndex = 19;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // circleColor
            // 
            this.circleColor.Location = new System.Drawing.Point(375, 122);
            this.circleColor.Name = "circleColor";
            this.circleColor.Size = new System.Drawing.Size(103, 41);
            this.circleColor.TabIndex = 20;
            this.circleColor.Text = "Color";
            this.circleColor.UseVisualStyleBackColor = true;
            this.circleColor.Click += new System.EventHandler(this.circleColor_Click);
            // 
            // StartWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 545);
            this.Controls.Add(this.circleColor);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.beginTrial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randomSizeCheck);
            this.Controls.Add(this.circleSizeMax);
            this.Controls.Add(this.maxSizeLabel);
            this.Controls.Add(this.circleSizeMin);
            this.Controls.Add(this.minSizeLabel);
            this.Controls.Add(this.circleSizeSpinner);
            this.Controls.Add(this.circleSizeLabel);
            this.Controls.Add(this.subjectName);
            this.Controls.Add(this.subject);
            this.Name = "StartWindows";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.StartWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrialsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.TextBox subjectName;
        private System.Windows.Forms.Label circleSizeLabel;
        private System.Windows.Forms.NumericUpDown circleSizeSpinner;
        private System.Windows.Forms.Label minSizeLabel;
        private System.Windows.Forms.NumericUpDown circleSizeMin;
        private System.Windows.Forms.Label maxSizeLabel;
        private System.Windows.Forms.NumericUpDown circleSizeMax;
        private System.Windows.Forms.CheckBox randomSizeCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button beginTrial;
        private System.Windows.Forms.NumericUpDown trialTime;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.RadioButton trialManual;
        private System.Windows.Forms.RadioButton trialTimeLimited;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private NumericUpDown numTrialsUpDown;
        private Label numTrialsLabel;
        private Button circleColor;
        private ColorDialog circleColorDialog;
    }
}