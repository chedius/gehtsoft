using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
 
namespace ChatClient
{
    class Program
    {
        //static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
 
        static void Main(string[] args)
        {

            client = new TcpClient();

            client.Connect(host, port); //подключение клиента
            stream = client.GetStream(); // получаем поток


                // запускаем новый поток для получения данных
            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start(); //старт потока
    

        }
        // отправка сообщений
        static void SendMessage(string message)
        {
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            

        }
        // получение сообщений
        static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    string message = ReceiveText();
                    SendMessage(message);
                    Console.WriteLine(message);//вывод сообщения
                    Thread.Sleep(9000);
                    message = ReceiveText();
                    SendMessage(message);
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
                
            }
        }
        static string ReceiveText()
        {
            byte[] data = new byte[64]; // буфер для получаемых данных
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {

                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            string message = builder.ToString();
            return message;
        }


 
        static void Disconnect()
        {
            if(stream!=null)
                stream.Close();//отключение потока
            if(client!=null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }
    }
}
