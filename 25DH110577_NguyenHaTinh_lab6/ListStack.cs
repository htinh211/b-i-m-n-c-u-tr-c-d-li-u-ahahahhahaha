using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _25DH110577_NguyenHaTinh_lab6
{
    internal class ListStack
    {
        private Node top;

        public Node Top { get { return top; } set { top = value; } }

        public ListStack()
        {
            top = null;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public bool Push(int x)
        {
            Node newNode = new Node(x);
            newNode.Next = top;
            top = newNode;
            return true;
        }

        public bool Pop(out int outItem)
        {
            if (IsEmpty())
            {
                outItem = 0;
                return false;
            }

            outItem = top.Data;
            top = top.Next;
            return true;
        }

        public bool GetTop(out int outItem)
        {
            if (IsEmpty())
            {
                outItem = 0;
                return false;
            }

            outItem = top.Data;
            return true;
        }
    }
}