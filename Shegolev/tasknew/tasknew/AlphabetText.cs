using System;
using System.Linq;

namespace tasknew
{
    public class AlphabetText
    {
        

        public void Sort(string mTxt, out int num)
        {
            var result = (from c in mTxt where Char.IsLetter(c) select c).ToArray();
            num = 0;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i - 1] > result[i])
                {
                    num = i + 1;
                    break;
                }
            }
            if (num == 0)
            {
                Console.WriteLine("Alphabetical text");
            }
            else Console.WriteLine("{0} - first symbol, that out of order", num);
        }
    }
}
