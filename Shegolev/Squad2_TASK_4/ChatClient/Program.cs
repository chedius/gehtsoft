using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using Configurator;

namespace ChatClient
{
    class Program
    {
        static TcpClient client;
        static NetworkStream stream;
        private static int count = 0;
        private static bool f = true;
        private static string[] TextArr = new string[7];

        static void Main(string[] args)
        {
            Config config = new Config();

            Console.Clear();
            Console.Write("Введите свое имя: ");
            config.userName = Console.ReadLine();
            string path = config.GetPath(config.userName);
            client = new TcpClient();
            try
            {
                client.Connect(config.host, config.port);
                stream = client.GetStream();
                byte[] data = Encoding.Unicode.GetBytes(config.userName);
                stream.Write(data, 0, data.Length);
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                else
                {
                    Console.WriteLine("Такое имя занято!");
                    Disconnect();
                }
                Console.WriteLine("Добро пожаловать, {0}", config.userName);
                while (true)
                {
                    string text = ReceiveMessage();
                    if (CheckText(text))
                    {
                        TextArr[count] = text;
                        string vow = GetVow(TextArr[count]);
                        string con = GetCon(TextArr[count]);
                        string uniq = GetUniqWords(TextArr[count]);
                        PrintInFile(vow, "Vowels", count + 1, path);
                        PrintInFile(con, "Consonants", count + 1, path);
                        PrintInFile(uniq, "UniqWords", count + 1, path);
                        count++;
                        Console.WriteLine("Текст готов!");
                        if (count == 7)
                        {
                            Console.WriteLine("\nВсе текста успешно обработаны!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такой текст уже был!");
                    }
                    Thread.Sleep(10000);
                }
                Disconnect();
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
        static string ReceiveMessage()
        {
            Config configg = new Config();
            Console.WriteLine("Запрашивается текст");
            byte[] data = new byte[configg.buf];
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
            return text;
        }

        static bool CheckText(string text)
        {
            if (TextArr[0] == null)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (TextArr[i] == text)
                    {
                        f = false;
                        return false;
                    }
                    else
                    {
                        f = true;
                    }
                }
                if (f == true)
                {
                    return true;
                }
                else return false;
            }
        }

        static string GetVow(string mtext)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            string vowTxt = new string(mtext.ToLower().Where(c => vowels.Contains(c)).ToArray());
            string totalVow = new string(vowTxt.Count() + " ," + vowTxt);
            return totalVow;
        }

        static string GetCon(string mtext)
        {
            var consonants = new HashSet<char> { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            string conTxt = new string(mtext.ToLower().Where(c => consonants.Contains(c)).ToArray());
            string totalCon = new string(conTxt.Count() + " ," + conTxt);
            return totalCon;
        }

        static string GetUniqWords(string text)
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
            return result;

        }

        static void PrintInFile(string res, string name, int number, string path)
        {
            using (FileStream fstream = new FileStream($"{path}/{name}{number}.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(res);
                fstream.Write(array, 0, array.Length);
            }
        }
        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }
    }
}