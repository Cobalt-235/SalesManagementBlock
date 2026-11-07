using System.ComponentModel;
using Quanlybangame.BLL;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI;

namespace Quanlybangame.UI.Forms;

public partial class taohoadon : Form
{
    private readonly BindingList<DongbanDTO> gio = [];
    private readonly Guid yeucau = Guid.NewGuid();
    public int HoadonId { get; private set; }
    public taohoadon()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.GanCot(banggiohang, (banggiohangMa, "Ma"), (banggiohangTen, "Ten"), (banggiohangDongia, "Dongia"), (banggiohangSoluong, "Soluong"), (banggiohangThanhtien, "Thanhtien"));
        Giaodien.ChuanbiForm(this);
        banggiohang.DataSource = gio;
        gio.ListChanged += (_, _) => Tongtien(); ogiamgia.ValueChanged += (_, _) => Tongtien();
        chongame.SelectedIndexChanged += (_, _) => CapnhatGame();
        nutthem.Click += async (_, _) => await Giaodien.Chay(this, () => { Them(); return Task.CompletedTask; });
        nutxoadong.Click += (_, _) => { var d = Giaodien.Chon<DongbanDTO>(banggiohang); if (d != null) gio.Remove(d); };
        nutcapnhat.Click += async (_, _) => await Giaodien.Chay(this, () => { CapnhatSoluong(); return Task.CompletedTask; });
        banggiohang.SelectionChanged += (_, _) => { var d = Giaodien.Chon<DongbanDTO>(banggiohang); if (d != null) osoluong.Value = d.Soluong; };
        nuttailai.Click += async (_, _) => await Giaodien.Chay(this, Tailai);
        nutthemkhach.Click += async (_, _) =>
        {
            using var f = new suakhachhang(); if (f.ShowDialog(this) != DialogResult.OK) return;
            await Giaodien.Chay(this, async () => { await Tailai(); if (chonkhachhang.DataSource is List<KhachhangDTO> kh) chonkhachhang.SelectedItem = kh.FirstOrDefault(x => x.Id == f.IdDaLuu); });
        };
        nutluu.Click += async (_, _) => await Giaodien.Chay(this, Luu);
        Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); }; Tongtien();
    }
    private async Task Tailai()
    {
        if (!Phienlamviec.DaKetnoi) { nhantrangthai.Text = "Chưa kết nối SQL. Đóng cửa sổ này rồi bấm Kết nối lại để tải dữ liệu."; return; }
        int? idkh = (chonkhachhang.SelectedItem as KhachhangDTO)?.Id; int? idgame = (chongame.SelectedItem as SanphamDTO)?.Id;
        var data = await Task.Run(() => (Game: Phienlamviec.Dichvu.TimSanpham("", true), Khach: Phienlamviec.Dichvu.TimKhachhang()));
        data.Khach.Insert(0, new KhachhangDTO { Hoten = "Khách lẻ" });
        chonkhachhang.DataSource = data.Khach; chongame.DataSource = data.Game;
        if (idkh.HasValue) chonkhachhang.SelectedItem = data.Khach.FirstOrDefault(x => x.Id == idkh) ?? data.Khach[0];
        if (idgame.HasValue && data.Game.Any(x => x.Id == idgame)) chongame.SelectedItem = data.Game.First(x => x.Id == idgame);
        nhantrangthai.Text = $"Đã tải {data.Game.Count} game còn hàng • Giá và tồn sẽ được kiểm tra lại khi thanh toán."; CapnhatGame();
    }
    private void CapnhatGame()
    {
        var s = chongame.SelectedItem as SanphamDTO;
        nhanton.Text = s == null ? "Chưa có game còn hàng để chọn." : $"{s.Ma}  •  {s.Nentang}  •  Tồn: {s.Tonkho:N0}  •  Giá: {XuatdulieuBLL.Tien(s.Giaban)}";
    }
    private void Them()
    {
        if (chongame.SelectedItem is not SanphamDTO s) throw new ArgumentException("Vui lòng chọn một game còn hàng.");
        int sl = (int)osoluong.Value; var cu = gio.FirstOrDefault(x => x.SanphamId == s.Id);
        if (sl + (cu?.Soluong ?? 0) > s.Tonkho) throw new ArgumentException($"Số lượng vượt tồn hiện tại ({s.Tonkho}).");
        if (cu != null && cu.Dongia != s.Giaban) throw new ArgumentException("Giá của game đã thay đổi. Xóa dòng cũ rồi thêm lại.");
        if (cu == null) gio.Add(new DongbanDTO { SanphamId = s.Id, Ma = s.Ma, Ten = s.Ten, Dongia = s.Giaban, Soluong = sl });
        else { cu.Soluong += sl; gio.ResetBindings(); }
        Tongtien();
    }
    private void CapnhatSoluong()
    {
        var d = Giaodien.Chon<DongbanDTO>(banggiohang) ?? throw new ArgumentException("Chọn dòng trong giỏ cần cập nhật.");
        var s = (chongame.DataSource as List<SanphamDTO>)?.FirstOrDefault(x => x.Id == d.SanphamId);
        if (s == null || osoluong.Value > s.Tonkho) throw new ArgumentException("Không đủ tồn. Hãy tải lại danh sách game.");
        d.Soluong = (int)osoluong.Value; gio.ResetBindings(); Tongtien();
    }
    private void Tongtien()
    {
        decimal tong = gio.Sum(x => x.Thanhtien) - ogiamgia.Value;
        nhantong.Text = tong < 0 ? "Giảm giá quá lớn" : XuatdulieuBLL.Tien(tong);
        nutluu.Enabled = gio.Count > 0 && tong >= 0;
    }
    private async Task Luu()
    {
        var k = chonkhachhang.SelectedItem as KhachhangDTO;
        var y = new YeucaubanDTO { YeucauId = yeucau, KhachhangId = k?.Id > 0 ? k.Id : null, Chitiet = gio.Select(d => new DongbanDTO { SanphamId = d.SanphamId, Ma = d.Ma, Ten = d.Ten, Dongia = d.Dongia, Soluong = d.Soluong }).ToList(), Giamgia = ogiamgia.Value, Ghichu = oghichu.Text };
        HoadonId = await Task.Run(() => Phienlamviec.Dichvu.TaoHoadon(y));
        DialogResult = DialogResult.OK; Close();
    }
}
