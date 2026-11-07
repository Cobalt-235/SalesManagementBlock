IF OBJECT_ID(N'dbo.Phienbanhethong', N'U') IS NOT NULL
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.Phienbanhethong WHERE Phienban <> 1)
    BEGIN
        ;THROW 50001, N'Phiên bản database không phù hợp với ứng dụng.', 1;
    END;
END;
IF OBJECT_ID(N'dbo.Sanpham', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Sanpham (
        Id int IDENTITY PRIMARY KEY,
        Ma nvarchar(30) NOT NULL UNIQUE,
        Ten nvarchar(150) NOT NULL,
        Theloai nvarchar(80) NOT NULL,
        Nentang nvarchar(50) NOT NULL,
        Nhaphathanh nvarchar(100) NOT NULL,
        Gianhap decimal(18,0) NOT NULL CHECK(Gianhap>=0),
        Giaban decimal(18,0) NOT NULL CHECK(Giaban>0),
        Tonkho int NOT NULL CHECK(Tonkho>=0),
        TonToithieu int NOT NULL CHECK(TonToithieu>=0),
        Dangban bit NOT NULL,
        Mota nvarchar(1000) NOT NULL,
        Phienban rowversion
    );
END;
IF COL_LENGTH(N'dbo.Sanpham', N'Id') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Ma') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Ten') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Theloai') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Nentang') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Nhaphathanh') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Gianhap') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Giaban') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Tonkho') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'TonToithieu') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Dangban') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Mota') IS NULL OR COL_LENGTH(N'dbo.Sanpham', N'Phienban') IS NULL
BEGIN
    ;THROW 50002, N'Bảng Sanpham đã tồn tại nhưng thiếu cột. Giữ nguyên dữ liệu và kiểm tra lại cấu trúc.', 1;
END;
IF OBJECT_ID(N'dbo.Khachhang', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Khachhang (
        Id int IDENTITY PRIMARY KEY,
        Ma nvarchar(30) NOT NULL UNIQUE,
        Hoten nvarchar(100) NOT NULL,
        Dienthoai nvarchar(15) NOT NULL UNIQUE,
        Email nvarchar(150) NOT NULL,
        Diachi nvarchar(250) NOT NULL,
        Phienban rowversion
    );
END;
IF COL_LENGTH(N'dbo.Khachhang', N'Id') IS NULL OR COL_LENGTH(N'dbo.Khachhang', N'Ma') IS NULL OR COL_LENGTH(N'dbo.Khachhang', N'Hoten') IS NULL OR COL_LENGTH(N'dbo.Khachhang', N'Dienthoai') IS NULL OR COL_LENGTH(N'dbo.Khachhang', N'Email') IS NULL OR COL_LENGTH(N'dbo.Khachhang', N'Diachi') IS NULL OR COL_LENGTH(N'dbo.Khachhang', N'Phienban') IS NULL
BEGIN
    ;THROW 50002, N'Bảng Khachhang đã tồn tại nhưng thiếu cột. Giữ nguyên dữ liệu và kiểm tra lại cấu trúc.', 1;
END;
IF OBJECT_ID(N'dbo.Hoadon', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Hoadon (
        Id int IDENTITY PRIMARY KEY,
        YeucauId uniqueidentifier NOT NULL UNIQUE,
        MaBam char(64) NOT NULL,
        Ngaylap datetime2 NOT NULL,
        KhachhangId int NULL REFERENCES dbo.Khachhang(Id),
        Khachhang nvarchar(100) NOT NULL,
        Dienthoai nvarchar(15) NOT NULL,
        Tamtinh decimal(18,0) NOT NULL CHECK(Tamtinh>0),
        Giamgia decimal(18,0) NOT NULL CHECK(Giamgia>=0),
        Tongtien decimal(18,0) NOT NULL CHECK(Tongtien>=0),
        Trangthai nvarchar(30) NOT NULL CHECK(Trangthai IN(N'Đã thanh toán',N'Đã hủy')),
        Ghichu nvarchar(500) NOT NULL,
        LydoHuy nvarchar(250) NOT NULL DEFAULT N'',
        Ngayhuy datetime2 NULL,
        CONSTRAINT CK_Hoadon_Tong CHECK(Tongtien=Tamtinh-Giamgia)
    );
END;
IF COL_LENGTH(N'dbo.Hoadon', N'Id') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'YeucauId') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'MaBam') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Ngaylap') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'KhachhangId') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Khachhang') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Dienthoai') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Tamtinh') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Giamgia') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Tongtien') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Trangthai') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Ghichu') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'LydoHuy') IS NULL OR COL_LENGTH(N'dbo.Hoadon', N'Ngayhuy') IS NULL
BEGIN
    ;THROW 50002, N'Bảng Hoadon đã tồn tại nhưng thiếu cột. Giữ nguyên dữ liệu và kiểm tra lại cấu trúc.', 1;
