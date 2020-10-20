using NUnit.Framework;
using QueueLib;

namespace Tests
{
    public class Tests
    {
        private MyQueue<int> queue;

        [SetUp]
        public void Setup()
        {
            queue = new MyQueue<int>();
        }

        [Test]
        public void Test1()
        {
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);

            Assert.IsTrue(queue.GetCount() == 4);
            Assert.IsTrue(queue.Dequeue() == 10);
            Assert.IsTrue(queue.Dequeue() == 11);

            Assert.IsTrue(queue.GetCount() == 2);

            Assert.IsTrue(queue.Peek() == 12);

            Assert.IsTrue(queue.GetCount() == 2);

            Assert.IsTrue(queue.Dequeue() == 12);
            Assert.IsTrue(queue.Dequeue() == 13);

            Assert.IsTrue(queue.GetCount() == 0);
        }
    }
}