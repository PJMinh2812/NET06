-- Bài tập 2: Thiết kế CSDL cybersoft_shop theo ERD

CREATE DATABASE cybersoft_shop;
GO

USE cybersoft_shop;
GO

CREATE TABLE LoaiSanPham (
    MaLoaiSP   INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiSP  NVARCHAR(100)     NOT NULL
);

CREATE TABLE SanPham (
    MaSP      INT IDENTITY(1,1) PRIMARY KEY,
    TenSP     NVARCHAR(200)     NOT NULL,
    MoTa      NVARCHAR(MAX),
    Gia       DECIMAL(18, 2),
    MaLoaiSP  INT,
    CONSTRAINT FK_SanPham_LoaiSanPham FOREIGN KEY (MaLoaiSP) REFERENCES LoaiSanPham(MaLoaiSP)
);

CREATE TABLE KhachHang (
    MaKH    INT IDENTITY(1,1) PRIMARY KEY,
    Ho      NVARCHAR(50),
    Ten     NVARCHAR(50)      NOT NULL,
    DiaChi  NVARCHAR(200),
    Email   VARCHAR(100),
    SoDT    VARCHAR(20)
);

CREATE TABLE HoaDon (
    MaHoaDon  INT IDENTITY(1,1) PRIMARY KEY,
    NgayMua   DATE,
    MaKH      INT,
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

-- Bảng trung gian HoaDon - SanPham (quan hệ N-N qua "Chua")
CREATE TABLE ChiTietHoaDon (
    MaHoaDon  INT,
    MaSP      INT,
    SoLuong   INT,
    GiaBan    DECIMAL(18, 2),
    PRIMARY KEY (MaHoaDon, MaSP),
    CONSTRAINT FK_CTHD_HoaDon  FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT FK_CTHD_SanPham FOREIGN KEY (MaSP)      REFERENCES SanPham(MaSP)
);
