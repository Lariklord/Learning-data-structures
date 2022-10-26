using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class QueueNode<T>
    {
        public T Data { get; set; }
        public QueueNode(T data)
        {
            Data = data;
        }
        public QueueNode<T> Next { get; set; }
    }
    internal class MyQueue<T>:IEnumerable<T>
    {
        QueueNode<T> head;
        QueueNode<T> tail;
        int count;

        public void Enqueue(T data)
        {
            QueueNode<T> node = new QueueNode<T>(data);
            QueueNode<T> temp = tail;
            tail = node;
            if (IsEmpty)
                head = node;
            else
                temp.Next = tail;
            count++;
        }
        public T Dequeue()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Очередб пуста");
            T temp = head.Data;
            head = head.Next;
            count--;
            return temp;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public T First { 
            get 
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Очередб пуста");
                return head.Data; 
            } 
        }
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Очередб пуста");
                return tail.Data;
            }
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T data)
        {
            QueueNode<T> current = head;
            while(current != null)
            {
                if(current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            QueueNode<T> current = head;
            while(current!=null)
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
