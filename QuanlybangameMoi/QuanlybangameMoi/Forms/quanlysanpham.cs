using Quanlybangame.BLL;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI.Forms;

namespace Quanlybangame.UI.Forms;

public partial class quanlysanpham : Form
{
    public quanlysanpham()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.GanCot(bangsanpham, (bangsanphamMa, "Ma"), (bangsanphamTen, "Ten"), (bangsanphamNentang, "Nentang"), (bangsanphamGiaban, "Giaban"), (bangsanphamTonkho, "Tonkho"), (bangsanphamTrangthai, "Trangthai"));
        Giaodien.ChuanbiForm(this);
        nutthem.Click += (_, _) => MoSua(null);
        nutsua.Click += (_, _) => MoSua(Giaodien.Chon<SanphamDTO>(bangsanpham));
        nutxoa.Click += async (_, _) => await Giaodien.Chay(this, Xoa);
        nuttimkiem.Click += async (_, _) => await Giaodien.Chay(this, Tailai);
        nutlammoi.Click += async (_, _) => { otimkiem.Clear(); await Giaodien.Chay(this, Tailai); };
        nutxuat.Click += async (_, _) => await Giaodien.Chay(this, () => { Giaodien.XuatBang(this, bangsanpham, "sanpham"); return Task.CompletedTask; });
        nutnhapkho.Click += (_, _) => MoNhapkho();
        bangsanpham.SelectionChanged += (_, _) => Chon();
        bangsanpham.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) MoSua(Giaodien.Chon<SanphamDTO>(bangsanpham)); };
        Giaodien.TimBang(otimkiem, nuttimkiem); Giaodien.Phimtat(this, Tailai, () => MoSua(null));
        Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); };
        Chon();
    }
    private async Task Tailai()
    {
        if (!Phienlamviec.DaKetnoi) { nhantrangthai.Text = "Chưa kết nối SQL • Các form Thêm game vẫn mở được để bạn xem giao diện."; return; }
        string q = otimkiem.Text;
        var data = await Task.Run(() => Phienlamviec.Dichvu.TimSanpham(q));
        if (IsDisposed) return;
        Giaodien.Gan(bangsanpham, data); Chon();
        nhantrangthai.Text = $"{data.Count} game  •  Ctrl+N: Thêm game  •  F5: Tải lại  •  Nhấp đúp: Cập nhật";
    }
    private void Chon()
    {
        var s = Giaodien.Chon<SanphamDTO>(bangsanpham); nutsua.Enabled = nutxoa.Enabled = nutnhapkho.Enabled = s != null;
        nhanthongtin.AutoEllipsis = true;
        nhanthongtin.Text = s == null ? "Chọn một game trong bảng để xem thông tin chi tiết." : $"{s.Ten}\n\nMã: {s.Ma}\nNền tảng: {s.Nentang}\nThể loại: {s.Theloai}\n\nGiá bán: {XuatdulieuBLL.Tien(s.Giaban)}\nGiá nhập: {XuatdulieuBLL.Tien(s.Gianhap)}\nTồn kho: {s.Tonkho:N0}\nCảnh báo khi tồn ≤ {s.TonToithieu:N0}\n\n{s.Trangthai}";
    }
    private async void MoSua(SanphamDTO? s)
    {
        using var f = s == null ? new suasanpham() : new suasanpham(s);
        if (f.ShowDialog(this) == DialogResult.OK) await Giaodien.Chay(this, Tailai);
    }
    private async Task Xoa()
    {
        var s = Giaodien.Chon<SanphamDTO>(bangsanpham); if (s == null) return;
        if (!Giaodien.Dongy(this, $"Xóa game {s.Ma} — {s.Ten}?\nGame đã có lịch sử nhập/bán sẽ được giữ lại.")) return;
        await Task.Run(() => Phienlamviec.Dichvu.XoaSanpham(s)); await Tailai();
    }
    private async void MoNhapkho()
    {
        var s = Giaodien.Chon<SanphamDTO>(bangsanpham); if (s == null) return;
        using var f = new nhapkho(s.Id);
        if (f.ShowDialog(this) == DialogResult.OK) await Giaodien.Chay(this, Tailai);
    }
}
