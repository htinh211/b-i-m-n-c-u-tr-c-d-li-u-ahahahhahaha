using _25DH110577_NguyenHaTinh_lab2;
using System;

namespace _25DH110577_NguyenHaTinh_lab6 // Đổi tên namespace này cho khớp với project Lab 6 / Bài tập 2 của bạn
{
    internal class IntArray
    {
        private int[] arr;

        public int[] Arr
        {
            get { return arr; }
            set { arr = value; }
        }

        public IntArray() { }

        public IntArray(int k)
        {
            arr = new int[k];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 201);
            }
        }

        public IntArray(int[] a)
        {
            arr = new int[a.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a[i];
            }
        }

        public IntArray(IntArray obj)
        {
            arr = new int[obj.arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = obj.arr[i];
            }
        }

        public bool KiemTraKT(int n)
        {
            if (n >= 1 && n <= 1000000)
                return true;
            else
                return false;
        }

        public void Nhap()
        {
            int n;
            while (true)
            {
                Console.Write("Nhap kich thuoc mang, n = ");
                n = int.Parse(Console.ReadLine());
                if (KiemTraKT(n))
                    break;
                Console.WriteLine("Kich thuoc khong hop le! Vui long nhap lai (1 <= n <= 1.000.000).");
            }

            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap Arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.WriteLine("\n-- Mang IntArray: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public int TimTuanTu(int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public int TimNhiPhan(int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] > x)
                    r = mid - 1;
                else
                    l = mid + 1;
            }
            return -1;
        }

        public int TimViTriMax()
        {
            int max = arr[0];
            int viTriMax = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                    viTriMax = i;
                }
            }
            return viTriMax;
        }

        public bool XoaPhanTu(int x)
        {
            int viTriTimThay_X = TimTuanTu(x);
            if (viTriTimThay_X != -1)
            {
                int[] b = new int[arr.Length - 1];

                if (viTriTimThay_X == 0)
                {
                    for (int i = 1; i < arr.Length; i++)
                        b[i - 1] = arr[i];
                }
                else if (viTriTimThay_X == arr.Length - 1)
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                        b[i] = arr[i];
                }
                else
                {
                    int j = 0;
                    for (int i = 0; i < viTriTimThay_X; i++)
                    {
                        b[j] = arr[i];
                        j++;
                    }
                    for (int i = viTriTimThay_X + 1; i < arr.Length; i++)
                    {
                        b[j] = arr[i];
                        j++;
                    }
                }

                arr = b;
                return true;
            }
            return false;
        }

        public void ChenSauMax(int x)
        {
            int viTriTimThay_Max = TimViTriMax();
            if (viTriTimThay_Max != -1)
            {
                int[] b = new int[arr.Length + 1];

                if (viTriTimThay_Max < arr.Length - 1)
                {
                    int j = 0;
                    for (int i = 0; i <= viTriTimThay_Max; i++)
                    {
                        b[j] = arr[i];
                        j++;
                    }
                    b[j] = x;
                    j++;
                    for (int i = viTriTimThay_Max + 1; i < arr.Length; i++)
                    {
                        b[j] = arr[i];
                        j++;
                    }
                }
                else
                {
                    int i;
                    for (i = 0; i < arr.Length; i++)
                        b[i] = arr[i];
                    b[i] = x;
                }

                arr = b;
            }
        }

        public int MinhHoaTimTuanTu(int x)
        {
            int soLanSoSanh = 0;
            Console.WriteLine($"\n--- Minh hoa Tim Tuan Tu (Search x = {x}) ---");
            for (int i = 0; i < arr.Length; i++)
            {
                soLanSoSanh++;
                Console.WriteLine($"Buoc {soLanSoSanh}: So sanh arr[{i}] ({arr[i]}) voi {x}");
                if (arr[i] == x)
                {
                    Console.WriteLine($"-> Tim thay tai vi tri {i}. Tong so lan so sanh: {soLanSoSanh}");
                    return soLanSoSanh;
                }
            }
            Console.WriteLine($"-> Khong tim thay. Tong so lan so sanh: {soLanSoSanh}");
            return soLanSoSanh;
        }

        public int MinhHoaTimNhiPhan(int x)
        {
            int soLanSoSanh = 0;
            int low = 0, high = arr.Length - 1;
            Console.WriteLine($"\n--- Minh hoa Tim Nhi Phan (Search x = {x}) ---");
            while (low <= high)
            {
                int mid = (low + high) / 2;
                soLanSoSanh++;
                Console.WriteLine($"Buoc {soLanSoSanh}: Khoang [{low}, {high}], Mid = {mid} (arr[mid] = {arr[mid]}) so sanh voi {x}");

                if (arr[mid] == x)
                {
                    Console.WriteLine($"-> Tim thay tai vi tri {mid}. Tong so lan so sanh: {soLanSoSanh}");
                    return soLanSoSanh;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            Console.WriteLine($"-> Khong tim thay. Tong so lan so sanh: {soLanSoSanh}");
            return soLanSoSanh;
        }

        public void QuickSortKhongDeQuy()
        {
            if (arr == null || arr.Length < 2)
                return;

            StackDoan stack = new StackDoan();
            stack.Push(0, arr.Length - 1);

            while (stack.Pop(out Doan doan))
            {
                int left = doan.Left;
                int right = doan.Right;

                int pivot = arr[(left + right) / 2];
                int i = left, j = right;
                while (i <= j)
                {
                    while (arr[i] < pivot)
                        i++;
                    while (arr[j] > pivot)
                        j--;
                    if (i <= j)
                    {
                        HoanVi(ref arr[i], ref arr[j]);
                        i++; j--;
                    }
                }

                bool phaiLonHon = (right - i) > (j - left);
                if (phaiLonHon)
                {
                    if (i < right) stack.Push(i, right);
                    if (left < j) stack.Push(left, j);
                }
                else
                {
                    if (left < j) stack.Push(left, j);
                    if (i < right) stack.Push(i, right);
                }
            }
        }
    }
}