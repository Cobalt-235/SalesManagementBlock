using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quanlybangame.BLL;
using Quanlybangame.DAL;
using Quanlybangame.DTO;

namespace Quanlybangame.Tests;

// Chạy riêng với GAME_SQL_SERVER. Database tạm có tên ngẫu nhiên, được xóa sau kiểm thử.
[TestClass, TestCategory("Tichhop"), DoNotParallelize]
public sealed class SqlTichhopTests
{
    private static readonly CauhinhDTO cauhinh = new() { Cosodulieu = "GameTest_" + Guid.NewGuid().ToString("N")[..12] };
    private static CuahangBLL bll = null!;
    private static string matkhau = "";
    private static bool daduocTao;
    [ClassInitialize]
    public static void Khoitao(TestContext context)
    {
        string? server = Environment.GetEnvironmentVariable("GAME_SQL_SERVER");
        if (string.IsNullOrWhiteSpace(server)) Assert.Inconclusive("Chỉ chạy khi đặt GAME_SQL_SERVER. Kiểm thử này cần SQL Server thực trên Windows/mạng.");
        cauhinh.Maychu = server!;
        string? user = Environment.GetEnvironmentVariable("GAME_SQL_USER");
        cauhinh.XacthucWindows = string.IsNullOrEmpty(user); cauhinh.Taikhoan = user ?? "";
        matkhau = Environment.GetEnvironmentVariable("GAME_SQL_PASSWORD") ?? "";
        SqlKetnoi.Khoitao(cauhinh, matkhau, false); daduocTao = true;
        bll = CauhinhBLL.Ketnoi(cauhinh, matkhau, NullLogger<CuahangBLL>.Instance);
    }
    [ClassCleanup]
    public static void Dondep()
    {
        if (!daduocTao) return;
        SqlConnection.ClearAllPools();
        using var c = new SqlConnection(SqlKetnoi.TaoChuoi(cauhinh, matkhau, true)); c.Open();
        // Tên do chương trình sinh, chỉ có ký tự [A-Za-z0-9_], không lấy từ người dùng.
        using var l = new SqlCommand($"ALTER DATABASE [{cauhinh.Cosodulieu}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE [{cauhinh.Cosodulieu}];", c); l.ExecuteNonQuery();
    }
    private static SanphamDTO TaoGame(int ton = 5)
    {
        string ma = "T" + Guid.NewGuid().ToString("N")[..12];
        bll.LuuSanpham(new() { Ma = ma, Ten = "Game ' đặc biệt", Theloai = "Nhập vai", Nentang = "PC", Giaban = 100000, Tonkho = ton });
        return bll.TimSanpham(ma).Single();
    }
    private static YeucaubanDTO Don(SanphamDTO s, int sl = 2) => new() { Giamgia = 10000, Chitiet = [new() { SanphamId = s.Id, Dongia = s.Giaban, Soluong = sl }] };
    private static SanphamDTO Doc(SanphamDTO s) => bll.TimSanpham(s.Ma).Single();
    [TestMethod]
    public void Ban_CommitHoadonVaTruKho()
    {
        var s = TaoGame(); int id = bll.TaoHoadon(Don(s)); var h = bll.DocHoadon(id);
        Assert.AreEqual(3, Doc(s).Tonkho); Assert.AreEqual(190000m, h.Tongtien); Assert.AreEqual(1, h.Chitiet.Count);
        Assert.AreEqual(-2, bll.DocLichsukho(s.Id).First().Soluong);
    }
    [TestMethod]
    public void Ban_ThieuHang_RollbackToanBo()
    {
        var s = TaoGame(1); var y = Don(s, 2); Assert.ThrowsException<InvalidOperationException>(() => bll.TaoHoadon(y));
        Assert.AreEqual(1, Doc(s).Tonkho); Assert.AreEqual(1, bll.DocLichsukho(s.Id).Count);
    }
    [TestMethod]
    public void Ban_GuiLaiCungGuid_KhongTruKhoLanHai()
    {
        var s = TaoGame(); var y = Don(s); int lan1 = bll.TaoHoadon(y), lan2 = bll.TaoHoadon(y);
        Assert.AreEqual(lan1, lan2); Assert.AreEqual(3, Doc(s).Tonkho); Assert.AreEqual(2, bll.DocLichsukho(s.Id).Count);
    }
    [TestMethod]
    public void Ban_CungGuidNoidungKhac_BiTuChoi()
    {
        var s = TaoGame(); var y = Don(s); bll.TaoHoadon(y); y.Chitiet[0].Soluong = 1;
        Assert.ThrowsException<InvalidOperationException>(() => bll.TaoHoadon(y)); Assert.AreEqual(3, Doc(s).Tonkho);
    }
    [TestMethod]
    public void Huy_HoanKhoDungMotLanVaLoaiDoanhthu()
    {
        var s = TaoGame(); var y = Don(s); int id = bll.TaoHoadon(y);
        DateTime ngay = DateTime.UtcNow.AddHours(7).Date; decimal truoc = bll.DocDoanhthu(ngay, ngay).Tongdoanhthu;
        bll.HuyHoadon(id, "Kiểm thử hủy");
        Assert.AreEqual(5, Doc(s).Tonkho); Assert.AreEqual("Đã hủy", bll.DocHoadon(id).Trangthai);
        Assert.AreEqual(truoc - 190000m, bll.DocDoanhthu(ngay, ngay).Tongdoanhthu);
        Assert.ThrowsException<InvalidOperationException>(() => bll.HuyHoadon(id, "Hủy lại")); Assert.AreEqual(5, Doc(s).Tonkho);
    }
    [TestMethod]
    public void Ban_GiaVuaDoi_BiTuChoi()
    {
        var s = TaoGame(); var y = Don(s); s.Giaban += 1000; bll.LuuSanpham(s);
        Assert.ThrowsException<InvalidOperationException>(() => bll.TaoHoadon(y)); Assert.AreEqual(5, Doc(s).Tonkho);
    }
    [TestMethod]
    public void Nhap_GuiLap_KhongCongHaiLan()
    {
        var s = TaoGame(); var p = new NhapkhoDTO { SanphamId = s.Id, Soluong = 3, Dongia = 50000, Nhacungcap = "NCC ' kiểm thử" };
        bll.Nhapkho(p); bll.Nhapkho(p); Assert.AreEqual(8, Doc(s).Tonkho); Assert.AreEqual(50000m, Doc(s).Gianhap);
        p.Soluong = 4; Assert.ThrowsException<InvalidOperationException>(() => bll.Nhapkho(p)); Assert.AreEqual(8, Doc(s).Tonkho);
    }
    [TestMethod]
    public void Sua_RowversionCu_KhongGhiDe()
    {
        var s = TaoGame(); var cu = Doc(s); s.Ten = "Tên mới"; bll.LuuSanpham(s); cu.Ten = "Ghi đè";
        Assert.ThrowsException<InvalidOperationException>(() => bll.LuuSanpham(cu)); Assert.AreEqual("Tên mới", Doc(s).Ten);
    }
    [TestMethod]
    public void Xoa_GameDaBan_GiuLichsu()
    {
        var s = TaoGame(); bll.TaoHoadon(Don(s)); s = Doc(s);
        Assert.ThrowsException<InvalidOperationException>(() => bll.XoaSanpham(s)); Assert.AreEqual(1, bll.TimSanpham(s.Ma).Count);
    }
    [TestMethod]
    public void Timkiem_DauNhayKhongLamHongSql()
    {
        var s = TaoGame(); Assert.IsTrue(bll.TimSanpham("' đặc biệt").Any(x => x.Id == s.Id));
        Assert.AreEqual(0, bll.TimSanpham("'; DROP TABLE Sanpham;--").Count); Assert.AreEqual(5, Doc(s).Tonkho);
    }
    [TestMethod]
    public void Hoadon_GiuTenKhachTaiThoiDiemMua()
    {
        var s = TaoGame(); string ma = "K" + Guid.NewGuid().ToString("N")[..12];
        string so = "0" + Random.Shared.NextInt64(100000000, 999999999);
        int kh = bll.LuuKhachhang(new() { Ma = ma, Hoten = "Tên ban đầu", Dienthoai = so }); var y = Don(s); y.KhachhangId = kh;
        int hd = bll.TaoHoadon(y); var k = bll.TimKhachhang(ma).Single(); k.Hoten = "Tên đã sửa"; bll.LuuKhachhang(k);
        Assert.AreEqual("Tên ban đầu", bll.DocHoadon(hd).Khachhang);
    }
}
