using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class MyStackOnArray<T>
    {
        private int head;
        T[] elements;
        public MyStackOnArray(int length = 10)
        {
            elements = new T[length];
        }

        public int Count { get { return head; } }
        public bool IsEmpty
        { 
            get{ return head == 0; } 
        }
        public void Push(T elem)
        {
            if (head == elements.Length)
                throw new InvalidOperationException("Стек переполнен");
            elements[head++] = elem;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пустой");
            T elem = elements[--head];
            elements[head] = default(T);
            return elem;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пустой");
            return elements[head-1];
        }
    }
}
