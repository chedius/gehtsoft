using System;


namespace Task_1_with_massive
{
    class Menu
    {   
        /*
            Метод Main выполняет вывод пользовательского меню, вызов доступных методов для генерации и преобразования строки, и вывод результата
        */
        static void Main(string[] args)
        {
            Console.Clear();
            int key;
            string Text;
            Modification Obj = new Modification();
            StrBuilder genStr = new StrBuilder();
            bool f =  true;
            while(f == true)
            {
                Console.Clear();    
                Console.WriteLine("Программа возвращает все строчные русские буквы из текста в алфавитном порядке");
                Console.WriteLine("1.Ввести текст в консоли");
                Console.WriteLine("2.Использовать готовый текст");
                Console.WriteLine("3.Выход");
                key = Convert.ToInt32(Console.ReadLine());
                switch(key)
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine("Введите текст:");
                    Text = Console.ReadLine();
                    Console.WriteLine("Строчные русские буквы из текста в алфавитном порядке:\n" + Obj.Modificate(Text));
                    Console.ReadKey(); 
                    break;

                    case 2:
                    Console.Clear();

                    Text = genStr.StrBuild("ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnmабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789!№;%:?*().><,", 141, 7);
                    Console.WriteLine("Используется генерируемый текст:\n" + Text);
                    Console.WriteLine("Строчные русские буквы из текста в алфавитном порядке:\n" + Obj.Modificate(Text)); 
                    Console.ReadKey();
                    break;
                    
                    case 3:
                    Console.Clear();
                    f=false;
                    break;

                    default:
                    Console.WriteLine("Введите номер функции");
                    Console.ReadKey();
                    break;
                }

            }
        }   
    }
}