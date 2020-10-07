using System;

namespace ClassTable
{
    public class TableCreator
    {
        Random mRnd = new Random();
        public int[,] CreateNormalTable(int dim)
        {
            int[,] result = new int[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    result[i, j] = (i) * (j);
                }
            }

            return result;
        }

        public int[,] CreateRandomTable(int dim)
        {
            int[,] result = new int[dim, dim];
            int[] usedValues = new int[dim * dim];
            int usedValuesCount = 0;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    int random;
                    do
                    {
                        random = mRnd.Next(1, dim * dim + 1);
                    }
                    while (isContain(usedValues, random));

                    usedValues[usedValuesCount++] = random;
                    result[i, j] = random;
                }
            }
            return result;
        }
        private bool isContain(int[] values, int value)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                if (values[i] == value)
                    return true;
            }
            return false;
        }
    }


    public class Output
    {
        TableCreator table = new TableCreator();
        public void TableNormalOutput(int dim, int key)
        {
            int flag1 = key;
            int flag2 = dim;
            for (int i = 1; i < dim; i++)
            {
                for (int j = 1; j < dim; j++)
                {
                    if (flag1 == 1 && flag2 == 16)
                    {
                        Console.Write("{0:X2} ", table.CreateNormalTable(dim)[i, j]); //форматирование {0, 4} не работает с :X
                    }
                    else { Console.Write("{0,2} ", table.CreateNormalTable(dim + 1)[i, j]); }
                }
                Console.WriteLine();
            }
        }
        public void TableRandomOutput(int dim, int key)
        {
            int flag1 = key;
            int flag2 = dim;

            TableCreator tableCreator = new TableCreator();

            int[,] table = tableCreator.CreateRandomTable(dim);

            for (int i = 0; i<dim; i++)
            {
               for (int j = 0; j<dim; j++)
                {
                    Console.Write("{0,2} ", table[i, j]); 
                }
                Console.WriteLine();
            }
        }

        class Program
        {
            
            static public void Main(string[] args)
            {
                Output mOut = new Output();
                Console.Clear();
                int key;
                int dim;

                Console.WriteLine("Выберите одно из предложенных действий:");
                Console.WriteLine("1.Вывести таблицу умножения в 16СС \n2.Вывести рандомный массив");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        dim = 16;
                        mOut.TableNormalOutput(dim, key);

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите размерность массива:");
                        dim = Convert.ToInt32(Console.ReadLine());
                        mOut.TableRandomOutput(dim, key);

                        break;

                    default:
                        Console.WriteLine("Введите номер действия");
                        break;

                }
            }
        }
    }
}

