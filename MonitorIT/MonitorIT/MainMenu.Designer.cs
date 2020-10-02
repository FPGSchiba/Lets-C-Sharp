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
            this.groupBox1.SuspendLayout();
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 589);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu ";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OV_User;
        private System.Windows.Forms.Label OV_Crit;
        private System.Windows.Forms.Label OV_Stat;
        private System.Windows.Forms.Label OV_CUser;
    }
}