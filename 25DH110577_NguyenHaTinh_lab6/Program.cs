using _25DH110577_NguyenHaTinh_lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSV_HoTen_BaiTap06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            ArrayStack arrayStack = null;
            ListStack listStack = null;
            int choice;
            do
            {
                Console.WriteLine("\n\n--- STACK ---");
                Console.WriteLine("1. Test Push (ArrayStack)");
                Console.WriteLine("2. Test Pop (ArrayStack)");
                Console.WriteLine("3. Test GetTop (ArrayStack)");
                Console.WriteLine("4. Test Push (ListStack)");
                Console.WriteLine("5. Test Pop (ListStack)");
                Console.WriteLine("6. Test GetTop (ListStack)");
                Console.WriteLine("0. Exit");
                Console.Write("\nNhap lua chon: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập số phần tử tối đa của stack: ");
                        int max = int.Parse(Console.ReadLine());
                        arrayStack = new ArrayStack(max);
                        Test_ArrayStack_Push(arrayStack);
                        break;
                    case 2:
                        Test_ArrayStack_Pop(arrayStack);
                        break;
                    case 3:
                        Test_ArrayStack_GetTop(arrayStack);
                        break;
                    case 4:
                        listStack = new ListStack();
                        Test_ListStack_Push(listStack);
                        break;
                    case 5:
                        Test_ListStack_Pop(listStack);
                        break;
                    case 6:
                        Test_ListStack_GetTop(listStack);
                        break;
                }
            } while (choice != 0);
        }

        static void Test_ArrayStack_Push(ArrayStack arrayStack)
        {
            Console.WriteLine("Nhập các giá trị (nhập số âm để dừng): ");
            while (true)
            {
                Console.Write("Nhập giá trị: ");
                int x = int.Parse(Console.ReadLine());
                if (x < 0) break;
                if (!arrayStack.Push(x))
                {
                    Console.WriteLine("Stack đã đầy, không thể thêm nữa!");
                    break;
                }
            }
        }

        static void Test_ArrayStack_GetTop(ArrayStack arrayStack)
        {
            Console.WriteLine("\nXem giá trị đầu stack:");
            if (arrayStack.GetTop(out int value))
                Console.WriteLine("Top = " + value);
            else
                Console.WriteLine("Stack rỗng!");
        }

        static void Test_ArrayStack_Pop(ArrayStack arrayStack)
        {
            Console.WriteLine("\nCác giá trị lấy ra khỏi stack:");
            while (arrayStack.Pop(out int value))
                Console.WriteLine(value);
        }

        static void Test_ListStack_Push(ListStack listStack)
        {
            Console.WriteLine("Nhập các giá trị (nhập số âm để dừng): ");
            while (true)
            {
                Console.Write("Nhập giá trị: ");
                int x = int.Parse(Console.ReadLine());
                if (x < 0) break;
                listStack.Push(x);
            }
        }

        static void Test_ListStack_GetTop(ListStack listStack)
        {
            Console.WriteLine("\nXem giá trị đầu stack:");
            if (listStack.GetTop(out int value))
                Console.WriteLine("Top = " + value);
            else
                Console.WriteLine("Stack rỗng!");
        }

        static void Test_ListStack_Pop(ListStack listStack)
        {
            Console.WriteLine("\nCác giá trị lấy ra khỏi stack:");
            while (listStack.Pop(out int value))
                Console.WriteLine(value);
        }
    }
}