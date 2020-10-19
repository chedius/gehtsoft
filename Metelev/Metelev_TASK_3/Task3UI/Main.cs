namespace Task3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstSymbol frs = new FirstSymbol();
            Printer prt = new Printer();
            int num = prt.GetNum();
            string str;
            char letter; 
            char[] letters = new char[num];
            for (int i = 1; i<=num;i++)
            {
                str = prt.GetStr(i);
                letter = frs.Finder(str);
                letters[num-i] = letter;
            }
            string s = new string(letters);
            prt.PrintRes(s);
        }
    }
}
