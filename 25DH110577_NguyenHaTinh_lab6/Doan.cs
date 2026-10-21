using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab6
{
    internal class Doan
    {
        private int left;
        private int right;

        public int Left { get { return left; } set { left = value; } }
        public int Right { get { return right; } set { right = value; } }

        public Doan() { }

        public Doan(int l, int r)
        {
            left = l;
            right = r;
        }
    }
}
