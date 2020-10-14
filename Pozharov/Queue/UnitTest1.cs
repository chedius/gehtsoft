using NUnit.Framework;

namespace Queue
{
    public class Tests
    {
        [Test]
        public void Test1()
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