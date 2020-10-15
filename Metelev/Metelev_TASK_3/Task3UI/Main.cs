using System;

namespace Task3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseOrder rvr = new ReverseOrder();
            Console.WriteLine("Enter the number of strings");
            int num = Convert.ToInt32(Console.ReadLine());
            string s = rvr.Reverse(num);
            Console.WriteLine("\nFirst characters of each line in reverse order: " + s);
        }
    }
}
