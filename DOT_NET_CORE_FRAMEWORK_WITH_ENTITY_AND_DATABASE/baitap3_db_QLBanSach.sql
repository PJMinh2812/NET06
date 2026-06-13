-- Bài tập 3: Thiết kế CSDL db_QLBanSach theo ERD

CREATE DATABASE db_QLBanSach;
GO

USE db_QLBanSach;
GO

CREATE TABLE KhachHang (
    MaKH       INT IDENTITY(1,1) PRIMARY KEY,
    TaiKhoan   VARCHAR(50)       NOT NULL UNIQUE,
    MatKhau    VARCHAR(255)      NOT NULL,
    Email      VARCHAR(100),
    DiaChi     NVARCHAR(200),
    DienThoai  VARCHAR(20),
    GioiTinh   NVARCHAR(10),
    NgaySinh   DATE,
    HoTen      NVARCHAR(100)     NOT NULL
);

CREATE TABLE DonHang (
    MaDonHang   INT IDENTITY(1,1) PRIMARY KEY,
    DaThanhToan BIT               NOT NULL DEFAULT 0,
    NgayDat     DATE,
    NgayGiao    DATE,
    TinhTrangGH NVARCHAR(100),
    MaKH        INT,
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE TacGia (
    MaTacGia   INT IDENTITY(1,1) PRIMARY KEY,
    TenTacGia  NVARCHAR(100)     NOT NULL,
    TieuSu     NVARCHAR(MAX),
    DienThoai  VARCHAR(20),
    DiaChi     NVARCHAR(200)
);

CREATE TABLE ChuDe (
    MaChuDe   INT IDENTITY(1,1) PRIMARY KEY,
    TenChuDe  NVARCHAR(100)     NOT NULL
);

CREATE TABLE NhaXuatBan (
    MaNSX     INT IDENTITY(1,1) PRIMARY KEY,
    TenNSB    NVARCHAR(100)     NOT NULL,
    DienThoai VARCHAR(20),
    DiaChi    NVARCHAR(200)
);

CREATE TABLE Sach (
    MaSach       INT IDENTITY(1,1) PRIMARY KEY,
    TenSach      NVARCHAR(200)     NOT NULL,
    SoLuongTon   INT               DEFAULT 0,
    NgayCapNhat  DATE,
    AnhBia       NVARCHAR(500),
    MoTa         NVARCHAR(MAX),
    GiaBan       DECIMAL(18, 2),
    MaChuDe      INT,
    MaNSX        INT,
    CONSTRAINT FK_Sach_ChuDe      FOREIGN KEY (MaChuDe) REFERENCES ChuDe(MaChuDe),
    CONSTRAINT FK_Sach_NhaXuatBan FOREIGN KEY (MaNSX)   REFERENCES NhaXuatBan(MaNSX)
);

-- Bảng trung gian DonHang - Sach (quan hệ N-N qua "Gom")
CREATE TABLE ChiTietDonHang (
    MaDonHang  INT,
    MaSach     INT,
    SoLuong    INT,
    DonGia     DECIMAL(18, 2),
    PRIMARY KEY (MaDonHang, MaSach),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    CONSTRAINT FK_CTDH_Sach    FOREIGN KEY (MaSach)    REFERENCES Sach(MaSach)
);

-- Bảng trung gian TacGia - Sach (quan hệ N-N qua "Tham gia")
CREATE TABLE TacGia_Sach (
    MaTacGia  INT,
    MaSach    INT,
    VaiTro    NVARCHAR(100),
    ViTri     NVARCHAR(100),
    PRIMARY KEY (MaTacGia, MaSach),
    CONSTRAINT FK_TGS_TacGia FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia),
    CONSTRAINT FK_TGS_Sach   FOREIGN KEY (MaSach)   REFERENCES Sach(MaSach)
);
