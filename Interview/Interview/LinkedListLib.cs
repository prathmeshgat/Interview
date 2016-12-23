using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int _d)
        {
            data = _d;
        }
    }

    public class LinkedListLib
    {
        private Node head;

        public LinkedListLib()
        {
            head = null;
        }

        public Node getNode(int _d)
        {
            return new Node(_d);
        }

        public Node Add(int _d)
        {
            Node tempNode = getNode(_d);

            if (head == null)
                head = tempNode;
            else
            {
                Node pointer = head;
                while (pointer.next != null)
                    pointer = pointer.next;

                pointer.next = tempNode;
            }
            return tempNode;
        }

        public void DisplayList()
        {
            Node pointer = head;
            while (pointer != null)
            {
                Console.WriteLine(pointer.data);
                pointer = pointer.next;
            }
        }

        public int DeleteFirstOccurance(int _d)
        {
            if (head == null)
                return Int32.MinValue;
            if (head.data == _d)
            {
                head = head.next;
                return _d;
            }
            else
            {
                Node pointer = head;
                while (pointer != null)
                {
                    if (pointer.next != null && pointer.next.data == _d)
                    {
                        pointer.next = pointer.next.next;
                        return _d;
                    }
                    pointer = pointer.next;
                }
            }
            return Int32.MinValue;
        }

        public int kthElement(int k)
        {
            if (k < 0)
                return int.MinValue;

            if (head == null)
                return int.MinValue;

            int count = -1;
            Node pointer1 = head;
            Node pointer2 = head;

            while (count < k && pointer2 != null)
            {
                pointer2 = pointer2.next;
                count++;
            }

            if (count == k)
            {
                while (pointer2 != null)
                {
                    pointer2 = pointer2.next;
                    pointer1 = pointer1.next;
                }
                return pointer1.data;
            }
            else
                return int.MinValue;
        }

        public bool DeleteGivenNode(Node n)
        {
            if (n == null)
                return false;
            if (n.next == null)
                return false;
            Node nextNode = n.next;
            n.data = nextNode.data;
            n.next = nextNode.next;

            return true;
        }

        public string getList()
        {
            if (head == null)
                return null;
            string data = null;
            Node pointer = head;

            while (pointer != null)
            {
                data = data + pointer.data;
                pointer = pointer.next;
            }

            return data;
        }

        public bool isPalindrome()
        {
            string testList = getList();
            if (string.IsNullOrEmpty(testList))
                return false;
            int pointer1 = 0;
            int pointer2 = testList.Length - 1;

            while (pointer1 < pointer2)
            {
                if (testList[pointer1] != testList[pointer2])
                    return false;
                pointer1++;
                pointer2--;
            }
            return true;
        }

        public void stairCase(int n)
        {
            if (n >= 1 && n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j < n; j++)
                    {
                        if (j < n - i)
                            Console.Write(' ');
                        else
                            Console.Write('#');
                    }
                }
            }

        }

    }
}
