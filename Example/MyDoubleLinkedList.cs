using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class DoubleNode<T>
    {
        public DoubleNode(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public DoubleNode<T>? Next { get; set; }
        public DoubleNode<T>? Previous { get; set; }
    }
    internal class MyDoubleLinkedList<T> : IEnumerable<T>
    {
        DoubleNode<T>? head;
        DoubleNode<T>? tail;
        int count;
        public int Count { get { return count; } }

        public void Add(T data)
        {
            DoubleNode<T> el = new DoubleNode<T>(data);
            if (head == null)
            {
                head = el;
            }
            else
            {
                tail.Next = el;
                el.Previous = tail;
            }
            tail = el;
            count++;
        }
        public bool Remove(T data)
        {
            DoubleNode<T>? curent = head;
            while (curent != null)
            {
                if (curent.Data.Equals(data))
                {
                    break;    
                }
                curent = curent.Next;
            }
            if(curent!=null)
            {
                if(curent.Next!=null)
                    curent.Next.Previous=curent.Previous;
                else
                    tail = curent.Previous;
                if (curent.Previous != null)
                    curent.Previous.Next = curent.Next;
                return true;
            }
            return false;
        }
        public bool IsEmpty { get { return count == 0; } }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T data)
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public void AppendFirst(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            DoubleNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public IEnumerable<T> BackEnumerator()
        {
            DoubleNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}
