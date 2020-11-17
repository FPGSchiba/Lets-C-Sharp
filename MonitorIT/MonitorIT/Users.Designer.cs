namespace MonitorIT
{
    partial class Users
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
            this.lV_Users = new System.Windows.Forms.ListView();
            this.B_Edit = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Create = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lV_Users
            // 
            this.lV_Users.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lV_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lV_Users.HideSelection = false;
            this.lV_Users.Location = new System.Drawing.Point(12, 43);
            this.lV_Users.MultiSelect = false;
            this.lV_Users.Name = "lV_Users";
            this.lV_Users.Size = new System.Drawing.Size(243, 391);
            this.lV_Users.TabIndex = 0;
            this.lV_Users.UseCompatibleStateImageBehavior = false;
            this.lV_Users.View = System.Windows.Forms.View.List;
            // 
            // B_Edit
            // 
            this.B_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Edit.Location = new System.Drawing.Point(12, 440);
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(75, 23);
            this.B_Edit.TabIndex = 1;
            this.B_Edit.Text = "Edit";
            this.B_Edit.UseVisualStyleBackColor = true;
            this.B_Edit.Click += new System.EventHandler(this.B_Edit_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Delete.Location = new System.Drawing.Point(93, 440);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(81, 23);
            this.B_Delete.TabIndex = 2;
            this.B_Delete.Text = "Delete";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Create
            // 
            this.B_Create.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Create.Location = new System.Drawing.Point(180, 440);
            this.B_Create.Name = "B_Create";
            this.B_Create.Size = new System.Drawing.Size(75, 23);
            this.B_Create.TabIndex = 3;
            this.B_Create.Text = "Create";
            this.B_Create.UseVisualStyleBackColor = true;
            this.B_Create.Click += new System.EventHandler(this.B_Create_Click);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(13, 13);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(75, 23);
            this.B_Save.TabIndex = 4;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 475);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Create);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Edit);
            this.Controls.Add(this.lV_Users);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lV_Users;
        private System.Windows.Forms.Button B_Edit;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Create;
        private System.Windows.Forms.Button B_Save;
    }
}