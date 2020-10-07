using System;
using System.Linq;
public class Modification
{  
    private string mTxt;
    public Modification(string txt)
    {
        mTxt = txt;
    }
    public void Modificate()
    {
        Console.WriteLine("Измененный текст:");
        Console.WriteLine(new string(mTxt
        .Where(letter => (letter >= 'а' && letter <= 'я'))
        .OrderBy(letter => letter)
        .ToArray()));
    }
}