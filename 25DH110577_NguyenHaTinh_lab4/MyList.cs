using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab4
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        private int count;

        public IntNode First { get { return first; } set { first = value; } }
        public IntNode Last { get { return last; } set { last = value; } }
        public int Count { get { return count; } }

        public MyList()
        {
            first = null;
            last = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
            count++;
        }

        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
            count++;
        }

        public void Input_Front()
        {
            int x;
            while (true)
            {
                Console.Write("x (0 to stop) = ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    break;
                AddFirst(new IntNode(x));
            }
        }

        public void Input_Last()
        {
            int x;
            while (true)
            {
                Console.Write("x (0 to stop) = ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    break;
                AddLast(new IntNode(x));
            }
        }

        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        public IntNode SearchX(int x)
        {
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data == x)
                    return p;
            }
            return null;
        }

        public IntNode GetMax()
        {
            IntNode max = first;
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data > max.Data)
                    max = p;
            }
            return max;
        }

        public IntNode GetMin()
        {
            IntNode min = first;
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data < min.Data)
                    min = p;
            }
            return min;
        }

        public MyList GetEvenList()
        {
            MyList evenList = new MyList();
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data % 2 == 0)
                {
                    evenList.AddLast(new IntNode(p.Data));
                }
            }
            return evenList;
        }

        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data % 2 != 0)
                {
                    oddList.AddLast(new IntNode(p.Data));
                }
            }
            return oddList;
        }

        public static MyList JoinList(MyList list1, MyList list2)
        {
            MyList list3 = new MyList();

            if (list1 != null)
            {
                for (IntNode p = list1.First; p != null; p = p.Next)
                {
                    list3.AddLast(new IntNode(p.Data));
                }
            }

            if (list2 != null)
            {
                for (IntNode p = list2.First; p != null; p = p.Next)
                {
                    list3.AddLast(new IntNode(p.Data));
                }
            }

            return list3;
        }

        public IntNode Search_At_i(int i)
        {
            int viTri = 0;
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (viTri == i)
                    return p;
                viTri++;
            }
            return null;
        }

        public int CountNodes()
        {
            int dem = 0;
            for (IntNode p = first; p != null; p = p.Next)
                dem++;
            return dem;
        }

        public void Input_Front_NotDuplicate()
        {
            int x;
            while (true)
            {
                Console.Write("x (0 to stop) = ");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                    break;
                if (SearchX(x) != null)
                {
                    Console.WriteLine("Gia tri {0} da ton tai, hay nhap gia tri khac!", x);
                    continue;
                }
                AddFirst(new IntNode(x));
            }
        }

        public void Input_Last_NotDuplicate()
        {
            int x;
            while (true)
            {
                Console.Write("x (0 to stop) = ");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                    break;
                if (SearchX(x) != null)
                {
                    Console.WriteLine("Gia tri {0} da ton tai, hay nhap gia tri khac!", x);
                    continue;
                }
                AddLast(new IntNode(x));
            }
        }

        public void RemoveX(IntNode nodex)
        {
            if (nodex == null || IsEmpty())
                return;

            if (nodex == first)
            {
                first = first.Next;
                nodex.Next = null;
                if (first == null)
                    last = null;
            }
            else if (nodex == last)
            {
                IntNode pTruoc = first;
                while (pTruoc.Next != nodex)
                    pTruoc = pTruoc.Next;
                pTruoc.Next = null;
                last = pTruoc;
            }
            else
            {
                IntNode pSau = nodex.Next;
                nodex.Data = pSau.Data;
                nodex.Next = pSau.Next;
                if (pSau == last)
                    last = nodex;
                pSau.Next = null;
            }
        }

        public void RemoveAt(int i)
        {
            IntNode pxoa = Search_At_i(i);
            if (pxoa == null)
            {
                Console.WriteLine("Vi tri i khong hop le!");
                return;
            }
            RemoveX(pxoa);
        }

        public void InsertAt(int x, int i)
        {
            IntNode newNode = new IntNode(x);
            IntNode pChen = Search_At_i(i);
            if (pChen == null)
            {
                if (i == CountNodes())
                    AddLast(newNode);
                else
                    Console.WriteLine("Vi tri i khong hop le!");
                return;
            }

            newNode.Next = pChen.Next;
            pChen.Next = newNode;

            int tmp = pChen.Data;
            pChen.Data = newNode.Data;
            newNode.Data = tmp;

            if (pChen == last)
                last = newNode;
        }

        public void InsertXAfterY(IntNode nodex, IntNode nodeY)
        {
            if (nodex == null || nodeY == null)
                return;
            if (nodeY == last)
            {
                AddLast(nodex);
            }
            else
            {
                nodex.Next = nodeY.Next;
                nodeY.Next = nodex;
            }
        }

        public void InsertXAfterMin(IntNode nodex)
        {
            IntNode min = GetMin();
            if (min == null)
                AddFirst(nodex);
            else
                InsertXAfterY(nodex, min);
        }

        public void ShiftLeft()
        {
            RemoveAt(0);
        }

        public void InsertXBeforeY(IntNode nodex, IntNode nodeY)
        {
            if (nodex == null || nodeY == null)
                return;

            InsertXAfterY(nodex, nodeY);

            int tmp = nodex.Data;
            nodex.Data = nodeY.Data;
            nodeY.Data = tmp;
        }

        public void InsertXBeforeMax(IntNode nodex)
        {
            IntNode max = GetMax();
            if (max == null)
                AddFirst(nodex);
            else
                InsertXBeforeY(nodex, max);
        }

        public void RShiftRight()
        {
            if (IsEmpty() || first == last)
                return;
            IntNode pLast = new IntNode(last.Data);
            RemoveX(last);
            AddFirst(pLast);
        }

        public void InterchangeSort()
        {
            for (IntNode p = first; p != null; p = p.Next)
            {
                for (IntNode q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data > q.Data)
                    {
                        int tmp = p.Data;
                        p.Data = q.Data;
                        q.Data = tmp;
                    }
                }
            }
        }

        public void SelectionSort()
        {
            for (IntNode p = first; p != null; p = p.Next)
            {
                IntNode max = p;
                for (IntNode q = p.Next; q != null; q = q.Next)
                {
                    if (q.Data > max.Data)
                        max = q;
                }
                int tmp = p.Data;
                p.Data = max.Data;
                max.Data = tmp;
            }
        }

        public static MyList MergeList(MyList list1, MyList list2)
        {
            MyList list3 = new MyList();
            IntNode p = list1.First;
            IntNode q = list2.First;

            while (p != null && q != null)
            {
                if (p.Data <= q.Data)
                {
                    list3.AddLast(new IntNode(p.Data));
                    p = p.Next;
                }
                else
                {
                    list3.AddLast(new IntNode(q.Data));
                    q = q.Next;
                }
            }

            while (p != null)
            {
                list3.AddLast(new IntNode(p.Data));
                p = p.Next;
            }

            while (q != null)
            {
                list3.AddLast(new IntNode(q.Data));
                q = q.Next;
            }

            return list3;
        }
    }
}