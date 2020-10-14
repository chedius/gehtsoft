using System;
using QueueLib;
using Tests;

namespace QueueUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue1 = new MyQueue<int>();
            queue1.Enqueue(10);
            queue1.Enqueue(11);
            queue1.Enqueue(12);
            Console.WriteLine("Количество элементов в очереди: " + queue1.GetCount());
            Console.WriteLine("Удаляем первый элемент {0} из очереди", queue1.Dequeue());
            Console.WriteLine("Первый элемент в очереди теперь {0}", queue1.Peek());

        }
    }
}
