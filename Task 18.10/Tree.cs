using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Tree
    {
        public class Node
        {
            public int data;
            public Node l, r;
            public Node(int a)
            {
                l = null;
                r = null;
                data = a;
            }
        }

        Node root;

        public Tree()
        {
            root = null;
        }

        public bool isEmpty()
        {
            return (root == null);
        }

        public void Add(int a)
        {
            root = Add1(root,a);
        }
        private  Node Add1(Node node, int a)
        {
            if (node == null)
                return new Node(a);
            if (a > node.data)
                node.r = Add1(node.r,a);
            else
                node.l = Add1(node.l,a);
            return node;
        }

        public int f(int k, float x)
        {
            n = 0;
            int lvl = 1;
            f1(root, lvl, k, x);
            return n;
        }
        private int n;
        private void f1(Node node, int level, int k, float x)
        {
            if (node == null)
                return;
            if (level > k && (float)node.data < x)
                n++;
            f1(node.l, level + 1, k, x);
            f1(node.r, level + 1, k, x);
        }
    }
}
