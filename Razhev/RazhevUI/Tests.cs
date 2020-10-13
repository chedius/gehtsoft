using System;
using IntroUI;
using System.Collections.Generic;
public class Tests
{
    ModificationsStr InstanceModificationsStrTest = new ModificationsStr();
    Spliter InstanceSpliterTest = new Spliter();
    GeneratorRandowWords InstanceGeneratorRandowWordsTest = new GeneratorRandowWords();
    Finder testcase = new Finder();
    public bool Assert(bool predic)
    {
        if (!predic)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string testfindesowrds = "a,b,c,d,e.";
    public void RandomWordsTest()
    {
        char[] setTest = "abcd".ToLower().ToCharArray();
        List<string> tTest1 = InstanceGeneratorRandowWordsTest.GenerateRandomWords(0, 0, setTest);
        List<string> tTest2 = InstanceGeneratorRandowWordsTest.GenerateRandomWords(2, 4, setTest);
        Console.WriteLine(Assert(tTest2.Count == 4));
        foreach (var tTemp in tTest2)
        {
            Console.WriteLine(Assert(tTemp.Length == 2));
        }
    }

    public void GenerateStrTest()
    {
        List<string> tTest1 = new List<string>();
        List<string> tTest2 = new List<string>();
        tTest1.Add("a");
        tTest1.Add("b");
        tTest1.Add("c");
        string test = InstanceModificationsStrTest.GenerateStr(tTest1);
        InstanceModificationsStrTest.GenerateStr(tTest2);
        string tStr = "a,b,c.";
        Console.WriteLine(Assert(tStr != test));
    }

    public void SpliterWordsTest()
    {
        string test1 = "a,b,c.";
        string test2 = "";
        string[] tTest1 = InstanceSpliterTest.SpliterWords(test1);
        string[] tTest2 = InstanceSpliterTest.SpliterWords(test2);
        Console.WriteLine(Assert(tTest1.Length != 3 & tTest2.Length != 0));
    }
    public void FinderWordsTest()
    {
        List<int> Occurrencestest;
        List<string> wWordstest;
        string[] massivetestfindesowrds = InstanceSpliterTest.SpliterWords(testfindesowrds);
        List<string> failedwWordstest = testcase.FinderWords(testfindesowrds, massivetestfindesowrds, out Occurrencestest, out wWordstest);
        Console.WriteLine(Assert(failedwWordstest.Count == 0 & Occurrencestest.Count == 5 & wWordstest.Count == 5));
    }
}