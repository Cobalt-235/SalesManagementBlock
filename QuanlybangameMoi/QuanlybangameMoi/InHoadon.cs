using System.Drawing.Printing;
using Quanlybangame.BLL;
using Quanlybangame.DTO;

namespace Quanlybangame.UI;

internal sealed class InHoadon : IDisposable
{
    private readonly HoadonDTO hoadon;
    private int dong;
    private int trang;
    public PrintDocument Tailieu { get; } = new();
    public InHoadon(HoadonDTO h)
    {
        hoadon = h;
        Tailieu.DocumentName = h.Ma;
        Tailieu.DefaultPageSettings.Margins = new Margins(45, 45, 45, 45);
        Tailieu.BeginPrint += (_, _) => { dong = 0; trang = 0; };
        Tailieu.PrintPage += VeTrang;
    }
    private void VeTrang(object? sender, PrintPageEventArgs e)
    {
        var g = e.Graphics ?? throw new InvalidOperationException("Không mở được thiết bị in.");
        trang++;
        using var tieuDe = new Font("Segoe UI", 20, FontStyle.Bold);
        using var dam = new Font("Segoe UI", 10, FontStyle.Bold);
        using var font = new Font("Segoe UI", 10);
        using var small = new Font("Segoe UI", 9);
        using var muc = new SolidBrush(Giaodien.Xanh);
        using var vien = new Pen(Color.LightGray);
        float x = e.MarginBounds.Left, y = e.MarginBounds.Top, width = e.MarginBounds.Width;
        g.DrawString("GAME DESK • HÓA ĐƠN BÁN HÀNG", tieuDe, muc, x, y); y += 44;
        g.DrawString($"{hoadon.Ma}  |  {hoadon.Ngaylap:dd/MM/yyyy HH:mm}  |  {hoadon.Trangthai}", dam, muc, x, y); y += 27;
        g.DrawString($"Khách hàng: {hoadon.Khachhang}    Điện thoại: {hoadon.Dienthoai}", font, muc, new RectangleF(x, y, width, 46)); y += 48;
        float tenw = Math.Max(150, width - 315);
        g.DrawString("Tên game", dam, muc, x, y); g.DrawString("SL", dam, muc, x + tenw, y);
        g.DrawString("Đơn giá", dam, muc, x + tenw + 45, y); g.DrawString("Thành tiền", dam, muc, x + tenw + 165, y); y += 28;
        g.DrawLine(vien, x, y, x + width, y); y += 12;
        while (dong < hoadon.Chitiet.Count)
        {
            var d = hoadon.Chitiet[dong];
            string ten = d.Ma + " • " + d.Ten;
            float cao = Math.Max(30, g.MeasureString(ten, font, (int)tenw - 12).Height + 12);
            if (y + cao > e.MarginBounds.Bottom - 135)
            {
                g.DrawString($"Trang {trang} • Còn tiếp", small, muc, x, e.MarginBounds.Bottom - 18);
                e.HasMorePages = true; return;
            }
            g.DrawString(ten, font, muc, new RectangleF(x, y, tenw - 12, cao));
            g.DrawString(d.Soluong.ToString("N0"), font, muc, x + tenw, y);
            g.DrawString(d.Dongia.ToString("N0"), font, muc, x + tenw + 45, y);
            g.DrawString(d.Thanhtien.ToString("N0"), font, muc, x + tenw + 165, y);
            y += cao; dong++;
        }
        y += 12; g.DrawLine(vien, x, y, x + width, y); y += 16;
        g.DrawString($"Tiền hàng: {XuatdulieuBLL.Tien(hoadon.Tamtinh)}   |   Giảm giá: {XuatdulieuBLL.Tien(hoadon.Giamgia)}", font, muc, x, y); y += 29;
        g.DrawString("THANH TOÁN: " + XuatdulieuBLL.Tien(hoadon.Tongtien), dam, muc, x, y); y += 30;
        g.DrawString("Phiếu bán hàng nội bộ. Cảm ơn bạn đã mua hàng tại GAME DESK.", small, muc, x, y);
        g.DrawString($"Trang {trang}", small, muc, x, e.MarginBounds.Bottom - 18); e.HasMorePages = false;
    }
    public void Dispose() => Tailieu.Dispose();
}