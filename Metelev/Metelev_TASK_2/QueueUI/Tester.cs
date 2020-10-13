using System;
using System.Collections.Generic;
using System.Collections;

namespace QueueUI
{
    public class Tester
    {
        static void Assert(bool predic)
        {
            if (!predic)
                throw new InvalidOperationException(); // если мы здесь, значит что-то пошло не так
        }
        public static void TestQueue(){
            // Проверяющий код
            MyQueue queue = new MyQueue();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);

            Assert(queue.GetCount() == 4);
            Assert(queue.Dequeue() == 10);
            Assert(queue.Dequeue() == 11);

            Assert(queue.GetCount() == 2);

            Assert(queue.Peek() == 12);

            Assert(queue.GetCount() == 2);

            Assert(queue.Dequeue() == 12);
            Assert(queue.Dequeue() == 13);

            Assert(queue.GetCount() == 0);
        }
    }
}