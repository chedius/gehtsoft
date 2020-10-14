using System;


public class Spliter
{
    /* Метод SpliterWords разбивает строку на отдельные слова складывает их в массив и возвращает его*/
    public string[] SpliterWords(string str)
    {
        char[] delete_symbol = { ',', '.', ' ' };
        str = str.Trim(delete_symbol);
        string[] arr_words = str.Split(',');
        return arr_words;
    }
}