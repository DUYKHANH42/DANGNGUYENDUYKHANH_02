using System;
using System.Collections.Generic;

namespace DEKTSO2_DANGNGUYENDUYKHANH
{
    public class QuanLyNV
    {
        List<NhanVien> dsNhanVien = new List<NhanVien>();
        // khai báo danh sách (List) nhân viên
        public QuanLyNV()
        {
            dsNhanVien = new List<NhanVien>();
        }
        public void DuLieuSan()
        {
            dsNhanVien.Add(new NhanVienBC { MaSoNhanVien = "A01", HoTen = "Nguyễn Văn A", LuongCung = 2000000, Mucxeploai = "A" });
            dsNhanVien.Add(new NhanVienBC { MaSoNhanVien = "A02", HoTen = "Nguyễn Văn B", LuongCung = 5000000, Mucxeploai = "B" });
            dsNhanVien.Add(new NhanVienHD { MaSoNhanVien = "A03", HoTen = "Nguyễn Văn C", LuongCung = 30000, DoanhThu = 1000 });
            dsNhanVien.Add(new NhanVienHD { MaSoNhanVien = "A04", HoTen = "Nguyễn Văn D", LuongCung = 40000, DoanhThu = 2000 });
        }
        // hàm tạo dữ liệu mẫu
        public void Clear()
        {
            Console.Clear(); ;
        }
        public void KiemTraMaNV(string masonv)
        {
            
            foreach (NhanVien NV in dsNhanVien)
            {
                if (NV.MaSoNhanVien == masonv)
                {
                    Console.WriteLine("Mã Số Nhân Viên Đã Tồn Tại");
                    return;

                }
            }
        }
        public void NhapDS()
        {
            string chon;
            do
            {
                Clear();
                Console.WriteLine("Nhập loại nhân viên(1:Nhân Viên Biên Chế / 2: Nhân Viên Hợp Đồng): ");
                int loai = int.Parse(Console.ReadLine());
                NhanVien nv = null;
                if (loai == 1)
                {
                    Console.Write("Nhập mã số nhân viên: ");
                    nv.MaSoNhanVien = Console.ReadLine();

                    nv = new NhanVienBC();

                }
                else if (loai == 2)
                {
                    nv = new NhanVienHD();
                    KiemTraMaNV(nv.MaSoNhanVien);
                }
                else
                {
                    Console.WriteLine("Nhập sai loại nhân viên");
                    return;
                }
                nv.Nhap();
                dsNhanVien.Add(nv);
                Console.WriteLine("Bạn có muốn nhập tiếp không? (Y/N): ");
                chon = Console.ReadLine();
            } while (chon.ToUpperInvariant() == "y");
        }
        // phương thức nhập danh sách nhân viên

        public void XuatDS()
        {
            Clear();
            Console.WriteLine("{0,-20}{1,-15}{2,15}{3,30}"
            , "Mã Số Nhân Viên", "Họ Tên Nhân Viên", "Lương Cứng", "Lương Thực Lãnh");
            foreach (NhanVien nv in dsNhanVien)
            {

                Console.WriteLine("{0,-20}{1,-15}{2,15}{3,30}"
                                 , nv.MaSoNhanVien, nv.HoTen, nv.LuongCung.ToString("#,0"), nv.TinhLuong().ToString("#,0"));
            }
        }
        // phương thức xuất danh sách nhân viên
        public int TinhTongLuong()
        {
            Clear();
            int tong = 0;
            foreach (NhanVien nv in dsNhanVien)
            {
                tong += nv.TinhLuong();
            }
            Console.WriteLine($"Tổng tiền lương thực lãnh của tất cả nhân viên là: {tong.ToString("#,0")} VND ");
            return tong;
        }
        // phương thức tính tổng lương
        public double TinhLuongTB()
        {
            Clear();
            if (dsNhanVien.Count == 0) return 0;
            double TinhLuongTB = TinhTongLuong() / dsNhanVien.Count;

            Console.WriteLine($"Trung bình tiền lương thực lãnh của tất cả nhân viên là: {TinhLuongTB.ToString("#,0")} VND ");
            return TinhLuongTB;
        }
        // phương thức tính trung bình 
        public void XoaDS()
        {
            Console.WriteLine("Nhập mã số nhân viên muốn xóa: ");
            string masonv = Console.ReadLine();
            for (int i = 0; i < dsNhanVien.Count;)
            {
                if (dsNhanVien[i].MaSoNhanVien == masonv)
                {
                    dsNhanVien.RemoveAt(i);
                    Console.WriteLine("Xóa Thành Công!");
                    return;
                }
                else
                {
                    Console.WriteLine("Không tìm thấy mã số nhân viên");
                    return;
                }
            }
        }
    }
}
