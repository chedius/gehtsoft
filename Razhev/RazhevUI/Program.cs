using System;

namespace RazhevUI
{
    class Program
    {
        private Program()
        {
            string str = "q,ww,ee,rr,ttt,yyyy,uuuuu,q,o,p,uuuuu,ss,dd,f,g,h,j,xx,zz,xx,cc,vv,bb,nn,mm,q,rty,yui,asd,uuuuu.";
            InstanseFinder cont = new InstanseFinder(str);
            cont.InstanseFinderWords();
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
