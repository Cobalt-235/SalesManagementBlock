using System.Data;
using Microsoft.Data.SqlClient;
using Quanlybangame.DTO;

namespace Quanlybangame.DAL;

public sealed class CuahangDAL(string chuoiketnoi) : ICuahangDAL
{
    private SqlConnection Mo() { var c = new SqlConnection(chuoiketnoi); c.Open(); return c; }

    private static SqlCommand Lenh(SqlConnection c, SqlTransaction? t, string sql, params (string Ten, object? Gia)[] giatri)
    {
        var l = new SqlCommand(sql, c, t) { CommandTimeout = 30 };
        foreach (var (ten, gia) in giatri)
        {
            var p = gia switch
            {
                int => new SqlParameter(ten, SqlDbType.Int),
                bool => new SqlParameter(ten, SqlDbType.Bit),
                decimal => new SqlParameter(ten, SqlDbType.Decimal) { Precision = 18, Scale = 0 },
                DateTime => new SqlParameter(ten, SqlDbType.DateTime2),
                Guid => new SqlParameter(ten, SqlDbType.UniqueIdentifier),
                byte[] b => new SqlParameter(ten, SqlDbType.VarBinary, Math.Max(1, b.Length)),
                null => new SqlParameter(ten, SqlDbType.Int),
                _ => new SqlParameter(ten, SqlDbType.NVarChar, -1)
            };
            p.Value = gia ?? DBNull.Value; l.Parameters.Add(p);
        }
        return l;
    }

    private static List<T> Danhsach<T>(SqlCommand l, Func<SqlDataReader, T> doc)
    {
        using (l) using (var r = l.ExecuteReader())
        {
            var kq = new List<T>(); while (r.Read()) kq.Add(doc(r)); return kq;
        }
    }
    private static int Chay(SqlCommand l) { using (l) return l.ExecuteNonQuery(); }
    private static object? Mot(SqlCommand l) { using (l) return l.ExecuteScalar(); }
    private static T AnToan<T>(Func<T> tacvu)
    {
        try { return tacvu(); }
        catch (SqlException e) when (e.Number is 2601 or 2627) { throw new InvalidOperationException("Mã hoặc số điện thoại đã tồn tại. Vui lòng nhập giá trị khác.", e); }
        catch (SqlException e) when (e.Number == 547) { throw new InvalidOperationException("Dữ liệu đang được sử dụng hoặc không thỏa điều kiện lưu. Hãy tải lại danh sách.", e); }
        catch (SqlException e) when (e.Number == 1205) { throw new InvalidOperationException("Có người khác đang thao tác cùng dữ liệu. Vui lòng tải lại và thử lại.", e); }
    }
    private static void Thaydoi(int n) { if (n == 0) throw new InvalidOperationException("Dữ liệu đã được thay đổi hoặc xóa ở cửa sổ khác. Hãy tải lại danh sách rồi sửa lại."); }
    private static DateTime GioVN => DateTime.UtcNow.AddHours(7);
    private static SanphamDTO Sanpham(SqlDataReader r) => new()
    {
        Id = (int)r["Id"],
        Ma = (string)r["Ma"],
        Ten = (string)r["Ten"],
        Theloai = (string)r["Theloai"],
        Nentang = (string)r["Nentang"],
        Nhaphathanh = (string)r["Nhaphathanh"],
        Gianhap = (decimal)r["Gianhap"],
        Giaban = (decimal)r["Giaban"],
        Tonkho = (int)r["Tonkho"],
        TonToithieu = (int)r["TonToithieu"],
        Dangban = (bool)r["Dangban"],
        Mota = (string)r["Mota"],
        Phienban = (byte[])r["Phienban"]
    };
    private static KhachhangDTO Khachhang(SqlDataReader r) => new()
    {
        Id = (int)r["Id"],
        Ma = (string)r["Ma"],
        Hoten = (string)r["Hoten"],
        Dienthoai = (string)r["Dienthoai"],
        Email = (string)r["Email"],
        Diachi = (string)r["Diachi"],
        Phienban = (byte[])r["Phienban"]
    };
    private static HoadonDTO Hoadon(SqlDataReader r) => new()
    {
        Id = (int)r["Id"],
        Ngaylap = (DateTime)r["Ngaylap"],
        Khachhang = (string)r["Khachhang"],
        Dienthoai = (string)r["Dienthoai"],
        Tamtinh = (decimal)r["Tamtinh"],
        Giamgia = (decimal)r["Giamgia"],
        Tongtien = (decimal)r["Tongtien"],
        Trangthai = (string)r["Trangthai"],
        Ghichu = (string)r["Ghichu"],
        LydoHuy = (string)r["LydoHuy"]
    };

