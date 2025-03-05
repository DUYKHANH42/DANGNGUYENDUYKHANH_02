using System;

namespace DEKTSO2_DANGNGUYENDUYKHANH
{
    public class NhanVienHD : NhanVien
    {
        private int doanhthu;
        // khai báo biến doanhthu của lớp NhanVienHD
        public NhanVienHD(string masonv, string hoten, int luongcung, int doanhthu) : base(masonv, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }
        // hàm tạo không tham số
        public NhanVienHD() : base()
        {
            doanhthu = 0;
        }
        // hàm tạo có tham số
        public int DoanhThu
        {
            get { return doanhthu; }
            set { doanhthu = value; }
        }
        // properties doanhthu
        public override void Nhap()
        {
            base.Nhap();
          Console.Write("Nhập doanh thu: ");
            doanhthu = int.Parse(Console.ReadLine());
        }
        // Phương thức ghi đè nhập thông tin cho nhân viên hợp đồng
        public override int TinhLuong()
        {

            double Thuong= 0.1 * doanhthu;
            double LuongThucLanh= Thuong * LuongCung;
            return (int)LuongThucLanh;
        }
        // Phương thức ghi đè tính lương cho nhân viên hợp đồng


    }
}
