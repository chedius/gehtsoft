using System;


public class Spliter
{
    /*
    protected string[] JoinerSpliter(string[] arr_words, string word)
    {
        string join = String.Join(" ", arr_words);
        join = join.Replace(word, "");
        string[] arr_spliter_words = join.Split(' ');
        return arr_spliter_words;
    }
    */
    protected string[] SpliterWords(string str)
    {
        char[] delete_symbol = { ',', '.', ' ' };
        str = str.ToLower().Trim(delete_symbol);
        string[] arr_words = str.Split(',');
        return arr_words;
    }
}