using System;

namespace ClassTable
{
    public class Output
    {

        //Вывод таблицы
        public void TableOutput(int dim, int[,] table)
        {
            
            if (dim == 16)
            {
                for (int i = 1; i < dim; i++)
                {
                    for (int j = 1; j < dim; j++)
                    {
                        Console.Write("{0:X2} ", table[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        Console.Write("{0,2} ", table[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}
