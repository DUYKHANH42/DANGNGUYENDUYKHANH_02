using System;

namespace DEKTSO2_DANGNGUYENDUYKHANH
{
    public class NhanVien
    {
        // khai báo các biến của lớp NhanVien
        private string masonv;
        private string hoten;
        private int luongcung;

        public NhanVien(string masonv, string hoten, int luongcung)
        {
            this.masonv = masonv;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }
        // hàm tạo không tham số
        public NhanVien()
        {
            masonv = "";
            hoten = "";
            luongcung = 0;
        }
        // hàm tạo có tham số
        public string MaSoNhanVien
        {
            get { return masonv; }
            set { masonv = value; }
        }
        // properties masonv
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        // properties hoten
        public int LuongCung
        {
            get { return luongcung; }
            set { luongcung = value; }
        }
        // properties luongcung
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên nhân viên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập lương cứng: ");
            luongcung = int.Parse(Console.ReadLine());
        }
        // Phương thức ảo nhập thông tin cho nhân viên
        public virtual int TinhLuong()
        {
            return luongcung;
        }
        // Phương thức ảo TinhLuong trả về luongcung


    }
}
