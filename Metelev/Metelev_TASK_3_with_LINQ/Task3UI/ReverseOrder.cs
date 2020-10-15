using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3UI
{
    public class Reverser
    {
        public string ReverseOrder(int num, List<string> strList)
        {
            var res = (from s in strList select s[0]).Reverse().ToArray();
            return new string(res);
        }
    }
}