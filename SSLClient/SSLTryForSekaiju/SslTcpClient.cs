using System;
using System.Collections;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace SSLTryForSekaiju
{
    
    public class SslTcpClient
        {
            private static Hashtable certificateErrors = new Hashtable();

            private static bool ValidateServerCertificate(
                  object sender,
                  X509Certificate certificate,
                  X509Chain chain,
                  SslPolicyErrors sslPolicyErrors)
            {
                if (sslPolicyErrors == SslPolicyErrors.None)
                {
                    return true;   
                }
                Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
                
               return false;
            }

            private static void RunClient(string machineName, string serverName)
            {
                TcpClient client = new TcpClient(machineName,14271);
                Console.WriteLine("Client connected.");
                SslStream sslStream = new SslStream(
                    client.GetStream(),
                    false,
                    new RemoteCertificateValidationCallback (ValidateServerCertificate),
                    null
                    );

                try
                {
                    sslStream.AuthenticateAsClient(serverName);
                }
                catch (AuthenticationException e)
                {
                    Console.WriteLine("Exception: {0}", e.Message);
                    if (e.InnerException != null)
                    {
                        Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
                    }
                    Console.WriteLine ("Authentication failed - closing the connection.");
                    client.Close();
                    return;
                }

                byte[] messsage = Encoding.UTF8.GetBytes("Hello from the client.<EOF>");

                sslStream.Write(messsage);
                sslStream.Flush();

                string serverMessage = ReadMessage(sslStream);
                Console.WriteLine("Server says: {0}", serverMessage);
                
                client.Close();
                Console.WriteLine("Client closed.");
            }
            static string ReadMessage(SslStream sslStream)
            {

                byte [] buffer = new byte[2048];
                StringBuilder messageData = new StringBuilder();
                int bytes = -1;
                do
                {
                    bytes = sslStream.Read(buffer, 0, buffer.Length);
                    
                    Decoder decoder = Encoding.UTF8.GetDecoder();
                    char[] chars = new char[decoder.GetCharCount(buffer,0,bytes)];
                    decoder.GetChars(buffer, 0, bytes, chars,0);
                    messageData.Append (chars);
                    
                } while (bytes != 0);

                return messageData.ToString();
            }

            public static int Main(string[] args)
            {
                SslTcpClient.RunClient ("localhost", "sekaiju");
                return 0;
            }
    }
}