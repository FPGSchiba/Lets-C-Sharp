using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BackIT
{
    class Program
    {

        static string tempFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BackIT\Temp\";

        static void Main(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    case "-local":
                        firstLocal(args);
                        break;
                    case "-ftp":
                        firstFTP(args);
                        break;
                    default:
                        Log("Error unkown Parameter at Position 1: " + args[0], 2);
                        Console.ReadKey();
                        break;
                }
            }
            catch(Exception ex)
            {
                Log("No paramters were given. " + ex.Message, 2);
            }
        }

        static void firstLocal(string[] args)
        {
            if (Directory.Exists(args[1]))
            {
                try
                {
                    switch (args[2])
                    {
                        case "-local":
                            secondLocal(args, 0);
                            break;
                        case "-ftp":
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Log("No second Parameter were given" + ex.Message, 2);
                }
            }
            else
            {
               Log("The first Path was not valid.", 2);
            }
        }

        static void secondLocal(string[] args, int first, string tempPath = "")
        {
            string SourcePath = "";
            string DestinationPath = "";

            switch (first)
            {
                case 0:
                    SourcePath = args[1];
                    DestinationPath = args[3];
                    break;
                case 1:
                    SourcePath = tempPath;
                    DestinationPath = args[6];
                    break;
                default:
                    break;
            }

            if(DestinationPath != "" && SourcePath != "")
            {
                if (Directory.Exists(DestinationPath))
                {
                    Log(Copy(SourcePath, DestinationPath), 1);
                }
                else
                {
                    Log("Second Path was not valid.", 1);
                    Directory.CreateDirectory(DestinationPath);
                    Log("created path: " + DestinationPath, 0);
                    Log(Copy(SourcePath, DestinationPath), 0);
                }
            }
            else
            {
                Log("No vaild Path was passed into 2nd -local.", 2);
            }
        }

        static void firstFTP(string[] args)
        {
            if(args.Length >= 5)
            {
                string hostname = args[1];
                string username = args[2];
                string password = args[3];
                string remotePath = args[4];
                string dirPath = tempFolder + getFTPID() + @"\";

                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                try
                {
                    NetworkCredential Credentials = new NetworkCredential(username, password);
                    DownloadFtpDirectory($"ftp://{hostname}/{remotePath}", Credentials, dirPath);

                    switch (args[5])
                    {
                        case "-local":
                            secondLocal(args, 1, dirPath);
                            break;
                        case "-ftp":
                            break;
                        default:
                            break;
                    }

                }
                catch(Exception ex)
                {
                    Log(ex.Message, 2);
                }
            }
            else
            {
                Log("Missing arguments after: -ftp", 2);
            }
        }

        static string getFTPID()
        {
            string text = "01";
            int length = 4;
            Random random = new Random();
            const string numchars = "0123456789";
            const string chars = "0123456789";
            List<string> randStr = new List<string>();
            for (int i = 0; i <= 2000; i++)
            {
                string AlphaRandom = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray()) + "-";

                string NumberRandom = new string(Enumerable.Repeat(numchars, length).Select(s => s[random.Next(s.Length)]).ToArray());

                if (randStr.Contains(AlphaRandom + NumberRandom))
                {
                    i--;
                }
                else
                {
                    randStr.Add(AlphaRandom + NumberRandom);
                    text = randStr[i];
                }
            }

            return text;

        }

        static string Copy(string SourcePath, string DestinationPath)
        {
            if(SourcePath != DestinationPath)
            {
                try
                {
                    foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));
                    }

                    foreach (string newPath in Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
                        Log("copying: " + newPath, 0);
                    }

                    return "Files Copied";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Source equals Destination Path.";
            }
        }

        static void Log(string text, int level)
        {
            switch (level)
            {
                case 0:
                    Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " | [INFO]: " + text);
                    break;
                case 1:
                    Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " | [WARN]: " + text);
                    break;
                case 2:
                    Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " | [ERROR]: " + text);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        public static void DownloadFtpDirectory(string url, NetworkCredential credentials, string localPath)
        {
            FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create(url);
            listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            listRequest.Credentials = credentials;

            List<string> lines = new List<string>();

            using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
            using (Stream listStream = listResponse.GetResponseStream())
            using (StreamReader listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }

            foreach (string line in lines)
            {
                string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                string localFilePath = Path.Combine(localPath, name);
                string fileUrl = url + name;

                if (permissions[0] == 'd')
                {
                    if (!Directory.Exists(localFilePath))
                    {
                        Directory.CreateDirectory(localFilePath);
                    }

                    DownloadFtpDirectory(fileUrl + "/", credentials, localFilePath);
                }
                else
                {
                    FtpWebRequest downloadRequest = (FtpWebRequest)WebRequest.Create(fileUrl);
                    downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                    downloadRequest.Credentials = credentials;

                    using (FtpWebResponse downloadResponse = (FtpWebResponse)downloadRequest.GetResponse())
                    using (Stream sourceStream = downloadResponse.GetResponseStream())
                    using (Stream targetStream = File.Create(localFilePath))
                    {
                        Log("downloading: " + localFilePath, 0);
                        byte[] buffer = new byte[10240];
                        int read;
                        while ((read = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            targetStream.Write(buffer, 0, read);
                        }
                    }
                }
            }
        }
    }
}
