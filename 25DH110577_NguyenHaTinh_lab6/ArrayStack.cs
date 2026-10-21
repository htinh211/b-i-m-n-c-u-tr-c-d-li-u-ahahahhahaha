using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab6
{
    internal class ArrayStack
    {
        private int[] stkArray;
        private int stkMax;
        private int stkTop;

        public int[] StkArray { get { return stkArray; } set { stkArray = value; } }
        public int StkMax { get { return stkMax; } set { stkMax = value; } }
        public int StkTop { get { return stkTop; } set { stkTop = value; } }

        public ArrayStack() { }

        public ArrayStack(int max)
        {
            stkMax = max;
            stkArray = new int[max];
            stkTop = -1;
        }

        public bool IsEmpty()
        {
            if (stkTop == -1)
                return true;
            else
                return false;
        }

        public bool IsFull()
        {
            if (stkTop == stkMax - 1)
                return true;
            return false;
        }

        public bool Push(int x)
        {
            if (IsFull())
                return false;
            else
            {
                stkTop++;
                stkArray[stkTop] = x;
                return true;
            }
        }

        public bool Pop(out int x)
        {
            if (IsEmpty())
            {
                x = 0;
                return false;
            }

            x = stkArray[stkTop];
            stkTop--;
            return true;
        }

        public bool GetTop(out int x)
        {
            if (IsEmpty())
            {
                x = 0;
                return false;
            }

            x = stkArray[stkTop];
            return true;
        }
    }
}