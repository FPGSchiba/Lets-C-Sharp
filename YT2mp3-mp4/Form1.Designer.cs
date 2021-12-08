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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.L_timeCodeLast = new System.Windows.Forms.Label();
            this.L_timeCodeCurrent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.pB_FileProgress.Location = new System.Drawing.Point(11, 41);
            this.pB_FileProgress.Margin = new System.Windows.Forms.Padding(2);
            this.pB_FileProgress.Maximum = 1000;
            this.pB_FileProgress.Name = "pB_FileProgress";
            this.pB_FileProgress.Size = new System.Drawing.Size(344, 19);
            this.pB_FileProgress.TabIndex = 0;
            // 
            // B_Path
            // 
            this.B_Path.Location = new System.Drawing.Point(11, 14);
            this.B_Path.Margin = new System.Windows.Forms.Padding(2);
            this.B_Path.Name = "B_Path";
            this.B_Path.Size = new System.Drawing.Size(50, 23);
            this.B_Path.TabIndex = 3;
            this.B_Path.Text = "Pick File";
            this.B_Path.UseVisualStyleBackColor = true;
            this.B_Path.Click += new System.EventHandler(this.B_Path_Click);
            // 
            // B_Convert
            // 
            this.B_Convert.Location = new System.Drawing.Point(370, 31);
            this.B_Convert.Margin = new System.Windows.Forms.Padding(2);
            this.B_Convert.Name = "B_Convert";
            this.B_Convert.Size = new System.Drawing.Size(62, 29);
            this.B_Convert.TabIndex = 5;
            this.B_Convert.Text = "Convert";
            this.B_Convert.UseVisualStyleBackColor = true;
            this.B_Convert.Click += new System.EventHandler(this.B_Convert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Web-URL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // L_Vtitel
            // 
            this.L_Vtitel.AutoSize = true;
            this.L_Vtitel.Location = new System.Drawing.Point(155, 19);
            this.L_Vtitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Vtitel.Name = "L_Vtitel";
            this.L_Vtitel.Size = new System.Drawing.Size(73, 13);
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(54, 65);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(343, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Visible = false;
            // 
            // L_timeCodeLast
            // 
            this.L_timeCodeLast.AutoSize = true;
            this.L_timeCodeLast.Location = new System.Drawing.Point(397, 82);
            this.L_timeCodeLast.Name = "L_timeCodeLast";
            this.L_timeCodeLast.Size = new System.Drawing.Size(35, 13);
            this.L_timeCodeLast.TabIndex = 12;
            this.L_timeCodeLast.Text = "label1";
            this.L_timeCodeLast.Visible = false;
            // 
            // L_timeCodeCurrent
            // 
            this.L_timeCodeCurrent.AutoSize = true;
            this.L_timeCodeCurrent.Location = new System.Drawing.Point(13, 82);
            this.L_timeCodeCurrent.Name = "L_timeCodeCurrent";
            this.L_timeCodeCurrent.Size = new System.Drawing.Size(35, 13);
            this.L_timeCodeCurrent.TabIndex = 13;
            this.L_timeCodeCurrent.Text = "label1";
            this.L_timeCodeCurrent.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 121);
            this.Controls.Add(this.L_timeCodeCurrent);
            this.Controls.Add(this.L_timeCodeLast);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.L_Vtitel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B_Convert);
            this.Controls.Add(this.B_Path);
            this.Controls.Add(this.pB_FileProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label L_timeCodeLast;
        private System.Windows.Forms.Label L_timeCodeCurrent;
    }
}

