using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class QueueOperations<T>
    {
        private Node<T> top;
        private Node<T> last;

        public T peek()
        {
            if (top == null)
                throw new SystemException("QUEUE IS EMPTY!!!");
            return top.data;
        }

        public void Add(T _data)
        {
            Node<T> temp = new Node<T>(_data);
            if (last == null)
            {
                top = temp;
                last = temp;
            }
            else
            {
                last.next = temp;
                last = last.next;
            }
        }

        public bool isEmpty()
        {
            if ((top == null) && (last == null))
                return true;
            return false;
        }

        public T remove()
        {
            if(isEmpty())
                throw new SystemException("QUEUE IS EMPTY");

            if (top == last)
            {
                T _data = top.data;
                top = null;
                last = null;
                return _data;
            }
            else
            {
                T _data = top.data;
                top = top.next;
                return _data;
            }

        }
    }
}
