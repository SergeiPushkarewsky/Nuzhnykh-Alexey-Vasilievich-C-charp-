using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
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
            tmp.next = head;
            head = tmp;
        }
        public int pop()
        {
            if (isEmpty())
                throw new Exception();
            int v = head.info;
            head = head.next;
            return v;
        }
        public bool isEmpty()
        {
            return (head == null);
        }
    }

}
