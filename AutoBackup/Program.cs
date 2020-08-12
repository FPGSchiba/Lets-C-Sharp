using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Threading;

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
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            ZipPathI = generateZip();

            SetStartup();

            testOld();

            if (!File.Exists(ZipPathI))
            {

                Console.WriteLine("Creating ZIP...");

                ZipFile.CreateFromDirectory(StartPathI, ZipPathI, CompressionLevel.Optimal, false);

                Console.WriteLine("All done Closing.");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("A Zip File exists already.");
                Console.WriteLine("Closing.");
                Thread.Sleep(1000);
            }
        }

        private static void SetStartup()
        {
            Console.WriteLine("Create Registry...");

            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("AutoBackup.exe", Application.ExecutablePath);

            Console.WriteLine("Registry done.");
        }

        public static string generateZip()
        {

            Console.WriteLine("Creating Zip Name...");

            string end = "";
            string time = DateTime.Now.ToString("ddMMyyyy");
            string path = @"E:\Backups\";

            if (Directory.Exists(@"E:\"))
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("No Directory");
                }

                end = path + "Igtrasil" + time + ".zip";
            }
            else
            {
                MessageBox.Show("Keine Externe Festplatte mit dem Buchstaben: \"E\" eingelegt.");
                Environment.Exit(1);
            }

            Console.WriteLine("Zip Name done.");

            return end;
        }

        public static void testOld()
        {
            Console.WriteLine("Testing...");

            string path = @"E:\Backups\";
            string[] files = Directory.GetFiles(path);

            if(files != null)
            {
                foreach (string file in files)
                {
                    string temp = file.Replace(path + "Igtrasil", "");
                    temp = temp.Replace(".zip", "");

                    Console.Write(temp);

                    DateTime time = DateTime.ParseExact(temp, "ddMMyyyy", null);

                    Console.Write(" " + (DateTime.Now.Date - time).TotalDays);

                    if ((DateTime.Now.Date - time).TotalDays > 7)
                    {
                        Console.WriteLine(" - Delete.");
                        File.Delete(file);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Finished Testing.");
        }
    }
}
