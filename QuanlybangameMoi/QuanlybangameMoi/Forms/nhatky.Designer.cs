#nullable disable
using System.ComponentModel;

namespace Quanlybangame.UI.Forms;

partial class nhatky
{
    private IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        nhantieude = new Label();
        nhanmota = new Label();
        ngayxem = new DateTimePicker();
        nuttailai = new Button();
        nutthumuc = new Button();
        onhatky = new TextBox();
        nutdong = new Button();
        SuspendLayout();
        // 
        // nhantieude
        // 
        nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
        nhantieude.Location = new Point(20, 0);
        nhantieude.Name = "nhantieude";
        nhantieude.Size = new Size(585, 52);
        nhantieude.TabIndex = 0;
        nhantieude.Text = "Nhật ký hoạt động";
        // 
        // nhanmota
        // 
        nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
        nhanmota.Location = new Point(22, 58);
        nhanmota.Name = "nhanmota";
        nhanmota.Size = new Size(976, 26);
        nhanmota.TabIndex = 1;
        nhanmota.Text = "Theo dõi thao tác, dữ liệu chưa hợp lệ và lỗi ứng dụng";
        // 
        // ngayxem
        // 
        ngayxem.CustomFormat = "dd/MM/yyyy";
        ngayxem.Format = DateTimePickerFormat.Custom;
        ngayxem.Location = new Point(20, 99);
        ngayxem.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
        ngayxem.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        ngayxem.Name = "ngayxem";
        ngayxem.Size = new Size(170, 30);
        ngayxem.TabIndex = 2;
        // 
        // nuttailai
        // 
        nuttailai.BackColor = Color.White;
        nuttailai.Cursor = Cursors.Hand;
        nuttailai.FlatStyle = FlatStyle.Flat;
        nuttailai.ForeColor = Color.FromArgb(23, 60, 59);
        nuttailai.Location = new Point(205, 96);
        nuttailai.Name = "nuttailai";
        nuttailai.Size = new Size(145, 36);
        nuttailai.TabIndex = 3;
        nuttailai.Text = "Tải nhật ký";
        nuttailai.UseVisualStyleBackColor = false;
        // 
        // nutthumuc
        // 
        nutthumuc.BackColor = Color.White;
        nutthumuc.Cursor = Cursors.Hand;
        nutthumuc.FlatStyle = FlatStyle.Flat;
        nutthumuc.ForeColor = Color.FromArgb(23, 60, 59);
        nutthumuc.Location = new Point(364, 96);
        nutthumuc.Name = "nutthumuc";
        nutthumuc.Size = new Size(180, 36);
        nutthumuc.TabIndex = 4;
        nutthumuc.Text = "Mở thư mục log";
        nutthumuc.UseVisualStyleBackColor = false;
        // 
        // onhatky
        // 
        onhatky.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        onhatky.BorderStyle = BorderStyle.FixedSingle;
        onhatky.Font = new Font("Consolas", 10F);
        onhatky.Location = new Point(20, 150);
        onhatky.Multiline = true;
        onhatky.Name = "onhatky";
        onhatky.ReadOnly = true;
        onhatky.ScrollBars = ScrollBars.Both;
        onhatky.Size = new Size(978, 480);
        onhatky.TabIndex = 5;
        onhatky.WordWrap = false;
        // 
        // nutdong
        // 
        nutdong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        nutdong.BackColor = Color.White;
        nutdong.Cursor = Cursors.Hand;
        nutdong.DialogResult = DialogResult.Cancel;
        nutdong.FlatStyle = FlatStyle.Flat;
        nutdong.ForeColor = Color.FromArgb(23, 60, 59);
        nutdong.Location = new Point(868, 649);
        nutdong.Name = "nutdong";
        nutdong.Size = new Size(130, 36);
        nutdong.TabIndex = 6;
        nutdong.Text = "Đóng";
        nutdong.UseVisualStyleBackColor = false;
        // 
        // nhatky
        // 
        AutoScaleDimensions = new SizeF(120F, 120F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(245, 247, 244);
        CancelButton = nutdong;
        ClientSize = new Size(1020, 700);
        Controls.Add(nhantieude);
        Controls.Add(nhanmota);
        Controls.Add(ngayxem);
        Controls.Add(nuttailai);
        Controls.Add(nutthumuc);
        Controls.Add(onhatky);
        Controls.Add(nutdong);
        Font = new Font("Segoe UI", 10F);
        ForeColor = Color.FromArgb(23, 60, 59);
        MinimumSize = new Size(1020, 700);
        Name = "nhatky";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Nhật ký hoạt động";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label nhantieude;
    private Label nhanmota;
    private DateTimePicker ngayxem;
    private Button nuttailai;
    private Button nutthumuc;
    private TextBox onhatky;
    private Button nutdong;
}
