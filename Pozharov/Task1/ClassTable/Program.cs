using System;

namespace ClassTable
{
    public class TableCreator
    {
        Random mRnd = new Random();

        //Создание упорядоченной таблицы умножения
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

        //Создание таблицы с произвольной расстановкой
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
        

        //Вывод обычной таблицы умножения
        public void TableNormalOutput(int dim)
        {
            

            for (int i = 1; i < dim; i++)
            {
                for (int j = 1; j < dim; j++)
                {
                    Console.Write("{0:X2} ", normalTable[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Вывод произвольной таблицы
        public void TableRandomOutput(int dim)
        {
            

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Console.Write("{0,2} ", randomTable[i, j]);
                }
                Console.WriteLine();
            }
        }

        class Program
        {
            TableCreator tableCreator_1 = new TableCreator();
            TableCreator tableCreator_2 = new TableCreator();
            //Output mOut = new Output();
            static public void Main(string[] args)
            {
                Output mOut = new Output();
                Console.Clear();
                int key;
                int dim;

                Console.WriteLine("Выберите одно из предложенных действий:");
                Console.WriteLine("1.Вывести таблицу умножения в 16СС \n2.Вывести рандомный массив \n3.Выход");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        dim = 16;
                        int[,] normalTable = tableCreator_1.CreateNormalTable(dim);
                        mOut.TableNormalOutput(dim);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите размерность массива:");
                        dim = Convert.ToInt32(Console.ReadLine());
                        int[,] randomTable = tableCreator_2.CreateRandomTable(dim);
                        mOut.TableRandomOutput(dim);
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Введите номер действия");
                        break;

                }
            }
        }
    }
}

