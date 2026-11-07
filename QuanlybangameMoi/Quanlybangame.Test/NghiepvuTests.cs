using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quanlybangame.BLL;
using Quanlybangame.DAL;
using Quanlybangame.DTO;

namespace Quanlybangame.Tests;

[TestClass, TestCategory("Donvi")]
public sealed class NghiepvuTests
{
    private DalGia dal = null!;
    private CuahangBLL bll = null!;
    [TestInitialize] public void Khoitao() { dal = new(); bll = new(dal, NullLogger<CuahangBLL>.Instance); }
    private static SanphamDTO Game() => new() { Ma = " sp_01 ", Ten = " Elden Ring ", Theloai = " Nh?p vai ", Nentang = " PC ", Giaban = 500000, Tonkho = 3 };
    private static KhachhangDTO Khach() => new() { Ma = " kh001 ", Hoten = " Tr?n Tin ", Dienthoai = " 0901234567 ", Email = "tin@example.com" };
    private static YeucaubanDTO Don() => new() { Chitiet = [new() { SanphamId = 1, Dongia = 500000, Soluong = 2 }], Giamgia = 100000 };

    [TestMethod] public void ThemGame_ChuanhoaVaGoiDal() { var s = Game(); int id = bll.LuuSanpham(s); Assert.AreEqual(1, id); Assert.AreEqual("SP_01", dal.SanphamDaLuu!.Ma); Assert.AreEqual("Elden Ring", s.Ten); }
    [TestMethod] public void Game_ThieuTen_KhongGhiDal() { var s = Game(); s.Ten = " "; Assert.ThrowsException<ArgumentException>(() => bll.LuuSanpham(s)); Assert.AreEqual(0, dal.SolanGhi); }
    [TestMethod] public void Game_MaCoDau_BiTuChoi() { var s = Game(); s.Ma = "s?nph?m"; Assert.ThrowsException<ArgumentException>(() => bll.LuuSanpham(s)); }
    [DataTestMethod, DataRow(0), DataRow(-1), DataRow(1000000001)]
    public void Game_GiabanNgoaiMien_BiTuChoi(int gia) { var s = Game(); s.Giaban = gia; Assert.ThrowsException<ArgumentException>(() => bll.LuuSanpham(s)); }
    [TestMethod] public void Game_GiaLeDong_BiTuChoi() { var s = Game(); s.Giaban = 1.5m; Assert.ThrowsException<ArgumentException>(() => bll.LuuSanpham(s)); }
    [TestMethod] public void Game_TonAm_BiTuChoi() { var s = Game(); s.Tonkho = -1; Assert.ThrowsException<ArgumentException>(() => bll.LuuSanpham(s)); }
    [TestMethod] public void Game_Ton0VaGiaToida_HopLe() { var s = Game(); s.Tonkho = 0; s.Giaban = 1000000000; bll.LuuSanpham(s); Assert.AreEqual(1, dal.SolanGhi); }
    [TestMethod] public void SuaGame_ThieuRowversion_BiTuChoi() { var s = Game(); s.Id = 3; Assert.ThrowsException<ArgumentException>(() => bll.LuuSanpham(s)); }
    [TestMethod] public void SuaGame_CoRowversion_GiuNguyenPhienban() { var s = Game(); s.Id = 3; s.Phienban = [1, 2, 3, 4, 5, 6, 7, 8]; bll.LuuSanpham(s); CollectionAssert.AreEqual(s.Phienban, dal.SanphamDaLuu!.Phienban); }
    [TestMethod] public void SuaGame_XungdotDuLieu_KhongBaoThanhcong() { var s = Game(); dal.LoiKhiGhi = new InvalidOperationException("?a ??i d? li?u"); Assert.ThrowsException<InvalidOperationException>(() => bll.LuuSanpham(s)); Assert.AreEqual(0, dal.SolanGhi); }
    [TestMethod] public void XoaGame_ChuaChon_BiTuChoi() => Assert.ThrowsException<ArgumentException>(() => bll.XoaSanpham(Game()));
    [TestMethod] public void Khach_HopLe_ChuanhoaVaLuu() { var k = Khach(); bll.LuuKhachhang(k); Assert.AreEqual("KH001", dal.KhachDaLuu!.Ma); Assert.AreEqual("0901234567", k.Dienthoai); }
    [DataTestMethod, DataRow("123"), DataRow("+84901234567"), DataRow("09012abc67"), DataRow("090123456789")]
    public void Khach_DienthoaiSai_BiTuChoi(string so) { var k = Khach(); k.Dienthoai = so; Assert.ThrowsException<ArgumentException>(() => bll.LuuKhachhang(k)); }
    [TestMethod] public void Khach_EmailSai_BiTuChoi() { var k = Khach(); k.Email = "khong-co-at"; Assert.ThrowsException<ArgumentException>(() => bll.LuuKhachhang(k)); }
    [TestMethod] public void Khach_EmailTrong_DuocChapNhan() { var k = Khach(); k.Email = ""; bll.LuuKhachhang(k); Assert.AreEqual(1, dal.SolanGhi); }
    [TestMethod] public void Don_Rong_KhongGhi() { var y = Don(); y.Chitiet.Clear(); Assert.ThrowsException<ArgumentException>(() => bll.TaoHoadon(y)); Assert.AreEqual(0, dal.SolanGhi); }
    [TestMethod] public void Don_TrungGame_BiTuChoi() { var y = Don(); y.Chitiet.Add(new() { SanphamId = 1, Dongia = 500000, Soluong = 1 }); Assert.ThrowsException<ArgumentException>(() => bll.TaoHoadon(y)); }
    [DataTestMethod, DataRow(0), DataRow(-1), DataRow(100001)]
    public void Don_SoluongSai_BiTuChoi(int n) { var y = Don(); y.Chitiet[0].Soluong = n; Assert.ThrowsException<ArgumentException>(() => bll.TaoHoadon(y)); }
    [TestMethod] public void Don_GiamVuotTien_BiTuChoi() { var y = Don(); y.Giamgia = 1000001; Assert.ThrowsException<ArgumentException>(() => bll.TaoHoadon(y)); }
    [TestMethod] public void Don_GiamBangTien_DuocChapNhan() { var y = Don(); y.Giamgia = 1000000; Assert.AreEqual(9, bll.TaoHoadon(y)); }
    [TestMethod] public void Don_GiamAm_BiTuChoi() { var y = Don(); y.Giamgia = -1; Assert.ThrowsException<ArgumentException>(() => bll.TaoHoadon(y)); }
    [TestMethod] public void Don_GuidRong_BiTuChoi() { var y = Don(); y.YeucauId = Guid.Empty; Assert.ThrowsException<ArgumentException>(() => bll.TaoHoadon(y)); }
    [TestMethod] public void Don_HopLe_GiuGuidVaTaoMaBam() { var y = Don(); var id = y.YeucauId; bll.TaoHoadon(y); Assert.AreEqual(id, dal.YeucauDaLuu!.YeucauId); Assert.AreEqual(64, y.MaBam.Length); }
    [TestMethod] public void Don_DoiThutuDong_MaBamGiongNhau() { var y = Don(); y.Chitiet.Add(new() { SanphamId = 2, Dongia = 100, Soluong = 1 }); bll.TaoHoadon(y); string bam = y.MaBam; y.Chitiet.Reverse(); bll.TaoHoadon(y); Assert.AreEqual(bam, y.MaBam); }
    [TestMethod] public void Don_DoiSoluong_MaBamKhac() { var y = Don(); bll.TaoHoadon(y); string cu = y.MaBam; y.Chitiet[0].Soluong = 3; bll.TaoHoadon(y); Assert.AreNotEqual(cu, y.MaBam); }
    [TestMethod] public void Huy_ThieuLydo_BiTuChoi() => Assert.ThrowsException<ArgumentException>(() => bll.HuyHoadon(1, " "));
    [TestMethod] public void Huy_CoLydo_GoiDal() { bll.HuyHoadon(1, "Khach ??i y"); Assert.AreEqual(1, dal.SolanGhi); }
    [TestMethod] public void Nhap_Soluong0_BiTuChoi() => Assert.ThrowsException<ArgumentException>(() => bll.Nhapkho(new() { SanphamId = 1, Nhacungcap = "NCC" }));
    [TestMethod] public void Nhap_ThieuNhacungcap_BiTuChoi() => Assert.ThrowsException<ArgumentException>(() => bll.Nhapkho(new() { SanphamId = 1, Soluong = 1 }));
    [TestMethod] public void Nhap_HopLe_LuuVaCoMaBam() { var p = new NhapkhoDTO { SanphamId = 1, Soluong = 5, Dongia = 300000, Nhacungcap = " NCC " }; bll.Nhapkho(p); Assert.AreEqual("NCC", dal.PhieuDaLuu!.Nhacungcap); Assert.AreEqual(64, p.MaBam.Length); }
    [TestMethod] public void Doanhthu_KyRong_KhongChia0() { var b = bll.DocDoanhthu(new(2026, 1, 1), new(2026, 1, 3)); Assert.AreEqual(0m, b.Tongdoanhthu); Assert.AreEqual(0m, b.BinhquanHoadon); Assert.AreEqual(0m, b.BinhquanNgay); Assert.AreEqual(3, b.Chitiet.Count); }
    [TestMethod] public void Doanhthu_BinhquanNgay_TinhCaNgay0() { dal.Doanhthu = [new() { Ngay = new(2026, 1, 2), Sohoadon = 2, Doanhthu = 600000 }]; var b = bll.DocDoanhthu(new(2026, 1, 1), new(2026, 1, 3)); Assert.AreEqual(300000m, b.BinhquanHoadon); Assert.AreEqual(200000m, b.BinhquanNgay); Assert.AreEqual(0m, b.Chitiet[0].Doanhthu); }
    [TestMethod] public void Doanhthu_DaoNgay_BiTuChoi() => Assert.ThrowsException<ArgumentException>(() => bll.DocDoanhthu(new(2026, 1, 5), new(2026, 1, 1)));
    [TestMethod] public void Sql_TenDatabaseChuaLenh_BiTuChoi() => Assert.ThrowsException<ArgumentException>(() => SqlKetnoi.TaoChuoi(new() { Cosodulieu = "abc];DROP DATABASE master;--" }, ""));
    [TestMethod] public void Sql_MaychuDungYeuCau() { var c = CauhinhBLL.Doc(); Assert.AreEqual(@"LAPTOP-NDOLH29D\SQLEXPRESS01", c.Maychu); StringAssert.Contains(SqlKetnoi.TaoChuoi(c, ""), @"LAPTOP-NDOLH29D\SQLEXPRESS01"); }
    [TestMethod] public void Html_MahoaTenGameTranhChenHtml() { var h = new HoadonDTO { Khachhang = "<script>x</script>", Chitiet = [new() { Ten = "A & B", Dongia = 100, Soluong = 1 }] }; var html = XuatdulieuBLL.HtmlHoadon(h); Assert.IsFalse(html.Contains("<script>")); StringAssert.Contains(html, "&lt;script&gt;"); StringAssert.Contains(html, "A &amp; B"); }
    [TestMethod] public void Csv_ChanCongthucVaEscapeDauNgoac() { Assert.AreEqual("\"'=1+2\"", XuatdulieuBLL.OCSV("=1+2")); Assert.AreEqual("\"Game \"\"A\"\"\"", XuatdulieuBLL.OCSV("Game \"A\"")); }
    [TestMethod]
    public void Logging_GhiThongtinThanhcongVaCanhbaoDulieu()
    {
        var log = new LogGom(); var dv = new CuahangBLL(dal, log); dv.LuuSanpham(Game());
        var s = Game(); s.Ten = ""; Assert.ThrowsException<ArgumentException>(() => dv.LuuSanpham(s));
        CollectionAssert.Contains(log.Muc, LogLevel.Information); CollectionAssert.Contains(log.Muc, LogLevel.Warning);
    }
    private sealed class LogGom : ILogger<CuahangBLL>
    {
        public List<LogLevel> Muc { get; } = [];
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;
        public bool IsEnabled(LogLevel level) => true;
        public void Log<TState>(LogLevel level, EventId id, TState state, Exception? e, Func<TState, Exception?, string> formatter) => Muc.Add(level);
    }
}
