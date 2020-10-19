using System;

namespace Task3UI
{
    public class Printer
    {
        public int GetNum(){
            Console.Clear();
            Console.WriteLine("Enter the number of strings");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public string GetStr(int i)
        {
            Console.WriteLine("\nEnter string number " + i);
            string str = Console.ReadLine();
            return str;
        }
        public void PrintRes(string s)
        {
           Console.WriteLine("\nFirst characters of each line in reverse order: " + s);
        }
    }
}