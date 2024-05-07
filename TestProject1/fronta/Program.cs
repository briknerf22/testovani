using System;
using System.Collections.Generic;

namespace Program;

public class Stack<T>
{
    private List<T> items;

    public Stack()
    {
        items = new List<T>();
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T poppedItem = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return poppedItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return items[items.Count - 1];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public int Count
    {
        get { return items.Count; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}