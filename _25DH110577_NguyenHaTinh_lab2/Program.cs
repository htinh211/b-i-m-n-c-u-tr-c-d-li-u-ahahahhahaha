using _25DH110577_NguyenHaTinh_lab6;
using System;
using System.Text;

namespace _25DH110577_NguyenHaTinh_lab2
{
    internal class Program
    {
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
            int k, x;
            Console.Write(">> Enter the array size: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">> Elements:");
            obj.Xuat();

            Console.Write("\n>> Value to search for x = ");
            int.TryParse(Console.ReadLine(), out x);

            int kq = obj.TimTuanTu(x);
            if (kq == -1)
                Console.WriteLine($"-> {x} does not exist!");
            else
                Console.WriteLine($"-> {x} found at position {kq}");
        }

        static void TestTimNhiPhan()
        {
            int x, kq;
            int[] a = { 3, 4, 5, 6, 7, 8, 9, 10, 10, 17, 20 };
            IntArray obj = new IntArray(a);
            Console.WriteLine(">> Elements:");
            obj.Xuat();

            Console.Write("\n>> Value to search for x = ");
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.TimNhiPhan(x);
            if (kq == -1)
                Console.WriteLine($"-> {x} does not exist!");
            else
                Console.WriteLine($"-> {x} found at position {kq}");
        }

        static void TestTimViTriMax()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 20, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.WriteLine("Array values:");
            obj.Xuat();

            int viTriMaxTimThay = obj.TimViTriMax();
            Console.WriteLine($"-> Max = {obj.Arr[viTriMaxTimThay]} found at position {viTriMaxTimThay}");
        }

        static void TestXoaPhanTu()
        {
            int k, x;
            Console.Write(">> Enter the array size: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">> Elements:");
            obj.Xuat();

            Console.Write("\n>> Value to delete, x = ");
            int.TryParse(Console.ReadLine(), out x);

            bool kqXoa = obj.XoaPhanTu(x);
            if (kqXoa)
            {
                Console.WriteLine("DELETE is completed!, Array values (AFTER DELETE X)");
                obj.Xuat();
            }
            else
            {
                Console.WriteLine("DELETE is NOT completed!");
            }
        }

        static void Test_Chen_X_Sau_Max()
        {
            int k, x;
            Console.Write(">> Enter the array size: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">> Elements:");
            obj.Xuat();

            Console.Write("\n>> Value to insert, x = ");
            int.TryParse(Console.ReadLine(), out x);

            obj.ChenSauMax(x);
            Console.WriteLine("INSERT is completed!, Array values (AFTER INSERT X)");
            obj.Xuat();
        }

        static void TestSoSanhGiaiThuat()
        {
            int[] sizes = { 10, 1000, 100000 };
            int valueNotFound = -999;

            Console.WriteLine("=== SO SANH HIEU SUAT TIM KIEM (WORST CASE) ===");
            foreach (int n in sizes)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = i * 2;

                IntArray obj = new IntArray(a);

                Console.WriteLine($"\n==================== N = {n} ====================");
                int ssTuanTu = obj.MinhHoaTimTuanTu(valueNotFound);
                int ssNhiPhan = obj.MinhHoaTimNhiPhan(valueNotFound);

                Console.WriteLine($"\n[KET QUA N = {n}]");
                Console.WriteLine($"+ Tim tuan tu : {ssTuanTu} lan so sanh");
                Console.WriteLine($"+ Tim nhi phan: {ssNhiPhan} lan so sanh");
            }
        }

        static void TestQuickSort_Stack_KoDeQuy(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Original array:");
            objTam.Xuat();
            objTam.QuickSortKhongDeQuy();
            Console.WriteLine("\n>>Quick Sort (Non-Recursive):");
            objTam.Xuat();
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int choice = -1;
            do
            {
                Console.WriteLine("\n\n=== BAI TAP BUOI 2 ===");
                Console.WriteLine("1. Test Constructor 1 (Ngau nhien)");
                Console.WriteLine("2. Test Constructor 2 (Mang co san)");
                Console.WriteLine("3. Test Constructor 3 (Nhap & Sao chep)");
                Console.WriteLine("4. Test Tim Tuan Tu (Linear Search)");
                Console.WriteLine("5. Test Tim Nhi Phan (Binary Search)");
                Console.WriteLine("6. Test Tim Vi Tri Max");
                Console.WriteLine("7. Test Xoa Phan Tu");
                Console.WriteLine("8. Test Chen Phan Tu X sau MAX");
                Console.WriteLine("9. Test Minh hoa & So sanh giai thuat (Phan C)");
                Console.WriteLine("10. Test QuickSort (su dung Stack Ko De quy)");
                Console.WriteLine("0. Thoat");
                Console.Write("\nNhap lua chon: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1: TestConstructor1(); break;
                        case 2: TestConstructor2(); break;
                        case 3: TestConstructor3(); break;
                        case 4: TestTimTuanTu(); break;
                        case 5: TestTimNhiPhan(); break;
                        case 6: TestTimViTriMax(); break;
                        case 7: TestXoaPhanTu(); break;
                        case 8: Test_Chen_X_Sau_Max(); break;
                        case 9: TestSoSanhGiaiThuat(); break;
                        case 10:
                            {
                                int k;
                                Console.Write(">> Enter the array size: ");
                                int.TryParse(Console.ReadLine(), out k);
                                IntArray obj = new IntArray(k);
                                TestQuickSort_Stack_KoDeQuy(obj);
                            }
                            break;
                    }
                }
            } while (choice != 0);
        }
    }
}