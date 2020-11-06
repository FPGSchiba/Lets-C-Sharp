namespace MonitorIT
{
    partial class MainMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OV_CUser = new System.Windows.Forms.Label();
            this.OV_Stat = new System.Windows.Forms.Label();
            this.OV_User = new System.Windows.Forms.Label();
            this.OV_Crit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.open_Dashboard = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.open_Settings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OV_CUser);
            this.groupBox1.Controls.Add(this.OV_Stat);
            this.groupBox1.Controls.Add(this.OV_User);
            this.groupBox1.Controls.Add(this.OV_Crit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
            // 
            // OV_CUser
            // 
            this.OV_CUser.AutoSize = true;
            this.OV_CUser.Location = new System.Drawing.Point(6, 111);
            this.OV_CUser.Name = "OV_CUser";
            this.OV_CUser.Size = new System.Drawing.Size(69, 13);
            this.OV_CUser.TabIndex = 4;
            this.OV_CUser.Text = "Current User:";
            // 
            // OV_Stat
            // 
            this.OV_Stat.AutoSize = true;
            this.OV_Stat.Location = new System.Drawing.Point(6, 80);
            this.OV_Stat.Name = "OV_Stat";
            this.OV_Stat.Size = new System.Drawing.Size(40, 13);
            this.OV_Stat.TabIndex = 3;
            this.OV_Stat.Text = "Status:";
            // 
            // OV_User
            // 
            this.OV_User.AutoSize = true;
            this.OV_User.Location = new System.Drawing.Point(6, 48);
            this.OV_User.Name = "OV_User";
            this.OV_User.Size = new System.Drawing.Size(37, 13);
            this.OV_User.TabIndex = 2;
            this.OV_User.Text = "Users:";
            // 
            // OV_Crit
            // 
            this.OV_Crit.AutoSize = true;
            this.OV_Crit.Location = new System.Drawing.Point(6, 16);
            this.OV_Crit.Name = "OV_Crit";
            this.OV_Crit.Size = new System.Drawing.Size(49, 13);
            this.OV_Crit.TabIndex = 1;
            this.OV_Crit.Text = "Criticals: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.open_Settings);
            this.groupBox2.Controls.Add(this.open_Dashboard);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open";
            // 
            // open_Dashboard
            // 
            this.open_Dashboard.Location = new System.Drawing.Point(6, 19);
            this.open_Dashboard.Name = "open_Dashboard";
            this.open_Dashboard.Size = new System.Drawing.Size(177, 23);
            this.open_Dashboard.TabIndex = 0;
            this.open_Dashboard.Text = "Dashboard";
            this.open_Dashboard.UseVisualStyleBackColor = true;
            this.open_Dashboard.Click += new System.EventHandler(this.open_Dashboard_Click);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(822, 469);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(135, 23);
            this.B_Save.TabIndex = 6;
            this.B_Save.Text = "Save this Connection";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // open_Settings
            // 
            this.open_Settings.Location = new System.Drawing.Point(7, 49);
            this.open_Settings.Name = "open_Settings";
            this.open_Settings.Size = new System.Drawing.Size(176, 23);
            this.open_Settings.TabIndex = 1;
            this.open_Settings.Text = "Settings";
            this.open_Settings.UseVisualStyleBackColor = true;
            this.open_Settings.Click += new System.EventHandler(this.open_Settings_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 504);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OV_User;
        private System.Windows.Forms.Label OV_Crit;
        private System.Windows.Forms.Label OV_Stat;
        private System.Windows.Forms.Label OV_CUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button open_Dashboard;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button open_Settings;
    }
}