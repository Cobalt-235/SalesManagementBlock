using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using Microsoft.Extensions.Logging;
using Quanlybangame.BLL;
using Quanlybangame.DTO;
using QuanlybangameMoi_UI;

namespace Quanlybangame.UI;

internal static class Giaodien
{
    public static readonly Color Xanh = Color.FromArgb(23, 60, 59);
    public static readonly Color Vang = Color.FromArgb(189, 135, 67);
    public static bool DangThietke => LicenseManager.UsageMode == LicenseUsageMode.Designtime;
    public static async Task Chay(Control owner, Func<Task> f)
    {
        if (owner.IsDisposed) return;
        bool old = owner.Enabled;
        owner.Enabled = false; owner.UseWaitCursor = true;
        try { await f(); }
        catch (Exception e)
        {
            Phienlamviec.Log.LogError(e, "Thao tác giao diện thất bại tại {Form}", owner.Name);
            if (owner.IsDisposed) return;
            owner.Enabled = old; owner.UseWaitCursor = false;
            string nd = e is ArgumentException or InvalidOperationException ? e.Message : "Không thể hoàn tất thao tác. Kiểm tra dịch vụ SQL Server, tên máy chủ và quyền truy cập database. Chi tiết đã lưu trong Nhật ký hoạt động.";
            MessageBox.Show(owner, nd, "GAME DESK • Thông báo", MessageBoxButtons.OK, e is ArgumentException or InvalidOperationException ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
        finally { if (!owner.IsDisposed) { owner.Enabled = old; owner.UseWaitCursor = false; } }
    }
    // Giữ đủ nội dung trên laptop có độ phân giải thấp hoặc tỉ lệ DPI lớn.
    public static void ChuanbiForm(Form f)
    {
        f.Load += (_, _) =>
        {
            if (DangThietke || !f.TopLevel) return;
            Rectangle wa = Screen.FromControl(f).WorkingArea;
            int maxw = wa.Width - 24, maxh = wa.Height - 24;
            if (f.Width <= maxw && f.Height <= maxh) return;
            if (f.Name != "trangchinh")
            {
                Size goc = f.ClientSize;
                var khung = new Panel { Name = "khungcuon", Location = Point.Empty, Size = goc, BackColor = f.BackColor };
                var controls = f.Controls.Cast<Control>().Reverse().ToArray();
                f.SuspendLayout();
                foreach (var c in controls) { f.Controls.Remove(c); khung.Controls.Add(c); }
                f.Controls.Add(khung); f.AutoScroll = true;
                f.Resize += (_, _) => khung.Size = new Size(Math.Max(goc.Width, f.ClientSize.Width), Math.Max(goc.Height, f.ClientSize.Height));
                f.ResumeLayout(false);
            }
            f.MinimumSize = new Size(Math.Min(f.MinimumSize.Width, maxw), Math.Min(f.MinimumSize.Height, maxh));
            f.Size = new Size(Math.Min(f.Width, maxw), Math.Min(f.Height, maxh));
            f.Location = new Point(wa.Left + (wa.Width - f.Width) / 2, wa.Top + (wa.Height - f.Height) / 2);
        };
    }
    public static bool Batbuoc(ErrorProvider ep, params (Control O, string Ten)[] ds)
    {
        ep.Clear(); Control? dau = null;
        foreach (var (o, ten) in ds) if (string.IsNullOrWhiteSpace(o.Text)) { ep.SetError(o, "Vui lòng nhập " + ten); dau ??= o; }
        dau?.Focus(); return dau == null;
    }
    public static bool Dongy(IWin32Window owner, string nd) => MessageBox.Show(owner, nd, "GAME DESK • Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
    public static void Thongbao(IWin32Window owner, string nd) => MessageBox.Show(owner, nd, "GAME DESK", MessageBoxButtons.OK, MessageBoxIcon.Information);
    public static void Phimtat(Form f, Func<Task> tailai, Action? them = null)
    {
        f.KeyPreview = true;
        f.KeyDown += async (_, e) =>
        {
            if (e.KeyCode == Keys.F5) { e.SuppressKeyPress = true; await Chay(f, tailai); }
            if (e.Control && e.KeyCode == Keys.N && them != null) { e.SuppressKeyPress = true; them(); }
        };
    }
    public static void TimBang(TextBox o, Button nut) => o.KeyDown += (_, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; nut.PerformClick(); } };
    public static T? Chon<T>(DataGridView bang) where T : class => bang.CurrentRow?.DataBoundItem as T;
    // Chỉ gán liên kết dữ liệu lúc runtime. Trong Designer, cột là cột tự đặt,
    // không phụ thuộc schema của một DataSource chưa tồn tại.
    public static void GanCot(DataGridView bang, params (DataGridViewColumn Cot, string ThuocTinh)[] ds)
    {
        bang.AutoGenerateColumns = false;
        foreach (var (cot, thuocTinh) in ds) cot.DataPropertyName = thuocTinh;
    }
    public static void Gan<T>(DataGridView bang, IList<T> data) { bang.DataSource = null; bang.DataSource = data; }
    public static void XuatBang(Form f, DataGridView bang, string ten)
    {
        if (bang.Rows.Count == 0) { Thongbao(f, "Không có dữ liệu để xuất."); return; }
        using var chon = new SaveFileDialog { Filter = "Bảng CSV (*.csv)|*.csv", FileName = ten + ".csv", OverwritePrompt = true };
        if (chon.ShowDialog(f) != DialogResult.OK) return;
        var cot = bang.Columns.Cast<DataGridViewColumn>().Where(x => x.Visible).OrderBy(x => x.DisplayIndex).ToList();
        var dong = new List<IEnumerable<object?>> { cot.Select(x => (object?)x.HeaderText) };
        foreach (DataGridViewRow r in bang.Rows) dong.Add(cot.Select(c => r.Cells[c.Index].Value is DateTime d ? (object?)d.ToString("dd/MM/yyyy HH:mm") : r.Cells[c.Index].Value).ToArray());
        XuatdulieuBLL.LuuCSV(chon.FileName, dong);
        Phienlamviec.Log.LogInformation("Xuất bảng CSV {Ten}, số dòng {So}", Path.GetFileName(chon.FileName), bang.Rows.Count);
        Thongbao(f, "Đã xuất " + Path.GetFileName(chon.FileName));
    }
    public static void XuatHoadon(Form f, HoadonDTO h)
    {
        using var chon = new SaveFileDialog { Filter = "Hóa đơn HTML (*.html)|*.html|Dữ liệu JSON (*.json)|*.json", FileName = h.Ma + ".html", OverwritePrompt = true };
        if (chon.ShowDialog(f) != DialogResult.OK) return;
        XuatdulieuBLL.LuuHoadon(h, chon.FileName); Phienlamviec.Log.LogInformation("Xuất hóa đơn {Ma}, định dạng {Dinhdang}", h.Ma, Path.GetExtension(chon.FileName));
        Thongbao(f, "Đã xuất " + Path.GetFileName(chon.FileName));
    }
    public static void MoThumuc(string path) { Directory.CreateDirectory(path); Process.Start(new ProcessStartInfo(path) { UseShellExecute = true }); }
    public static void VeBieudo(Graphics g, Rectangle vung, List<DoanhthuNgayDTO> data)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        using var font = new Font("Segoe UI", 9); using var bold = new Font("Segoe UI", 11, FontStyle.Bold);
        using var chu = new SolidBrush(Xanh); using var cot = new SolidBrush(Vang); using var duong = new Pen(Color.FromArgb(222, 231, 223));
        g.DrawString("DOANH THU 10 NGÀY CUỐI KỲ", bold, chu, 16, 16);
        var ds = data.TakeLast(10).ToList();
        if (ds.Count == 0 || ds.Max(x => x.Doanhthu) == 0) { g.DrawString("Chưa có doanh thu trong kỳ này.", font, chu, 20, 78); return; }
        float left = 22, top = 72, bottom = vung.Height - 45, width = vung.Width - 42;
        if (width < 100 || bottom <= top) return;
        var max = ds.Max(x => x.Doanhthu);
        g.DrawString("Cao nhất: " + XuatdulieuBLL.Tien(max), font, chu, 18, 45);
        g.DrawLine(duong, left, bottom, left + width, bottom);
        float step = width / ds.Count;
        for (int i = 0; i < ds.Count; i++)
        {
            float cao = (float)(ds[i].Doanhthu / max) * (bottom - top);
            g.FillRectangle(cot, left + i * step + step * .15f, bottom - cao, step * .7f, cao);
            if (i % 2 == 0 || ds.Count <= 5) g.DrawString(ds[i].Ngay.ToString("dd/MM"), font, chu, left + i * step, bottom + 10);
        }
    }
}
