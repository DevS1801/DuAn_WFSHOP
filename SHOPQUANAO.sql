use QL_ShopQuanAo
CREATE TABLE DanhMuc (
    MaDM INTEGER PRIMARY KEY,
    TenDM NVARCHAR(100)
);
GO

CREATE TABLE SanPham (
    MaSp INTEGER PRIMARY KEY,
    MaDM INTEGER,
    TenSp NVARCHAR(100),
    MoTa NVARCHAR(100),
    SoLuongTon INTEGER,
    ThuongHieu NVARCHAR(100),
    GiaBan DECIMAL(18, 2),
    FOREIGN KEY (MaDM) REFERENCES DanhMuc (MaDM),
    CONSTRAINT CHK_SoLuongTon CHECK (SoLuongTon >= 0)
);
GO

CREATE TABLE NhanVien (
    MaNV INTEGER PRIMARY KEY,
    MaTK INTEGER,
    HoTen NVARCHAR(100) not null,
    SoDT NVARCHAR(100)unique,
    Email NVARCHAR(100) unique,
    DiaChi NVARCHAR(100),
    CCCD NVARCHAR(100) unique not null,
    ChucVu NVARCHAR(100),
);
GO
CREATE TABLE TaiKhoanNguoiDung (
    MaTK INTEGER PRIMARY KEY,
    MaNV INTEGER,
    TenDangNhap NVARCHAR(100) not null,
    MatKhau NVARCHAR(100) not null,
    LoaiTK SMALLINT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV)
);
GO
CREATE TABLE KhachHang (
    MaKH INTEGER PRIMARY KEY,
    HoTen NVARCHAR(100),
    SoDT NVARCHAR(100),
    DiaChi NVARCHAR(100),
    Email NVARCHAR(100)
);
GO
CREATE TABLE HoaDon (
    MaHD INTEGER PRIMARY KEY,
    MaNV INTEGER,
    MaKH INTEGER,
    NgayDatHang DATE,
    TongGT DECIMAL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang (MaKH),
    CONSTRAINT CHK_TongGT CHECK (TongGT >= 0)
);
GO

CREATE TABLE ChiTietHoaDon (
    MaSp INTEGER,
    MaHD INTEGER,
    SoLuong INTEGER,
    PRIMARY KEY (MaSp, MaHD),
    FOREIGN KEY (MaSp) REFERENCES SanPham (MaSp),
    FOREIGN KEY (MaHD) REFERENCES HoaDon (MaHD),
    CONSTRAINT CHK_SoLuong CHECK (SoLuong >= 0)
);
GO





--trigger update cua khi them xoa sua chi tiet hoa don
CREATE TRIGGER UpdateTotalValue
ON ChiTietHoaDon
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @MaHD INT;
    SELECT @MaHD = MaHD FROM inserted;

    UPDATE HoaDon
    SET TongGT = (
        SELECT SUM(SoLuong * GiaBan)
        FROM ChiTietHoaDon, SanPham
        WHERE MaHD = @MaHD
    )
    WHERE MaHD = @MaHD;
END;
go
