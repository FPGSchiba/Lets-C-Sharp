using Microsoft.AspNetCore.Authentication;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pferderennen
{
    static class Logger
    {
        public static string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Pferderennen");
        public static string infoPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Pferderennen\InfoLog.txt");
        public static string errorPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Pferderennen\ErroroLog.txt");
        public static int linecountinfo = CountLinesReader(infoPath);
        public static int linecountrerror = CountLinesReader(errorPath);

        public static void ErrorLog(string Message)
        {
            createDir();

            if (!File.Exists(errorPath))
            {
                File.Create(errorPath);
            }

            if (linecountrerror >= 10000)
            {
                File.WriteAllText(errorPath, "");
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(errorPath, true))
                {
                    sw.WriteLine(DateTime.Now.ToString() + " - Error: " + Message);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void InfoLog(string Message)
        {
            createDir();

            if (!File.Exists(infoPath))
            {
                File.Create(infoPath);
            }

            if(linecountinfo >= 10000)
            {
                File.WriteAllText(infoPath, "");
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(infoPath, true))
                {
                    sw.WriteLine(DateTime.Now.ToString() + " - Info: " + Message);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static void createDir()
        {
            if (!Directory.Exists(folderPath))
            {
                DirectorySecurity directorySecurity = new DirectorySecurity();
                FileSystemAccessRule rule1 = new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow);
                FileSystemAccessRule rule2 = new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.LocalSystemSid, null), FileSystemRights.FullControl, AccessControlType.Allow);
                directorySecurity.AddAccessRule(rule1);
                directorySecurity.AddAccessRule(rule2);
                Directory.CreateDirectory(folderPath, directorySecurity);
            }
        }

        public static int CountLinesReader(string Path)
        {
            if (File.Exists(Path))
            {
                int lineCounter = 0;

                using (var reader = new StreamReader(Path))
                {

                    while (reader.ReadLine() != null)
                    {

                        lineCounter++;

                    }

                    return lineCounter;
                }
            }

            return 0;
        }
    }
}
