-- ============================================================
-- BÀI TẬP INNER JOIN — db_qlnv_dotnet06
-- Lược đồ:
--   PhongBan      (Id, TenPB)
--   DiaDiem       (Id, TenDiaDiem, DiaChi)
--   NhanVien      (Id, TenNV, NgaySinh, DiaChi, SoDienThoai,
--                  MaPB, NgayNhamChuc, MaTruongPhong)
--   DuAn          (Id, TenDuAn, MoTa, NgayBatDau, NgayKetThuc, MaDiaDiem)
--   NhanVien_Duan (MaNhanVien, MaDuAn, NgayThamGia)
-- ============================================================

USE db_qlnv_dotnet06;

-- ============================================================
-- BÀI 1 — INNER JOIN từ 2 bảng
-- ============================================================

-- Câu 1.1: Danh sách nhân viên kèm tên phòng ban, sắp xếp theo TenPB
SELECT
    nv.TenNV,
    nv.SoDienThoai,
    pb.TenPB
FROM NhanVien nv
INNER JOIN PhongBan pb ON nv.MaPB = pb.Id
ORDER BY pb.TenPB;

-- Câu 1.2: Tất cả dự án cùng địa điểm thực hiện
SELECT
    da.TenDuAn,
    da.NgayBatDau,
    da.NgayKetThuc,
    dd.TenDiaDiem,
    dd.DiaChi
FROM DuAn da
INNER JOIN DiaDiem dd ON da.MaDiaDiem = dd.Id;

-- Câu 1.3: Mỗi dự án có những nhân viên (mã) nào tham gia
SELECT
    da.TenDuAn,
    nvd.MaNhanVien,
    nvd.NgayThamGia
FROM DuAn da
INNER JOIN NhanVien_Duan nvd ON da.Id = nvd.MaDuAn;

-- ============================================================
-- BÀI 2 — INNER JOIN từ 3 bảng
-- ============================================================

-- Câu 2.1: Nhân viên, phòng ban và tên trưởng phòng (self-join NhanVien)
SELECT
    nv.TenNV,
    pb.TenPB,
    tp.TenNV AS TenTruongPhong
FROM NhanVien nv
INNER JOIN PhongBan pb ON nv.MaPB = pb.Id
INNER JOIN NhanVien tp ON nv.MaTruongPhong = tp.Id;

-- Câu 2.2: Chi tiết phân công: tên nhân viên, tên dự án, ngày tham gia
SELECT
    nv.TenNV,
    da.TenDuAn,
    nvd.NgayThamGia
FROM NhanVien nv
INNER JOIN NhanVien_Duan nvd ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da ON nvd.MaDuAn = da.Id
ORDER BY nv.TenNV;

-- Câu 2.3: Mỗi dự án, địa điểm và các nhân viên (mã) tham gia
SELECT
    da.TenDuAn,
    dd.TenDiaDiem,
    nvd.MaNhanVien,
    nvd.NgayThamGia
FROM DuAn da
INNER JOIN DiaDiem dd ON da.MaDiaDiem = dd.Id
INNER JOIN NhanVien_Duan nvd ON da.Id = nvd.MaDuAn;

-- ============================================================
-- BÀI 3 — INNER JOIN từ 4 bảng
-- ============================================================

-- Câu 3.1: Nhân viên, dự án tham gia và địa điểm dự án
-- NhanVien → NhanVien_Duan → DuAn → DiaDiem
SELECT
    nv.TenNV,
    da.TenDuAn,
    dd.TenDiaDiem,
    nvd.NgayThamGia
FROM NhanVien nv
INNER JOIN NhanVien_Duan nvd ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da ON nvd.MaDuAn = da.Id
INNER JOIN DiaDiem dd ON da.MaDiaDiem = dd.Id;

-- Câu 3.2: Nhân viên tham gia dự án kèm phòng ban và tên dự án
-- NhanVien → PhongBan, NhanVien → NhanVien_Duan → DuAn
SELECT
    nv.TenNV,
    pb.TenPB,
    da.TenDuAn,
    nvd.NgayThamGia
FROM NhanVien nv
INNER JOIN PhongBan pb ON nv.MaPB = pb.Id
INNER JOIN NhanVien_Duan nvd ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da ON nvd.MaDuAn = da.Id;

-- Câu 3.3: Báo cáo tổng hợp: tên nhân viên, phòng ban, tên dự án, địa điểm dự án
-- NhanVien, PhongBan, NhanVien_Duan, DuAn, DiaDiem
SELECT
    nv.TenNV,
    pb.TenPB,
    da.TenDuAn,
    dd.TenDiaDiem
FROM NhanVien nv
INNER JOIN PhongBan pb ON nv.MaPB = pb.Id
INNER JOIN NhanVien_Duan nvd ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da ON nvd.MaDuAn = da.Id
INNER JOIN DiaDiem dd ON da.MaDiaDiem = dd.Id;
