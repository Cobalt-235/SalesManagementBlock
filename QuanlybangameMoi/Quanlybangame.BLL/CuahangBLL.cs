using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using Quanlybangame.DAL;
using Quanlybangame.DTO;

namespace Quanlybangame.BLL;

// UI chỉ gọi BLL. Quy tắc kiểm tra dữ liệu nằm ở đây, không nằm trong sự kiện nút bấm.
public sealed partial class CuahangBLL(ICuahangDAL dal, ILogger<CuahangBLL> log)
{
    [GeneratedRegex("^[A-Za-z0-9_-]{1,30}$")] private static partial Regex MaHopLe();
    [GeneratedRegex("^0[0-9]{9,10}$")] private static partial Regex SoDienthoai();
    public static string Chuanhoa(string? s) => (s ?? "").Trim();
    private static void Chuoi(string s, string ten, int max, bool batbuoc = false)
    {
        if (batbuoc && string.IsNullOrWhiteSpace(s)) throw new ArgumentException($"Vui lòng nhập {ten}.");
        if (s.Length > max) throw new ArgumentException($"{ten} tối đa {max} ký tự.");
    }
    private static void Ma(string ma) { if (!MaHopLe().IsMatch(ma)) throw new ArgumentException("Mã gồm 1–30 ký tự không dấu: chữ, số, gạch ngang hoặc gạch dưới."); }
    private static void Tien(decimal gia, string ten, bool cho0 = true)
    {
        if (gia < (cho0 ? 0 : 1) || gia > 1000000000m || decimal.Truncate(gia) != gia) throw new ArgumentException($"{ten} phải là số nguyên từ {(cho0 ? "0" : "1")} đến 1.000.000.000 đồng.");
    }
    private T Thucthi<T>(string tacvu, Func<T> f)
    {
        try { return f(); }
        catch (ArgumentException e) { log.LogWarning("Kiểm tra dữ liệu thất bại: {Tacvu}. {Lydo}", tacvu, e.Message); throw; }
        catch (InvalidOperationException e) { log.LogWarning(e, "Không thể thực hiện {Tacvu}", tacvu); throw; }
        catch (Exception e) { log.LogError(e, "Lỗi khi {Tacvu}", tacvu); throw; }
    }

