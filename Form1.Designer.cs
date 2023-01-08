namespace windows_app
{
    partial class USBGUARD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USBGUARD));
            this.AppTittle = new System.Windows.Forms.Label();
            this.AppVersion = new System.Windows.Forms.Label();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.StopTmrVal = new System.Windows.Forms.Label();
            this.pictureButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Activelbl = new System.Windows.Forms.Label();
            this.aboutlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usbnotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppTittle
            // 
            this.AppTittle.AutoSize = true;
            this.AppTittle.BackColor = System.Drawing.Color.Transparent;
            this.AppTittle.Font = new System.Drawing.Font("Trebuchet MS", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppTittle.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.AppTittle.Location = new System.Drawing.Point(83, 9);
            this.AppTittle.Name = "AppTittle";
            this.AppTittle.Size = new System.Drawing.Size(334, 71);
            this.AppTittle.TabIndex = 0;
            this.AppTittle.Text = "USB GUARD";
            // 
            // AppVersion
            // 
            this.AppVersion.AutoSize = true;
            this.AppVersion.BackColor = System.Drawing.Color.Transparent;
            this.AppVersion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppVersion.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.AppVersion.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.AppVersion.Location = new System.Drawing.Point(106, 69);
            this.AppVersion.Name = "AppVersion";
            this.AppVersion.Size = new System.Drawing.Size(55, 26);
            this.AppVersion.TabIndex = 1;
            this.AppVersion.Text = "V2.0";
            // 
            // StartTimer
            // 
            this.StartTimer.Enabled = true;
            this.StartTimer.Interval = 1000;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // StopTmrVal
            // 
            this.StopTmrVal.AutoSize = true;
            this.StopTmrVal.BackColor = System.Drawing.Color.Transparent;
            this.StopTmrVal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StopTmrVal.Location = new System.Drawing.Point(280, 191);
            this.StopTmrVal.Name = "StopTmrVal";
            this.StopTmrVal.Size = new System.Drawing.Size(122, 26);
            this.StopTmrVal.TabIndex = 6;
            this.StopTmrVal.Text = "44 : 64 : 45";
            // 
            // pictureButton
            // 
            this.pictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureButton.BackgroundImage = global::windows_app.Properties.Resources.btnon;
            this.pictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureButton.Image = global::windows_app.Properties.Resources.btnoff1;
            this.pictureButton.Location = new System.Drawing.Point(194, 93);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(80, 72);
            this.pictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureButton.TabIndex = 7;
            this.pictureButton.TabStop = false;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "until :";
            // 
            // Activelbl
            // 
            this.Activelbl.AutoSize = true;
            this.Activelbl.BackColor = System.Drawing.Color.Transparent;
            this.Activelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Activelbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.Activelbl.Location = new System.Drawing.Point(83, 191);
            this.Activelbl.Name = "Activelbl";
            this.Activelbl.Size = new System.Drawing.Size(116, 26);
            this.Activelbl.TabIndex = 10;
            this.Activelbl.Text = "Activated, ";
            // 
            // aboutlbl
            // 
            this.aboutlbl.AutoSize = true;
            this.aboutlbl.BackColor = System.Drawing.Color.Transparent;
            this.aboutlbl.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutlbl.Location = new System.Drawing.Point(83, 269);
            this.aboutlbl.Name = "aboutlbl";
            this.aboutlbl.Size = new System.Drawing.Size(37, 18);
            this.aboutlbl.TabIndex = 11;
            this.aboutlbl.Text = "EESC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::windows_app.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usbnotify
            // 
            this.usbnotify.Icon = ((System.Drawing.Icon)(resources.GetObject("usbnotify.Icon")));
            this.usbnotify.Text = "Running";
            this.usbnotify.Visible = true;
            this.usbnotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.usbnotify_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(451, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.WorkerSupportsCancellation = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 73);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // USBGUARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 334);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aboutlbl);
            this.Controls.Add(this.Activelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.StopTmrVal);
            this.Controls.Add(this.AppVersion);
            this.Controls.Add(this.AppTittle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "USBGUARD";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB GUARD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.USBGUARD_FormClosed);
            this.Load += new System.EventHandler(this.USBGUARD_Load);
            this.VisibleChanged += new System.EventHandler(this.USBGUARD_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AppTittle;
        private Label AppVersion;
        private System.Windows.Forms.Timer StartTimer;
        private Label StopTmrVal;
        private PictureBox pictureButton;
        private Label label1;
        private Label Activelbl;
        private Label aboutlbl;
        private PictureBox pictureBox1;
        private NotifyIcon usbnotify;
        private Button button1;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private RichTextBox richTextBox1;
    }
}