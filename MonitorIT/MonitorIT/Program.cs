using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace MonitorIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MIT\";
        public static List<IPEndPoint> sockets = new List<IPEndPoint>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }
    }
}
