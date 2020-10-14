using System;
using QueueLib;
namespace QueueUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue1 = new MyQueue();

            queue1.Enqueue(10);
            queue1.Enqueue(11);

            Console.WriteLine(queue1.GetCount());
            queue1.Dequeue();
            Console.WriteLine(queue1.GetCount());
        }
    }
}
