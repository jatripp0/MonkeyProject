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
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(8, 14);
            this.subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(128, 17);
            this.subject.TabIndex = 0;
            this.subject.Text = "Trial Subject Name";
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(129, 15);
            this.subjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(383, 20);
            this.subjectName.TabIndex = 1;
            this.subjectName.TextChanged += new System.EventHandler(this.subjectName_TextChanged);
            // 
            // circleSizeLabel
            // 
            this.circleSizeLabel.AutoSize = true;
            this.circleSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleSizeLabel.Location = new System.Drawing.Point(8, 49);
            this.circleSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.circleSizeLabel.Name = "circleSizeLabel";
            this.circleSizeLabel.Size = new System.Drawing.Size(123, 17);
            this.circleSizeLabel.TabIndex = 2;
            this.circleSizeLabel.Text = "Circle Size (pixels)";
            // 
            // circleSizeSpinner
            // 
            this.circleSizeSpinner.Location = new System.Drawing.Point(129, 50);
            this.circleSizeSpinner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circleSizeSpinner.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.circleSizeSpinner.Name = "circleSizeSpinner";
            this.circleSizeSpinner.Size = new System.Drawing.Size(80, 20);
            this.circleSizeSpinner.TabIndex = 3;
            // 
            // minSizeLabel
            // 
            this.minSizeLabel.AutoSize = true;
            this.minSizeLabel.Enabled = false;
            this.minSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSizeLabel.Location = new System.Drawing.Point(8, 99);
            this.minSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minSizeLabel.Name = "minSizeLabel";
            this.minSizeLabel.Size = new System.Drawing.Size(65, 17);
            this.minSizeLabel.TabIndex = 4;
            this.minSizeLabel.Text = "Min. Size";
            // 
            // circleSizeMin
            // 
            this.circleSizeMin.Enabled = false;
            this.circleSizeMin.Location = new System.Drawing.Point(73, 100);
            this.circleSizeMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circleSizeMin.Name = "circleSizeMin";
            this.circleSizeMin.Size = new System.Drawing.Size(53, 20);
            this.circleSizeMin.TabIndex = 0;
            this.circleSizeMin.ValueChanged += new System.EventHandler(this.circleSizeMin_ValueChanged);
            // 
            // maxSizeLabel
            // 
            this.maxSizeLabel.AutoSize = true;
            this.maxSizeLabel.Enabled = false;
            this.maxSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSizeLabel.Location = new System.Drawing.Point(131, 99);
            this.maxSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxSizeLabel.Name = "maxSizeLabel";
            this.maxSizeLabel.Size = new System.Drawing.Size(68, 17);
            this.maxSizeLabel.TabIndex = 5;
            this.maxSizeLabel.Text = "Max. Size";
            // 
            // circleSizeMax
            // 
            this.circleSizeMax.Enabled = false;
            this.circleSizeMax.Location = new System.Drawing.Point(200, 100);
            this.circleSizeMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circleSizeMax.Name = "circleSizeMax";
            this.circleSizeMax.Size = new System.Drawing.Size(53, 20);
            this.circleSizeMax.TabIndex = 6;
            this.circleSizeMax.ValueChanged += new System.EventHandler(this.circleSizeMax_ValueChanged);
            // 
            // randomSizeCheck
            // 
            this.randomSizeCheck.AutoSize = true;
            this.randomSizeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomSizeCheck.Location = new System.Drawing.Point(11, 78);
            this.randomSizeCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomSizeCheck.Name = "randomSizeCheck";
            this.randomSizeCheck.Size = new System.Drawing.Size(111, 21);
            this.randomSizeCheck.TabIndex = 7;
            this.randomSizeCheck.Text = "Random Size";
            this.randomSizeCheck.UseVisualStyleBackColor = true;
            this.randomSizeCheck.CheckedChanged += new System.EventHandler(this.randomSizeCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trials Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trial Duration";
            // 
            // beginTrial
            // 
            this.beginTrial.Enabled = false;
            this.beginTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginTrial.Location = new System.Drawing.Point(200, 292);
            this.beginTrial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.beginTrial.Name = "beginTrial";
            this.beginTrial.Size = new System.Drawing.Size(119, 34);
            this.beginTrial.TabIndex = 15;
            this.beginTrial.Text = "Begin";
            this.beginTrial.UseVisualStyleBackColor = true;
            this.beginTrial.Click += new System.EventHandler(this.beginTrial_Click);
            // 
            // trialTime
            // 
            this.trialTime.Enabled = false;
            this.trialTime.Location = new System.Drawing.Point(101, 38);
            this.trialTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trialTime.Name = "trialTime";
            this.trialTime.Size = new System.Drawing.Size(64, 20);
            this.trialTime.TabIndex = 12;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Enabled = false;
            this.secondsLabel.Location = new System.Drawing.Point(169, 40);
            this.secondsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(47, 13);
            this.secondsLabel.TabIndex = 13;
            this.secondsLabel.Text = "seconds";
            // 
            // trialManual
            // 
            this.trialManual.AutoSize = true;
            this.trialManual.Checked = true;
            this.trialManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialManual.Location = new System.Drawing.Point(11, 15);
            this.trialManual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trialManual.Name = "trialManual";
            this.trialManual.Size = new System.Drawing.Size(72, 21);
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
            this.trialTimeLimited.Location = new System.Drawing.Point(101, 14);
            this.trialTimeLimited.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trialTimeLimited.Name = "trialTimeLimited";
            this.trialTimeLimited.Size = new System.Drawing.Size(90, 21);
            this.trialTimeLimited.TabIndex = 11;
            this.trialTimeLimited.Text = "Time Limit";
            this.trialTimeLimited.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trialTimeLimited);
            this.panel1.Controls.Add(this.trialTime);
            this.panel1.Controls.Add(this.secondsLabel);
            this.panel1.Controls.Add(this.trialManual);
            this.panel1.Location = new System.Drawing.Point(99, 165);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 65);
            this.panel1.TabIndex = 16;
            // 
            // StartWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartWindows";
            this.Text = "StartWindows";
            this.Load += new System.EventHandler(this.StartWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleSizeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}