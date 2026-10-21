using System;

namespace _25DH110577_NguyenHaTinh_lab1
{
    internal class Program
    {
        static void TestSinhVien()
        {
            Console.WriteLine("================ PHẦN A: TEST SINH VIÊN ================");

            SinhVien svA = new SinhVien();

            Console.WriteLine("--- Nhap thong tin cho svA ---");
            svA.Nhap();

            Console.WriteLine("\n--- Thong tin svA ---");
            svA.Xuat();

            Console.WriteLine("\n--- Tao svB bang Constructor co tham so ---");
            SinhVien svB = new SinhVien("18DH001", "Lam Thanh Ngoc", "CNPM", 2000, 7.6f);

            svB.Xuat();

            Console.WriteLine("\n--- Tao svC la bản sao cua svB ---");
            SinhVien svC = new SinhVien(svB);

            Console.WriteLine("-> Cap nhat svC: HoTen = 'Nguyen Van Hung', DiemTB = 9.0");
            svC.HoTen = "Nguyen Van Hung";
            svC.DiemTB = 9.0f;

            Console.WriteLine("\n--- Thong tin svC sau khi sua ---");
            svC.Xuat();

            Console.WriteLine("\n--- Thong tin svB ---");
            svB.Xuat();
        }

        static void TestMangSinhVien()
        {
            Console.WriteLine("\n================ PHẦN B: TEST MẢNG SINH VIÊN ================");
            MangSinhVien dssv = new MangSinhVien();
            dssv.NhapMang();

            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN VỪA NHẬP ---");
            dssv.XuatMang();
        }

        static void TestMangSinhVienNangCao()
        {
            Console.WriteLine("\n================ PHẦN C: CHƯƠNG TRÌNH NÂNG CAO ================");
            MangSinhVien dssv = new MangSinhVien();
            dssv.NhapMang();

            dssv.SapXepGiamDanTheoDiem();
            Console.WriteLine("\n--- DANH SÁCH SẮP XẾP GIẢM DẦN THEO ĐIỂM TB ---");
            dssv.XuatMang();

            Console.Write("\nNhap ma so sinh vien can tim: ");
            string msSearch = Console.ReadLine();
            SinhVien svTim = dssv.TimTheoMaSo(msSearch);
            if (svTim != null)
            {
                Console.WriteLine("-> Tim thay sinh vien:");
                svTim.Xuat();
            }
            else
            {
                Console.WriteLine($"-> Khong tim thay sinh vien co ma so: {msSearch}");
            }

            dssv.ThongKeXepLoai();

            SinhVien svMax = dssv.TimSinhVienDiemCaoNhat();
            if (svMax != null)
            {
                Console.WriteLine("\n--- SINH VIÊN CÓ ĐIỂM TRUNG BÌNH CAO NHẤT ---");
                svMax.Xuat();
            }
        }

        static void Main(string[] args)
        {
            TestSinhVien();

            Console.ReadLine();
        }
    }
}