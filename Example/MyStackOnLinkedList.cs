using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode(T data)
        {
            Data = data;
        }
        public StackNode<T>? Next { get; set; }
    }
    internal class MyStackOnLinkedList<T>:IEnumerable<T>
    {
        StackNode<T>? head;
        int count;

        public int Count { get { return count; } }

        public bool IsEmpty { get { return count == 0; } }

        public void Push(T data)
        {
            var elem = new StackNode<T>(data);
            elem.Next = head;
            head = elem;
            count++;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T elem = head.Data;
            head = head.Next;
            count--;
            return elem;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return head.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            StackNode<T>? current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
            
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
