namespace bai_tap_OOP
{
    class ThucPham : SanPham
    {
        public double PhiVanChuyen { get; set; }

        public ThucPham(string maSanPham, string tenSanPham, double giaGoc, double phiVanChuyen)
            : base(maSanPham, tenSanPham, giaGoc)
        {
            PhiVanChuyen = phiVanChuyen;
        }

        public override double TinhGiaBan()
        {
            return GiaGoc + PhiVanChuyen;
        }
    }
}
