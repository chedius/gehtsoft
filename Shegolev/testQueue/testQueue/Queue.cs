using System;
using System.Collections;
using System.Collections.Generic;

namespace testQueue
{
    class Queue
    {
        static void Assert(bool predic)
        {
            if (!predic)
                throw new InvalidOperationException(); // если мы здесь, значит что-то пошло не так
        }

        static void Main(string[] args)
        {
            // Проверяющий код.
            // Закомментируйте в начале работы, чтоб он не "валил" приложеине, 
            // пока вы не закончили реализовывать структуры данных.

            MyQueue queue = new MyQueue();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            Console.WriteLine(queue.GetCount());
            Assert(queue.GetCount() == 4);
            Console.WriteLine(queue.GetCount());
            Assert(queue.Dequeue() == 10);
            Assert(queue.Dequeue() == 11);
            Console.WriteLine(queue.GetCount());
            Assert(queue.GetCount() == 2);
            Console.WriteLine(queue.GetCount());
            Assert(queue.Peek() == 12);
            Console.WriteLine(queue.GetCount());
            Assert(queue.GetCount() == 2);
            Console.WriteLine(queue.GetCount());
            Assert(queue.Dequeue() == 12);
            Assert(queue.Dequeue() == 13);
            Console.WriteLine(queue.GetCount());
            Assert(queue.GetCount() == 0);
        }
    }
}
