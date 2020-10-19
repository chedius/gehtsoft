using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

namespace Task3
{
    public class Comparator
    {
        public string Compare(List<string> list) 
        {
            var newlist = list .OrderByDescending(x => x) .First() .ToArray();
            return new string (newlist);
        }
    }
}