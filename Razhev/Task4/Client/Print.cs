using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    class Print
    {
        public void PrinterMenu() 
        {
            Console.WriteLine("Enter 1 if you are looking for films by actors.");
            Console.WriteLine("Enter 2 if you are looking for films by years.");
            Console.WriteLine("Enter 3 if you are looking for films by name.");
            Console.WriteLine("Enter 4 if you want to quit the program.");
        }

        public void PrinterCaseOne() 
        {
            Console.Clear();
            Console.WriteLine("When enumeration, use ;");
            Console.WriteLine("Example: Gray;Henderson;Brown;");
            Console.WriteLine("Enter the actor(s) to be searched for:");
        }

        public void PrinterCaseSecond()
        {
            Console.Clear();
            Console.WriteLine("When enumeration, use .");
            Console.WriteLine("Example: 1998.");
            Console.WriteLine("Enter the release year of the film:");
        }

        public void PrinterCaseThree()
        {
            Console.Clear();
            Console.WriteLine("When enumeration, use |");
            Console.WriteLine("Example: Breaker Morant|");
            Console.WriteLine("Enter the name film:");
        }

        public void PrinterCaseDefault() 
        {
            Console.WriteLine("You haven't chosen anything.");
        }
    }
}
