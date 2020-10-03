using System;
using System.Linq;
using System.IO;

//Metelev Ilya

namespace Alphabetical_text
{
    class ChangeText
    {
        static void Main(string[] args)
        {
            int key;
            Console.WriteLine("1.Ввести текст в консоли");
            Console.WriteLine("2.Взять текст из файла");
            key = Convert.ToInt32(Console.ReadLine());
            switch(key)
            {
                case 1:
                Console.WriteLine("Введите текст: ");
                Console.WriteLine("Все строчные русские буквы из текста в алфавитном порядке: \n" + 
                    new string(Console.ReadLine()
                    .Where(letter => (letter >= 'а' && letter <= 'я'))
                    .OrderBy(letter => letter)
                    .ToArray()));
                break;

                case 2:
                Console.WriteLine("Введите путь к файлу:");
                string path = Console.ReadLine();
                if(!(File.Exists(path)))
                {
                    Console.WriteLine("Введите корректный путь к файлу:");
                    path = Console.ReadLine();
                }
                StreamReader f = new StreamReader(path);
                Console.WriteLine("Все строчные русские буквы из текста в алфавитном порядке: \n" +
                    new string(f.ReadLine()
                    .Where(letter => (letter >= 'а' && letter <= 'я'))
                    .OrderBy(letter => letter)
                    .ToArray()));
                break;

                default:
                Console.WriteLine("Выберите функцию 1 или 2!");
                break;
            }
        }   
    }
}
