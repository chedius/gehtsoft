using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;

namespace ServerGehtSoft
{
    // Сделал: Ражев Дмитрий
    class Program
    {
        static int port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
        static string address = ConfigurationManager.AppSettings["address"];
        static TcpListener listener;

        public void ServerStart()
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse(address), port);
                listener.Start();
                Console.WriteLine("Server start.");

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientObject clientObject = new ClientObject(client);

                    Thread clientTherad = new Thread(new ThreadStart(clientObject.Process));
                    clientTherad.Start();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                } 
            }
        }

        static void Main(string[] args)
        {
            Program InstanceProgram = new Program();
            InstanceProgram.ServerStart();
        }
    }
}
