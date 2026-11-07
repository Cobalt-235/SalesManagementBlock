using QuanlybangameMoi_UI;

namespace Quanlybangame.UI.Forms;

public partial class nhatky : Form
{
    public nhatky()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.ChuanbiForm(this);
        ngayxem.Value = DateTime.Today;
        nuttailai.Click += async (_, _) => await Giaodien.Chay(this, Tailai);
        nutthumuc.Click += async (_, _) => await Giaodien.Chay(this, () => { Giaodien.MoThumuc(NhatkyProvider.Thumuc); return Task.CompletedTask; });
        Shown += async (_, _) => { if (!Giaodien.DangThietke) await Giaodien.Chay(this, Tailai); };
    }
    private async Task Tailai()
    {
        string path = NhatkyProvider.Duongdan(ngayxem.Value);
        string nd = await Task.Run(() => File.Exists(path) ? string.Join(Environment.NewLine, File.ReadLines(path).TakeLast(800)) : "Chưa có nhật ký cho ngày được chọn.");
        onhatky.Text = nd; onhatky.SelectionStart = onhatky.TextLength; onhatky.ScrollToCaret();
    }
}
