using System;
using System.Collections.Generic;
using System.Text;

namespace ServerGehtSoft
{
    class Printer
    {
        public void PrintAbsolutePath(string path)
        {
            Console.WriteLine("Full path to the file: {0}", path);
        }
        public void PrintRecommendations()
        {
            Console.WriteLine("If you think that the paths to the file do not match use 2. Otherwise 1.");
        }
        public void PrintDialog()
        {
            Console.WriteLine("You chose 2. Drag file or enter full path");
        }
    }
}
