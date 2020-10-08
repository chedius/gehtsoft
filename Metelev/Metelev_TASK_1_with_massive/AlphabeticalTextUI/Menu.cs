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
            char key;
            string text;
            Modification Obj = new Modification();
            StrBuilder genStr = new StrBuilder();
            Tester test1 = new Tester();
            bool f =  true;
            bool b;
            while(f == true)
            {
                Console.Clear();    
                Console.WriteLine("Программа возвращает все строчные русские буквы из текста в алфавитном порядке");
                Console.WriteLine("1.Ввести текст в консоли");
                Console.WriteLine("2.Использовать готовый текст");
                Console.WriteLine("3.Тесты");
                Console.WriteLine("4.Выход");
                key = Console.ReadKey().KeyChar;
                switch(key)
                {
                    case '1':
                    Console.Clear();
                    Console.WriteLine("Введите текст:");
                    text = Console.ReadLine();
                    b = test1.TestNullStr(text);
                    if (b == true)
                    {
                        Console.WriteLine("Строчные русские буквы из текста в алфавитном порядке:\n" + Obj.Modificate(text));
                        Console.ReadKey();
                    }
                    else 
                    {
                        Console.WriteLine("Вы ввели пустую строку!");
                        Console.ReadKey();
                        goto case '1';
                    } 
                    break;

                    case '2':
                    Console.Clear();
                    text = genStr.StrBuild("ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnmабвгдежзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789!№;%:?*().><,", 141, 7);
                    Console.WriteLine("Используется генерируемый текст:\n" + text);
                    Console.WriteLine("Строчные русские буквы из текста в алфавитном порядке:\n" + Obj.Modificate(text)); 
                    Console.ReadKey();
                    break;
                    
                    case '3':
                    Console.Clear();
                    Console.WriteLine("Введите номер теста");
                    Console.WriteLine("1.Тестирование функции модификации текста(правильно возвращает текст)");
                    Console.WriteLine("2.Тестирование функции генерации строки(максимальные длины строки и слова не превышаются)");
                    key = Console.ReadKey().KeyChar;
                    if (key == '1')
                    {
                        Console.WriteLine("\n" + test1.TestMod());
                        Console.ReadKey();
                    }
                    else if (key == '2')
                    {
                        Console.WriteLine(test1.TestGen());
                        Console.ReadKey();
                    }
                    else 
                    {
                        Console.WriteLine("Укажите номер теста, который хотите провести!");
                        Console.ReadKey();
                        goto case '3';
                    }
                    break;

                    case '4':
                    Console.Clear();
                    f=false;
                    break;

                    default:
                    Console.WriteLine("Введите номер одной из предложенных функций!");
                    Console.ReadKey();
                    break;
                }

            }
        }   
    }
}