namespace MonitorIT
{
    partial class Login
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
            this.gB_Login = new System.Windows.Forms.GroupBox();
            this.B_SeleLogin = new System.Windows.Forms.Button();
            this.tB_SelePW = new System.Windows.Forms.TextBox();
            this.tB_SeleUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gB_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_Login
            // 
            this.gB_Login.Controls.Add(this.B_SeleLogin);
            this.gB_Login.Controls.Add(this.tB_SelePW);
            this.gB_Login.Controls.Add(this.tB_SeleUser);
            this.gB_Login.Controls.Add(this.label2);
            this.gB_Login.Controls.Add(this.label1);
            this.gB_Login.Location = new System.Drawing.Point(12, 12);
            this.gB_Login.Name = "gB_Login";
            this.gB_Login.Size = new System.Drawing.Size(225, 132);
            this.gB_Login.TabIndex = 2;
            this.gB_Login.TabStop = false;
            this.gB_Login.Text = "Login";
            // 
            // B_SeleLogin
            // 
            this.B_SeleLogin.Location = new System.Drawing.Point(133, 93);
            this.B_SeleLogin.Name = "B_SeleLogin";
            this.B_SeleLogin.Size = new System.Drawing.Size(75, 23);
            this.B_SeleLogin.TabIndex = 4;
            this.B_SeleLogin.Text = "Login";
            this.B_SeleLogin.UseVisualStyleBackColor = true;
            this.B_SeleLogin.Click += new System.EventHandler(this.B_SeleLogin_Click);
            // 
            // tB_SelePW
            // 
            this.tB_SelePW.Location = new System.Drawing.Point(66, 56);
            this.tB_SelePW.Name = "tB_SelePW";
            this.tB_SelePW.Size = new System.Drawing.Size(100, 20);
            this.tB_SelePW.TabIndex = 3;
            this.tB_SelePW.UseSystemPasswordChar = true;
            // 
            // tB_SeleUser
            // 
            this.tB_SeleUser.Location = new System.Drawing.Point(66, 27);
            this.tB_SeleUser.Name = "tB_SeleUser";
            this.tB_SeleUser.Size = new System.Drawing.Size(100, 20);
            this.tB_SeleUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 159);
            this.Controls.Add(this.gB_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.gB_Login.ResumeLayout(false);
            this.gB_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_Login;
        private System.Windows.Forms.Button B_SeleLogin;
        private System.Windows.Forms.TextBox tB_SelePW;
        private System.Windows.Forms.TextBox tB_SeleUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}