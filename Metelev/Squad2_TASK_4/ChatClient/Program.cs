using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
 
namespace ChatClient
{
    class Program
    {
        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        private static int count = 0;
        private static bool f = true;
        private static string[] TextArr = new string[7];
 
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            userName = Console.ReadLine();
            client = new TcpClient();
            try
            {
                client.Connect(host, port); //подключение клиента
                stream = client.GetStream(); // получаем поток
                string message = userName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); //старт потока
                Console.WriteLine("Добро пожаловать, {0}", userName);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        // получение сообщений
        static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Запрашивается текст");
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);
                    string text = builder.ToString();
                    Console.WriteLine("Отправляем текст " + text + " на проверку");
                    Thread.Sleep(10000); 
                    CheckText(text); 
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }

        static void CheckText(string text)
        {
            if (text == null) goto exit;
            if(TextArr[0] == null)
            {
                TextArr[0] = text;
                count++;
                GetVowAndCon(TextArr[0], count);
                Console.WriteLine("Текст готов!");
            }
            else
            {
                for(int i = 0; i < 6; i++)
                {
                    if(TextArr[i] == text)
                    {
                        Console.WriteLine("Такой текст уже был!");
                        f = false;
                        break;
                    }
                    else
                    {
                        f = true;
                    }
                }
                if(f == true)
                {
                    TextArr[count] = text;
                    count++;
                    GetVowAndCon(TextArr[count], count);
                    Console.WriteLine("Текст готов!");//вывод сообщения
                }
            }exit:;
        }
        static void GetVowAndCon(string mtext, int number)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var consonants = new HashSet<char> { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            string vowTxt = new string(mtext.ToLower().Where(c=>vowels.Contains(c)).ToArray());
            string conTxt = new string(mtext.ToLower().Where(c=>consonants.Contains(c)).ToArray());
            string totalVow = new string(vowTxt.Count() + " ," + vowTxt);
            string totalCon = new string(conTxt.Count() + " ," + conTxt);
            PrintInFile(totalVow, "vowels", number);
            PrintInFile(totalCon, "consonants", number);
        }
        static void PrintInFile(string res, string name, int number)
        {
            using (FileStream fstream = new FileStream($"../{name}{number}.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(res);
                fstream.Write(array, 0, array.Length);
            }
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