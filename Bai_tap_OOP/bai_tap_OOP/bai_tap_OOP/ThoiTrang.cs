namespace bai_tap_OOP
{
    class ThoiTrang : SanPham
    {
        public double PhanTramGiamGia { get; set; } 

        public ThoiTrang(string maSanPham, string tenSanPham, double giaGoc, double phanTramGiamGia)
            : base(maSanPham, tenSanPham, giaGoc)
        {
            PhanTramGiamGia = phanTramGiamGia;
        }

        public override double TinhGiaBan()
        {
            return GiaGoc * (1 - PhanTramGiamGia / 100);
        }
    }
}
