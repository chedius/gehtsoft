using System;

public class Spliter
{

    protected string[] SpliterWords(string str)
    {
        char[] delete_symbol = { ',', '.', ' ' };
        str = str.ToLower().Trim(delete_symbol);
        string[] arr_words = str.Split(',');
        return arr_words;
    }

}