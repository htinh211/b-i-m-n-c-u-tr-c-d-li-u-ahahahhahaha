using _25DH110577_NguyenHaTinh_lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab2
{
    internal class NodeDoan
    {
        private Doan data;
        private NodeDoan next;

        public Doan Data { get { return data; } set { data = value; } }
        public NodeDoan Next { get { return next; } set { next = value; } }

        public NodeDoan() { }

        public NodeDoan(Doan d)
        {
            data = d;
            next = null;
        }
    }
}