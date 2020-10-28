using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
 
namespace ChatClient
{
    class Program
    {
        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        private static int count;
        private static bool f = true;
        private static List <string> TextArr = new List<string>();
 
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
                    Console.WriteLine(text);
                   // if (text == null) ;

                    //count++;
                        
                   /* GetVowAndCon(text, count);
                    GetUniqWords(text, count);
                    Console.WriteLine("Текст готов!");*/
                        

                    foreach (var str in TextArr)
                    {
                        if(str == text)
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
                    TextArr.Add(text);
                    if (f == true)
                    {
                        count++;
                        TextArr.Add(text);
                        GetVowAndCon(text, count);
                        GetUniqWords(text, count);
                        Console.WriteLine("Текст готов!");//вывод сообщения
                    }
                    Thread.Sleep(10000);
                    
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }

        static void GetVowAndCon(string text, int number)
        {
             var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
             var consonants = new HashSet<char> { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
             string vowTxt = new string(text.ToLower().Where(c=>vowels.Contains(c)).ToArray());
             string conTxt = new string(text.ToLower().Where(c=>consonants.Contains(c)).ToArray());
             string totalVow = new string(text.ToLower().Count(c=>vowels.Contains(c)) + " ," + vowTxt);
             string totalCon = new string(text.ToLower().Count(c=>consonants.Contains(c)) + " ," + conTxt);
             PrintInFile(totalVow, "vowels", number);
             PrintInFile(totalCon, "consonants", number);

        }

           
        
        static void GetUniqWords(string text, int number)
        {
            Regex req_exp = new Regex("[^a-zA-Z0-9]");
            text = req_exp.Replace(text, " ");

            string[] words = text.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var word_query = (from string word in words orderby word select word).Distinct();
            string[] noResult = word_query.ToArray();

            string result = null;
            for (int i = 0; i < noResult.Length; i++)
            {
                result += noResult[i];
                result += " ";
            }
            PrintInFile(result, "uniq", number);

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