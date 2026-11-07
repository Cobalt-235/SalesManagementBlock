IF NOT EXISTS(SELECT 1 FROM dbo.Sanpham)
BEGIN
    INSERT dbo.Sanpham(Ma,Ten,Theloai,Nentang,Nhaphathanh,Gianhap,Giaban,Tonkho,TonToithieu,Dangban,Mota) VALUES
    (N'GAME001',N'Minecraft Java & Bedrock',N'Sáng tạo',N'PC',N'Mojang',420000,599000,18,5,1,N'Game xây dựng thế giới mở; bản quyền PC.'),
    (N'GAME002',N'EA Sports FC 25',N'Thể thao',N'PS5',N'Electronic Arts',850000,1199000,8,5,1,N'Game bóng đá cho PlayStation 5.'),
    (N'GAME003',N'Elden Ring',N'Nhập vai',N'PC',N'Bandai Namco',650000,899000,4,5,1,N'Game nhập vai hành động, phiên bản PC.'),
    (N'GAME004',N'Stardew Valley',N'Mô phỏng',N'PC',N'ConcernedApe',140000,220000,25,5,1,N'Xây dựng nông trại, chơi đơn hoặc nhiều người.'),
    (N'GAME005',N'The Legend of Zelda: Tears of the Kingdom',N'Phiêu lưu',N'Switch',N'Nintendo',1100000,1499000,6,3,1,N'Phiên bản Nintendo Switch.'),
    (N'GAME006',N'God of War Ragnarok',N'Hành động',N'PS5',N'Sony',900000,1299000,3,5,1,N'Phiêu lưu hành động trên PS5.'),
    (N'GAME007',N'It Takes Two',N'Phiêu lưu',N'PC',N'Electronic Arts',350000,550000,12,5,1,N'Game phối hợp dành cho hai người.'),
    (N'GAME008',N'Hollow Knight',N'Hành động',N'PC',N'Team Cherry',120000,199000,0,5,1,N'Cần nhập thêm hàng trước khi bán.');
    INSERT dbo.Lichsukho(SanphamId,Ngay,Loai,Soluong,Tonsau,Thamchieu,Ghichu)
    SELECT Id,DATEADD(hour,7,SYSUTCDATETIME()),N'Khởi tạo',Tonkho,Tonkho,N'DỮ LIỆU MẪU',N'Tồn đầu kỳ minh họa' FROM dbo.Sanpham;
END;
IF NOT EXISTS(SELECT 1 FROM dbo.Khachhang)
    INSERT dbo.Khachhang(Ma,Hoten,Dienthoai,Email,Diachi) VALUES
    (N'KH001',N'Nguyễn Minh Anh',N'0901234567',N'minhanh@example.com',N'TP. Hồ Chí Minh'),
    (N'KH002',N'Trần Gia Bảo',N'0912345678',N'giabao@example.com',N'Đà Nẵng'),
    (N'KH003',N'Lê Phương Linh',N'0987654321',N'phuonglinh@example.com',N'Hà Nội');
