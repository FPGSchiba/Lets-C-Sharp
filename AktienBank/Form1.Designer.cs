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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tb_stock2 = new System.Windows.Forms.Label();
            this.tb_stock3 = new System.Windows.Forms.Label();
            this.tb_stock4 = new System.Windows.Forms.Label();
            this.tb_stock5 = new System.Windows.Forms.Label();
            this.tB_Worth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1, 1);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Mohatu AG";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Uru Consulting";
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Nuka";
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Chumvi RGB";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
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
            // tb_stock2
            // 
            this.tb_stock2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_stock2.AutoSize = true;
            this.tb_stock2.Location = new System.Drawing.Point(1071, 109);
            this.tb_stock2.Name = "tb_stock2";
            this.tb_stock2.Size = new System.Drawing.Size(53, 13);
            this.tb_stock2.TabIndex = 1;
            this.tb_stock2.Text = "Filler: zahl";
            // 
            // tb_stock3
            // 
            this.tb_stock3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_stock3.AutoSize = true;
            this.tb_stock3.Location = new System.Drawing.Point(1071, 140);
            this.tb_stock3.Name = "tb_stock3";
            this.tb_stock3.Size = new System.Drawing.Size(53, 13);
            this.tb_stock3.TabIndex = 2;
            this.tb_stock3.Text = "Filler: zahl";
            // 
            // tb_stock4
            // 
            this.tb_stock4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_stock4.AutoSize = true;
            this.tb_stock4.Location = new System.Drawing.Point(1071, 174);
            this.tb_stock4.Name = "tb_stock4";
            this.tb_stock4.Size = new System.Drawing.Size(53, 13);
            this.tb_stock4.TabIndex = 3;
            this.tb_stock4.Text = "Filler: zahl";
            // 
            // tb_stock5
            // 
            this.tb_stock5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_stock5.AutoSize = true;
            this.tb_stock5.Location = new System.Drawing.Point(1071, 210);
            this.tb_stock5.Name = "tb_stock5";
            this.tb_stock5.Size = new System.Drawing.Size(53, 13);
            this.tb_stock5.TabIndex = 4;
            this.tb_stock5.Text = "Filler: zahl";
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
            this.Controls.Add(this.tb_stock5);
            this.Controls.Add(this.tb_stock4);
            this.Controls.Add(this.tb_stock3);
            this.Controls.Add(this.tb_stock2);
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
        private System.Windows.Forms.Label tb_stock2;
        private System.Windows.Forms.Label tb_stock3;
        private System.Windows.Forms.Label tb_stock4;
        private System.Windows.Forms.Label tb_stock5;
        private System.Windows.Forms.TextBox tB_Worth;
    }
}

