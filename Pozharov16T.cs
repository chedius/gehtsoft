using System;

namespace _16Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица Умножения 16СС:");
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int[,] tab2 = new int[16, 16];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    //int l = 10;
                    string s = Convert.ToString(tab[i] * tab[j]);
                    if (s.Length == 2)
                    //попробовать условие если произведение равно 10, 12, 14 
                    {
                        Console.Write("|{0}|", s);
                    }
                    else
                    {
                        Console.Write("|{0} |", s);
                    }

                    if (j != 14) { Console.Write("-"); };
                    //  if (j == 9) { Console.WriteLine(); };
                }
                Console.WriteLine();
                // if (i != 15) { Console.WriteLine("-"); };
                // Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    //int l = 10;
                    string s = Convert.ToString(tab[i] * tab[j]);
                    if (s.Length == 1)
                    {
                        Console.Write("|{0:X} |", Convert.ToInt32(s));
                    }
                    else if (s.Length == 2)

                    {
                        Console.Write("|{0:X}|", Convert.ToInt32(s));
                    }

                    else if (s.Length == 3)
                    {
                        Console.Write("|{0:X}|", Convert.ToInt32(s));
                    }
                    if (j != 14) { Console.Write("-"); };
                    //  if (j == 9) { Console.WriteLine(); };
                }
                Console.WriteLine();
            }
            
            // if (i != 15) { Console.WriteLine("-"); };
            // Console.WriteLine();
        }

    }
}

