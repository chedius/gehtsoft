using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApplication
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
        int count = 0;
        private MyNode mHead; // голова списка (первый элемент в списке)
        private MyNode mTail; // хвост списка (последний элемент в списке)

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

        /// <summary>
        /// Добавить элемент в начало списка.
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент.</param>
        public void AddFirst(int value)
        {
            MyNode node = new MyNode();
            MyNode temp = mHead;
            node.Value = value;
            node.Next = temp;
            if(count == 0)
            {
                mHead = node;
                mTail = node;
            }
            else 
            {
                temp = mHead;
                node.Next = temp;
                mHead = node;
            }
            count ++;
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
                throw new NotImplementedException();
            }
            else
            {
                return mHead.Value;
            }
        }

        /// <summary>
        /// Удалить первый элемент из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public void RemoveFirst()
        {
            if(count == 0)
            {
                throw new NotImplementedException();
            }
            else
            {
                MyNode temp = mHead;
                temp = temp.Next;
                mHead = temp;
                count--;
            }
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
                throw new NotImplementedException();
            }
            else
            {
                return mTail.Value;
            }
        }

        /// <summary>
        /// Удалить последний элемент из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public void RemoveLast()
        {
            if(count == 0)
            {
                throw new NotImplementedException();
            }
            else
            {
                MyNode temp = mTail;
                temp = temp.Prev;
                mTail = temp;
                count--;
            }
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
            if (count == 0)
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
        }

        /// <summary>
        /// Получить количество элементов в списке, или 0, если список пустой.
        /// Сложность: O(1).
        /// </summary>
        public int GetCount()
        {
                return count;
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
        }

        /// <summary>
        /// Удаляет самый первый элемент из очереди и возвращает его. 
        /// Если очеред пуста, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public int Dequeue()
        {
            int firstElem = mLinkedList.GetFirst();
            mLinkedList.RemoveFirst();
            return firstElem;
        }

        /// <summary>
        /// Возвращает самый первый элемент в очереди, но в отличии от Dequeue() элемент из очереди не удаляется.
        /// Если очеред пуста, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public int Peek()
        {
            return mLinkedList.GetFirst();
        }

        /// <summary>
        /// Возвращает количество элементов в очереди или 0, если очередь пустая.
        /// Сложность: O(1).
        /// </summary>
        public int GetCount()
        {
            return mLinkedList.GetCount();
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
