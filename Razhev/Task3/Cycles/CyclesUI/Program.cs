using System;
namespace Task3UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Result InstaceResult = new Result();
            Print InstacePrint = new Print();
            string result = InstaceResult.OutputResulter();
            InstacePrint.DisplayResult();
            Console.WriteLine(result);
        }
    }
}