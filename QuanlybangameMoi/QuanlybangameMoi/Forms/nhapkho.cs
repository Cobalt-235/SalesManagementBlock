using Quanlybangame.BLL;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI;

namespace Quanlybangame.UI.Forms;

public partial class nhapkho : Form
{
    private readonly Guid yeucau = Guid.NewGuid();
    private readonly int? chonId;
    public nhapkho()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.ChuanbiForm(this);
        chongame.SelectedIndexChanged += (_, _) =>
        {
            if (chongame.SelectedItem is not SanphamDTO s) return;
            nhanton.Text = $"{s.Ma} • {s.Nentang} • Tồn hiện tại: {s.Tonkho:N0}"; odongia.Value = s.Gianhap;
        };
        osoluong.ValueChanged += (_, _) => Tongtien(); odongia.ValueChanged += (_, _) => Tongtien();
        nutluu.Click += async (_, _) =>
        {
            if (!Giaodien.Batbuoc(kiemtraloi, (onhacungcap, "nhà cung cấp"))) return;
            await Giaodien.Chay(this, async () =>
            {
                var s = chongame.SelectedItem as SanphamDTO ?? throw new ArgumentException("Vui lòng chọn game để nhập.");
                var p = new NhapkhoDTO { YeucauId = yeucau, SanphamId = s.Id, Soluong = (int)osoluong.Value, Dongia = odongia.Value, Nhacungcap = onhacungcap.Text, Ghichu = oghichu.Text };
                await Task.Run(() => Phienlamviec.Dichvu.Nhapkho(p)); DialogResult = DialogResult.OK; Close();
            });
        };
        Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); };
    }
    public nhapkho(int? id) : this() => chonId = id;
    private async Task Tailai()
    {
        if (!Phienlamviec.DaKetnoi) { nhanton.Text = "Chưa kết nối SQL. Kết nối để tải danh sách game."; return; }
        var ds = await Task.Run(() => Phienlamviec.Dichvu.TimSanpham()); chongame.DataSource = ds;
        if (chonId.HasValue) chongame.SelectedItem = ds.FirstOrDefault(x => x.Id == chonId);
    }
    private void Tongtien() => nhantong.Text = "Tổng tiền nhập: " + XuatdulieuBLL.Tien(osoluong.Value * odongia.Value);
}
