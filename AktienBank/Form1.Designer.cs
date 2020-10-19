namespace AktienBank
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Mohatu_Int = new System.Windows.Forms.Label();
            this.Uru_Int = new System.Windows.Forms.Label();
            this.Nuka_Int = new System.Windows.Forms.Label();
            this.Chumvi_Int = new System.Windows.Forms.Label();
            this.tB_Worth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1, 1);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Mohatu AG";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Uru Consulting";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Nuka";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Chumvi RGB";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1224, 653);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Chart";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Mohatu_Int
            // 
            this.Mohatu_Int.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Mohatu_Int.AutoSize = true;
            this.Mohatu_Int.Location = new System.Drawing.Point(1071, 109);
            this.Mohatu_Int.Name = "Mohatu_Int";
            this.Mohatu_Int.Size = new System.Drawing.Size(86, 13);
            this.Mohatu_Int.TabIndex = 1;
            this.Mohatu_Int.Text = "Mohatu AG: zahl";
            // 
            // Uru_Int
            // 
            this.Uru_Int.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Uru_Int.AutoSize = true;
            this.Uru_Int.Location = new System.Drawing.Point(1071, 140);
            this.Uru_Int.Name = "Uru_Int";
            this.Uru_Int.Size = new System.Drawing.Size(101, 13);
            this.Uru_Int.TabIndex = 2;
            this.Uru_Int.Text = "Uru Consulting: zahl";
            // 
            // Nuka_Int
            // 
            this.Nuka_Int.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Nuka_Int.AutoSize = true;
            this.Nuka_Int.Location = new System.Drawing.Point(1071, 174);
            this.Nuka_Int.Name = "Nuka_Int";
            this.Nuka_Int.Size = new System.Drawing.Size(58, 13);
            this.Nuka_Int.TabIndex = 3;
            this.Nuka_Int.Text = "Nuka: zahl";
            // 
            // Chumvi_Int
            // 
            this.Chumvi_Int.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Chumvi_Int.AutoSize = true;
            this.Chumvi_Int.Location = new System.Drawing.Point(1071, 210);
            this.Chumvi_Int.Name = "Chumvi_Int";
            this.Chumvi_Int.Size = new System.Drawing.Size(93, 13);
            this.Chumvi_Int.TabIndex = 4;
            this.Chumvi_Int.Text = "Chumvi RGB: zahl";
            // 
            // tB_Worth
            // 
            this.tB_Worth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tB_Worth.Location = new System.Drawing.Point(1074, 573);
            this.tB_Worth.Name = "tB_Worth";
            this.tB_Worth.Size = new System.Drawing.Size(100, 20);
            this.tB_Worth.TabIndex = 5;
            this.tB_Worth.Text = "40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 653);
            this.Controls.Add(this.tB_Worth);
            this.Controls.Add(this.Chumvi_Int);
            this.Controls.Add(this.Nuka_Int);
            this.Controls.Add(this.Uru_Int);
            this.Controls.Add(this.Mohatu_Int);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Aktien";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Mohatu_Int;
        private System.Windows.Forms.Label Uru_Int;
        private System.Windows.Forms.Label Nuka_Int;
        private System.Windows.Forms.Label Chumvi_Int;
        private System.Windows.Forms.TextBox tB_Worth;
    }
}

