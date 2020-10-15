using System;

namespace Task3UI
{
    public class ReverseOrder
    {
        public string Reverse(int num)
        {
            FirstSymbol frs = new FirstSymbol();
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
            return new string(letters);
        }
    }
}