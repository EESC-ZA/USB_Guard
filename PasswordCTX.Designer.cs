namespace windows_app
{
    partial class PasswordCTX
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
            this.pwordtxt = new System.Windows.Forms.TextBox();
            this.disableApp = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pwordtxt
            // 
            this.pwordtxt.AcceptsReturn = true;
            this.pwordtxt.Location = new System.Drawing.Point(123, 59);
            this.pwordtxt.Name = "pwordtxt";
            this.pwordtxt.PasswordChar = '*';
            this.pwordtxt.Size = new System.Drawing.Size(206, 27);
            this.pwordtxt.TabIndex = 0;
            this.pwordtxt.TextChanged += new System.EventHandler(this.pwordtxt_TextChanged);
            // 
            // disableApp
            // 
            this.disableApp.AutoSize = true;
            this.disableApp.Location = new System.Drawing.Point(120, 12);
            this.disableApp.Name = "disableApp";
            this.disableApp.Size = new System.Drawing.Size(155, 24);
            this.disableApp.TabIndex = 2;
            this.disableApp.TabStop = true;
            this.disableApp.Text = "Disable USB Guard";
            this.disableApp.UseVisualStyleBackColor = true;
            this.disableApp.CheckedChanged += new System.EventHandler(this.disableApp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // PasswordCTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disableApp);
            this.Controls.Add(this.pwordtxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordCTX";
            this.Text = "PasswordCTX";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PasswordCTX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pwordtxt;
        private RadioButton disableApp;
        private Label label1;
    }
}