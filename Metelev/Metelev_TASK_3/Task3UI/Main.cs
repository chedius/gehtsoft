using System;

namespace Task3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstSymbol frs = new FirstSymbol();
            Console.WriteLine("Enter the number of strings");
            int num = Convert.ToInt32(Console.ReadLine());
            string str;
            char letter; 
            char[] letters = new char[num];
            for (int i = 1; i<=num;i++)
            {
                Console.WriteLine("\nEnter string number " + i);
                str = Console.ReadLine();
                letter = frs.Finder(str);
                letters[num-i] = letter;
            }
            string s = new string(letters);
            Console.WriteLine("\nFirst characters of each line in reverse order: " + s);
        }
    }
}
