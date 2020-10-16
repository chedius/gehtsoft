namespace Task3UI
{
    public class FirstSymbol
    {
        public char Finder(string str)
        {
            char[] chars = str.ToCharArray();
            char symbol = chars[0];
            return symbol;
        }
    }
}