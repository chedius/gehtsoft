using NUnit.Framework;
using QueueLib;

namespace NunitTests
{
    [TestFixture]
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
            queue.GetCount();
            queue.Dequeue();
            queue.Dequeue();

            queue.GetCount();

            queue.Peek();

            queue.GetCount();

            queue.Dequeue();
            queue.Dequeue();

            queue.GetCount();
        }
    }
}