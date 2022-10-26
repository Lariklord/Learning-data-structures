using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public Node<T>? Next { get; set; }
    }
    internal class MyLinkedList<T>:IEnumerable<T>
    {
        Node<T>? head;
        Node<T>? tail;
        int count;
        public int Count { get { return count; } }

        public void Add(T data)
        {
            Node<T> el = new Node<T>(data);
            if(head == null)
            {
                head = el;
            }
            else
            {
                tail.Next=el;
            }
            tail = el;
            count++;
        }
        public bool Remove(T data)
        {
            Node<T>? curent = head;
            Node<T>? previous = null;
            while(curent!= null)
            {
                if(curent.Data.Equals(data))
                {
                    if(previous != null)
                    {
                        previous.Next = curent.Next;

                        if (curent.Next == null)
                            tail = curent;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = curent;
                curent = curent.Next;
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
            Node<T> current = head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next=head;
            head = node;
            count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
