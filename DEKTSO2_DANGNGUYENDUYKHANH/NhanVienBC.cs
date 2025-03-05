using System;

namespace DEKTSO2_DANGNGUYENDUYKHANH
{
    public class NhanVienBC : NhanVien
    {
        private string mucxeploai;
        // khai báo biến mucxeloai của lớp NhanVienBC
        public NhanVienBC(string masonv, string hoten, int luongcung, string mucxeloai) : base(masonv, hoten, luongcung)
        {
            this.mucxeploai = mucxeloai;
        }
        // hàm tạo không tham số
        public NhanVienBC() : base()
        {
            mucxeploai = "";
        }
        // hàm tạo có tham số
        public string Mucxeploai
        {
            get { return mucxeploai; }
            set
            {
                mucxeploai = value;
            }
        }
        // properties mucxeploai
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập mức xếp loại: ");
            mucxeploai = Console.ReadLine();
        }
        // Phương thức ghi đè nhập thông tin cho nhân viên biên chế
        public override int TinhLuong()
        {
            double LuongThucLanh = 0;
            double Thuong = 0;
            if (Mucxeploai.ToUpper() == "A")
            {
                Thuong = 1.5;
            }
            else if (Mucxeploai.ToUpper() == "B")
            {
                Thuong = 1;
            }
            else if (Mucxeploai.ToUpper() == "C")
            {
                Thuong = 0.5;
            }
            LuongThucLanh = Thuong * LuongCung;

            return (int)LuongThucLanh;
        }
        // Phương thức ghi đè tính lương cho nhân viên biên chế

    }
}