    public List<SanphamDTO> TimSanpham(string tukhoa = "", bool chiconhang = false) => Thucthi("tìm sản phẩm", () => dal.TimSanpham(Chuanhoa(tukhoa), chiconhang));
    public int LuuSanpham(SanphamDTO s) => Thucthi("lưu sản phẩm", () =>
    {
        s.Ma = Chuanhoa(s.Ma).ToUpperInvariant(); s.Ten = Chuanhoa(s.Ten); s.Theloai = Chuanhoa(s.Theloai);
        s.Nentang = Chuanhoa(s.Nentang); s.Nhaphathanh = Chuanhoa(s.Nhaphathanh); s.Mota = Chuanhoa(s.Mota);
        Ma(s.Ma); Chuoi(s.Ten, "tên game", 150, true); Chuoi(s.Theloai, "thể loại", 80, true);
        Chuoi(s.Nentang, "nền tảng", 50, true); Chuoi(s.Nhaphathanh, "nhà phát hành", 100); Chuoi(s.Mota, "mô tả", 1000);
        Tien(s.Gianhap, "Giá nhập"); Tien(s.Giaban, "Giá bán", false);
        if (s.Tonkho < 0 || s.Id == 0 && s.Tonkho > 1000000 || s.TonToithieu < 0 || s.TonToithieu > 1000000) throw new ArgumentException("Tồn đầu kỳ và ngưỡng cảnh báo phải từ 0 đến 1.000.000.");
        if (s.Id < 0 || s.Id > 0 && s.Phienban.Length != 8) throw new ArgumentException("Phiên bản game không hợp lệ. Hãy tải lại danh sách.");
        int id = dal.LuuSanpham(s); log.LogInformation("{Tacvu} sản phẩm {Ma}, Id {Id}", s.Id == 0 ? "Thêm" : "Cập nhật", s.Ma, id); return id;
    });
    public void XoaSanpham(SanphamDTO s) => Thucthi("xóa sản phẩm", () =>
    {
        if (s.Id <= 0 || s.Phienban.Length != 8) throw new ArgumentException("Vui lòng chọn game trong danh sách.");
        dal.XoaSanpham(s); log.LogInformation("Xóa sản phẩm {Ma}, Id {Id}", s.Ma, s.Id); return 0;
    });
    public List<KhachhangDTO> TimKhachhang(string tukhoa = "") => Thucthi("tìm khách hàng", () => dal.TimKhachhang(Chuanhoa(tukhoa)));
    public int LuuKhachhang(KhachhangDTO k) => Thucthi("lưu khách hàng", () =>
    {
        k.Ma = Chuanhoa(k.Ma).ToUpperInvariant(); k.Hoten = Chuanhoa(k.Hoten); k.Dienthoai = Chuanhoa(k.Dienthoai); k.Email = Chuanhoa(k.Email); k.Diachi = Chuanhoa(k.Diachi);
        Ma(k.Ma); Chuoi(k.Hoten, "họ tên", 100, true); Chuoi(k.Email, "email", 150); Chuoi(k.Diachi, "địa chỉ", 250);
        if (!SoDienthoai().IsMatch(k.Dienthoai)) throw new ArgumentException("Số điện thoại gồm 10–11 chữ số và bắt đầu bằng 0.");
        if (k.Email.Length > 0 && (!MailAddress.TryCreate(k.Email, out var email) || email.Address != k.Email)) throw new ArgumentException("Email chưa đúng định dạng, ví dụ ten@example.com.");
        if (k.Id < 0 || k.Id > 0 && k.Phienban.Length != 8) throw new ArgumentException("Phiên bản khách hàng không hợp lệ. Hãy tải lại danh sách.");
        int id = dal.LuuKhachhang(k); log.LogInformation("Lưu khách hàng {Ma}, Id {Id}", k.Ma, id); return id;
    });
    public void XoaKhachhang(KhachhangDTO k) => Thucthi("xóa khách hàng", () =>
    {
        if (k.Id <= 0 || k.Phienban.Length != 8) throw new ArgumentException("Vui lòng chọn khách hàng trong danh sách.");
        dal.XoaKhachhang(k); log.LogInformation("Xóa khách hàng {Ma}, Id {Id}", k.Ma, k.Id); return 0;
    });
    public static void KiemtraKhoangngay(DateTime tu, DateTime den)
    {
        if (tu.Date > den.Date) throw new ArgumentException("Từ ngày phải nhỏ hơn hoặc bằng đến ngày.");
        if (tu.Year < 2000 || den.Year > 2100) throw new ArgumentException("Vui lòng chọn ngày trong khoảng năm 2000–2100.");
    }
    public List<HoadonDTO> TimHoadon(DateTime tu, DateTime den, string tukhoa = "", int? khachhangId = null) => Thucthi("tìm hóa đơn", () =>
    {
        KiemtraKhoangngay(tu, den); return dal.TimHoadon(tu.Date, den.Date, Chuanhoa(tukhoa), khachhangId);
    });
    public HoadonDTO DocHoadon(int id) => Thucthi("đọc hóa đơn", () => dal.DocHoadon(id));
    private static string Bam(object data) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(data))));
    public int TaoHoadon(YeucaubanDTO y) => Thucthi("tạo hóa đơn", () =>
    {
        if (y.YeucauId == Guid.Empty) throw new ArgumentException("Mã yêu cầu hóa đơn không hợp lệ.");
        y.Ghichu = Chuanhoa(y.Ghichu); Chuoi(y.Ghichu, "ghi chú", 500);
        if (y.KhachhangId <= 0) throw new ArgumentException("Khách hàng không hợp lệ.");
        if (y.Chitiet.Count is < 1 or > 200) throw new ArgumentException("Hóa đơn phải có từ 1 đến 200 game.");
        if (y.Chitiet.GroupBy(x => x.SanphamId).Any(g => g.Count() > 1)) throw new ArgumentException("Một game chỉ được có một dòng trong giỏ hàng. Hãy cập nhật số lượng.");
        foreach (var d in y.Chitiet)
        {
            if (d.SanphamId <= 0 || d.Soluong is < 1 or > 100000) throw new ArgumentException("Game phải hợp lệ; số lượng mỗi dòng từ 1 đến 100.000.");
            Tien(d.Dongia, "Đơn giá", false);
        }
        decimal tam = y.Chitiet.Sum(x => x.Thanhtien);
        if (y.Giamgia < 0 || y.Giamgia > tam || decimal.Truncate(y.Giamgia) != y.Giamgia) throw new ArgumentException("Giảm giá phải là số nguyên từ 0 đến tổng tiền hàng.");
        y.MaBam = Bam(new { y.KhachhangId, y.Giamgia, y.Ghichu, Dong = y.Chitiet.OrderBy(d => d.SanphamId).Select(d => new { d.SanphamId, d.Soluong, d.Dongia }) });
        int id = dal.TaoHoadon(y); log.LogInformation("Lưu hóa đơn {HoadonId}, yêu cầu {YeucauId}, tổng {Tong}", id, y.YeucauId, tam - y.Giamgia); return id;
    });
    public void HuyHoadon(int id, string lydo) => Thucthi("hủy hóa đơn", () =>
    {
        if (id <= 0) throw new ArgumentException("Vui lòng chọn hóa đơn.");
        lydo = Chuanhoa(lydo); Chuoi(lydo, "lý do hủy", 250, true);
        dal.HuyHoadon(id, lydo); log.LogWarning("Hủy hóa đơn {HoadonId}, đã hoàn kho", id); return 0;
    });
    public void Nhapkho(NhapkhoDTO p) => Thucthi("nhập kho", () =>
    {
        if (p.YeucauId == Guid.Empty || p.SanphamId <= 0 || p.Soluong is < 1 or > 100000) throw new ArgumentException("Chọn game và nhập số lượng từ 1 đến 100.000.");
        Tien(p.Dongia, "Đơn giá nhập"); p.Nhacungcap = Chuanhoa(p.Nhacungcap); p.Ghichu = Chuanhoa(p.Ghichu);
        Chuoi(p.Nhacungcap, "nhà cung cấp", 100, true); Chuoi(p.Ghichu, "ghi chú", 500);
        p.MaBam = Bam(new { p.SanphamId, p.Soluong, p.Dongia, p.Nhacungcap, p.Ghichu });
        dal.Nhapkho(p); log.LogInformation("Nhập kho game {SanphamId}, số lượng {Soluong}, yêu cầu {YeucauId}", p.SanphamId, p.Soluong, p.YeucauId); return 0;
    });
    public List<LichsukhoDTO> DocLichsukho(int? id = null) => Thucthi("đọc lịch sử kho", () => dal.DocLichsukho(id));
    public BaocaodoanhthuDTO DocDoanhthu(DateTime tu, DateTime den) => Thucthi("thống kê doanh thu", () =>
    {
        KiemtraKhoangngay(tu, den);
        if ((den.Date - tu.Date).Days > 3660) throw new ArgumentException("Mỗi báo cáo tối đa 10 năm. Hãy thu hẹp khoảng ngày.");
        var nguon = dal.DocDoanhthu(tu.Date, den.Date).ToDictionary(x => x.Ngay.Date);
        var bc = new BaocaodoanhthuDTO { Tungay = tu.Date, Denngay = den.Date };
        for (var ngay = tu.Date; ngay <= den.Date; ngay = ngay.AddDays(1)) bc.Chitiet.Add(nguon.GetValueOrDefault(ngay) ?? new DoanhthuNgayDTO { Ngay = ngay });
        log.LogDebug("Đọc doanh thu từ {Tu} đến {Den}, số hóa đơn {So}", tu, den, bc.Sohoadon); return bc;
    });
}
