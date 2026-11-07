using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using Quanlybangame.DAL;
using Quanlybangame.DTO;

namespace Quanlybangame.BLL
{
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
    }
}
