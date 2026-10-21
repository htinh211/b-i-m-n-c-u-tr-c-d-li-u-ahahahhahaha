using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_Buoiso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.Clear();

                Console.WriteLine("==========================================");
                Console.WriteLine("        BAI TAP INTARRAY - BUOI 3");
                Console.WriteLine("==========================================");

                Console.WriteLine("\n1. Test Constructor 1");
                Console.WriteLine("2. Test Constructor 2");
                Console.WriteLine("3. Test Constructor 3");
                Console.WriteLine("4. Test Tim Tuan Tu");
                Console.WriteLine("5. Test Tim Nhi Phan");
                Console.WriteLine("6. Test Tim Vi Tri Max");
                Console.WriteLine("7. Test Xoa Phan Tu");
                Console.WriteLine("8. Test Chen X Sau MAX");
                Console.WriteLine("9. Test Interchange Sort");
                Console.WriteLine("10. Test Bubble Sort");
                Console.WriteLine("11. Test Selection Sort");
                Console.WriteLine("12. Test Insertion Sort");
                Console.WriteLine("13. Test Quick Sort");
                Console.WriteLine("14. Test Heap Sort");
                Console.WriteLine("15. Test Merge Sort");
                Console.WriteLine("16. Test Shell Sort");
                Console.WriteLine("17. Test Shaker Sort");
                Console.WriteLine("18. Minh Hoa Sorting");
                Console.WriteLine("19. So Sanh So Phep Gan");
                Console.WriteLine("0. Thoat");

                Console.Write("\nNhap lua chon: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                    choice = -1;

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        TestConstructor1();
                        break;

                    case 2:
                        TestConstructor2();
                        break;

                    case 3:
                        TestConstructor3();
                        break;

                    case 4:
                        TestTimTuanTu();
                        break;

                    case 5:
                        TestTimNhiPhan();
                        break;

                    case 6:
                        TestTimViTriMax();
                        break;

                    case 7:
                        TestXoaPhanTu();
                        break;

                    case 8:
                        Test_Chen_X_Sau_Max();
                        break;

                    case 9:
                        TestInterchangeSort();
                        break;

                    case 10:
                        TestBubbleSort();
                        break;

                    case 11:
                        TestSelectionSort();
                        break;

                    case 12:
                        TestInsertionSort();
                        break;

                    case 13:
                        TestQuickSort();
                        break;

                    case 14:
                        TestHeapSort();
                        break;

                    case 15:
                        TestMergeSort();
                        break;

                    case 16:
                        TestShellSort();
                        break;

                    case 17:
                        TestShakerSort();
                        break;

                    case 18:
                        MinhHoa();
                        break;

                    case 19:
                        SoSanhTatCa();
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhan phim bat ky de quay lai menu...");
                    Console.ReadKey();
                }

            } while (choice != 0);
        }

        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);

            Console.WriteLine("Generated array values:");
            obj.Xuat();
        }

        static void TestConstructor2()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };

            IntArray obj = new IntArray(a);

            Console.WriteLine("Array values:");
            obj.Xuat();
        }

        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();

            obj1.Nhap();

            Console.WriteLine("Array values:");
            obj1.Xuat();

            IntArray obj2 = new IntArray(obj1);

            Console.WriteLine("\nCopied array values:");
            obj2.Xuat();
        }

        static void TestTimTuanTu()
        {
            int k;
            int x;

            Console.Write("Nhap kich thuoc mang k = ");
            int.TryParse(Console.ReadLine(), out k);

            IntArray obj = new IntArray(k);

            Console.WriteLine("Mang:");
            obj.Xuat();

            Console.Write("\nNhap gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);

            int kq = obj.TimTuanTu(x);

            if (kq == -1)
                Console.WriteLine($"{x} khong ton tai!");
            else
                Console.WriteLine($"{x} nam tai vi tri {kq}");
        }

        static void TestTimNhiPhan()
        {
            int x;

            int[] a = { 3, 4, 5, 6, 7, 8, 9, 10, 10, 17, 20 };

            IntArray obj = new IntArray(a);

            Console.WriteLine("Mang:");
            obj.Xuat();

            Console.Write("\nNhap gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);

            int kq = obj.TimNhiPhan(x);

            if (kq == -1)
                Console.WriteLine($"{x} khong ton tai!");
            else
                Console.WriteLine($"{x} nam tai vi tri {kq}");
        }

        static void TestTimViTriMax()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 20, 10, 6 };

            IntArray obj = new IntArray(a);

            Console.WriteLine("Array values:");
            obj.Xuat();

            int viTriMax = obj.TimViTriMax();

            Console.WriteLine(
                $"Max = {obj.Arr[viTriMax]}, vi tri = {viTriMax}"
            );
        }

        static void TestXoaPhanTu()
        {
            int k;
            int x;

            Console.Write("Nhap kich thuoc mang k = ");
            int.TryParse(Console.ReadLine(), out k);

            IntArray obj = new IntArray(k);

            Console.WriteLine("Mang:");
            obj.Xuat();

            Console.Write("\nNhap gia tri can xoa x = ");
            int.TryParse(Console.ReadLine(), out x);

            bool kq = obj.XoaPhanTu(x);

            if (kq)
            {
                Console.WriteLine("Xoa thanh cong!");
                obj.Xuat();
            }
            else
            {
                Console.WriteLine("Xoa khong thanh cong!");
            }
        }

        static void Test_Chen_X_Sau_Max()
        {
            int k;
            int x;

            Console.Write("Nhap kich thuoc mang k = ");
            int.TryParse(Console.ReadLine(), out k);

            IntArray obj = new IntArray(k);

            Console.WriteLine("Mang:");
            obj.Xuat();

            Console.Write("\nNhap gia tri can chen x = ");
            int.TryParse(Console.ReadLine(), out x);

            obj.ChenSauMax(x);

            Console.WriteLine("Mang sau khi chen:");
            obj.Xuat();
        }

        static void TestInterchangeSort()
        {
            TestSort("Interchange Sort", 1);
        }

        static void TestBubbleSort()
        {
            TestSort("Bubble Sort", 2);
        }

        static void TestSelectionSort()
        {
            TestSort("Selection Sort", 3);
        }

        static void TestInsertionSort()
        {
            TestSort("Insertion Sort", 4);
        }

        static void TestQuickSort()
        {
            TestSort("Quick Sort", 5);
        }

        static void TestHeapSort()
        {
            TestSort("Heap Sort", 6);
        }

        static void TestMergeSort()
        {
            TestSort("Merge Sort", 7);
        }

        static void TestShellSort()
        {
            TestSort("Shell Sort", 8);
        }

        static void TestShakerSort()
        {
            TestSort("Shaker Sort", 9);
        }

        static void TestSort(string tenSort, int loai)
        {
            int k;

            Console.Write("Nhap so luong phan tu k = ");
            int.TryParse(Console.ReadLine(), out k);

            IntArray obj = new IntArray(k);

            Console.WriteLine("\nMang ban dau:");
            obj.Xuat();

            switch (loai)
            {
                case 1:
                    obj.InterchangeSort();
                    break;

                case 2:
                    obj.BubbleSort();
                    break;

                case 3:
                    obj.SelectionSort();
                    break;

                case 4:
                    obj.InsertionSort();
                    break;

                case 5:
                    obj.QuickSort();
                    break;

                case 6:
                    obj.HeapSort();
                    break;

                case 7:
                    obj.MergeSort();
                    break;

                case 8:
                    obj.ShellSort();
                    break;

                case 9:
                    obj.ShakerSort();
                    break;
            }

            Console.WriteLine($"\nSau khi {tenSort}:");
            obj.Xuat();
        }

        static void MinhHoa()
        {
            int[] a = { 8, 3, 7, 4, 9, 2, 6, 1, 5, 10 };

            Console.WriteLine("Mang dung de minh hoa:");
            IntArray original = new IntArray(a);
            original.Xuat();

            Console.WriteLine("\n1. Interchange Sort");
            IntArray obj1 = new IntArray(a);
            Console.WriteLine("Cac buoc:");

            long count1 = obj1.InterchangeSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count1}");

            Console.WriteLine("\n2. Bubble Sort");
            IntArray obj2 = new IntArray(a);
            long count2 = obj2.BubbleSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count2}");

            Console.WriteLine("\n3. Selection Sort");
            IntArray obj3 = new IntArray(a);
            long count3 = obj3.SelectionSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count3}");

            Console.WriteLine("\n4. Insertion Sort");
            IntArray obj4 = new IntArray(a);
            long count4 = obj4.InsertionSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count4}");

            Console.WriteLine("\n5. Quick Sort");
            IntArray obj5 = new IntArray(a);
            long count5 = obj5.QuickSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count5}");

            Console.WriteLine("\n6. Heap Sort");
            IntArray obj6 = new IntArray(a);
            long count6 = obj6.HeapSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count6}");

            Console.WriteLine("\n7. Merge Sort");
            IntArray obj7 = new IntArray(a);
            long count7 = obj7.MergeSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count7}");

            Console.WriteLine("\n8. Shell Sort");
            IntArray obj8 = new IntArray(a);
            long count8 = obj8.ShellSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count8}");

            Console.WriteLine("\n9. Shaker Sort");
            IntArray obj9 = new IntArray(a);
            long count9 = obj9.ShakerSortMinhHoa();

            Console.WriteLine($"So phep gan/doi: {count9}");
        }

        static void SoSanhTatCa()
        {
            int[] kichThuoc = { 10, 1000, 10000 };

            foreach (int n in kichThuoc)
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine($"N = {n}");
                Console.WriteLine("==========================================");

                IntArray goc = new IntArray(n);

                IntArray a1 = new IntArray(goc);
                IntArray a2 = new IntArray(goc);
                IntArray a3 = new IntArray(goc);
                IntArray a4 = new IntArray(goc);
                IntArray a5 = new IntArray(goc);
                IntArray a6 = new IntArray(goc);
                IntArray a7 = new IntArray(goc);
                IntArray a8 = new IntArray(goc);
                IntArray a9 = new IntArray(goc);

                long interchange = a1.DemInterchangeSort();
                long bubble = a2.DemBubbleSort();
                long selection = a3.DemSelectionSort();
                long insertion = a4.DemInsertionSort();
                long quick = a5.DemQuickSort();
                long heap = a6.DemHeapSort();
                long merge = a7.DemMergeSort();
                long shell = a8.DemShellSort();
                long shaker = a9.DemShakerSort();

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Algorithm",
                    "Assignments"
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Interchange Sort",
                    interchange
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Bubble Sort",
                    bubble
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Selection Sort",
                    selection
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Insertion Sort",
                    insertion
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Quick Sort",
                    quick
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Heap Sort",
                    heap
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Merge Sort",
                    merge
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Shell Sort",
                    shell
                );

                Console.WriteLine(
                    "{0,-20} {1,15}",
                    "Shaker Sort",
                    shaker
                );
            }
        }
    }
}
    



