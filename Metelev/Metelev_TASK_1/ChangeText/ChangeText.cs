using System;
using System.Linq;
using System.IO;


namespace Alphabetical_text
{
    class ChangeText
    {
        public static void ModificationText(string str)
        {
                Console.WriteLine("Измененный текст: \n" +
                    new string(str
                    .Where(letter => (letter >= 'а' && letter <= 'я'))
                    .OrderBy(letter => letter)
                    .ToArray()));
        }
        static void Main(string[] args)
        {
            int key;
            Console.Clear();
            Console.WriteLine("Программа возвращает все строчные русские буквы из текста в алфавитном порядке");
            Console.WriteLine("1.Ввести текст в консоли");
            Console.WriteLine("2.Использовать готовый текст");
            key = Convert.ToInt32(Console.ReadLine());
            switch(key)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("Введите текст: ");
                string ConsoleString = Console.ReadLine();
                ChangeText.ModificationText(ConsoleString);
                break;

                case 2:
                Console.Clear();
                string Text = "asdjkhija&*%^!@..#87124687ячс.юьисмбюэжджлолдорпаыавыфйцугшекегшщзхъъйД,ЛФЫ,!*ВЛДПТЬБФЫВЙЩЦШКГЕН";
                Console.WriteLine("Первоначальный текст:\n" + Text);
                ChangeText.ModificationText(Text);
                break;

                default:
                Console.WriteLine("Выберите функцию 1 или 2!");
                break;
            }
        }   
    }
}