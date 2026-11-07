using Quanlybangame.BLL;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI;

namespace Quanlybangame.UI.Forms;

public partial class quanlydoanhthu : Form
{
    private BaocaodoanhthuDTO? baocao;
    public quanlydoanhthu()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.GanCot(bangdoanhthu, (bangdoanhthuNgay, "Ngay"), (bangdoanhthuSohoadon, "Sohoadon"), (bangdoanhthuDoanhthu, "Doanhthu"));
        Giaodien.ChuanbiForm(this);
        ngaytu.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); ngayden.Value = DateTime.Today;
        nutthongke.Click += async (_, _) => await Giaodien.Chay(this, Tailai);
        nutxuat.Click += async (_, _) => await Giaodien.Chay(this, () => { Giaodien.XuatBang(this, bangdoanhthu, "doanhthu"); return Task.CompletedTask; });
        khungbieudo.Paint += (_, e) => Giaodien.VeBieudo(e.Graphics, khungbieudo.ClientRectangle, baocao?.Chitiet ?? []);
        khungbieudo.Resize += (_, _) => khungbieudo.Invalidate();
        Giaodien.Phimtat(this, Tailai); Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); };
    }
    private async Task Tailai()
    {
        if (!Phienlamviec.DaKetnoi) { nhantrangthai.Text = "Chưa kết nối SQL. Kết nối để xem doanh thu thực tế của cửa hàng."; return; }
        DateTime tu = ngaytu.Value, den = ngayden.Value;
        var bc = await Task.Run(() => Phienlamviec.Dichvu.DocDoanhthu(tu, den));
        if (IsDisposed) return;
        baocao = bc;
        Giaodien.Gan(bangdoanhthu, bc.Chitiet);
        nhandoanhthu.Text = XuatdulieuBLL.Tien(bc.Tongdoanhthu); nhanbinhquanhd.Text = XuatdulieuBLL.Tien(bc.BinhquanHoadon);
        nhanbinhquanngay.Text = XuatdulieuBLL.Tien(bc.BinhquanNgay); nhansohoadon.Text = bc.Sohoadon.ToString("N0");
        khungbieudo.Invalidate();
        nhantrangthai.Text = $"Báo cáo từ {bc.Tungay:dd/MM/yyyy} đến {bc.Denngay:dd/MM/yyyy}  •  {(bc.Denngay - bc.Tungay).Days + 1} ngày";
    }
}
