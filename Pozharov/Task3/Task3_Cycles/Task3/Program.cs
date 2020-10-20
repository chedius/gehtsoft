using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Task3
{
    public class Program
    {
         public List<string> Collection(int cnt)
        {
            List<string> list = new List<string>();
            while(cnt > 0)
            {
                string str = new string(Console.ReadLine());
                list.Add(str.ToUpper());
                cnt--;
            }
            return list;
        }

        public int sequence(List<string> list , char symbol)
        {
            int count = 0;
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].ToCharArray()[list[i].Length - 1] == symbol) //without Linq
                {
                    count++;
                }
            }
            return count;
        }

        public bool check(bool predict)
        {
            if(predict) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Printer(int count, char symbol)
        {
            try
            {
                if(check(count == 1))
                {   
                    Console.WriteLine(symbol);
                }
                else if(check(count > 1))
                {
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Error!");
            }
        }
        static void Main(string[] args)
        {
           Program InstanceProgram = new Program();
           char symbol = 'C';
           Console.WriteLine("Enter a number of strings:");
           int cnt = Convert.ToInt32(Console.ReadLine());
           var temp = InstanceProgram.Collection(cnt);
           var pop = InstanceProgram.sequence(temp,symbol);
           InstanceProgram.Printer(pop,symbol);
        }
    }
}

