using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T _data)
        {
            data = _data;
            next = null;
        }
    }
    public class StackOperations<T>
    {
        private Node<T> top;

        public StackOperations()
        {
            top = null;
        }

        public void push(T _data)
        {
            Node<T> temp = new Node<T>(_data);
            temp.next = top;
            top = temp;
        }

        public T pop()
        {
            if (top == null)
                throw new SystemException("EMPTY STACK");

            T data = top.data;
            top = top.next;
            return data;
        }

        public T peek()
        {
            if (top == null)
                throw new SystemException("EMPTY STACK");

            return top.data;
        }

        public bool isEmpty()
        {
            return (top == null);
        }

        public void display()
        {
            Node<T> pointer = top;
            while (pointer != null)
            {
                Console.WriteLine(pointer.data);
                pointer = pointer.next;
            }
        }
    }
}
