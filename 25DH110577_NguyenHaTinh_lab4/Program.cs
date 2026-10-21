using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- BAI TAP 4 & 5: DSLK DON ---");
                Console.WriteLine("1. Test Input_Front + ShowList");
                Console.WriteLine("2. Test Input_Last + ShowList");
                Console.WriteLine("3. Test SearchX");
                Console.WriteLine("4. Test GetMax");
                Console.WriteLine("5. Test GetMin");
                Console.WriteLine("6. Test GetEvenList");
                Console.WriteLine("7. Test GetOddList");
                Console.WriteLine("8. Test JoinList");
                Console.WriteLine("9. Test Input_Front (Not Duplicate)");
                Console.WriteLine("10. Test Input_Last (Not Duplicate)");
                Console.WriteLine("11. Test RemoveAt_i");
                Console.WriteLine("12. Test RemoveX");
                Console.WriteLine("13. Test InsertAt(int x, int i)");
                Console.WriteLine("14. Test InsertXAfterY");
                Console.WriteLine("15. Test InsertXAfterMin");
                Console.WriteLine("16. Test ShiftLeft");
                Console.WriteLine("17. Test InsertXBeforeY");
                Console.WriteLine("18. Test InsertXBeforeMax");
                Console.WriteLine("19. Test RShiftRight");
                Console.WriteLine("20. Test InterchangeSort");
                Console.WriteLine("21. Test SelectionSort");
                Console.WriteLine("22. Test MergeList");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1: TestInput_Front(); break;
                    case 2: TestInput_Last(); break;
                    case 3: TestSearchX(); break;
                    case 4: TestGetMax(); break;
                    case 5: TestGetMin(); break;
                    case 6: TestGetEvenList(); break;
                    case 7: TestGetOddList(); break;
                    case 8: TestJoinList(); break;
                    case 9: Test_Input_Front_Not_Duplicate(); break;
                    case 10: Test_Input_Last_Not_Duplicate(); break;
                    case 11: Test_RemoveAt_i(); break;
                    case 12: Test_RemoveX(); break;
                    case 13: Test_InsertAt(); break;
                    case 14: Test_InsertXAfterY(); break;
                    case 15: Test_InsertXAfterMin(); break;
                    case 16: Test_ShiftLeft(); break;
                    case 17: Test_InsertXBeforeY(); break;
                    case 18: Test_InsertXBeforeMax(); break;
                    case 19: Test_RShiftRight(); break;
                    case 20: Test_InterchangeSort(); break;
                    case 21: Test_SelectionSort(); break;
                    case 22: Test_MergeList(); break;
                }
            } while (choice != 0);
        }

        static void TestInput_Front()
        {
            MyList list = new MyList();
            list.Input_Front();
            Console.WriteLine("\n--- Integer linked list:");
            list.ShowList();
            Console.WriteLine("Count = " + list.Count);
        }

        static void TestInput_Last()
        {
            MyList list = new MyList();
            list.Input_Last();
            Console.WriteLine("\n--- Integer linked list:");
            list.ShowList();
            Console.WriteLine("Count = " + list.Count);
        }

        static void TestSearchX()
        {
            MyList list = new MyList();
            list.Input_Last();
            Console.WriteLine("\n--- Integer linked list:");
            list.ShowList();

            Console.Write("Nhap x can tim: ");
            int x;
            int.TryParse(Console.ReadLine(), out x);

            IntNode kq = list.SearchX(x);
            if (kq != null)
                Console.WriteLine("Tim thay, Data = " + kq.Data);
            else
                Console.WriteLine("Khong tim thay!");
        }

        static void TestGetMax()
        {
            MyList list = new MyList();
            list.Input_Last();
            Console.WriteLine("\n--- Integer linked list:");
            list.ShowList();

            IntNode max = list.GetMax();
            if (max != null)
                Console.WriteLine("Max = " + max.Data);
            else
                Console.WriteLine("Danh sach rong!");
        }

        static void TestGetMin()
        {
            MyList list = new MyList();
            list.Input_Last();
            Console.WriteLine("\n--- Integer linked list:");
            list.ShowList();

            IntNode min = list.GetMin();
            if (min != null)
                Console.WriteLine("Min = " + min.Data);
            else
                Console.WriteLine("Danh sach rong!");
        }

        static void TestGetEvenList()
        {
            MyList list = new MyList();
            list.Input_Last();
            Console.WriteLine("\n--- Danh sach goc:");
            list.ShowList();

            MyList evenList = list.GetEvenList();
            Console.WriteLine("Danh sach so chan:");
            evenList.ShowList();
            Console.WriteLine("Count = " + evenList.Count);

            Console.WriteLine("Danh sach goc (phai khong doi):");
            list.ShowList();
        }

        static void TestGetOddList()
        {
            MyList list = new MyList();
            list.Input_Last();
            Console.WriteLine("\n--- Danh sach goc:");
            list.ShowList();

            MyList oddList = list.GetOddList();
            Console.WriteLine("Danh sach so le:");
            oddList.ShowList();
            Console.WriteLine("Count = " + oddList.Count);

            Console.WriteLine("Danh sach goc (phai khong doi):");
            list.ShowList();
        }

        static void TestJoinList()
        {
            Console.WriteLine("\n--- Nhap danh sach 1:");
            MyList list1 = new MyList();
            list1.Input_Last();

            Console.WriteLine("\n--- Nhap danh sach 2:");
            MyList list2 = new MyList();
            list2.Input_Last();

            Console.WriteLine("\n--- List 1:");
            list1.ShowList();
            Console.WriteLine("--- List 2:");
            list2.ShowList();

            MyList list3 = MyList.JoinList(list1, list2);
            Console.WriteLine("\n--- List 3 (Noi List 1 va List 2):");
            list3.ShowList();
            Console.WriteLine("Count = " + list3.Count);

            Console.WriteLine("\n--- Kiểm tra tinh doc lap:");
            Console.WriteLine("List 1 (phai khong doi):");
            list1.ShowList();
            Console.WriteLine("List 2 (phai khong doi):");
            list2.ShowList();
        }

        static void Test_Input_Front_Not_Duplicate()
        {
            MyList list = new MyList();
            list.Input_Front_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();
        }

        static void Test_Input_Last_Not_Duplicate()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();
        }

        static void Test_RemoveAt_i()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();

            Console.Write("Nhap vi tri i (can xoa): ");
            int i = int.Parse(Console.ReadLine());
            list.RemoveAt(i);
            Console.WriteLine("\n\n---DSLK sau khi xoa tai vi tri i:");
            list.ShowList();
        }

        static void Test_RemoveX()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();

            Console.Write("Nhap x (can xoa): ");
            int x = int.Parse(Console.ReadLine());
            IntNode nodex = list.SearchX(x);
            if (nodex == null)
            {
                Console.WriteLine("Khong tim thay {0} trong danh sach!", x);
                return;
            }
            list.RemoveX(nodex);
            Console.WriteLine($"\n\n---DSLK sau khi xoa {x}:");
            list.ShowList();
        }

        static void Test_InsertAt()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();

            Console.Write("Nhap x (can them): ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri i: ");
            int i = int.Parse(Console.ReadLine());

            list.InsertAt(x, i);
            Console.WriteLine($"\n\n---DSLK sau khi them {x} tai vi tri {i}:");
            list.ShowList();
        }

        static void Test_InsertXAfterY()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();

            Console.Write("Nhap x (can them): ");
            int x = int.Parse(Console.ReadLine());
            IntNode nodex = new IntNode(x);

            Console.Write("Nhap y: ");
            int y = int.Parse(Console.ReadLine());
            IntNode nodeY = list.SearchX(y);
            if (nodeY == null)
            {
                Console.WriteLine("Khong tim thay {0} trong danh sach!", y);
                return;
            }

            list.InsertXAfterY(nodex, nodeY);
            Console.WriteLine($"\n\n---DSLK sau khi them node {x} sau node {y}:");
            list.ShowList();
        }

        static void Test_InsertXAfterMin()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();

            Console.Write("Nhap x (can them): ");
            int x = int.Parse(Console.ReadLine());
            IntNode nodex = new IntNode(x);

            list.InsertXAfterMin(nodex);
            Console.WriteLine($"\n\n---DSLK sau khi them node {x} sau MIN:");
            list.ShowList();
        }

        static void Test_ShiftLeft()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Original linked list:");
            list.ShowList();

            list.ShiftLeft();
            Console.WriteLine($"\n---DSLK After ShiftLeft()");
            list.ShowList();
        }

        static void Test_InsertXBeforeY()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();

            Console.Write("Nhap x (can them): ");
            int x = int.Parse(Console.ReadLine());
            IntNode nodex = new IntNode(x);

            Console.Write("Nhap y: ");
            int y = int.Parse(Console.ReadLine());
            IntNode nodeY = list.SearchX(y);
            if (nodeY == null)
            {
                Console.WriteLine("Khong tim thay {0} trong danh sach!", y);
                return;
            }

            list.InsertXBeforeY(nodex, nodeY);
            Console.WriteLine($"\n\n---DSLK sau khi them node {x} TRUOC node {y}:");
            list.ShowList();
        }

        static void Test_InsertXBeforeMax()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Integer linked list:");
            list.ShowList();

            Console.Write("Nhap x (can them): ");
            int x = int.Parse(Console.ReadLine());
            IntNode nodex = new IntNode(x);

            list.InsertXBeforeMax(nodex);
            Console.WriteLine($"\n\n---DSLK sau khi them node {x} truoc MAX:");
            list.ShowList();
        }

        static void Test_RShiftRight()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Original linked list:");
            list.ShowList();

            list.RShiftRight();
            Console.WriteLine($"\n---DSLK - After RShiftRight()");
            list.ShowList();
        }

        static void Test_InterchangeSort()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Original linked list:");
            list.ShowList();

            list.InterchangeSort();
            Console.WriteLine($"\n\n---DSLK sau khi sap xep InterchangeSort");
            list.ShowList();
        }

        static void Test_SelectionSort()
        {
            MyList list = new MyList();
            list.Input_Last_NotDuplicate();
            Console.WriteLine("\n---Original linked list:");
            list.ShowList();

            list.SelectionSort();
            Console.WriteLine($"\n\n---DSLK sau khi sap xep SelectionSort");
            list.ShowList();
        }

        static void Test_MergeList()
        {
            MyList list1 = new MyList();
            Console.WriteLine("--Nhap List1:");
            list1.Input_Last_NotDuplicate();
            list1.InterchangeSort();
            Console.WriteLine("\n---list1 (tang dan):");
            list1.ShowList();

            MyList list2 = new MyList();
            Console.WriteLine("\n--Nhap list2:");
            list2.Input_Last_NotDuplicate();
            list2.InterchangeSort();
            Console.WriteLine("\n---list2 (tang dan):");
            list2.ShowList();

            MyList list3 = MyList.MergeList(list1, list2);
            Console.WriteLine("\n---list3 = MergeList(list1, list2):");
            list3.ShowList();
        }
    }
}