using System;
using System.Collections.Generic;
using System.Text;

namespace testQueue
{
    public class MyLinkedList
    {
        private MyNode mHead; // голова списка (первый элемент в списке)
        private MyNode mTail; // хвост списка (последний элемент в списке)
        int count = 0;

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
            MyNode temp = new MyNode();
            node.Value = value;
            if (mHead == null)
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
        public int GetFirst()
        {
            if (mHead == null)
            {
                throw new InvalidOperationException();
            }
            else return mHead.Value;
        }

        /// <summary>
        /// Удалить первый элемент из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public void RemoveFirst()//?????????????????????
        {
            if (mHead == null)
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
        }

        /// <summary>
        /// Получить элемент с конца списка. Элемент не удаляется из списка.
        /// Если список пуст, то кидает InvalidOperationException.
        /// Сложность: O(1).
        /// </summary>
        public int GetLast()
        {
            if (mTail == null)
            {
                throw new InvalidOperationException();
            }
            else return mTail.Value;
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
                MyNode current = mTail;
                current = current.Prev;
                mTail = current;
                count--;
            }
        }

        /// <summary>
        /// Добавить элемент в конец списка.
        /// Сложность: O(1).
        /// </summary>
        /// <param name="value">Добавляемый элемент.</param>
        public void AddLast(int value)//??????????????????????????????
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
                mTail.Prev = mTail;
                mTail = node;
            }
            count++;
        }

        /// <summary>
        /// Получить количество элементов в списке, или 0, если список пустой.
        /// Сложность: O(1).
        /// </summary>
        public int GetCount()
        {
            if (count == 0)
            {
                return 0;
            }
            else return count;
        }
    }
}
