using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEKTSO2_DANGNGUYENDUYKHANH
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuanLyNV nv = new QuanLyNV();
            nv.DuLieuSan();
            int chon;
            do
            {
                Console.WriteLine("------------Danh Sách Nhân Viên------------");
                Console.WriteLine("1.Nhập Nhân Viên.");
                Console.WriteLine("2.Xóa Nhân Viên.");
                Console.WriteLine("3.Xuất Giảng Viên.");
                Console.WriteLine("4.Xuất Tổng Tiền Nhà Trường Trả Cho Giảng Viên.");
                Console.WriteLine("5.Tính Trung Bình Lương Thực Lãnh Của Nhân Viên.");
                Console.WriteLine("6.Thoát.");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv.NhapDS();
                        break;
                    case 2:
                        nv.XoaDS();
                        break;
                    case 3:
                        nv.XuatDS();
                        break;
                    case 4:
                        nv.TinhTongLuong();
                        break;
                    case 5:
                        nv.TinhLuongTB();
                        break;
                    case 6:
                        Console.WriteLine("Thoát");
                        break;
                    default:
                        Console.WriteLine("Chọn không hợp lệ.");
                        break;
                }
            }
            while (chon != 6);
            Console.ReadLine();
        }
    }
}
