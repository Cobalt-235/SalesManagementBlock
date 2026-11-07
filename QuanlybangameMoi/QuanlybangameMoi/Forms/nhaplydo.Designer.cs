#nullable disable
using System.ComponentModel;

namespace Quanlybangame.UI.Forms;

partial class nhaplydo
{
    private IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new Container();
        nhantieude = new Label();
        nhanhuongdan = new Label();
        olydo = new TextBox();
        nutdongy = new Button();
        nutdong = new Button();
        kiemtraloi = new ErrorProvider(components);
        ((ISupportInitialize)kiemtraloi).BeginInit();
        SuspendLayout();
        nhantieude.Name = "nhantieude";
        nhantieude.Location = new Point(24, 24);
        nhantieude.Size = new Size(520, 40);
        nhantieude.Text = "Lý do hủy hóa đơn";
        nhantieude.ForeColor = Color.FromArgb(101, 119, 115);
        nhantieude.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
        nhanhuongdan.Name = "nhanhuongdan";
        nhanhuongdan.Location = new Point(24, 79);
        nhanhuongdan.Size = new Size(520, 35);
        nhanhuongdan.Text = "Hóa đơn hủy sẽ hoàn kho và được loại khỏi doanh thu.";
        nhanhuongdan.ForeColor = Color.FromArgb(101, 119, 115);
        olydo.Name = "olydo";
        olydo.Location = new Point(24, 122);
        olydo.Size = new Size(520, 112);
        olydo.BorderStyle = BorderStyle.FixedSingle;
        olydo.TabIndex = 2;
        olydo.Multiline = true;
        olydo.ScrollBars = ScrollBars.Vertical;
        olydo.MaxLength = 250;
        nutdongy.Name = "nutdongy";
        nutdongy.Location = new Point(244, 277);
        nutdongy.Size = new Size(170, 36);
        nutdongy.Text = "Xác nhận hủy";
        nutdongy.FlatStyle = FlatStyle.Flat;
        nutdongy.FlatAppearance.BorderSize = 0;
        nutdongy.BackColor = Color.FromArgb(174, 64, 64);
        nutdongy.ForeColor = Color.White;
        nutdongy.UseVisualStyleBackColor = false;
        nutdongy.Cursor = Cursors.Hand;
        nutdongy.TabIndex = 3;
        nutdong.Name = "nutdong";
        nutdong.Location = new Point(427, 277);
        nutdong.Size = new Size(116, 36);
        nutdong.Text = "Quay lại";
        nutdong.FlatStyle = FlatStyle.Flat;
        nutdong.FlatAppearance.BorderSize = 1;
        nutdong.BackColor = Color.White;
        nutdong.ForeColor = Color.FromArgb(23, 60, 59);
        nutdong.UseVisualStyleBackColor = false;
        nutdong.Cursor = Cursors.Hand;
        nutdong.TabIndex = 4;
        nutdong.DialogResult = DialogResult.Cancel;
        kiemtraloi.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        kiemtraloi.ContainerControl = this;
        Controls.Add(nhantieude);
        Controls.Add(nhanhuongdan);
        Controls.Add(olydo);
        Controls.Add(nutdongy);
        Controls.Add(nutdong);
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(570, 340);
        Font = new Font("Segoe UI", 10F);
        BackColor = Color.FromArgb(245, 247, 244);
        ForeColor = Color.FromArgb(23, 60, 59);
        Name = "nhaplydo";
        Text = "Lý do hủy hóa đơn";
        StartPosition = FormStartPosition.CenterParent;
        MinimumSize = new Size(570, 340);
        CancelButton = nutdong;
        MaximizeBox = false;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        ((ISupportInitialize)kiemtraloi).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label nhantieude;
    private Label nhanhuongdan;
    private TextBox olydo;
    private Button nutdongy;
    private Button nutdong;
    private ErrorProvider kiemtraloi;
}
