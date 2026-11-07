using Quanlybangame.DTO;

namespace Quanlybangame.UI.Forms;

public partial class quanlytonkho : Form
{
    private bool dangtai;
    public quanlytonkho()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.GanCot(bangtonkho, (bangtonkhoMa, "Ma"), (bangtonkhoTen, "Ten"), (bangtonkhoNentang, "Nentang"), (bangtonkhoGiaban, "Giaban"), (bangtonkhoTonkho, "Tonkho"), (bangtonkhoTrangthai, "Trangthai"));
        Giaodien.GanCot(banglichsu, (banglichsuNgay, "Ngay"), (banglichsuLoai, "Loai"), (banglichsuSoluong, "Soluong"), (banglichsuTonsau, "Tonsau"), (banglichsuThamchieu, "Thamchieu"), (banglichsuGhichu, "Ghichu"));
        Giaodien.ChuanbiForm(this);
        nutnhap.Click += (_, _) => MoNhap();
        nuttimkiem.Click += async (_, _) => await Giaodien.Chay(this, Tailai);
        nutlammoi.Click += async (_, _) => { otimkiem.Clear(); await Giaodien.Chay(this, Tailai); };
        chonsaphethang.CheckedChanged += async (_, _) => { if (Visible) await Giaodien.Chay(this, Tailai); };
        nutxuat.Click += async (_, _) => await Giaodien.Chay(this, () => { Giaodien.XuatBang(this, bangtonkho, "tonkho"); return Task.CompletedTask; });
        bangtonkho.SelectionChanged += async (_, _) => { if (!dangtai) await Giaodien.Chay(this, HienthiLichsu); };
        Giaodien.TimBang(otimkiem, nuttimkiem); Giaodien.Phimtat(this, Tailai, MoNhap);
        Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); };
    }
    private async Task Tailai()
    {
        if (!Phienlamviec.DaKetnoi) return;
        string q = otimkiem.Text;
        var data = await Task.Run(() => Phienlamviec.Dichvu.TimSanpham(q));
        if (IsDisposed) return;
        nhantong.Text = $"Tồn: {data.Sum(x => (long)x.Tonkho):N0}  |  Sắp hết: {data.Count(x => x.Dangban && x.Tonkho <= x.TonToithieu)} game";
        if (chonsaphethang.Checked) data = data.Where(x => x.Dangban && x.Tonkho <= x.TonToithieu).ToList();
        dangtai = true; try { Giaodien.Gan(bangtonkho, data); } finally { dangtai = false; }
        foreach (DataGridViewRow r in bangtonkho.Rows) if (r.DataBoundItem is SanphamDTO s && s.Tonkho <= s.TonToithieu) r.DefaultCellStyle.ForeColor = Color.FromArgb(157, 76, 34);
        nhantrangthai.Text = $"Đang hiển thị {data.Count} game. Chọn game để xem lịch sử nhập, bán và hoàn kho."; await HienthiLichsu();
    }
    private async Task HienthiLichsu()
    {
        var s = Giaodien.Chon<SanphamDTO>(bangtonkho);
        if (s == null) { Giaodien.Gan<LichsukhoDTO>(banglichsu, []); return; }
        var ds = await Task.Run(() => Phienlamviec.Dichvu.DocLichsukho(s.Id));
        if (!IsDisposed) Giaodien.Gan(banglichsu, ds);
    }
    private async void MoNhap()
    {
        using var f = new nhapkho(Giaodien.Chon<SanphamDTO>(bangtonkho)?.Id);
        if (f.ShowDialog(this) == DialogResult.OK) await Giaodien.Chay(this, Tailai);
    }
}