    public List<SanphamDTO> TimSanpham(string tukhoa, bool chiconhang = false)
    {
        using var c = Mo();
        return Danhsach(Lenh(c, null, "SELECT * FROM dbo.Sanpham WHERE (@q=N'' OR CHARINDEX(@q,Ma)>0 OR CHARINDEX(@q,Ten)>0 OR CHARINDEX(@q,Theloai)>0 OR CHARINDEX(@q,Nentang)>0) AND (@con=0 OR (Dangban=1 AND Tonkho>0)) ORDER BY Ma;", ("@q", tukhoa), ("@con", chiconhang)), Sanpham);
    }
    public int LuuSanpham(SanphamDTO s) => AnToan(() =>
    {
        using var c = Mo(); using var t = c.BeginTransaction();
        var p = new (string, object?)[] { ("@ma", s.Ma), ("@ten", s.Ten), ("@tl", s.Theloai), ("@nt", s.Nentang), ("@nph", s.Nhaphathanh), ("@gn", s.Gianhap), ("@gb", s.Giaban), ("@ton", s.Tonkho), ("@min", s.TonToithieu), ("@ban", s.Dangban), ("@mt", s.Mota), ("@id", s.Id), ("@v", s.Phienban) };
        int id = s.Id;
        if (s.Id == 0)
        {
            id = Convert.ToInt32(Mot(Lenh(c, t, "INSERT dbo.Sanpham(Ma,Ten,Theloai,Nentang,Nhaphathanh,Gianhap,Giaban,Tonkho,TonToithieu,Dangban,Mota) VALUES(@ma,@ten,@tl,@nt,@nph,@gn,@gb,@ton,@min,@ban,@mt); SELECT CAST(SCOPE_IDENTITY() AS int);", p)));
            Ghikho(c, t, id, "Khởi tạo", s.Tonkho, s.Tonkho, s.Ma, "Tồn đầu kỳ khi thêm game");
        }
        else Thaydoi(Chay(Lenh(c, t, "UPDATE dbo.Sanpham SET Ma=@ma,Ten=@ten,Theloai=@tl,Nentang=@nt,Nhaphathanh=@nph,Gianhap=@gn,Giaban=@gb,TonToithieu=@min,Dangban=@ban,Mota=@mt WHERE Id=@id AND Phienban=@v;", p)));
        t.Commit(); return id;
    });
    public void XoaSanpham(SanphamDTO s) => AnToan(() =>
    {
        using var c = Mo(); using var t = c.BeginTransaction(IsolationLevel.Serializable);
        var v = Mot(Lenh(c, t, "SELECT Phienban FROM dbo.Sanpham WITH(UPDLOCK,HOLDLOCK) WHERE Id=@id;", ("@id", s.Id))) as byte[];
        if (v == null || !v.SequenceEqual(s.Phienban)) Thaydoi(0);
        var dung = Convert.ToInt32(Mot(Lenh(c, t, "SELECT (SELECT COUNT(*) FROM dbo.Chitiethoadon WHERE SanphamId=@id)+(SELECT COUNT(*) FROM dbo.Phieunhap WHERE SanphamId=@id);", ("@id", s.Id))));
        if (dung > 0) throw new InvalidOperationException("Game đã có hóa đơn hoặc phiếu nhập. Hãy chọn Cập nhật và bỏ chọn Đang bán để giữ lịch sử.");
        Chay(Lenh(c, t, "DELETE dbo.Lichsukho WHERE SanphamId=@id; DELETE dbo.Sanpham WHERE Id=@id AND Phienban=@v;", ("@id", s.Id), ("@v", s.Phienban)));
        t.Commit(); return 0;
    });
    public List<KhachhangDTO> TimKhachhang(string tukhoa)
    {
        using var c = Mo();
        return Danhsach(Lenh(c, null, "SELECT * FROM dbo.Khachhang WHERE @q=N'' OR CHARINDEX(@q,Ma)>0 OR CHARINDEX(@q,Hoten)>0 OR CHARINDEX(@q,Dienthoai)>0 ORDER BY Ma;", ("@q", tukhoa)), Khachhang);
    }
    public int LuuKhachhang(KhachhangDTO k) => AnToan(() =>
    {
        using var c = Mo();
        var p = new (string, object?)[] { ("@id", k.Id), ("@ma", k.Ma), ("@ten", k.Hoten), ("@dt", k.Dienthoai), ("@email", k.Email), ("@dc", k.Diachi), ("@v", k.Phienban) };
        if (k.Id == 0) return Convert.ToInt32(Mot(Lenh(c, null, "INSERT dbo.Khachhang(Ma,Hoten,Dienthoai,Email,Diachi) VALUES(@ma,@ten,@dt,@email,@dc); SELECT CAST(SCOPE_IDENTITY() AS int);", p)));
        Thaydoi(Chay(Lenh(c, null, "UPDATE dbo.Khachhang SET Ma=@ma,Hoten=@ten,Dienthoai=@dt,Email=@email,Diachi=@dc WHERE Id=@id AND Phienban=@v;", p))); return k.Id;
    });
    public void XoaKhachhang(KhachhangDTO k) => AnToan(() =>
    {
        using var c = Mo();
        Thaydoi(Chay(Lenh(c, null, "DELETE dbo.Khachhang WHERE Id=@id AND Phienban=@v;", ("@id", k.Id), ("@v", k.Phienban)))); return 0;
    });
    public List<HoadonDTO> TimHoadon(DateTime tungay, DateTime denngay, string tukhoa, int? khachhangId = null)
    {
        using var c = Mo();
        return Danhsach(Lenh(c, null, "SELECT * FROM dbo.Hoadon WHERE Ngaylap>=@tu AND Ngaylap<@den AND (@kh IS NULL OR KhachhangId=@kh) AND (@q=N'' OR CHARINDEX(@q,Khachhang)>0 OR CHARINDEX(@q,Dienthoai)>0 OR CHARINDEX(@q,N'HD'+RIGHT(N'000000'+CONVERT(nvarchar(20),Id),6))>0) ORDER BY Id DESC;", ("@tu", tungay.Date), ("@den", denngay.Date.AddDays(1)), ("@kh", khachhangId), ("@q", tukhoa)), Hoadon);
    }
    public HoadonDTO DocHoadon(int id)
    {
        using var c = Mo();
        using var t = c.BeginTransaction(IsolationLevel.RepeatableRead);
        var h = Danhsach(Lenh(c, t, "SELECT * FROM dbo.Hoadon WHERE Id=@id;", ("@id", id)), Hoadon).SingleOrDefault() ?? throw new InvalidOperationException("Không tìm thấy hóa đơn.");
        h.Chitiet = Danhsach(Lenh(c, t, "SELECT * FROM dbo.Chitiethoadon WHERE HoadonId=@id ORDER BY SanphamId;", ("@id", id)), r => new DongbanDTO { SanphamId = (int)r["SanphamId"], Ma = (string)r["Ma"], Ten = (string)r["Ten"], Dongia = (decimal)r["Dongia"], Soluong = (int)r["Soluong"] });
        t.Commit(); return h;
    }
    private static void Ghikho(SqlConnection c, SqlTransaction t, int id, string loai, int sl, int ton, string tc, string ghichu)
        => Chay(Lenh(c, t, "INSERT dbo.Lichsukho(SanphamId,Ngay,Loai,Soluong,Tonsau,Thamchieu,Ghichu) VALUES(@id,@ngay,@loai,@sl,@ton,@tc,@gc);", ("@id", id), ("@ngay", GioVN), ("@loai", loai), ("@sl", sl), ("@ton", ton), ("@tc", tc), ("@gc", ghichu)));

