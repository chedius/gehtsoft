using System;
using System.Threading;

namespace foo
{
    class Program
    {
        static ServerObject server; // сервер
        static Thread listenThread; // потока для прослушивания
        static void Main(string[] args)
        {
            try
            {
                server = new ServerObject();
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); //старт потока
                bool isServerRunning = true;
                server.SendText(isServerRunning);
            }
            catch (Exception ex)
            {
                bool isServerRunning = false;
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
