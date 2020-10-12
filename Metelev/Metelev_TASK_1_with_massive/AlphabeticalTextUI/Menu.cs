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
            AlphabetSort Obj = new AlphabetSort();
            StrBuilder genStr = new StrBuilder();
            Tester test1 = new Tester();
            NullStrTester test5 = new NullStrTester();
            Console.Clear();
            char key;
            string text;
            bool f =  true;
            bool b;
            while(f == true)
            {
                Console.Clear();    
                Console.WriteLine("The program returns all lowercase Russian letters from the text in alphabetical order");
                Console.WriteLine("1.Enter text in console");
                Console.WriteLine("2.Use generated text");
                Console.WriteLine("3.Tests");
                Console.WriteLine("4.Exit");
                key = Console.ReadKey().KeyChar;
                switch(key)
                {
                    case '1':
                    Console.Clear();
                    Console.WriteLine("Enter text:");
                    text = Console.ReadLine();
                    b = test5.TestNullStr(text);
                    if (b == true)
                    {
                        Console.WriteLine("Lowercase Russian letters from text in alphabetical order:\n" + Obj.Sort(text));
                        Console.ReadKey();
                    }
                    else 
                    {
                        Console.WriteLine("You entered an empty line!");
                        Console.ReadKey();
                        goto case '1';
                    } 
                    break;

                    case '2':
                    Console.Clear();
                    text = genStr.StrBuild("ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnmабвгдежзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789!№;%:?*().><,", 141, 7);
                    Console.WriteLine("Generated text is used:\n" + text);
                    Console.WriteLine("Lowercase Russian letters from text in alphabetical order:\n" + Obj.Sort(text)); 
                    Console.ReadKey();
                    break;
                    
                    case '3':
                    Console.Clear();
                    Console.WriteLine("Enter the test number");
                    Console.WriteLine("1.Testing the text modification function (returns the text correctly)");
                    Console.WriteLine("2.Testing the string generation function (maximum string and word lengths are not exceeded)");
                    key = Console.ReadKey().KeyChar;
                    if (key == '1')
                    {
                        Console.WriteLine("\n" + test1.TestMod());
                        Console.ReadKey();
                    }
                    else if (key == '2')
                    {
                        Console.WriteLine("\n" + test1.TestGen());
                        Console.ReadKey();
                    }
                    else 
                    {
                        Console.WriteLine("Enter the number of the test you want to conduct!");
                        Console.ReadKey();
                        goto case '3';
                    }
                    break;

                    case '4':
                    Console.Clear();
                    f=false;
                    break;

                    default:
                    Console.WriteLine("Enter the number of one of the proposed functions!");
                    Console.ReadKey();
                    break;
                }

            }
        }   
    }
}