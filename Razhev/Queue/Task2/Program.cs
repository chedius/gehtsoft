using System;

namespace Task2
{
    ///////////// MyNode //////////////////

    public class MyNode
    {
        public int Value { get; set; }
        public MyNode Next { get; set; }
        public MyNode Prev { get; set; }
    }

    ///////////// MyLinkedList //////////////////

    public class MyLinkedList
    {
        private MyNode mHead; // голова списка (первый элемент в списке)
        private MyNode mTail; // хвост списка (последний элемент в списке)
        public int count = 0;
        // т.е. будет так
        //
        //   MyNode      <->  MyNode <-> MyNode <->         MyNode
        //   сюда                                           сюда
        //   указывает                                      указывает
        //   mHead                                          mTail
        //

        // 1) Если список пустой, то mHead = null и mTail = null
        // 2) Если в списке один элемент MyNode, то на него указывают mHead и mTail,
        //    т.к. этот один элемент является и первым и последним одновременно.
        // 3) Если в списке больше одного элемента MyNode, то на самый первый указывает mHead,
        //    а на самый последний mTail.


        public MyLinkedList()
        {
        }

        /// <summary>
        /// Добавить элемент в начало списка.
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент.</param>
        public void AddFirst(int value)
        {
            MyNode node = new MyNode();
            MyNode current = new MyNode();
            node.Value = value;
            if (mHead == null)
            {
                mHead = node;
                mTail = node;
            }
            else
            {
                current = mHead;
                node.Next = current;
                mHead = node;
            }
            //throw new NotImplementedException();
            count++;
        }

        /// <summary>
        /// Получить элемент из начала списка. Элемент не удаляется из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public int GetFirst()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                //Console.WriteLine(mHead.Value);
                return mHead.Value;
            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Удалить первый элемент из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public void RemoveFirst()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                MyNode current = mHead;
                current = current.Next;
                mHead = current;
                count--;
            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Получить элемент с конца списка. Элемент не удаляется из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public int GetLast()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                //Console.WriteLine(mTail.Value);
                return mTail.Value;
            }
            //MyNode current = mHead;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Удалить последний элемент из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public void RemoveLast()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                MyNode current = mTail;
                current = current.Prev;
                mTail = current.Prev;
                count--;
            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Добавить элемент в конец списка.
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент.</param>
        public void AddLast(int value)
        {
            MyNode node = new MyNode();
            node.Value = value;
            if (mHead == null)
            {
                mHead = node;
                mTail = node;
            }
            else
            {
                mTail.Next = node;
                node.Prev = mTail;
            }
            mTail = node;
            count++;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Получить количество элементов в списке, или 0, если список пустой.
        /// Сложность: O(1).
        /// </summary>
        public int GetCount()
        {
            return count;
            // throw new NotImplementedException();
        }
    }

    ///////////// MyQueue //////////////////

    public class MyQueue
    {
        private MyLinkedList mLinkedList = new MyLinkedList(); // очередь делаем на основе MyLinkedList

        /// <summary>
        /// Добавляет элемент в конец очереди. 
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент</param>
        public void Enqueue(int value)
        {
            mLinkedList.AddLast(value);
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Удаляет самый первый элемент из очереди и возвращает его. 
        /// Если очеред пуста, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public int Dequeue()
        {
            int deleteelement = mLinkedList.GetFirst();
            mLinkedList.RemoveFirst();
            return deleteelement;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Возвращает самый первый элемент в очереди, но в отличии от Dequeue() элемент из очереди не удаляется.
        /// Если очеред пуста, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public int Peek()
        {
            return mLinkedList.GetFirst();
            //throw new NotImplementedException();
        }

        public int PeekPeek()
        {
            return mLinkedList.GetLast();
        }

        /// <summary>
        /// Возвращает количество элементов в очереди или 0, если очередь пустая.
        /// Сложность: O(1).
        /// </summary>
        public int GetCount()
        {
            return mLinkedList.GetCount();
            // throw new NotImplementedException();
        }
    }

    /////////////////////////////////

    class Program
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
            Assert(queue.GetCount() == 4);
            Assert(queue.Dequeue() == 10);
            Assert(queue.Dequeue() == 11);

            Assert(queue.GetCount() == 2);

            Assert(queue.Peek() == 12);

            Assert(queue.GetCount() == 2);
            Console.WriteLine(queue.GetCount());
            Assert(queue.Dequeue() == 12);
            Assert(queue.Dequeue() == 13);

            Assert(queue.GetCount() == 0);
            Console.WriteLine(queue.GetCount());
        }
    }
}