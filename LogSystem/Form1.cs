using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace LogSystem
{
    public partial class Form1 : Form
    {


        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMEMCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
        PerformanceCounter perfSYSCounter = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perfGPUCounter = new PerformanceCounter("GPU Adapter Memory", "Shared Usage", "luid_0x00000000_0x00013869_phys_0");
        PerformanceCounter perfNETCounter = new PerformanceCounter("PhysicalDisk", "% Idle Time", "_Total");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "CPU:" + "   " + perfCPUCounter.NextValue().ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + "   " + "%";
            label2.Text = "MEM:" + "   " + perfMEMCounter.NextValue().ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + "   " + "%";
            label3.Text = "SYS Up Time:" + "   " + perfSYSCounter.NextValue().ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + "   " + "Seconds";
            label4.Text = "Disk Idle Time" + "   " + perfNETCounter.NextValue().ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + "   " + "%";
            label5.Text = "GPU:" + "   " + perfGPUCounter.NextValue().ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + "   " + "%";
        }
    }
}
