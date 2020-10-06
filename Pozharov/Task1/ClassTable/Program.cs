using System;

namespace ClassTable
{
    class MakeTable
    {
        public int[,] CreateTable()
        {
            int[,] result = new int[16, 16];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    result[i, j] = (i + 1) * (j + 1);
                }
            }
            return result;
        }
    }
    class Program : MakeTable
    {
        public Program()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write("{0:X} ", CreateTable()[i,j]); //форматирование {0, 4} не работает с :X
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
