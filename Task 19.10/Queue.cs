using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{

    public class Queue
    {
        class Node
        {
            public int info;
            public Node next;
            public Node(int _info, Node _next) // конструктор
            {
                info = _info;
                next = _next;
            }
        }

        Node head;
        public Queue()
        {
            head = null;
        }
        public void push(int info)
        {
            Node tmp = new Node(info, null);
            if (isEmpty())
                head = tmp;
            else
            {
                Node i = head;
                while (i.next != null)
                    i = i.next;
                i.next = tmp;
            }
        }
        public int pop()
        {
            if (isEmpty())
                throw new InvalidOperationException();
            int res = head.info;
            head = head.next;
            return res;
        }
        public bool isEmpty()
        {
            return (head == null);
        }
    }

}
