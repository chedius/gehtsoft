using System;
using System.Collections.Generic;
using System.Text;

namespace testQueue
{
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
            int firstElem = mLinkedList.GetFirst();
            return firstElem;
        }

        /// <summary>
        /// Возвращает количество элементов в очереди или 0, если очередь пустая.
        /// Сложность: O(1).
        /// </summary>
        public int GetCount()
        {
            int countElem = mLinkedList.GetCount();
            return countElem;
        }
    }
}
