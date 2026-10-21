using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab6
{
    internal class Node
    {
        private int data;
        private Node next;

        public int Data { get { return data; } set { data = value; } }
        public Node Next { get { return next; } set { next = value; } }

        public Node() { }

        public Node(int x)
        {
            data = x;
            next = null;
        }
    }
}