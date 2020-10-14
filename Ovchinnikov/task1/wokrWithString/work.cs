using System;
using CheckLib;
using sending;

namespace wokrWithString
{
    public class WorkerStr
    {
        Checker check = new Checker();
        Sender msg = new Sender();
        public void Working(string str)
        {
            if (str.IndexOf('.') == -1)
            {
                msg.NoFoundedDot();
            }
            else
            {

                str = str.Substring(0, str.IndexOf('.'));
                string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (check.Check(words, str))
                {
                    msg.SendResult(words);
                }
            }
        }
    }
}
