#nullable disable
using System.ComponentModel;

namespace Quanlybangame.UI.Forms;

partial class suakhachhang
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
        nhanoma = new Label();
        oma = new TextBox();
        nhanoten = new Label();
        oten = new TextBox();
        nhanodienthoai = new Label();
        odienthoai = new TextBox();
        nhanoemail = new Label();
        oemail = new TextBox();
        nhandiachi = new Label();
        odiachi = new TextBox();
        nhanluuy = new Label();
        nutluu = new Button();
        nuthuy = new Button();
        kiemtraloi = new ErrorProvider(components);
        ((ISupportInitialize)kiemtraloi).BeginInit();
        SuspendLayout();
        // 
        // nhantieude
        // 
        nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
        nhantieude.Location = new Point(19, 3);
        nhantieude.Name = "nhantieude";
        nhantieude.Size = new Size(610, 49);
        nhantieude.TabIndex = 0;
        nhantieude.Text = "Thông tin khách hàng";
        // 
        // nhanmota
        // 
        nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
        nhanmota.Location = new Point(22, 58);
        nhanmota.Name = "nhanmota";
        nhanmota.Size = new Size(606, 26);
        nhanmota.TabIndex = 1;
        nhanmota.Text = "Thông tin liên hệ để lưu hóa đơn và tra cứu lịch sử mua hàng";
        // 
        // nhanoma
        // 
        nhanoma.ForeColor = Color.FromArgb(101, 119, 115);
        nhanoma.Location = new Point(24, 112);
        nhanoma.Name = "nhanoma";
        nhanoma.Size = new Size(260, 24);
        nhanoma.TabIndex = 2;
        nhanoma.Text = "Mã khách hàng *";
        // 
        // oma
        // 
        oma.BorderStyle = BorderStyle.FixedSingle;
        oma.Location = new Point(24, 142);
        oma.MaxLength = 30;
        oma.Name = "oma";
        oma.Size = new Size(260, 30);
        oma.TabIndex = 3;
        // 
        // nhanoten
        // 
        nhanoten.ForeColor = Color.FromArgb(101, 119, 115);
        nhanoten.Location = new Point(310, 112);
        nhanoten.Name = "nhanoten";
        nhanoten.Size = new Size(310, 24);
        nhanoten.TabIndex = 4;
        nhanoten.Text = "Họ và tên *";
        // 
        // oten
        // 
        oten.BorderStyle = BorderStyle.FixedSingle;
        oten.Location = new Point(310, 142);
        oten.MaxLength = 100;
        oten.Name = "oten";
        oten.Size = new Size(310, 30);
        oten.TabIndex = 5;
        // 
        // nhanodienthoai
        // 
        nhanodienthoai.ForeColor = Color.FromArgb(101, 119, 115);
        nhanodienthoai.Location = new Point(24, 202);
        nhanodienthoai.Name = "nhanodienthoai";
        nhanodienthoai.Size = new Size(260, 24);
        nhanodienthoai.TabIndex = 6;
        nhanodienthoai.Text = "Số điện thoại *";
        // 
        // odienthoai
        // 
        odienthoai.BorderStyle = BorderStyle.FixedSingle;
        odienthoai.Location = new Point(24, 232);
        odienthoai.MaxLength = 15;
        odienthoai.Name = "odienthoai";
        odienthoai.Size = new Size(260, 30);
        odienthoai.TabIndex = 7;
        // 
        // nhanoemail
        // 
        nhanoemail.ForeColor = Color.FromArgb(101, 119, 115);
        nhanoemail.Location = new Point(310, 202);
        nhanoemail.Name = "nhanoemail";
        nhanoemail.Size = new Size(310, 24);
        nhanoemail.TabIndex = 8;
        nhanoemail.Text = "Email";
        // 
        // oemail
        // 
        oemail.BorderStyle = BorderStyle.FixedSingle;
        oemail.Location = new Point(310, 232);
        oemail.MaxLength = 150;
        oemail.Name = "oemail";
        oemail.Size = new Size(310, 30);
        oemail.TabIndex = 9;
        // 
        // nhandiachi
        // 
        nhandiachi.ForeColor = Color.FromArgb(101, 119, 115);
        nhandiachi.Location = new Point(24, 296);
        nhandiachi.Name = "nhandiachi";
        nhandiachi.Size = new Size(560, 24);
        nhandiachi.TabIndex = 10;
        nhandiachi.Text = "Địa chỉ";
        // 
        // odiachi
        // 
        odiachi.BorderStyle = BorderStyle.FixedSingle;
        odiachi.Location = new Point(24, 328);
        odiachi.MaxLength = 250;
        odiachi.Multiline = true;
        odiachi.Name = "odiachi";
        odiachi.ScrollBars = ScrollBars.Vertical;
        odiachi.Size = new Size(596, 100);
        odiachi.TabIndex = 11;
        // 
        // nhanluuy
        // 
        nhanluuy.ForeColor = Color.FromArgb(101, 119, 115);
        nhanluuy.Location = new Point(24, 450);
        nhanluuy.Name = "nhanluuy";
        nhanluuy.Size = new Size(596, 58);
        nhanluuy.TabIndex = 12;
        nhanluuy.Text = "Điện thoại gồm 10–11 chữ số, bắt đầu bằng 0.\nMã khách hàng và số điện thoại không được trùng.";
        // 
        // nutluu
        // 
        nutluu.BackColor = Color.FromArgb(23, 60, 59);
        nutluu.Cursor = Cursors.Hand;
        nutluu.FlatAppearance.BorderSize = 0;
        nutluu.FlatStyle = FlatStyle.Flat;
        nutluu.ForeColor = Color.White;
        nutluu.Location = new Point(324, 549);
        nutluu.Name = "nutluu";
        nutluu.Size = new Size(165, 36);
        nutluu.TabIndex = 13;
        nutluu.Text = "Lưu khách hàng";
        nutluu.UseVisualStyleBackColor = false;
        // 
        // nuthuy
        // 
        nuthuy.BackColor = Color.White;
        nuthuy.Cursor = Cursors.Hand;
        nuthuy.DialogResult = DialogResult.Cancel;
        nuthuy.FlatStyle = FlatStyle.Flat;
        nuthuy.ForeColor = Color.FromArgb(23, 60, 59);
        nuthuy.Location = new Point(501, 549);
        nuthuy.Name = "nuthuy";
        nuthuy.Size = new Size(120, 36);
        nuthuy.TabIndex = 14;
        nuthuy.Text = "Hủy";
        nuthuy.UseVisualStyleBackColor = false;
        // 
        // kiemtraloi
        // 
        kiemtraloi.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        kiemtraloi.ContainerControl = this;
        // 
        // suakhachhang
        // 
        AcceptButton = nutluu;
        AutoScaleDimensions = new SizeF(120F, 120F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(245, 247, 244);
        CancelButton = nuthuy;
        ClientSize = new Size(650, 610);
        Controls.Add(nhantieude);
        Controls.Add(nhanmota);
        Controls.Add(nhanoma);
        Controls.Add(oma);
        Controls.Add(nhanoten);
        Controls.Add(oten);
        Controls.Add(nhanodienthoai);
        Controls.Add(odienthoai);
        Controls.Add(nhanoemail);
        Controls.Add(oemail);
        Controls.Add(nhandiachi);
        Controls.Add(odiachi);
        Controls.Add(nhanluuy);
        Controls.Add(nutluu);
        Controls.Add(nuthuy);
        Font = new Font("Segoe UI", 10F);
        ForeColor = Color.FromArgb(23, 60, 59);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimumSize = new Size(650, 610);
        Name = "suakhachhang";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Thông tin khách hàng";
        ((ISupportInitialize)kiemtraloi).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label nhantieude;
    private Label nhanmota;
    private Label nhanoma;
    private TextBox oma;
    private Label nhanoten;
    private TextBox oten;
    private Label nhanodienthoai;
    private TextBox odienthoai;
    private Label nhanoemail;
    private TextBox oemail;
    private Label nhandiachi;
    private TextBox odiachi;
    private Label nhanluuy;
    private Button nutluu;
    private Button nuthuy;
    private ErrorProvider kiemtraloi;
}
