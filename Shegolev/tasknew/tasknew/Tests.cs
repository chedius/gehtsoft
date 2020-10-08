using System;

namespace tasknew
{
    public class Tests
    {
       String TestEmptyString(string s) {
           if (String.IsNullOrEmpty(s))
                return "Пустая строка";
            else
                return String.Format("(\"{0}\") is neither null nor empty", s);
       }

        public static void TestCase1() {
            string str1 = "АБВГДЕЕЖ";
            int i = 0;
            Console.WriteLine("Исходная строка: " + str1);
            AlphabetText teststs = new AlphabetText(str1);
            i = teststs.Sort(str1);
            if (i == 0)
            {
                Console.WriteLine("В алфавитном порядке");
            }
            else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
        }

        public static void TestCase2() {
            string str1 = "АбаГДеЕЖ";
            int i = 0;
            Console.WriteLine("Исходная строка: " + str1);
            AlphabetText teststs = new AlphabetText(str1);
            i = teststs.Sort(str1);
            if (i == 0)
            {
                Console.WriteLine("В алфавитном порядке");
            }
            else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
        }

    }
}