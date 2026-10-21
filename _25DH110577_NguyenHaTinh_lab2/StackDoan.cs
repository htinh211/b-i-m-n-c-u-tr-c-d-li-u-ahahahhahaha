using _25DH110577_NguyenHaTinh_lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab2
{
    internal class StackDoan
    {
        private NodeDoan top;

        public NodeDoan Top { get { return top; } set { top = value; } }

        public StackDoan()
        {
            top = null;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public bool Push(int left, int right)
        {
            NodeDoan newNode = new NodeDoan(new Doan(left, right));
            newNode.Next = top;
            top = newNode;
            return true;
        }

        public bool Pop(out Doan outItem)
        {
            if (top == null)
            {
                outItem = new Doan();
                return false;
            }

            outItem = top.Data;
            top = top.Next;
            return true;
        }

        public bool GetTop(out Doan outItem)
        {
            if (top == null)
            {
                outItem = new Doan();
                return false;
            }

            outItem = top.Data;
            return true;
        }
    }
}