    public int TaoHoadon(YeucaubanDTO y) => AnToan(() =>
    {
        using var c = Mo(); using var t = c.BeginTransaction(IsolationLevel.Serializable);
        var cu = Danhsach(Lenh(c, t, "SELECT Id,MaBam,Trangthai FROM dbo.Hoadon WITH(UPDLOCK,HOLDLOCK) WHERE YeucauId=@y;", ("@y", y.YeucauId)), r => (Id: (int)r["Id"], Bam: (string)r["MaBam"], Trangthai: (string)r["Trangthai"]));
        if (cu.Count > 0)
        {
            if (cu[0].Bam != y.MaBam) throw new InvalidOperationException($"Yêu cầu này đã tạo hóa đơn HD{cu[0].Id:000000} với nội dung khác. Hãy mở hóa đơn đó kiểm tra trước khi tạo hóa đơn mới.");
            if (cu[0].Trangthai == "Đã hủy") throw new InvalidOperationException("Hóa đơn của yêu cầu này đã hủy. Hãy đóng cửa sổ và tạo hóa đơn mới.");
            t.Commit(); return cu[0].Id;
        }
        var kh = y.KhachhangId.HasValue ? Danhsach(Lenh(c, t, "SELECT * FROM dbo.Khachhang WHERE Id=@id;", ("@id", y.KhachhangId)), Khachhang).SingleOrDefault() ?? throw new InvalidOperationException("Khách hàng không còn tồn tại.") : null;
        var game = new Dictionary<int, SanphamDTO>();
        foreach (var d in y.Chitiet.OrderBy(x => x.SanphamId))
        {
            var s = Danhsach(Lenh(c, t, "SELECT * FROM dbo.Sanpham WITH(UPDLOCK,HOLDLOCK) WHERE Id=@id;", ("@id", d.SanphamId)), Sanpham).SingleOrDefault() ?? throw new InvalidOperationException("Một game đã bị xóa. Hãy tải lại danh sách.");
            if (!s.Dangban || s.Tonkho < d.Soluong) throw new InvalidOperationException($"{s.Ten}: không đủ hàng hoặc đã ngừng bán (tồn {s.Tonkho}).");
            if (s.Giaban != d.Dongia) throw new InvalidOperationException($"Giá {s.Ten} vừa thay đổi. Hãy tải lại game và thêm lại vào giỏ.");
            game.Add(s.Id, s);
        }
        decimal tamtinh = y.Chitiet.Sum(x => x.Thanhtien);
        int hd = Convert.ToInt32(Mot(Lenh(c, t, "INSERT dbo.Hoadon(YeucauId,MaBam,Ngaylap,KhachhangId,Khachhang,Dienthoai,Tamtinh,Giamgia,Tongtien,Trangthai,Ghichu) VALUES(@y,@bam,@ngay,@kh,@ten,@dt,@tam,@giam,@tong,N'Đã thanh toán',@gc); SELECT CAST(SCOPE_IDENTITY() AS int);", ("@y", y.YeucauId), ("@bam", y.MaBam), ("@ngay", GioVN), ("@kh", y.KhachhangId), ("@ten", kh?.Hoten ?? "Khách lẻ"), ("@dt", kh?.Dienthoai ?? ""), ("@tam", tamtinh), ("@giam", y.Giamgia), ("@tong", tamtinh - y.Giamgia), ("@gc", y.Ghichu))));
        foreach (var d in y.Chitiet.OrderBy(x => x.SanphamId))
        {
            var s = game[d.SanphamId];
            Chay(Lenh(c, t, "INSERT dbo.Chitiethoadon(HoadonId,SanphamId,Ma,Ten,Dongia,Soluong) VALUES(@hd,@sp,@ma,@ten,@gia,@sl); UPDATE dbo.Sanpham SET Tonkho=Tonkho-@sl WHERE Id=@sp;", ("@hd", hd), ("@sp", s.Id), ("@ma", s.Ma), ("@ten", s.Ten), ("@gia", s.Giaban), ("@sl", d.Soluong)));
            Ghikho(c, t, s.Id, "Bán hàng", -d.Soluong, s.Tonkho - d.Soluong, $"HD{hd:000000}", y.Ghichu);
        }
        t.Commit(); return hd;
    });
    public void HuyHoadon(int id, string lydo) => AnToan(() =>
    {
        using var c = Mo(); using var t = c.BeginTransaction(IsolationLevel.Serializable);
        var tt = Convert.ToString(Mot(Lenh(c, t, "SELECT Trangthai FROM dbo.Hoadon WITH(UPDLOCK,HOLDLOCK) WHERE Id=@id;", ("@id", id))));
        if (string.IsNullOrEmpty(tt)) throw new InvalidOperationException("Không tìm thấy hóa đơn.");
        if (tt == "Đã hủy") throw new InvalidOperationException("Hóa đơn đã được hủy trước đó; tồn kho không thay đổi.");
        var dong = Danhsach(Lenh(c, t, "SELECT SanphamId,Soluong FROM dbo.Chitiethoadon WHERE HoadonId=@id ORDER BY SanphamId;", ("@id", id)), r => (Id: (int)r["SanphamId"], Sl: (int)r["Soluong"]));
        foreach (var d in dong)
        {
            int ton = Convert.ToInt32(Mot(Lenh(c, t, "UPDATE dbo.Sanpham SET Tonkho=Tonkho+@sl OUTPUT inserted.Tonkho WHERE Id=@sp;", ("@sl", d.Sl), ("@sp", d.Id))));
            Ghikho(c, t, d.Id, "Hủy hóa đơn", d.Sl, ton, $"HD{id:000000}", lydo);
        }
        Chay(Lenh(c, t, "UPDATE dbo.Hoadon SET Trangthai=N'Đã hủy',LydoHuy=@ld,Ngayhuy=@ngay WHERE Id=@id;", ("@ld", lydo), ("@ngay", GioVN), ("@id", id)));
        t.Commit(); return 0;
    });
    public void Nhapkho(NhapkhoDTO p) => AnToan(() =>
    {
        using var c = Mo(); using var t = c.BeginTransaction(IsolationLevel.Serializable);
        var cu = Convert.ToString(Mot(Lenh(c, t, "SELECT MaBam FROM dbo.Phieunhap WITH(UPDLOCK,HOLDLOCK) WHERE YeucauId=@y;", ("@y", p.YeucauId))));
        if (!string.IsNullOrEmpty(cu))
        {
            if (cu != p.MaBam) throw new InvalidOperationException("Phiếu nhập của yêu cầu này đã lưu với nội dung khác. Hãy kiểm tra lịch sử kho.");
            t.Commit(); return 0;
        }
        int? ton = Mot(Lenh(c, t, "SELECT Tonkho FROM dbo.Sanpham WITH(UPDLOCK,HOLDLOCK) WHERE Id=@id;", ("@id", p.SanphamId))) as int?;
        if (!ton.HasValue) throw new InvalidOperationException("Không tìm thấy game để nhập kho.");
        if (ton > 1000000 - p.Soluong) throw new InvalidOperationException("Tồn kho sau nhập vượt 1.000.000 đơn vị.");
        int pn = Convert.ToInt32(Mot(Lenh(c, t, "INSERT dbo.Phieunhap(YeucauId,MaBam,SanphamId,Ngay,Soluong,Dongia,Nhacungcap,Ghichu) VALUES(@y,@bam,@id,@ngay,@sl,@gia,@ncc,@gc); SELECT CAST(SCOPE_IDENTITY() AS int);", ("@y", p.YeucauId), ("@bam", p.MaBam), ("@id", p.SanphamId), ("@ngay", GioVN), ("@sl", p.Soluong), ("@gia", p.Dongia), ("@ncc", p.Nhacungcap), ("@gc", p.Ghichu))));
        Chay(Lenh(c, t, "UPDATE dbo.Sanpham SET Tonkho=Tonkho+@sl,Gianhap=@gia WHERE Id=@id;", ("@sl", p.Soluong), ("@gia", p.Dongia), ("@id", p.SanphamId)));
        Ghikho(c, t, p.SanphamId, "Nhập kho", p.Soluong, ton.Value + p.Soluong, $"PN{pn:000000}", $"{p.Nhacungcap} • {p.Ghichu}".Trim(' ', '•'));
        t.Commit(); return 0;
    });
    public List<LichsukhoDTO> DocLichsukho(int? sanphamId)
    {
        using var c = Mo();
        return Danhsach(Lenh(c, null, "SELECT TOP(1000) l.*,s.Ma,s.Ten FROM dbo.Lichsukho l INNER JOIN dbo.Sanpham s ON s.Id=l.SanphamId WHERE @id IS NULL OR l.SanphamId=@id ORDER BY l.Id DESC;", ("@id", sanphamId)), r => new LichsukhoDTO { Ngay = (DateTime)r["Ngay"], Ma = (string)r["Ma"], Ten = (string)r["Ten"], Loai = (string)r["Loai"], Soluong = (int)r["Soluong"], Tonsau = (int)r["Tonsau"], Thamchieu = (string)r["Thamchieu"], Ghichu = (string)r["Ghichu"] });
    }
    public List<DoanhthuNgayDTO> DocDoanhthu(DateTime tungay, DateTime denngay)
    {
        using var c = Mo();
        return Danhsach(Lenh(c, null, "SELECT CAST(Ngaylap AS date) AS Ngay,COUNT(*) AS Sohoadon,SUM(Tongtien) AS Doanhthu FROM dbo.Hoadon WHERE Trangthai=N'Đã thanh toán' AND Ngaylap>=@tu AND Ngaylap<@den GROUP BY CAST(Ngaylap AS date) ORDER BY Ngay;", ("@tu", tungay.Date), ("@den", denngay.Date.AddDays(1))), r => new DoanhthuNgayDTO { Ngay = (DateTime)r["Ngay"], Sohoadon = (int)r["Sohoadon"], Doanhthu = (decimal)r["Doanhthu"] });
    }
}
