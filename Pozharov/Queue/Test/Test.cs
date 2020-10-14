using System;
using MyNode;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    public class Test
    {
        
        static bool Assert(bool predict)
        {
            if(!predict)
            if (!predic)
                throw new InvalidOperationException();
            
        }
        //[Test]
        static void Main()
        {
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
