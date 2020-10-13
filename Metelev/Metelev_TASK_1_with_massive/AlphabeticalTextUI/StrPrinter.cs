using System;

namespace Task_1_with_massive
{
    public class StrPrinter
    {
        public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnmабвгдежзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789!№;%:?*().><,";
        public string nullStr = "No lowercase Russian letters found in the text";
        public static void OutputEnterText()
        {
            Console.Clear();
            Console.WriteLine("Enter text:");
        }
        public static void OutputMenu()
        {
            Console.Clear();    
            Console.WriteLine("The program returns all lowercase Russian letters from the text in alphabetical order");
            Console.WriteLine("1.Enter text in console");
            Console.WriteLine("2.Use generated text");
            Console.WriteLine("3.Tests");
            Console.WriteLine("4.Exit");   
        }
        public static void OutputResult(string res)
        {
            Console.WriteLine("Lowercase Russian letters from text in alphabetical order:\n" + res);
            Console.ReadKey();
        }
        public static string InputString()
        {
            return Console.ReadLine();
        }
        public static void NullStrException()
        {
            Console.WriteLine("You entered an empty line!");
            Console.ReadKey();
        }
        public static void OutputGenText(string text)
        {
            Console.WriteLine("Generated text is used:\n" + text);
        }

        public static char InputKey()
        {
            return Console.ReadKey().KeyChar;
        }

        public static void OutputTestsMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter the test number");
            Console.WriteLine("1.Testing the text modification function (returns the text correctly)");
            Console.WriteLine("2.Testing the string generation function (maximum string and word lengths are not exceeded)");
        }
        public static void OutputTestRes(bool t)
        {
            Console.WriteLine("\n" + t);
        }
        public static void OutputWrongNumberException()
        {
            Console.WriteLine("You entered the wrong number!");
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}