END;
IF OBJECT_ID(N'dbo.Chitiethoadon', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Chitiethoadon (
        HoadonId int NOT NULL REFERENCES dbo.Hoadon(Id),
        SanphamId int NOT NULL REFERENCES dbo.Sanpham(Id),
        Ma nvarchar(30) NOT NULL,
        Ten nvarchar(150) NOT NULL,
        Dongia decimal(18,0) NOT NULL CHECK(Dongia>0),
        Soluong int NOT NULL CHECK(Soluong>0),
        PRIMARY KEY(HoadonId,SanphamId)
    );
END;
IF COL_LENGTH(N'dbo.Chitiethoadon', N'HoadonId') IS NULL OR COL_LENGTH(N'dbo.Chitiethoadon', N'SanphamId') IS NULL OR COL_LENGTH(N'dbo.Chitiethoadon', N'Ma') IS NULL OR COL_LENGTH(N'dbo.Chitiethoadon', N'Ten') IS NULL OR COL_LENGTH(N'dbo.Chitiethoadon', N'Dongia') IS NULL OR COL_LENGTH(N'dbo.Chitiethoadon', N'Soluong') IS NULL
BEGIN
    ;THROW 50002, N'Bảng Chitiethoadon đã tồn tại nhưng thiếu cột. Giữ nguyên dữ liệu và kiểm tra lại cấu trúc.', 1;
END;
IF OBJECT_ID(N'dbo.Phieunhap', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Phieunhap (
        Id int IDENTITY PRIMARY KEY,
        YeucauId uniqueidentifier NOT NULL UNIQUE,
        MaBam char(64) NOT NULL,
        SanphamId int NOT NULL REFERENCES dbo.Sanpham(Id),
        Ngay datetime2 NOT NULL,
        Soluong int NOT NULL CHECK(Soluong>0),
        Dongia decimal(18,0) NOT NULL CHECK(Dongia>=0),
        Nhacungcap nvarchar(100) NOT NULL,
        Ghichu nvarchar(500) NOT NULL
    );
END;
IF COL_LENGTH(N'dbo.Phieunhap', N'Id') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'YeucauId') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'MaBam') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'SanphamId') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'Ngay') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'Soluong') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'Dongia') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'Nhacungcap') IS NULL OR COL_LENGTH(N'dbo.Phieunhap', N'Ghichu') IS NULL
BEGIN
    ;THROW 50002, N'Bảng Phieunhap đã tồn tại nhưng thiếu cột. Giữ nguyên dữ liệu và kiểm tra lại cấu trúc.', 1;
END;
IF OBJECT_ID(N'dbo.Lichsukho', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Lichsukho (
        Id int IDENTITY PRIMARY KEY,
        SanphamId int NOT NULL REFERENCES dbo.Sanpham(Id),
        Ngay datetime2 NOT NULL,
        Loai nvarchar(30) NOT NULL,
        Soluong int NOT NULL,
        Tonsau int NOT NULL CHECK(Tonsau>=0),
        Thamchieu nvarchar(50) NOT NULL,
        Ghichu nvarchar(700) NOT NULL
    );
END;
IF COL_LENGTH(N'dbo.Lichsukho', N'Id') IS NULL OR COL_LENGTH(N'dbo.Lichsukho', N'SanphamId') IS NULL OR COL_LENGTH(N'dbo.Lichsukho', N'Ngay') IS NULL OR COL_LENGTH(N'dbo.Lichsukho', N'Loai') IS NULL OR COL_LENGTH(N'dbo.Lichsukho', N'Soluong') IS NULL OR COL_LENGTH(N'dbo.Lichsukho', N'Tonsau') IS NULL OR COL_LENGTH(N'dbo.Lichsukho', N'Thamchieu') IS NULL OR COL_LENGTH(N'dbo.Lichsukho', N'Ghichu') IS NULL
BEGIN
    ;THROW 50002, N'Bảng Lichsukho đã tồn tại nhưng thiếu cột. Giữ nguyên dữ liệu và kiểm tra lại cấu trúc.', 1;
END;
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.Hoadon') AND name=N'IX_Hoadon_Ngay')
BEGIN
    EXEC(N'CREATE INDEX IX_Hoadon_Ngay ON dbo.Hoadon(Ngaylap) INCLUDE(Tongtien,Trangthai,KhachhangId)');
END;
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.Chitiethoadon') AND name=N'IX_Chitiet_Sanpham')
BEGIN
    EXEC(N'CREATE INDEX IX_Chitiet_Sanpham ON dbo.Chitiethoadon(SanphamId)');
END;
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.Lichsukho') AND name=N'IX_Lichsukho_Sanpham')
BEGIN
    EXEC(N'CREATE INDEX IX_Lichsukho_Sanpham ON dbo.Lichsukho(SanphamId,Ngay)');
END;
IF OBJECT_ID(N'dbo.Phienbanhethong', N'U') IS NULL
    CREATE TABLE dbo.Phienbanhethong (Phienban int NOT NULL PRIMARY KEY);
IF NOT EXISTS (SELECT 1 FROM dbo.Phienbanhethong)
    INSERT dbo.Phienbanhethong(Phienban) VALUES (1);
