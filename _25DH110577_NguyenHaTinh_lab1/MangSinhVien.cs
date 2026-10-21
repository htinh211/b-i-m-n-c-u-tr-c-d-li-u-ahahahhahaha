using System;

namespace _25DH110577_NguyenHaTinh_lab1
{
    internal class MangSinhVien
    {
        private SinhVien[] a;

        public SinhVien[] A
        {
            get { return a; }
            set { a = value; }
        }

        public MangSinhVien() { }

        public MangSinhVien(int n)
        {
            if (KiemTraSize(n))
            {
                a = new SinhVien[n];
            }
        }

        public bool KiemTraSize(int n)
        {
            return n > 0 && n <= 1000000;
        }

        public void NhapMang()
        {
            int n;
            while (true)
            {
                Console.Write("Nhap so luong sinh vien (n): ");
                if (int.TryParse(Console.ReadLine(), out n) && KiemTraSize(n))
                {
                    break;
                }
                Console.WriteLine("-> So luong khong hop le (0 < n <= 1,000,000). Vui long nhap lai!");
            }

            a = new SinhVien[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"\n--- Nhap thong tin sinh vien thu {i + 1} ---");
                a[i] = new SinhVien();
                a[i].Nhap();
            }
        }

        public void XuatMang()
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Danh sach sinh vien rong!");
                return;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"SV {i + 1}: ");
                a[i].Xuat();
            }
        }

        public void SapXepGiamDanTheoDiem()
        {
            if (a == null || a.Length <= 1) return;

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j].DiemTB < a[j + 1].DiemTB)
                    {
                        SinhVien temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        public SinhVien TimTheoMaSo(string ms)
        {
            if (a == null) return null;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].MaSo.Equals(ms, StringComparison.OrdinalIgnoreCase))
                {
                    return a[i];
                }
            }
            return null;
        }

        public void ThongKeXepLoai()
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            int yeu = 0, trungBinh = 0, kha = 0, gioiXuatSac = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i].XepLoai();
                string l = a[i].Loai;

                if (l == "Yeu") yeu++;
                else if (l == "Trung binh") trungBinh++;
                else if (l == "Kha") kha++;
                else if (l == "Gioi Xuat sac") gioiXuatSac++;
            }

            Console.WriteLine("\n--- THỐNG KÊ XẾP LOẠI ---");
            Console.WriteLine($"- Yeu: {yeu} sinh vien");
            Console.WriteLine($"- Trung binh: {trungBinh} sinh vien");
            Console.WriteLine($"- Kha: {kha} sinh vien");
            Console.WriteLine($"- Gioi Xuat sac: {gioiXuatSac} sinh vien");
        }

        public SinhVien TimSinhVienDiemCaoNhat()
        {
            if (a == null || a.Length == 0) return null;

            SinhVien maxSV = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].DiemTB > maxSV.DiemTB)
                {
                    maxSV = a[i];
                }
            }
            return maxSV;
        }
    }
}