using System;

class Result
{
    InputLines InstaceInputLines = new InputLines();
    LenghtLines InstaceLenghtLines = new LenghtLines();
    SequenceCharacters InstaceSequenceCharacters = new SequenceCharacters();
    Sort InstaceSort = new Sort();
    Print InstacePrint = new Print();
    public string OutputResulter()
    {
        InstacePrint.DisplayQuestion();
        int quantity = Convert.ToInt32(Console.ReadLine());
        var lines = InstaceInputLines.EnterNumberLines(quantity);
        var countedlines = InstaceLenghtLines.FindLenghtLines(lines);
        var sequence = InstaceSequenceCharacters.GetSequenceCharacters(lines, countedlines);
        var sortsymbols = InstaceSort.SortSymbols(sequence);
        string resultsortsymbols = "";
        foreach (var i in sortsymbols)
        {
            resultsortsymbols += i;
        }
        return resultsortsymbols;
    }
}