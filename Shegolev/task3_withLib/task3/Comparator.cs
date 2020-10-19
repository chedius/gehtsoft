using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace task3
{
    class Comparator
    {
        public string Compare(int L, int a, string qwe = "")
        {
            List<string> list = new List<string>();
            for (int i = 0; i < a; i++)
            {
                string asd = Console.ReadLine();
                list.Add(asd);
            }

            foreach (string str in list)
            {
                if (str.Length == L)
                {
                    int j = String.Compare(qwe, str);
                    if (j == -1 | j == 0)
                    {
                        qwe = str;
                    }
                }
            }

            return qwe;
        }

    }
}
