using System;
using QueueLib;

namespace QueueUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyQueue<int> queue1 = new MyQueue<int>();
            queue1.Enqueue(10);
            queue1.Enqueue(11);

            Console.WriteLine("Total elements in a queue:" + queue1.GetCount());
            Console.WriteLine("Let's add one element in the end of the queue");
            queue1.Enqueue(12);
            Console.WriteLine("Now there are {0} elements and the last element equals {1}", queue1.GetCount(), queue1.Last());
        }
    }
}
