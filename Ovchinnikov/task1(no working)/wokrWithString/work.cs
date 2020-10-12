using System;
using CheckLib;
using sending;

namespace wokrWithString
{
    public class workerStr
    {
        checker check = new checker();
        sender msg = new sender();
        public void working(string str)
        {
            if (str.IndexOf('.') == -1)
            {
                msg.noFoundedDot();
            }
            else
            {

                str = str.Substring(0, str.IndexOf('.'));
                string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (check.checkLong(words) && check.checkMuch(words) && check.checkAbc(str) && check.checkEmpty(str))
                {
                    msg.sendResult(words);
                }
            }
        }
    }
}
