using System.Runtime.Intrinsics.X86;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI;

namespace Quanlybangame.UI.Forms;

public partial class suasanpham : Form
{
    private readonly int id;
    private readonly byte[] phienban = [];
    public suasanpham()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.ChuanbiForm(this);
        nutluu.Click += async (_, _) =>
        {
            if (!Giaodien.Batbuoc(kiemtraloi, (oma, "mã game"), (oten, "tên game"), (otheloai, "thể loại"), (onentang, "nền tảng"))) return;
            var s = new SanphamDTO { Id = id, Phienban = phienban, Ma = oma.Text, Ten = oten.Text, Theloai = otheloai.Text, Nentang = onentang.Text, Nhaphathanh = onhaphathanh.Text, Gianhap = ogianhap.Value, Giaban = ogiaban.Value, Tonkho = (int)otonkho.Value, TonToithieu = (int)otoithieu.Value, Dangban = chondangban.Checked, Mota = omota.Text };
            await Giaodien.Chay(this, async () => { await Task.Run(() => Phienlamviec.Dichvu.LuuSanpham(s)); DialogResult = DialogResult.OK; Close(); });
        };
        Shown += (_, _) => { if (!Giaodien.DangThietke) oma.Focus(); };
        onentang.Text = "PC"; otoithieu.Value = 5;
    }
    public suasanpham(SanphamDTO s) : this()
    {
        id = s.Id; phienban = s.Phienban.ToArray(); Text = "Cập nhật game • " + s.Ma;
        oma.Text = s.Ma; oten.Text = s.Ten; otheloai.Text = s.Theloai; onentang.Text = s.Nentang; onhaphathanh.Text = s.Nhaphathanh;
        ogianhap.Value = s.Gianhap; ogiaban.Value = s.Giaban; otonkho.Maximum = Math.Max(1000000, s.Tonkho); otonkho.Value = s.Tonkho; otoithieu.Value = s.TonToithieu; chondangban.Checked = s.Dangban; omota.Text = s.Mota;
        otonkho.Enabled = false; nhantonkho.Text = "Tồn hiện tại (thay đổi qua nhập/bán)";
    }
}
