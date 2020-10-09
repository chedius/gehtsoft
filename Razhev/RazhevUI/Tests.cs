using System;
using IntroUI;
using System.Collections.Generic;
public class Tests
{
    ModificationsStr InstanceModificationsStrTest = new ModificationsStr();
    Spliter InstanceSpliterTest = new Spliter();
    GeneratorRandowWords InstanceGeneratorRandowWordsTest = new GeneratorRandowWords();
    public string testfindesowrds = "a,b,c,d,e.";
    public bool RandomWordsTest()
    {
        char[] setTest = "abcd".ToLower().ToCharArray();
        List<string> tTest1 = InstanceGeneratorRandowWordsTest.RandomWords(0, 0, setTest);
        List<string> tTest2 = InstanceGeneratorRandowWordsTest.RandomWords(2, 4, setTest);
        if (tTest2.Count == 4)
        {
            foreach (var tTemp in tTest2)
            {
                if (tTemp.Length == 2)
                {
                    return true;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool GenerateStrTest()
    {
        List<string> tTest1 = new List<string>();
        List<string> tTest2 = new List<string>();
        tTest1.Add("a");
        tTest1.Add("b");
        tTest1.Add("c");
        string test = InstanceModificationsStrTest.GenerateStr(tTest1);
        InstanceModificationsStrTest.GenerateStr(tTest2);
        string tStr = "a,b,c.";
        if (tStr != test)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool SpliterWordsTest()
    {
        string test1 = "a,b,c.";
        string test2 = "";
        string[] tTest1 = InstanceSpliterTest.SpliterWords(test1);
        string[] tTest2 = InstanceSpliterTest.SpliterWords(test2);
        if (tTest1.Length != 3 & tTest2.Length != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public bool FinderWordsTest()
    {
        List<int> Occurrencestest;
        List<string> wWordstest;
        string[] massivetestfindesowrds = InstanceSpliterTest.SpliterWords(testfindesowrds);
        Finder testcase = new Finder(testfindesowrds);
        List<string> failedwWordstest = testcase.FinderWords(massivetestfindesowrds, out Occurrencestest, out wWordstest);
        if (failedwWordstest.Count == 0 & Occurrencestest.Count == 5 & wWordstest.Count == 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}