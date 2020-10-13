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
                    while (IsContain(usedValues, random));

                    usedValues[usedValuesCount++] = random;
                    result[i, j] = random;
                }
            }
            return result;
        }
        private bool IsContain(int[] values, int value)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                if (values[i] == value)
                    return true;
            }
            return false;
        }
    }
}