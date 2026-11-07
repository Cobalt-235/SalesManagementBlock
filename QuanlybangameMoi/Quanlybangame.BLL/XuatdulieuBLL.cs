using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;
using Quanlybangame.DTO;

namespace Quanlybangame.BLL;

public static class XuatdulieuBLL
{
    private static readonly CultureInfo Vi = CultureInfo.GetCultureInfo("vi-VN");
    public static string Tien(decimal n) => n.ToString("N0", Vi) + " đ";
    public static string HtmlHoadon(HoadonDTO h)
    {
        static string E(string s) => WebUtility.HtmlEncode(s);
        var dong = string.Join("", h.Chitiet.Select(d => $"<tr><td>{E(d.Ma)}</td><td>{E(d.Ten)}</td><td class='so'>{d.Soluong}</td><td class='so'>{Tien(d.Dongia)}</td><td class='so'>{Tien(d.Thanhtien)}</td></tr>"));
        return $$$"""
        <!doctype html><html lang="vi"><head><meta charset="utf-8"><title>{{{h.Ma}}}</title>
        <style>body{font:15px 'Segoe UI',Arial;color:#173c3b;max-width:900px;margin:40px auto;padding:24px}header{border-bottom:4px solid #bd8743;padding-bottom:18px}h1{margin:8px 0}table{width:100%;border-collapse:collapse;margin-top:28px}th,td{padding:12px;border-bottom:1px solid #ddd;text-align:left}th{background:#edf4ef}.so{text-align:right}.tong{text-align:right;font-size:22px;margin:24px 0}footer{color:#687b78;border-top:1px solid #ddd;padding-top:18px}@media print{body{margin:0;padding:10px}}</style></head>
        <body><header><b>GAME DESK · QUẢN LÝ BÁN GAME</b><h1>HÓA ĐƠN BÁN HÀNG</h1>{{{h.Ma}}} · {{{h.Ngaylap:dd/MM/yyyy HH:mm}}} · {{{E(h.Trangthai)}}}</header>
        <p>Khách hàng: <b>{{{E(h.Khachhang)}}}</b><br>Điện thoại: {{{E(h.Dienthoai)}}}</p>
        <table><thead><tr><th>Mã game</th><th>Tên game</th><th class="so">SL</th><th class="so">Đơn giá</th><th class="so">Thành tiền</th></tr></thead><tbody>{{{dong}}}</tbody></table>
        <p class="tong">Tiền hàng: {{{Tien(h.Tamtinh)}}}<br>Giảm giá: {{{Tien(h.Giamgia)}}}<br><b>Thanh toán: {{{Tien(h.Tongtien)}}}</b></p>
        <p>Ghi chú: {{{E(h.Ghichu)}}}<br>Lý do hủy: {{{E(h.LydoHuy)}}}</p><footer>Cảm ơn bạn đã mua hàng tại GAME DESK.<br>Phiếu bán hàng nội bộ.</footer></body></html>
        """;
    }
    public static void LuuHoadon(HoadonDTO h, string duongdan)
    {
        string noidung = Path.GetExtension(duongdan).Equals(".json", StringComparison.OrdinalIgnoreCase)
            ? JsonSerializer.Serialize(h, new JsonSerializerOptions { WriteIndented = true }) : HtmlHoadon(h);
        File.WriteAllText(duongdan, noidung, new UTF8Encoding(true));
    }
    public static string OCSV(object? giatri)
    {
        string s = Convert.ToString(giatri, Vi) ?? "";
        if (s.TrimStart().StartsWith('=') || s.TrimStart().StartsWith('+') || s.TrimStart().StartsWith('-') || s.TrimStart().StartsWith('@')) s = "'" + s;
        return "\"" + s.Replace("\"", "\"\"") + "\"";
    }
    public static void LuuCSV(string duongdan, IEnumerable<IEnumerable<object?>> cacdong)
        => File.WriteAllLines(duongdan, cacdong.Select(d => string.Join(";", d.Select(OCSV))), new UTF8Encoding(true));
}
