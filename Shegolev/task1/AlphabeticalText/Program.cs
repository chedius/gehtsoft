using System;

namespace AlphabeticalText
{
    class CheckAlphabetical
    {
        public static int Sort(string text)
        {
            text = text.Replace(" ", "").Replace(",", "").Replace(".", "");
            for (int i = 1; i < text.Length; i++)
            {
                if(text[i - 1] > text[i])
                {
                    return i+1;
                }
            }
            Console.WriteLine("Текст в алфавитном порядке");
            return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine(Sort(text));
        }
    }
}
