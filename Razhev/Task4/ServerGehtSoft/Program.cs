using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerGehtSoft
{
    // Сделал: Ражев Дмитрий
    class Program
    {
        const int port = 3000;
        const string address = "127.0.0.1";
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
                    listener.Stop();
            }
        }

        static void Main(string[] args)
        {
            Program InstanceProgram = new Program();
            InstanceProgram.ServerStart();
        }
    }
}
