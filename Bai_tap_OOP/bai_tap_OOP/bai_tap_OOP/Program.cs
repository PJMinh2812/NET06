namespace bai_tap_OOP
{
    internal class Program
    {
        static List<SanPham> danhSachSanPham = new List<SanPham>();

        static void ThemSanPham()
        {
            Console.WriteLine("Chọn loại sản phẩm:");
            Console.WriteLine("1. Điện tử");
            Console.WriteLine("2. Thời trang");
            Console.WriteLine("3. Thực phẩm");
            Console.Write("Lựa chọn: ");
            string loai = Console.ReadLine()!;

            Console.Write("Nhập mã sản phẩm: ");
            string ma = Console.ReadLine()!;
            Console.Write("Nhập tên sản phẩm: ");
            string ten = Console.ReadLine()!;
            Console.Write("Nhập giá gốc: ");
            double giaGoc = double.Parse(Console.ReadLine()!);

            switch (loai)
            {
                case "1":
                    Console.Write("Nhập thuế bảo hành (%): ");
                    double thue = double.Parse(Console.ReadLine()!);
                    danhSachSanPham.Add(new DienTu(ma, ten, giaGoc, thue));
                    break;
                case "2":
                    Console.Write("Nhập giảm giá (%): ");
                    double giamGia = double.Parse(Console.ReadLine()!);
                    danhSachSanPham.Add(new ThoiTrang(ma, ten, giaGoc, giamGia));
                    break;
                case "3":
                    Console.Write("Nhập phí vận chuyển: ");
                    double phi = double.Parse(Console.ReadLine()!);
                    danhSachSanPham.Add(new ThucPham(ma, ten, giaGoc, phi));
                    break;
                default:
                    Console.WriteLine("Loại sản phẩm không hợp lệ!");
                    break;
            }
        }

        static void HienThiDanhSach()
        {
            if (danhSachSanPham.Count == 0)
            {
                Console.WriteLine("Danh sách sản phẩm trống!");
                return;
            }
            Console.WriteLine("Danh sách sản phẩm:");
            foreach (var sp in danhSachSanPham)
            {
                sp.HienThiThongTin();
            }
        }

        static void TinhTongDoanhThu()
        {
            double tong = 0;
            foreach (var sp in danhSachSanPham)
            {
                tong += sp.TinhGiaBan();
            }
            Console.WriteLine($"Tổng doanh thu dự kiến: {tong} VND");
        }

        static void XoaSanPham()
        {
            Console.Write("Nhập mã sản phẩm cần xóa: ");
            string ma = Console.ReadLine()!;
            SanPham? sp = danhSachSanPham.Find(s => s.MaSanPham == ma);
            if (sp != null)
            {
                danhSachSanPham.Remove(sp);
                Console.WriteLine($"Đã xóa sản phẩm có mã {ma}.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sản phẩm với mã đã nhập!");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n---- Hệ thống quản lý bán hàng ----");
                Console.WriteLine("1. Thêm sản phẩm");
                Console.WriteLine("2. Hiển thị danh sách sản phẩm");
                Console.WriteLine("3. Tính tổng doanh thu");
                Console.WriteLine("4. Xóa sản phẩm");
                Console.WriteLine("5. Thoát");
                Console.Write("Vui lòng chọn chức năng: ");
                string luaChon = Console.ReadLine()!;

                switch (luaChon)
                {
                    case "1":
                        ThemSanPham();
                        break;
                    case "2":
                        HienThiDanhSach();
                        break;
                    case "3":
                        TinhTongDoanhThu();
                        break;
                    case "4":
                        XoaSanPham();
                        break;
                    case "5":
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại!");
                        break;
                }
            }
        }
    }
}
