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
    }
}
