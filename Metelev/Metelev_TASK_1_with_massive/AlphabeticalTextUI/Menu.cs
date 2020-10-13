  
using System;


namespace Task_1_with_massive
{
    class Menu
    {   
        /*
            Метод Main выполняет вывод пользовательского меню, вызов доступных методов для генерации и преобразования строки, и вывод результата
        */

        static void Main(string[] args)
        {
            AlphabetSort Obj = new AlphabetSort();
            StrBuilder genStr = new StrBuilder();
            Tester test1 = new Tester();
            NullStrTester test5 = new NullStrTester();
            StrPrinter msg = new StrPrinter();
            char key;
            string text, res;
            bool f =  true;
            bool b, t;
            while(f == true)
            {
                StrPrinter.OutputMenu();
                key = StrPrinter.InputKey();
                switch(key)
                {
                    case '1':
                    StrPrinter.OutputEnterText();
                    text = StrPrinter.InputString();
                    b = test5.TestNullStr(text);
                    if (b == true)
                    {
                        res= Obj.Sort(text);
                        StrPrinter.OutputResult(res);
                    }
                    else 
                    {
                        StrPrinter.NullStrException();
                        goto case '1';
                    } 
                    break;

                    case '2':
                    Console.Clear();
                    text = genStr.StrBuild(msg.alphabet, 141, 7);
                    StrPrinter.OutputGenText(text);
                    res = Obj.Sort(text);
                    StrPrinter.OutputResult(res); 
                    StrPrinter.Pause();
                    break;
                    
                    case '3':
                    StrPrinter.OutputTestsMenu();
                    key = StrPrinter.InputKey();
                    if (key == '1')
                    {
                        t = test1.TestMod();
                        StrPrinter.OutputTestRes(t);
                        StrPrinter.Pause();
                    }
                    else if (key == '2')
                    {
                        t = test1.TestGen();
                        StrPrinter.OutputTestRes(t);
                        StrPrinter.Pause();
                    }
                    else 
                    {
                        StrPrinter.OutputWrongNumberException();
                        StrPrinter.Pause();
                        goto case '3';
                    }
                    break;

                    case '4':
                    Console.Clear();
                    f=false;
                    break;

                    default:
                    StrPrinter.OutputWrongNumberException();
                    StrPrinter.Pause();
                    break;
                }

            }
        }   
    }
}