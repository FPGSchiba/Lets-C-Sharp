namespace YT2mp3_mp4
{
    partial class Form1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pB_FileProgress = new System.Windows.Forms.ProgressBar();
            this.B_Path = new System.Windows.Forms.Button();
            this.B_Convert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.L_Vtitel = new System.Windows.Forms.Label();
            this.saveFileDialogMP4 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "mp4";
            this.openFileDialog.FileName = "*.mp4";
            this.openFileDialog.Filter = "*.mp4|";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "mp3";
            this.saveFileDialog.FileName = "*.mp3";
            this.saveFileDialog.Filter = "*.mp3|";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // pB_FileProgress
            // 
            this.pB_FileProgress.Location = new System.Drawing.Point(12, 73);
            this.pB_FileProgress.Name = "pB_FileProgress";
            this.pB_FileProgress.Size = new System.Drawing.Size(516, 29);
            this.pB_FileProgress.TabIndex = 0;
            // 
            // B_Path
            // 
            this.B_Path.Location = new System.Drawing.Point(12, 22);
            this.B_Path.Name = "B_Path";
            this.B_Path.Size = new System.Drawing.Size(75, 35);
            this.B_Path.TabIndex = 3;
            this.B_Path.Text = "Pick File";
            this.B_Path.UseVisualStyleBackColor = true;
            this.B_Path.Click += new System.EventHandler(this.B_Path_Click);
            // 
            // B_Convert
            // 
            this.B_Convert.Location = new System.Drawing.Point(595, 73);
            this.B_Convert.Name = "B_Convert";
            this.B_Convert.Size = new System.Drawing.Size(93, 44);
            this.B_Convert.TabIndex = 5;
            this.B_Convert.Text = "Convert";
            this.B_Convert.UseVisualStyleBackColor = true;
            this.B_Convert.Click += new System.EventHandler(this.B_Convert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Web-URL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // L_Vtitel
            // 
            this.L_Vtitel.AutoSize = true;
            this.L_Vtitel.Location = new System.Drawing.Point(219, 29);
            this.L_Vtitel.Name = "L_Vtitel";
            this.L_Vtitel.Size = new System.Drawing.Size(108, 20);
            this.L_Vtitel.TabIndex = 10;
            this.L_Vtitel.Text = "Name (bald) (:";
            this.L_Vtitel.Visible = false;
            // 
            // saveFileDialogMP4
            // 
            this.saveFileDialogMP4.DefaultExt = "mp4";
            this.saveFileDialogMP4.FileName = "*.mp4";
            this.saveFileDialogMP4.Filter = "*.mp4|";
            this.saveFileDialogMP4.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogMP4_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 131);
            this.Controls.Add(this.L_Vtitel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B_Convert);
            this.Controls.Add(this.B_Path);
            this.Controls.Add(this.pB_FileProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ProgressBar pB_FileProgress;
        private System.Windows.Forms.Button B_Path;
        private System.Windows.Forms.Button B_Convert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label L_Vtitel;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMP4;
    }
}

