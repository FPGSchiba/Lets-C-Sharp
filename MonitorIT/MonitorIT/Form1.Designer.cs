namespace MonitorIT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cr_CPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cr_GPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cr_MEM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cr_DISK_Free = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cr_DISK_Usage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cr_FILL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cr_CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_GPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_MEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_DISK_Free)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_DISK_Usage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_FILL)).BeginInit();
            this.SuspendLayout();
            // 
            // cr_CPU
            // 
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.cr_CPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cr_CPU.Legends.Add(legend1);
            this.cr_CPU.Location = new System.Drawing.Point(38, 64);
            this.cr_CPU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cr_CPU.Name = "cr_CPU";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CPU Percent";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.cr_CPU.Series.Add(series1);
            this.cr_CPU.Size = new System.Drawing.Size(471, 267);
            this.cr_CPU.TabIndex = 2;
            this.cr_CPU.Text = "v";
            // 
            // cr_GPU
            // 
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.cr_GPU.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cr_GPU.Legends.Add(legend2);
            this.cr_GPU.Location = new System.Drawing.Point(38, 432);
            this.cr_GPU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cr_GPU.Name = "cr_GPU";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "GPU Percent";
            this.cr_GPU.Series.Add(series2);
            this.cr_GPU.Size = new System.Drawing.Size(471, 267);
            this.cr_GPU.TabIndex = 3;
            this.cr_GPU.Text = "v";
            // 
            // cr_MEM
            // 
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.cr_MEM.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cr_MEM.Legends.Add(legend3);
            this.cr_MEM.Location = new System.Drawing.Point(567, 64);
            this.cr_MEM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cr_MEM.Name = "cr_MEM";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Memory Percent";
            this.cr_MEM.Series.Add(series3);
            this.cr_MEM.Size = new System.Drawing.Size(471, 267);
            this.cr_MEM.TabIndex = 4;
            this.cr_MEM.Text = "v";
            // 
            // cr_DISK_Free
            // 
            chartArea4.AxisY.Maximum = 100D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.cr_DISK_Free.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cr_DISK_Free.Legends.Add(legend4);
            this.cr_DISK_Free.Location = new System.Drawing.Point(567, 432);
            this.cr_DISK_Free.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cr_DISK_Free.Name = "cr_DISK_Free";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Disk Space Free";
            this.cr_DISK_Free.Series.Add(series4);
            this.cr_DISK_Free.Size = new System.Drawing.Size(471, 267);
            this.cr_DISK_Free.TabIndex = 5;
            this.cr_DISK_Free.Text = "v";
            // 
            // cr_DISK_Usage
            // 
            chartArea5.Name = "ChartArea1";
            this.cr_DISK_Usage.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.cr_DISK_Usage.Legends.Add(legend5);
            this.cr_DISK_Usage.Location = new System.Drawing.Point(1098, 64);
            this.cr_DISK_Usage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cr_DISK_Usage.Name = "cr_DISK_Usage";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Disk Usage";
            this.cr_DISK_Usage.Series.Add(series5);
            this.cr_DISK_Usage.Size = new System.Drawing.Size(471, 267);
            this.cr_DISK_Usage.TabIndex = 6;
            this.cr_DISK_Usage.Text = "v";
            // 
            // cr_FILL
            // 
            chartArea6.Name = "ChartArea1";
            this.cr_FILL.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.cr_FILL.Legends.Add(legend6);
            this.cr_FILL.Location = new System.Drawing.Point(1098, 432);
            this.cr_FILL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cr_FILL.Name = "cr_FILL";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Can be filled";
            this.cr_FILL.Series.Add(series6);
            this.cr_FILL.Size = new System.Drawing.Size(471, 267);
            this.cr_FILL.TabIndex = 7;
            this.cr_FILL.Text = "v";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 767);
            this.Controls.Add(this.cr_FILL);
            this.Controls.Add(this.cr_DISK_Usage);
            this.Controls.Add(this.cr_DISK_Free);
            this.Controls.Add(this.cr_MEM);
            this.Controls.Add(this.cr_GPU);
            this.Controls.Add(this.cr_CPU);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cr_CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_GPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_MEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_DISK_Free)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_DISK_Usage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr_FILL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart cr_CPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart cr_GPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart cr_MEM;
        private System.Windows.Forms.DataVisualization.Charting.Chart cr_DISK_Free;
        private System.Windows.Forms.DataVisualization.Charting.Chart cr_DISK_Usage;
        private System.Windows.Forms.DataVisualization.Charting.Chart cr_FILL;
        private System.Windows.Forms.Timer timer;
    }
}

