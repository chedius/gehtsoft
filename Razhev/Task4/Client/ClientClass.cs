using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    // Сделал: Ражев Дмитрий
    class ClientClass
    {
        const int port = 3000;
        const string address = "127.0.0.1";

        /// <summary>
        /// Вводим Фамилии актеров и отправляем данные на сервер.И ждем ответа от сервера.
        /// </summary>
        public void Client()
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient(address, port);
                NetworkStream stream = client.GetStream();

                Console.WriteLine("Enter Name and Surname actor:");
                while (true)
                {
                    string message = Console.ReadLine();

                    byte[] data = Encoding.Unicode.GetBytes(message);

                    stream.Write(data, 0, data.Length);

                    data = new byte[256];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.AppendFormat("{0}", Encoding.UTF8.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    message = builder.ToString();
                    Console.WriteLine(message);
                }
            }
            finally
            {
                client.Close();
            }

        }
    }
}
