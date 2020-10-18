using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            // SymbolA sym = new SymbolA();
            Console.WriteLine("Enter the number of strings:");
            int num = Convert.ToInt32(Console.ReadLine());
            int len;
            string str = "";
            char letter = 'C';
            //char[] A = new char[str.Length];

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("Write {0} string:", i);
                string A = Console.ReadLine();
                list.Add(A);
                // A[i] = Convert.ToChar(str);
            }


            int cnt = 0;
            foreach (string B in list)
            {

                // char[] chars = B.ToCharArray();
                int i = B.IndexOf(letter);
                if (i == 1)
                {
                    str = B;
                    //Console.WriteLine(B);
                    cnt++;
                }

               


            }

            if (cnt == 1)
            {
                Console.WriteLine('C');
            }

            if (cnt == 0) 
            {
                Console.WriteLine("");
            }

            if (cnt > 1)
            {
                Console.WriteLine("Error");
            }

            // if (cnt > 1 )


            /*  for (int i = 0; i < num; i++)
              {
                  if(A.Length == 1)

              } */
        }
    }
}

