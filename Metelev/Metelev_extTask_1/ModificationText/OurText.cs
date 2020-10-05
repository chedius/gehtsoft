using System;
using System.Linq;
public class OurText
{  
    private string mTxt;
    public OurText(string txt)
    {
        mTxt = txt;
    }
    public void Modification()
    {
        Console.WriteLine("Измененный текст:");
        Console.WriteLine(new string(mTxt
        .Where(letter => (letter >= 'а' && letter <= 'я'))
        .OrderBy(letter => letter)
        .ToArray()));
    }
}