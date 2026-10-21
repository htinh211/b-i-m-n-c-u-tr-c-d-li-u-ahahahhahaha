using System;

namespace _25DH110577_NguyenHaTinh_lab1
{
    internal class SinhVien
    {
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;

        public string MaSo { get { return maSo; } set { maSo = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public string ChuyenNganh { get { return chuyenNganh; } set { chuyenNganh = value; } }
        public int NamSinh { get { return namSinh; } set { namSinh = value; } }
        public float DiemTB { get { return diemTB; } set { diemTB = value; } }
        public string Loai { get { return loai; } set { loai = value; } }

        public SinhVien() { }

        public SinhVien(string ms, string ht, string cn, int ns, float dtb)
        {
            this.maSo = ms;
            this.hoTen = ht;
            this.chuyenNganh = cn;
            this.namSinh = ns;
            this.diemTB = dtb;
            XepLoai();
        }

        public SinhVien(SinhVien sv)
        {
            if (sv != null)
            {
                this.maSo = sv.maSo;
                this.hoTen = sv.hoTen;
                this.chuyenNganh = sv.chuyenNganh;
                this.namSinh = sv.namSinh;
                this.diemTB = sv.diemTB;
                this.loai = sv.loai;
            }
        }

        public bool KiemTraNamSinh(int ns)
        {
            int studentAge = DateTime.Now.Year - ns;
            return studentAge >= 17 && studentAge <= 70;
        }

        public bool KiemTraDiemTB(float dtb)
        {
            return dtb >= 0 && dtb <= 10;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma so: ");
            MaSo = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap chuyen nganh: ");
            ChuyenNganh = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhap nam sinh: ");
                if (int.TryParse(Console.ReadLine(), out int ns) && KiemTraNamSinh(ns))
                {
                    NamSinh = ns;
                    break;
                }
                Console.WriteLine("-> Nam sinh khong hop le (tuoi phai tu 17 den 70). Vui long nhap lai!");
            }

            while (true)
            {
                Console.Write("Nhap diem trung binh: ");
                if (float.TryParse(Console.ReadLine(), out float dtb) && KiemTraDiemTB(dtb))
                {
                    DiemTB = dtb;
                    break;
                }
                Console.WriteLine("-> Diem TB khong hop le (phai tu 0.0 den 10.0). Vui long nhap lai!");
            }

            XepLoai();
        }

        public void XepLoai()
        {
            if (diemTB < 5)
                loai = "Yeu";
            else if (diemTB >= 5 && diemTB < 7)
                loai = "Trung binh";
            else if (diemTB >= 7 && diemTB < 8)
                loai = "Kha";
            else
                loai = "Gioi Xuat sac";
        }

        public void Xuat()
        {
            XepLoai();
            Console.WriteLine($"[MSSV: {maSo} | Ho ten: {hoTen} | Chuyen nganh: {chuyenNganh} | Nam sinh: {namSinh} | Diem TB: {diemTB:F1} | Loai: {loai}]");
        }
    }
}