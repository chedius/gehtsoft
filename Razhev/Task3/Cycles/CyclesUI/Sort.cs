using System;
using System.Collections.Generic;
using System.Linq;
class Sort
{
    public string SortSymbols(List<char> sequenceCharacters)
    {
        sequenceCharacters.Sort();
        sequenceCharacters.Reverse();
        string sortresult = "";
        foreach (var i in sequenceCharacters)
        {
            sortresult += i;
        }
        return sortresult;
    }
}