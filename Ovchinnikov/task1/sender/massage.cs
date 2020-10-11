using System;

namespace sending
{
    public class sender
    {
        public void noFoundedDot()
        {
            Console.WriteLine("Точка не найдена");
        }

        public void sendResult(string[] words)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                Console.Write(words[words.Length - i - 1] + ',');

            }
            Console.Write(words[0] + '.');
            Console.WriteLine();
        }
        public void sendLong()
        {
            Console.WriteLine("Есть слишком длинное слово");
        }
        public void sendMuch()
        {
            Console.WriteLine("Cлишком много слов");
        }
        public void sendAbc()
        {
            Console.WriteLine("Есть символы, не являющиеся строчными латинскими буквами");
        }
        public void sendAbtInput()
        {
            Console.WriteLine("Введите слова через запятую на латинском алфавите с точкой в конце");
        }
        public void sendEmpty()
        {
            Console.WriteLine("Пустое слово");
        }

        public void sendHello()
        {
            Console.WriteLine("Выберете способ ввода");
            Console.WriteLine("1:Ввод с консоли");
            Console.WriteLine("2:Использовать готовую строку");
            Console.WriteLine("3:Тесты");
        }
        public void sendHelloTest()
        {
            Console.WriteLine("Какое свойство хотите протестировать?");
            Console.WriteLine("1-Длинна слова");
            Console.WriteLine("2-Алфавит");
        }
    }
}
