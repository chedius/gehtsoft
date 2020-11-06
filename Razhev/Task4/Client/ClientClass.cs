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
            Print InstancePrint = new Print();
            TcpClient client = null;
            try
            {
                client = new TcpClient(address, port);
                NetworkStream stream = client.GetStream();

                string message = "";
                byte[] data;
                while (true)
                {
                    InstancePrint.PrinterMenu();
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InstancePrint.PrinterCaseOne();
                            message = Console.ReadLine();
                            data = Encoding.Unicode.GetBytes(message);
                            stream.Write(data, 0, data.Length);
                            break;
                        case 2:
                            InstancePrint.PrinterCaseSecond();
                            message = Console.ReadLine();
                            data = Encoding.Unicode.GetBytes(message);
                            stream.Write(data, 0, data.Length);
                            break;
                        case 3:
                            InstancePrint.PrinterCaseThree();
                            message = Console.ReadLine();
                            data = Encoding.Unicode.GetBytes(message);
                            stream.Write(data, 0, data.Length);
                            break;
                        case 4:
                            client.Close();
                            break;
                        default:
                            InstancePrint.PrinterCaseDefault();
                            break;
                    }

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
