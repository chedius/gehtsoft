using System;


namespace Task_1_with_massive
{
    class Menu
    {   
        static void Main(string[] args)
        {
            Console.Clear();
            int key;
            string Text;
            Console.WriteLine("Программа возвращает все строчные русские буквы из текста в алфавитном порядке");
            Console.WriteLine("1.Ввести текст в консоли");
            Console.WriteLine("2.Использовать готовый текст");
            key = Convert.ToInt32(Console.ReadLine());
            switch(key)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("Введите текст:");
                Text = Console.ReadLine();
                Modification.Modificate(Text);    
                break;

                case 2:
                Console.Clear();
                Text = "asdjkhija&*%^!@..#87124687ячс.юьисмбюэжджлолдорпаыавыфйцугшекегшщзхъъйД,ЛФЫ,!*ВЛДПТЬБФЫВЙЩЦШКГЕН";
                Console.WriteLine("Используется готовый текст:\n" + Text);
                Modification.Modificate(Text);
                break;

                default:
                Console.WriteLine("Введите номер функции");
                break;

            }
        }   
    }
}