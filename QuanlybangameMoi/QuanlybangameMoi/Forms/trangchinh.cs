using Microsoft.Extensions.Logging;
using Quanlybangame.BLL;
using QuanlybangameMoi_UI;

namespace Quanlybangame.UI.Forms;

public partial class trangchinh : Form
{
    private Form? trang;
    private string muc = "sanpham";
    public trangchinh()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.ChuanbiForm(this);
        khungnoidung.AutoScroll = true;
        khungnoidung.Resize += (_, _) => ChinhKichthuocTrang();
        nutsanpham.Click += (_, _) => HienTrang("sanpham");
        nutkhachhang.Click += (_, _) => HienTrang("khachhang");
        nuthoadon.Click += (_, _) => HienTrang("hoadon");
        nuttonkho.Click += (_, _) => HienTrang("tonkho");
        nutdoanhthu.Click += (_, _) => HienTrang("doanhthu");
        nutketnoi.Click += async (_, _) => await KetnoiLai();
        nutnhatky.Click += (_, _) => { using var f = new nhatky(); f.ShowDialog(this); };
        nutthoat.Click += (_, _) => Close();
        Shown += async (_, _) =>
        {
            if (Giaodien.DangThietke) return;
            HienTrang("sanpham");
            await KetnoiLai();
        };
    }
    private async Task KetnoiLai()
    {
        if (!nutketnoi.Enabled) return;
        nutketnoi.Enabled = false;
        nhanketnoi.Text = "œ ?ang k?t n?i SQL Serverc";
        try
        {
            Phienlamviec.DocCauhinh();
            await Phienlamviec.Ketnoi(Phienlamviec.Cauhinh, "");
            if (IsDisposed) return;
            nhanketnoi.Text = $"œ ?? k?t n?i: {Phienlamviec.Cauhinh.Maychu} | {Phienlamviec.Cauhinh.Cosodulieu}";
            HienTrang(muc);
        }
        catch (Exception e)
        {
            Phienlamviec.Log.LogWarning(e, "Kh?ng th? k?t n?i SQL khi t?i ?ng d?ng");
            if (!IsDisposed)
                nhanketnoi.Text = "œ Ch?a k?t n?i ? B?t SQLEXPRESS01, ch?y script Database n?u ch?a c? d? li?u, r?i b?m K?t n?i l?i.";
        }
        finally { if (!IsDisposed) nutketnoi.Enabled = true; }
    }
    private void HienTrang(string ten)
    {
        if (Giaodien.DangThietke) return;
        trang?.Dispose(); muc = ten;
        trang = ten switch
        {
            "khachhang" => new quanlykhachhang(),
            "hoadon" => new quanlyhoadon(),
            "tonkho" => new quanlytonkho(),
            "doanhthu" => new quanlydoanhthu(),
            _ => new quanlysanpham()
        };
        trang.TopLevel = false; trang.FormBorderStyle = FormBorderStyle.None; trang.Dock = DockStyle.None;
        trang.Location = Point.Empty;
        khungnoidung.Controls.Clear(); khungnoidung.Controls.Add(trang); trang.Show(); ChinhKichthuocTrang();
        var nut = new Dictionary<string, Button> { ["sanpham"] = nutsanpham, ["khachhang"] = nutkhachhang, ["hoadon"] = nuthoadon, ["tonkho"] = nuttonkho, ["doanhthu"] = nutdoanhthu };
        foreach (var (key, b) in nut) { b.BackColor = key == ten ? Color.FromArgb(49, 91, 78) : Giaodien.Xanh; b.ForeColor = key == ten ? Color.White : Color.FromArgb(225, 236, 231); }
    }
    private void ChinhKichthuocTrang()
    {
        if (trang == null || trang.IsDisposed) return;
        float he = DeviceDpi / 96F;
        trang.Size = new Size(Math.Max((int)(900 * he), khungnoidung.ClientSize.Width), Math.Max((int)(600 * he), khungnoidung.ClientSize.Height));
    }
}
