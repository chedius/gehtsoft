using System;
using System.Text;

namespace tasknew
{
    public class Generator
    {
        public string Generation(string alphabet, int lenght)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(lenght - 1);
            
            for (int i = 1; i <= lenght; i++)
            {
                int position = rnd.Next(0, alphabet.Length - 1);
                sb.Append(alphabet[position]);
            }

            return sb.ToString().ToUpper();
        }
    }
}