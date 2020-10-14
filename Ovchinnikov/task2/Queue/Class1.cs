using System;

namespace Queue
{
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
        public int count;

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
            mHead = null;
            mTail = null;
        }

        /// <summary>
        /// Добавить элемент в начало списка.
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент.</param>
        public void AddFirst(T value)
        {
            MyNode<T> node = new MyNode<T>();
            node.Value = value;
            if (count == 0)
            {
                mHead = node;
                mTail = node;
            }
            else
            {
                mHead.Prev = node;
                node.Next = mHead;
            }
            mHead = node;
            count++;
        }

        /// <summary>
        /// Получить элемент из начала списка. Элемент не удаляется из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public T GetFirst()
        {
            if (count == 0)
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
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                MyNode<T> temp = mHead;
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
        public T GetLast()
        {
            if (count == 0)
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
            MyNode<T> temp = mTail;
            temp = temp.Prev;
            mTail = temp;
            count--;
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

    public class MyQueue<T>
    {
        private MyLinkedList<T> mLinkedList = new MyLinkedList<T>(); // очередь делаем на основе MyLinkedList
        //MyLinkedList myList = new MyLinkedList();
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
            T results = mLinkedList.GetFirst();
            mLinkedList.RemoveFirst();
            return results;
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

        /// <summary>
        /// Возвращает количество элементов в очереди или 0, если очередь пустая.
        /// Сложность: O(1).
        /// </summary>
        public int GetCount()
        {
            return mLinkedList.count;
        }
    }
}
