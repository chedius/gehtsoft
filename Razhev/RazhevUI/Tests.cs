using System;
using RazhevUI;
using System.Collections.Generic;
public class Tests
{
    Tests tests = new Tests();
    Program InstanceProgramTest = new Program();
    public bool RandomWordsTest()
    {
        List<string> tTest1 = InstanceProgramTest.RandomWords(0, 0);
        List<string> tTest2 = InstanceProgramTest.RandomWords(2, 4);
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
        string test = InstanceProgramTest.GenerateStr(tTest1);
        InstanceProgramTest.GenerateStr(tTest2);
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
    Spliter InstanceSpliterTest = new Spliter();
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

    public string tstrTest = "a,b,c,d,v.";
    Finder InstanceFinderTest = new Finder(tests.tstrTest);
}