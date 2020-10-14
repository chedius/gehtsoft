using System;

namespace QueueLib
{
    ///////////// MyNode //////////////////
    public class MyNode<T>
    {
        public T Value { get; set; }
        public MyNode<T> Next { get; set; }
        public MyNode<T> Prev { get; set; }
    }

    ///////////// MyLinkedList //////////////////
    public class MyLinkedList<T>
    {
        private MyNode<T> mHead; // голова списка (первый элемент в списке)
        private MyNode<T> mTail; // хвост списка (последний элемент в списке)
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

        /// <summary>
        /// Добавить элемент в начало списка.
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент.</param>
        public void AddFirst(T value)
        {
            MyNode<T> node = new MyNode<T>();
            MyNode<T> current = new MyNode<T>();
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
            count++;
        }

        /// <summary>
        /// Получить элемент из начала списка. Элемент не удаляется из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public T GetFirst()
        {
            if (mHead == null)
            {
                throw new InvalidOperationException();
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
            if (mHead == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                MyNode<T> current = mHead;
                current = current.Next;
                mHead = current;
                count--;
            }
        }

        /// <summary>
        /// Получить элемент с конца списка. Элемент не удаляется из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public T GetLast()
        {
            if (mHead == null)
            {
                throw new InvalidOperationException();
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
            if (mTail == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                MyNode<T> current = mTail;
                current = current.Prev;
                mTail = current.Prev;
                count--;
            }
        }

        /// <summary>
        /// Добавить элемент в конец списка.
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент.</param>
        public void AddLast(T value)
        {
            MyNode<T> node = new MyNode<T>();
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
    public class MyQueue<T>
    {
        // очередь делаем на основе MyLinkedList
        private MyLinkedList<T> mLinkedList = new MyLinkedList<T>();
        /// <summary>
        /// Добавляет элемент в конец очереди. 
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент</param>
        public void Enqueue(T value)
        {
            mLinkedList.AddLast(value);
        }

        /// <summary>
        /// Удаляет самый первый элемент из очереди и возвращает его. 
        /// Если очеред пуста, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public T Dequeue()
        {
            T deleteelement = mLinkedList.GetFirst();
            mLinkedList.RemoveFirst();
            return deleteelement;
        }

        /// <summary>
        /// Возвращает самый первый элемент в очереди, но в отличии от Dequeue() элемент из очереди не удаляется.
        /// Если очеред пуста, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public T Peek()
        {
            return mLinkedList.GetFirst();
        }

        public T PeekPeek()
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
        }
    }
}