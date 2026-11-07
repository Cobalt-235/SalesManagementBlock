namespace Quanlybangame.UI.Forms;

public partial class nhaplydo : Form
{
    public string Lydo => olydo.Text.Trim();
    public nhaplydo()
    {
        InitializeComponent();
        if (Giaodien.DangThietke) return;
        Giaodien.ChuanbiForm(this);
        nutdongy.Click += (_, _) => { if (Giaodien.Batbuoc(kiemtraloi, (olydo, "lý do hủy"))) { DialogResult = DialogResult.OK; Close(); } };
    }
}
