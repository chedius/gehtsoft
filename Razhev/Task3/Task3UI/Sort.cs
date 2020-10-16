using System;
using System.Collections.Generic;
using System.Linq;
class Sort
{
    public IOrderedEnumerable<char> SortSymbols(List<char> sequenceCharacters)
    {
        var sortedsymbols = from i in sequenceCharacters orderby i descending select i;
        return sortedsymbols;
    }
}