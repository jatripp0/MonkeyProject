namespace WindowsFormsApplication1
{
    partial class MonkeyAppWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyAppWindow));
            this.Orange = new System.Windows.Forms.Button();
            this.Banana = new System.Windows.Forms.Button();
            this.Apple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Orange
            // 
            this.Orange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Orange.AutoSize = true;
            this.Orange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.orangepixifactory;
            this.Orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Orange.Location = new System.Drawing.Point(696, 234);
            this.Orange.MaximumSize = new System.Drawing.Size(500, 500);
            this.Orange.MinimumSize = new System.Drawing.Size(300, 300);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(300, 300);
            this.Orange.TabIndex = 2;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Visible = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Banana
            // 
            this.Banana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Banana.AutoSize = true;
            this.Banana.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Banana.BackColor = System.Drawing.Color.Gold;
            this.Banana.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bananasicon;
            this.Banana.Location = new System.Drawing.Point(364, 234);
            this.Banana.MaximumSize = new System.Drawing.Size(500, 500);
            this.Banana.MinimumSize = new System.Drawing.Size(300, 300);
            this.Banana.Name = "Banana";
            this.Banana.Size = new System.Drawing.Size(300, 300);
            this.Banana.TabIndex = 1;
            this.Banana.UseVisualStyleBackColor = false;
            this.Banana.Visible = false;
            this.Banana.Click += new System.EventHandler(this.Banana_Click);
            // 
            // Apple
            // 
            this.Apple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Apple.AutoSize = true;
            this.Apple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Apple.BackColor = System.Drawing.Color.Tomato;
            this.Apple.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.applefruiticon;
            this.Apple.Location = new System.Drawing.Point(32, 234);
            this.Apple.MaximumSize = new System.Drawing.Size(500, 500);
            this.Apple.MinimumSize = new System.Drawing.Size(300, 300);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(300, 300);
            this.Apple.TabIndex = 0;
            this.Apple.UseVisualStyleBackColor = false;
            this.Apple.Visible = false;
            this.Apple.Click += new System.EventHandler(this.Apple_Click);
            // 
            // MonkeyAppWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Banana);
            this.Controls.Add(this.Apple);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MonkeyAppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.updateShapes);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortcutHandler);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonkeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Apple;
        private System.Windows.Forms.Button Banana;
        private System.Windows.Forms.Button Orange;
    }
}

