using Quanlybangame.DTO;
using QuanlybangameMoi_UI.Forms;

namespace Quanlybangame.UI.Forms;

public partial class quanlykhachhang : Form
{
    public quanlykhachhang()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.GanCot(bangkhachhang, (bangkhachhangMa, "Ma"), (bangkhachhangHoten, "Hoten"), (bangkhachhangDienthoai, "Dienthoai"), (bangkhachhangEmail, "Email"));
        Giaodien.ChuanbiForm(this);
        nutthem.Click += (_, _) => MoSua(null); nutsua.Click += (_, _) => MoSua(Giaodien.Chon<KhachhangDTO>(bangkhachhang));
        nutxoa.Click += async (_, _) => await Giaodien.Chay(this, Xoa);
        nuttimkiem.Click += async (_, _) => await Giaodien.Chay(this, Tailai);
        nutlammoi.Click += async (_, _) => { otimkiem.Clear(); await Giaodien.Chay(this, Tailai); };
        nutxuat.Click += async (_, _) => await Giaodien.Chay(this, () => { Giaodien.XuatBang(this, bangkhachhang, "khachhang"); return Task.CompletedTask; });
        bangkhachhang.SelectionChanged += (_, _) => Chon();
        bangkhachhang.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) MoSua(Giaodien.Chon<KhachhangDTO>(bangkhachhang)); };
        nutlichsu.Click += (_, _) =>
        {
            var k = Giaodien.Chon<KhachhangDTO>(bangkhachhang); if (k == null) return;
            using var f = new quanlyhoadon(k.Id, k.Hoten); f.ShowDialog(this);
        };
        Giaodien.TimBang(otimkiem, nuttimkiem); Giaodien.Phimtat(this, Tailai, () => MoSua(null));
        Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); }; Chon();
    }
    private async Task Tailai()
    {
        if (!Phienlamviec.DaKetnoi) return;
        string q = otimkiem.Text;
        var data = await Task.Run(() => Phienlamviec.Dichvu.TimKhachhang(q));
        if (IsDisposed) return;
        Giaodien.Gan(bangkhachhang, data); Chon();
        nhantrangthai.Text = $"{data.Count} khách hàng  •  Ctrl+N: Thêm khách  •  F5: Tải lại";
    }
    private void Chon()
    {
        var k = Giaodien.Chon<KhachhangDTO>(bangkhachhang); nutsua.Enabled = nutxoa.Enabled = nutlichsu.Enabled = k != null;
        nhanthongtin.AutoEllipsis = true;
        nhanthongtin.Text = k == null ? "Chọn khách hàng để xem thông tin." : $"{k.Hoten}\n\nMã khách: {k.Ma}\n\nĐiện thoại:\n{k.Dienthoai}\n\nEmail:\n{k.Email}\n\nĐịa chỉ:\n{k.Diachi}";
    }
    private async void MoSua(KhachhangDTO? k)
    {
        using var f = k == null ? new suakhachhang() : new suakhachhang(k);
        if (f.ShowDialog(this) == DialogResult.OK) await Giaodien.Chay(this, Tailai);
    }
    private async Task Xoa()
    {
        var k = Giaodien.Chon<KhachhangDTO>(bangkhachhang); if (k == null || !Giaodien.Dongy(this, $"Xóa khách hàng {k.Ma} — {k.Hoten}?\nKhách đã có hóa đơn sẽ được giữ lại.")) return;
        await Task.Run(() => Phienlamviec.Dichvu.XoaKhachhang(k)); await Tailai();
    }
}
