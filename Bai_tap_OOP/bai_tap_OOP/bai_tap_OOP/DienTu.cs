namespace bai_tap_OOP
{
    class DienTu : SanPham
    {
        public double ThueBaoHanh { get; set; } // Phần trăm thuế bảo hành

        public DienTu(string maSanPham, string tenSanPham, double giaGoc, double thueBaoHanh)
            : base(maSanPham, tenSanPham, giaGoc)
        {
            ThueBaoHanh = thueBaoHanh;
        }

        public override double TinhGiaBan()
        {
            return GiaGoc * (1 + ThueBaoHanh / 100);
        }
    }
}
