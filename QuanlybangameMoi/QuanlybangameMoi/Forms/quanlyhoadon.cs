using Microsoft.Extensions.Logging;
using Quanlybangame.BLL;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI.Forms;

namespace Quanlybangame.UI.Forms;

public partial class quanlyhoadon : Form
{
    private readonly int? khachId;
    private bool dangtai;
    private HoadonDTO? hoadon;
    public quanlyhoadon()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.GanCot(banghoadon, (banghoadonMa, "Ma"), (banghoadonNgaylap, "Ngaylap"), (banghoadonKhachhang, "Khachhang"), (banghoadonTongtien, "Tongtien"), (banghoadonTrangthai, "Trangthai"));
        Giaodien.GanCot(bangchitiet, (bangchitietMa, "Ma"), (bangchitietTen, "Ten"), (bangchitietDongia, "Dongia"), (bangchitietSoluong, "Soluong"), (bangchitietThanhtien, "Thanhtien"));
        Giaodien.ChuanbiForm(this);
        ngaytu.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); ngayden.Value = DateTime.Today;
        nuttao.Click += (_, _) => MoTao();
        nuttimkiem.Click += async (_, _) => await Giaodien.Chay(this, Tailai);
        nutlammoi.Click += async (_, _) => { otimkiem.Clear(); await Giaodien.Chay(this, Tailai); };
        banghoadon.SelectionChanged += async (_, _) => { if (!DangTai()) await Giaodien.Chay(this, Hienthi); };
        nutxem.Click += (_, _) => MoXem(); banghoadon.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) MoXem(); };
        nutxuat.Click += async (_, _) => await Giaodien.Chay(this, () => { if (hoadon != null) Giaodien.XuatHoadon(this, hoadon); return Task.CompletedTask; });
        nuthuy.Click += async (_, _) => await Giaodien.Chay(this, Huy);
        Giaodien.TimBang(otimkiem, nuttimkiem); Giaodien.Phimtat(this, Tailai, MoTao);
        Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); }; CapnhatNut();
    }
    private bool DangTai() => dangtai || Giaodien.DangThietke;
    public quanlyhoadon(int id, string ten) : this()
    {
        khachId = id; nhantieude.Text = "Lịch sử mua hàng"; nhanmota.Text = ten;
        ngaytu.Value = new DateTime(2000, 1, 1); FormBorderStyle = FormBorderStyle.Sizable;
        Text = "Lịch sử mua hàng • " + ten; MinimumSize = new Size(1060, 720); StartPosition = FormStartPosition.CenterParent;
    }
    private void CapnhatNut() { nutxem.Enabled = nutxuat.Enabled = hoadon != null; nuthuy.Enabled = hoadon?.Trangthai == "Đã thanh toán"; }
    private async Task Tailai()
    {
        if (!Phienlamviec.DaKetnoi) return;
        DateTime tu = ngaytu.Value, den = ngayden.Value; string q = otimkiem.Text;
        var data = await Task.Run(() => Phienlamviec.Dichvu.TimHoadon(tu, den, q, khachId));
        if (IsDisposed) return;
        dangtai = true; try { Giaodien.Gan(banghoadon, data); } finally { dangtai = false; }
        nhantrangthai.Text = $"{data.Count} hóa đơn  •  Ctrl+N: Tạo hóa đơn  •  F5: Tải lại"; await Hienthi();
    }
    private async Task Hienthi()
    {
        hoadon = null; CapnhatNut(); Giaodien.Gan<DongbanDTO>(bangchitiet, []);
        var h = Giaodien.Chon<HoadonDTO>(banghoadon);
        if (h == null) { nhantong.Text = "Chưa có hóa đơn trong khoảng thời gian này."; return; }
        var kq = await Task.Run(() => Phienlamviec.Dichvu.DocHoadon(h.Id));
        if (IsDisposed) return;
        hoadon = kq; Giaodien.Gan(bangchitiet, kq.Chitiet);
        nhantong.Text = $"{kq.Ma}  •  Tiền hàng: {XuatdulieuBLL.Tien(kq.Tamtinh)}  •  Giảm: {XuatdulieuBLL.Tien(kq.Giamgia)}  •  Thanh toán: {XuatdulieuBLL.Tien(kq.Tongtien)}";
        CapnhatNut();
    }
    private async void MoTao()
    {
        using var f = new taohoadon();
        if (f.ShowDialog(this) != DialogResult.OK) return;
        ngayden.Value = DateTime.Today; if (ngaytu.Value > ngayden.Value) ngaytu.Value = ngayden.Value;
        await Giaodien.Chay(this, async () => { await Tailai(); var h = await Task.Run(() => Phienlamviec.Dichvu.DocHoadon(f.HoadonId)); using var xem = new xemhoadon(h); xem.ShowDialog(this); });
    }
    private void MoXem() { if (hoadon == null) return; using var f = new xemhoadon(hoadon); f.ShowDialog(this); }
    private async Task Huy()
    {
        if (hoadon == null) return;
        using var f = new nhaplydo(); if (f.ShowDialog(this) != DialogResult.OK) return;
        int id = hoadon.Id; await Task.Run(() => Phienlamviec.Dichvu.HuyHoadon(id, f.Lydo)); await Tailai();
        Phienlamviec.Log.LogInformation("Hoàn tất thao tác hủy hóa đơn {Id}", id);
    }
}
