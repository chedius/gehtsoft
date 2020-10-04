
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib1;

namespace ConsoleApp1
{
    class Ovchinnikov
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите слова на латинице через запятую");
                string str = Console.ReadLine();
                string str1 = OvchinnikovLib.lastSimb(str);
                if (OvchinnikovLib.longWrd(str1) && OvchinnikovLib.muchWrd(str1) && OvchinnikovLib.CheckLast(str) && OvchinnikovLib.Abc(str1))
                {
                    OvchinnikovLib.writeStr(str1);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            } while (true);
        }

    }
}