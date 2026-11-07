#nullable disable
using System.ComponentModel;

namespace Quanlybangame.UI.Forms;

partial class nhapkho
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
        nhanmota = new Label();
        nhangame = new Label();
        chongame = new ComboBox();
        nhanton = new Label();
        nhansl = new Label();
        osoluong = new NumericUpDown();
        nhangia = new Label();
        odongia = new NumericUpDown();
        nhanncc = new Label();
        onhacungcap = new TextBox();
        nhangc = new Label();
        oghichu = new TextBox();
        nhantong = new Label();
        nutluu = new Button();
        nuthuy = new Button();
        kiemtraloi = new ErrorProvider(components);
        ((ISupportInitialize)osoluong).BeginInit();
        ((ISupportInitialize)odongia).BeginInit();
        ((ISupportInitialize)kiemtraloi).BeginInit();
        SuspendLayout();
        // 
        // nhantieude
        // 
        nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
        nhantieude.Location = new Point(22, 9);
        nhantieude.Name = "nhantieude";
        nhantieude.Size = new Size(650, 49);
        nhantieude.TabIndex = 0;
        nhantieude.Text = "Nhập kho game";
        // 
        // nhanmota
        // 
        nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
        nhanmota.Location = new Point(22, 58);
        nhanmota.Name = "nhanmota";
        nhanmota.Size = new Size(646, 26);
        nhanmota.TabIndex = 1;
        nhanmota.Text = "Số lượng nhập sẽ cộng vào tồn và được lưu trong lịch sử kho";
        // 
        // nhangame
        // 
        nhangame.ForeColor = Color.FromArgb(101, 119, 115);
        nhangame.Location = new Point(24, 111);
        nhangame.Name = "nhangame";
        nhangame.Size = new Size(620, 24);
        nhangame.TabIndex = 2;
        nhangame.Text = "Chọn game *";
        // 
        // chongame
        // 
        chongame.DisplayMember = "Hienthi";
        chongame.DropDownHeight = 300;
        chongame.DropDownStyle = ComboBoxStyle.DropDownList;
        chongame.IntegralHeight = false;
        chongame.Location = new Point(24, 143);
        chongame.Name = "chongame";
        chongame.Size = new Size(635, 31);
        chongame.TabIndex = 3;
        // 
        // nhanton
        // 
        nhanton.ForeColor = Color.FromArgb(101, 119, 115);
        nhanton.Location = new Point(24, 191);
        nhanton.Name = "nhanton";
        nhanton.Size = new Size(635, 24);
        nhanton.TabIndex = 4;
        nhanton.Text = "Tồn hiện tại: —";
        // 
        // nhansl
        // 
        nhansl.ForeColor = Color.FromArgb(101, 119, 115);
        nhansl.Location = new Point(24, 246);
        nhansl.Name = "nhansl";
        nhansl.Size = new Size(285, 24);
        nhansl.TabIndex = 5;
        nhansl.Text = "Số lượng nhập *";
        // 
        // osoluong
        // 
        osoluong.Location = new Point(24, 278);
        osoluong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        osoluong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        osoluong.Name = "osoluong";
        osoluong.Size = new Size(285, 30);
        osoluong.TabIndex = 6;
        osoluong.TextAlign = HorizontalAlignment.Right;
        osoluong.ThousandsSeparator = true;
        osoluong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // nhangia
        // 
        nhangia.ForeColor = Color.FromArgb(101, 119, 115);
        nhangia.Location = new Point(344, 246);
        nhangia.Name = "nhangia";
        nhangia.Size = new Size(315, 24);
        nhangia.TabIndex = 7;
        nhangia.Text = "Đơn giá nhập (đ)";
        // 
        // odongia
        // 
        odongia.Location = new Point(344, 278);
        odongia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        odongia.Name = "odongia";
        odongia.Size = new Size(315, 30);
        odongia.TabIndex = 8;
        odongia.TextAlign = HorizontalAlignment.Right;
        odongia.ThousandsSeparator = true;
        // 
        // nhanncc
        // 
        nhanncc.ForeColor = Color.FromArgb(101, 119, 115);
        nhanncc.Location = new Point(24, 331);
        nhanncc.Name = "nhanncc";
        nhanncc.Size = new Size(635, 24);
        nhanncc.TabIndex = 9;
        nhanncc.Text = "Nhà cung cấp *";
        // 
        // onhacungcap
        // 
        onhacungcap.BorderStyle = BorderStyle.FixedSingle;
        onhacungcap.Location = new Point(24, 363);
        onhacungcap.MaxLength = 100;
        onhacungcap.Name = "onhacungcap";
        onhacungcap.Size = new Size(635, 30);
        onhacungcap.TabIndex = 10;
        // 
        // nhangc
        // 
        nhangc.ForeColor = Color.FromArgb(101, 119, 115);
        nhangc.Location = new Point(24, 414);
        nhangc.Name = "nhangc";
        nhangc.Size = new Size(635, 24);
        nhangc.TabIndex = 11;
        nhangc.Text = "Ghi chú";
        // 
        // oghichu
        // 
        oghichu.BorderStyle = BorderStyle.FixedSingle;
        oghichu.Location = new Point(24, 446);
        oghichu.MaxLength = 500;
        oghichu.Multiline = true;
        oghichu.Name = "oghichu";
        oghichu.ScrollBars = ScrollBars.Vertical;
        oghichu.Size = new Size(635, 62);
        oghichu.TabIndex = 12;
        // 
        // nhantong
        // 
        nhantong.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        nhantong.ForeColor = Color.FromArgb(23, 60, 59);
        nhantong.Location = new Point(24, 535);
        nhantong.Name = "nhantong";
        nhantong.Size = new Size(635, 32);
        nhantong.TabIndex = 13;
        nhantong.Text = "Tổng tiền nhập: 0 đ";
        // 
        // nutluu
        // 
        nutluu.BackColor = Color.FromArgb(23, 60, 59);
        nutluu.Cursor = Cursors.Hand;
        nutluu.FlatAppearance.BorderSize = 0;
        nutluu.FlatStyle = FlatStyle.Flat;
        nutluu.ForeColor = Color.White;
        nutluu.Location = new Point(358, 599);
        nutluu.Name = "nutluu";
        nutluu.Size = new Size(175, 36);
        nutluu.TabIndex = 14;
        nutluu.Text = "Lưu phiếu nhập";
        nutluu.UseVisualStyleBackColor = false;
        // 
        // nuthuy
        // 
        nuthuy.BackColor = Color.White;
        nuthuy.Cursor = Cursors.Hand;
        nuthuy.DialogResult = DialogResult.Cancel;
        nuthuy.FlatStyle = FlatStyle.Flat;
        nuthuy.ForeColor = Color.FromArgb(23, 60, 59);
        nuthuy.Location = new Point(545, 599);
        nuthuy.Name = "nuthuy";
        nuthuy.Size = new Size(114, 36);
        nuthuy.TabIndex = 15;
        nuthuy.Text = "Hủy";
        nuthuy.UseVisualStyleBackColor = false;
        // 
        // kiemtraloi
        // 
        kiemtraloi.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        kiemtraloi.ContainerControl = this;
        // 
        // nhapkho
        // 
        AcceptButton = nutluu;
        AutoScaleDimensions = new SizeF(120F, 120F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(245, 247, 244);
        CancelButton = nuthuy;
        ClientSize = new Size(690, 660);
        Controls.Add(nhantieude);
        Controls.Add(nhanmota);
        Controls.Add(nhangame);
        Controls.Add(chongame);
        Controls.Add(nhanton);
        Controls.Add(nhansl);
        Controls.Add(osoluong);
        Controls.Add(nhangia);
        Controls.Add(odongia);
        Controls.Add(nhanncc);
        Controls.Add(onhacungcap);
        Controls.Add(nhangc);
        Controls.Add(oghichu);
        Controls.Add(nhantong);
        Controls.Add(nutluu);
        Controls.Add(nuthuy);
        Font = new Font("Segoe UI", 10F);
        ForeColor = Color.FromArgb(23, 60, 59);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimumSize = new Size(690, 660);
        Name = "nhapkho";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Nhập kho game";
        ((ISupportInitialize)osoluong).EndInit();
        ((ISupportInitialize)odongia).EndInit();
        ((ISupportInitialize)kiemtraloi).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label nhantieude;
    private Label nhanmota;
    private Label nhangame;
    private ComboBox chongame;
    private Label nhanton;
    private Label nhansl;
    private NumericUpDown osoluong;
    private Label nhangia;
    private NumericUpDown odongia;
    private Label nhanncc;
    private TextBox onhacungcap;
    private Label nhangc;
    private TextBox oghichu;
    private Label nhantong;
    private Button nutluu;
    private Button nuthuy;
    private ErrorProvider kiemtraloi;
}
