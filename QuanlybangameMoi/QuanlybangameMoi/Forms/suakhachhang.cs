using System.Runtime.Intrinsics.X86;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quanlybangame.UI.Forms;

public partial class suakhachhang : Form
{
    private readonly int id;
    private readonly byte[] phienban = [];
    public int IdDaLuu { get; private set; }
    public suakhachhang()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.ChuanbiForm(this);
        nutluu.Click += async (_, _) =>
        {
            if (!Giaodien.Batbuoc(kiemtraloi, (oma, "mã khách"), (oten, "họ tên"), (odienthoai, "số điện thoại"))) return;
            var k = new KhachhangDTO { Id = id, Phienban = phienban, Ma = oma.Text, Hoten = oten.Text, Dienthoai = odienthoai.Text, Email = oemail.Text, Diachi = odiachi.Text };
            await Giaodien.Chay(this, async () => { IdDaLuu = await Task.Run(() => Phienlamviec.Dichvu.LuuKhachhang(k)); DialogResult = DialogResult.OK; Close(); });
        };
    }
    public suakhachhang(KhachhangDTO k) : this()
    {
        id = k.Id; phienban = k.Phienban.ToArray(); Text = "Cập nhật khách • " + k.Ma;
        oma.Text = k.Ma; oten.Text = k.Hoten; odienthoai.Text = k.Dienthoai; oemail.Text = k.Email; odiachi.Text = k.Diachi;
    }
}
