using Microsoft.Extensions.Logging;
using Quanlybangame.BLL;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI;

namespace Quanlybangame.UI.Forms;

public partial class xemhoadon : Form
{
    private HoadonDTO? hoadon;
    public xemhoadon()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.GanCot(bangchitiet, (bangchitietMa, "Ma"), (bangchitietTen, "Ten"), (bangchitietDongia, "Dongia"), (bangchitietSoluong, "Soluong"), (bangchitietThanhtien, "Thanhtien"));
        Giaodien.ChuanbiForm(this);
        nutxuat.Click += async (_, _) => await Giaodien.Chay(this, () => { if (hoadon != null) Giaodien.XuatHoadon(this, hoadon); return Task.CompletedTask; });
        nutxemin.Click += async (_, _) => await Giaodien.Chay(this, () => { XemIn(); return Task.CompletedTask; });
        nutin.Click += async (_, _) => await Giaodien.Chay(this, () => { In(); return Task.CompletedTask; });
        Shown += (_, _) => Hienthi();
    }
    public xemhoadon(HoadonDTO h) : this() => hoadon = h;
    private void Hienthi()
    {
        nutxuat.Enabled = nutxemin.Enabled = nutin.Enabled = hoadon != null;
        if (hoadon == null) return;
        Text = "Hóa đơn • " + hoadon.Ma;
        nhanthongtin.Text = $"{hoadon.Ma}  •  Ngày lập: {hoadon.Ngaylap:dd/MM/yyyy HH:mm}  •  {hoadon.Trangthai}\nKhách hàng: {hoadon.Khachhang}  •  Điện thoại: {hoadon.Dienthoai}";
        Giaodien.Gan(bangchitiet, hoadon.Chitiet);
        nhantong.Text = $"Tiền hàng: {XuatdulieuBLL.Tien(hoadon.Tamtinh)}  |  Giảm giá: {XuatdulieuBLL.Tien(hoadon.Giamgia)}\nThanh toán: {XuatdulieuBLL.Tien(hoadon.Tongtien)}";
        nhanghichu.Text = hoadon.Trangthai == "Đã hủy" ? "Lý do hủy: " + hoadon.LydoHuy : "Ghi chú: " + hoadon.Ghichu;
        nhanghichu.AutoEllipsis = true;
    }
    private void XemIn()
    {
        if (hoadon == null) return;
        using var inhd = new InHoadon(hoadon);
        using var preview = new PrintPreviewDialog { Document = inhd.Tailieu, Width = 1100, Height = 820, StartPosition = FormStartPosition.CenterParent, UseAntiAlias = true };
        preview.ShowDialog(this);
    }
    private void In()
    {
        if (hoadon == null) return;
        using var inhd = new InHoadon(hoadon);
        using var dialog = new PrintDialog { Document = inhd.Tailieu, UseEXDialog = true, AllowSomePages = false };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        inhd.Tailieu.Print(); Phienlamviec.Log.LogInformation("Gửi lệnh in hóa đơn {Ma}", hoadon.Ma);
    }
}
