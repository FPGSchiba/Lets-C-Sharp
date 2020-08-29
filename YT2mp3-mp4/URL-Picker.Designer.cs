namespace YT2mp3_mp4
{
    partial class URLPicker
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
            this.tB_URL = new System.Windows.Forms.TextBox();
            this.B_OK = new System.Windows.Forms.Button();
            this.cB_isValid = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tB_URL
            // 
            this.tB_URL.Location = new System.Drawing.Point(12, 12);
            this.tB_URL.Name = "tB_URL";
            this.tB_URL.Size = new System.Drawing.Size(513, 26);
            this.tB_URL.TabIndex = 0;
            this.tB_URL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(716, 47);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(54, 32);
            this.B_OK.TabIndex = 1;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // cB_isValid
            // 
            this.cB_isValid.AutoCheck = false;
            this.cB_isValid.AutoSize = true;
            this.cB_isValid.Location = new System.Drawing.Point(531, 12);
            this.cB_isValid.Name = "cB_isValid";
            this.cB_isValid.Size = new System.Drawing.Size(109, 24);
            this.cB_isValid.TabIndex = 2;
            this.cB_isValid.Text = "URL is OK";
            this.cB_isValid.UseVisualStyleBackColor = true;
            // 
            // URLPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 91);
            this.Controls.Add(this.cB_isValid);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.tB_URL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "URLPicker";
            this.Text = "URL Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_URL;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.CheckBox cB_isValid;
    }
}