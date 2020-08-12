using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace AutoBackup
{
    class Program
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        public static string StartPathI = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GitHub\\Igtrasil";
        static string ZipPathI = "";

        static void Main(string[] args)
        {
            //var handle = GetConsoleWindow();
            //ShowWindow(handle, SW_HIDE);

            ZipPathI = generateZip();

            if ((bool)Properties.Settings.Default["FirstRun"] == true)
            {
                Properties.Settings.Default["FirstRun"] = false;
                Properties.Settings.Default.Save();

                SetStartup();
            }

            testOld();

            ZipFile.CreateFromDirectory(StartPathI, ZipPathI);
            MessageBox.Show("Backup done");
        }

        private static void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("AutoBackup.exe", Application.ExecutablePath);
        }

        public static string generateZip()
        {
            string end = "";
            string time = DateTime.Now.ToString("ddMMyyyy");
            string path = @"E:\Backups\";

            if (Directory.Exists(@"E:\"))
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                end = path + "Igtrasil" + time + ".zip";
            }
            else
            {
                MessageBox.Show("Keine Externe Festplatte mit dem Buchstaben: \"E\" eingelegt.");
                Environment.Exit(1);
            }

            return end;
        }

        public static void testOld()
        {
            string path = @"E:\Backups\";
            string[] files = Directory.GetFiles(path);

            foreach(string file in files)
            {
                string temp = file.Replace(path + "Igtrasil", "");
                temp = file.Replace(".zip", "");

                Console.WriteLine(temp);

                DateTime time = Convert.ToDateTime(temp);

                if((DateTime.Now - time).TotalDays < 7)
                {
                    File.Delete(file);
                }
            }

            Console.ReadKey();
        }
    }
}
