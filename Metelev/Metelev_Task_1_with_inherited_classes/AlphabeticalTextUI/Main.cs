using System;

namespace ModificationText
{
    class Program : CallModification
    {
        static void Main(string[] args)
        {  
            Console.Clear();
            Console.WriteLine("Программа печатает в алфавитном порядке все различные\nстрочные русские буквы, входящие в исходный текст\n");
            new CallModification();
        }
    }
}
