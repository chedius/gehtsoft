using System;


public class Spliter
{
    public string[] SpliterWords(string str)
    {
        char[] delete_symbol = { ',', '.', ' ' };
        str = str.Trim(delete_symbol);
        string[] arr_words = str.Split(',');
        return arr_words;
    }
}