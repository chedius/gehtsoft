using System;

///////////// MyQueue //////////////////
public class MyQueue
{
    // очередь делаем на основе MyLinkedList
    private MyLinkedList mLinkedList = new MyLinkedList();
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