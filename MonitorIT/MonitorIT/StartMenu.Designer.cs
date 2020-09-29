namespace MonitorIT
{
    partial class StartMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.gB_Login = new System.Windows.Forms.GroupBox();
            this.tB_SelePW = new System.Windows.Forms.TextBox();
            this.tB_SeleUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_DiffPW = new System.Windows.Forms.TextBox();
            this.tB_DiffUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_ServerIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.B_SeleLogin = new System.Windows.Forms.Button();
            this.B_DiffLogin = new System.Windows.Forms.Button();
            this.gB_Login.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gB_Login
            // 
            this.gB_Login.Controls.Add(this.B_SeleLogin);
            this.gB_Login.Controls.Add(this.tB_SelePW);
            this.gB_Login.Controls.Add(this.tB_SeleUser);
            this.gB_Login.Controls.Add(this.label2);
            this.gB_Login.Controls.Add(this.label1);
            this.gB_Login.Location = new System.Drawing.Point(393, 38);
            this.gB_Login.Name = "gB_Login";
            this.gB_Login.Size = new System.Drawing.Size(200, 113);
            this.gB_Login.TabIndex = 1;
            this.gB_Login.TabStop = false;
            this.gB_Login.Text = "Login";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_DiffLogin);
            this.groupBox1.Controls.Add(this.tB_ServerIP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tB_DiffPW);
            this.groupBox1.Controls.Add(this.tB_DiffUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(393, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // tB_DiffPW
            // 
            this.tB_DiffPW.Location = new System.Drawing.Point(67, 83);
            this.tB_DiffPW.Name = "tB_DiffPW";
            this.tB_DiffPW.Size = new System.Drawing.Size(100, 20);
            this.tB_DiffPW.TabIndex = 3;
            this.tB_DiffPW.UseSystemPasswordChar = true;
            // 
            // tB_DiffUser
            // 
            this.tB_DiffUser.Location = new System.Drawing.Point(67, 54);
            this.tB_DiffUser.Name = "tB_DiffUser";
            this.tB_DiffUser.Size = new System.Drawing.Size(100, 20);
            this.tB_DiffUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selected Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diffrent Server";
            // 
            // tB_ServerIP
            // 
            this.tB_ServerIP.Location = new System.Drawing.Point(67, 28);
            this.tB_ServerIP.Name = "tB_ServerIP";
            this.tB_ServerIP.Size = new System.Drawing.Size(100, 20);
            this.tB_ServerIP.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Server IP";
            // 
            // B_SeleLogin
            // 
            this.B_SeleLogin.Location = new System.Drawing.Point(119, 82);
            this.B_SeleLogin.Name = "B_SeleLogin";
            this.B_SeleLogin.Size = new System.Drawing.Size(75, 23);
            this.B_SeleLogin.TabIndex = 4;
            this.B_SeleLogin.Text = "Login";
            this.B_SeleLogin.UseVisualStyleBackColor = true;
            this.B_SeleLogin.Click += new System.EventHandler(this.B_SeleLogin_Click);
            // 
            // B_DiffLogin
            // 
            this.B_DiffLogin.Location = new System.Drawing.Point(119, 109);
            this.B_DiffLogin.Name = "B_DiffLogin";
            this.B_DiffLogin.Size = new System.Drawing.Size(75, 23);
            this.B_DiffLogin.TabIndex = 5;
            this.B_DiffLogin.Text = "Login";
            this.B_DiffLogin.UseVisualStyleBackColor = true;
            this.B_DiffLogin.Click += new System.EventHandler(this.B_DiffLogin_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB_Login);
            this.Controls.Add(this.listView1);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.gB_Login.ResumeLayout(false);
            this.gB_Login.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gB_Login;
        private System.Windows.Forms.TextBox tB_SelePW;
        private System.Windows.Forms.TextBox tB_SeleUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_ServerIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_DiffPW;
        private System.Windows.Forms.TextBox tB_DiffUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_SeleLogin;
        private System.Windows.Forms.Button B_DiffLogin;
    }
}