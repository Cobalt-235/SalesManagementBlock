#nullable disable
using System.ComponentModel;

namespace Quanlybangame.UI.Forms;

partial class quanlykhachhang
{
    private IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        nhantieude = new Label();
        nhanmota = new Label();
        otimkiem = new TextBox();
        nuttimkiem = new Button();
        nutthem = new Button();
        nutsua = new Button();
        nutxoa = new Button();
        nutlammoi = new Button();
        nutxuat = new Button();
        bangkhachhang = new DataGridView();
        bangkhachhangMa = new DataGridViewTextBoxColumn();
        bangkhachhangHoten = new DataGridViewTextBoxColumn();
        bangkhachhangDienthoai = new DataGridViewTextBoxColumn();
        bangkhachhangEmail = new DataGridViewTextBoxColumn();
        khungchitiet = new Panel();
        nhanchitiet = new Label();
        nhanthongtin = new Label();
        nutlichsu = new Button();
        nhantrangthai = new Label();
        ((ISupportInitialize)bangkhachhang).BeginInit();
        khungchitiet.SuspendLayout();
        SuspendLayout();
        // 
        // nhantieude
        // 
        nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
        nhantieude.Location = new Point(20, 6);
        nhantieude.Name = "nhantieude";
        nhantieude.Size = new Size(397, 52);
        nhantieude.TabIndex = 0;
        nhantieude.Text = "Quản lý khách hàng";
        // 
        // nhanmota
        // 
        nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
        nhanmota.Location = new Point(22, 58);
        nhanmota.Name = "nhanmota";
        nhanmota.Size = new Size(996, 26);
        nhanmota.TabIndex = 1;
        nhanmota.Text = "Lưu thông tin khách hàng và theo dõi lịch sử mua game";
        // 
        // otimkiem
        // 
        otimkiem.BorderStyle = BorderStyle.FixedSingle;
        otimkiem.Location = new Point(20, 99);
        otimkiem.Name = "otimkiem";
        otimkiem.PlaceholderText = "Tìm mã khách hàng, họ tên hoặc số điện thoại…";
        otimkiem.Size = new Size(390, 30);
        otimkiem.TabIndex = 2;
        // 
        // nuttimkiem
        // 
        nuttimkiem.BackColor = Color.White;
        nuttimkiem.Cursor = Cursors.Hand;
        nuttimkiem.FlatStyle = FlatStyle.Flat;
        nuttimkiem.ForeColor = Color.FromArgb(23, 60, 59);
        nuttimkiem.Location = new Point(423, 96);
        nuttimkiem.Name = "nuttimkiem";
        nuttimkiem.Size = new Size(110, 36);
        nuttimkiem.TabIndex = 3;
        nuttimkiem.Text = "Tìm kiếm";
        nuttimkiem.UseVisualStyleBackColor = false;
        // 
        // nutthem
        // 
        nutthem.BackColor = Color.FromArgb(23, 60, 59);
        nutthem.Cursor = Cursors.Hand;
        nutthem.FlatAppearance.BorderSize = 0;
        nutthem.FlatStyle = FlatStyle.Flat;
        nutthem.ForeColor = Color.White;
        nutthem.Location = new Point(20, 139);
        nutthem.Name = "nutthem";
        nutthem.Size = new Size(132, 36);
        nutthem.TabIndex = 4;
        nutthem.Text = "+ Thêm khách";
        nutthem.UseVisualStyleBackColor = false;
        // 
        // nutsua
        // 
        nutsua.BackColor = Color.White;
        nutsua.Cursor = Cursors.Hand;
        nutsua.FlatStyle = FlatStyle.Flat;
        nutsua.ForeColor = Color.FromArgb(23, 60, 59);
        nutsua.Location = new Point(162, 139);
        nutsua.Name = "nutsua";
        nutsua.Size = new Size(112, 36);
        nutsua.TabIndex = 5;
        nutsua.Text = "Cập nhật";
        nutsua.UseVisualStyleBackColor = false;
        // 
        // nutxoa
        // 
        nutxoa.BackColor = Color.FromArgb(174, 64, 64);
        nutxoa.Cursor = Cursors.Hand;
        nutxoa.FlatAppearance.BorderSize = 0;
        nutxoa.FlatStyle = FlatStyle.Flat;
        nutxoa.ForeColor = Color.White;
        nutxoa.Location = new Point(284, 139);
        nutxoa.Name = "nutxoa";
        nutxoa.Size = new Size(88, 36);
        nutxoa.TabIndex = 6;
        nutxoa.Text = "Xóa";
        nutxoa.UseVisualStyleBackColor = false;
        // 
        // nutlammoi
        // 
        nutlammoi.BackColor = Color.White;
        nutlammoi.Cursor = Cursors.Hand;
        nutlammoi.FlatStyle = FlatStyle.Flat;
        nutlammoi.ForeColor = Color.FromArgb(23, 60, 59);
        nutlammoi.Location = new Point(382, 139);
        nutlammoi.Name = "nutlammoi";
        nutlammoi.Size = new Size(112, 36);
        nutlammoi.TabIndex = 7;
        nutlammoi.Text = "Làm mới";
        nutlammoi.UseVisualStyleBackColor = false;
        // 
        // nutxuat
        // 
        nutxuat.BackColor = Color.White;
        nutxuat.Cursor = Cursors.Hand;
        nutxuat.FlatStyle = FlatStyle.Flat;
        nutxuat.ForeColor = Color.FromArgb(23, 60, 59);
        nutxuat.Location = new Point(504, 139);
        nutxuat.Name = "nutxuat";
        nutxuat.Size = new Size(112, 36);
        nutxuat.TabIndex = 8;
        nutxuat.Text = "Xuất CSV";
        nutxuat.UseVisualStyleBackColor = false;
        // 
        // bangkhachhang
        // 
        bangkhachhang.AllowUserToAddRows = false;
        bangkhachhang.AllowUserToDeleteRows = false;
        bangkhachhang.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 247);
        bangkhachhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        bangkhachhang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        bangkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        bangkhachhang.BackgroundColor = Color.White;
        bangkhachhang.BorderStyle = BorderStyle.None;
        bangkhachhang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 239, 233);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle2.Padding = new Padding(5);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 239, 233);
        bangkhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        bangkhachhang.ColumnHeadersHeight = 42;
        bangkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        bangkhachhang.Columns.AddRange(new DataGridViewColumn[] { bangkhachhangMa, bangkhachhangHoten, bangkhachhangDienthoai, bangkhachhangEmail });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle3.Padding = new Padding(5);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(209, 229, 218);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        bangkhachhang.DefaultCellStyle = dataGridViewCellStyle3;
        bangkhachhang.EnableHeadersVisualStyles = false;
        bangkhachhang.GridColor = Color.FromArgb(231, 235, 230);
        bangkhachhang.Location = new Point(20, 191);
        bangkhachhang.MultiSelect = false;
        bangkhachhang.Name = "bangkhachhang";
        bangkhachhang.ReadOnly = true;
        bangkhachhang.RowHeadersVisible = false;
        bangkhachhang.RowHeadersWidth = 51;
        bangkhachhang.RowTemplate.Height = 37;
        bangkhachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        bangkhachhang.Size = new Size(704, 397);
        bangkhachhang.TabIndex = 9;
        // 
        // bangkhachhangMa
        // 
        bangkhachhangMa.FillWeight = 80F;
        bangkhachhangMa.HeaderText = "Mã KH";
        bangkhachhangMa.MinimumWidth = 65;
        bangkhachhangMa.Name = "bangkhachhangMa";
        bangkhachhangMa.ReadOnly = true;
        // 
        // bangkhachhangHoten
        // 
        bangkhachhangHoten.FillWeight = 170F;
        bangkhachhangHoten.HeaderText = "Họ tên";
        bangkhachhangHoten.MinimumWidth = 65;
        bangkhachhangHoten.Name = "bangkhachhangHoten";
        bangkhachhangHoten.ReadOnly = true;
        // 
        // bangkhachhangDienthoai
        // 
        bangkhachhangDienthoai.FillWeight = 105F;
        bangkhachhangDienthoai.HeaderText = "Điện thoại";
        bangkhachhangDienthoai.MinimumWidth = 65;
        bangkhachhangDienthoai.Name = "bangkhachhangDienthoai";
        bangkhachhangDienthoai.ReadOnly = true;
        // 
        // bangkhachhangEmail
        // 
        bangkhachhangEmail.FillWeight = 170F;
        bangkhachhangEmail.HeaderText = "Email";
        bangkhachhangEmail.MinimumWidth = 65;
        bangkhachhangEmail.Name = "bangkhachhangEmail";
        bangkhachhangEmail.ReadOnly = true;
        // 
        // khungchitiet
        // 
        khungchitiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        khungchitiet.BackColor = Color.White;
        khungchitiet.Controls.Add(nhanchitiet);
        khungchitiet.Controls.Add(nhanthongtin);
        khungchitiet.Controls.Add(nutlichsu);
        khungchitiet.Location = new Point(742, 191);
        khungchitiet.Name = "khungchitiet";
        khungchitiet.Size = new Size(278, 397);
        khungchitiet.TabIndex = 10;
        // 
        // nhanchitiet
        // 
        nhanchitiet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        nhanchitiet.ForeColor = Color.FromArgb(23, 60, 59);
        nhanchitiet.Location = new Point(18, 18);
        nhanchitiet.Name = "nhanchitiet";
        nhanchitiet.Size = new Size(242, 30);
        nhanchitiet.TabIndex = 0;
        nhanchitiet.Text = "HỒ SƠ KHÁCH HÀNG";
        // 
        // nhanthongtin
        // 
        nhanthongtin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nhanthongtin.ForeColor = Color.FromArgb(23, 60, 59);
        nhanthongtin.Location = new Point(18, 65);
        nhanthongtin.Name = "nhanthongtin";
        nhanthongtin.Size = new Size(242, 260);
        nhanthongtin.TabIndex = 1;
        nhanthongtin.Text = "Chọn khách hàng để xem thông tin.";
        // 
        // nutlichsu
        // 
        nutlichsu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nutlichsu.BackColor = Color.FromArgb(189, 135, 67);
        nutlichsu.Cursor = Cursors.Hand;
        nutlichsu.FlatAppearance.BorderSize = 0;
        nutlichsu.FlatStyle = FlatStyle.Flat;
        nutlichsu.ForeColor = Color.White;
        nutlichsu.Location = new Point(18, 337);
        nutlichsu.Name = "nutlichsu";
        nutlichsu.Size = new Size(242, 40);
        nutlichsu.TabIndex = 17;
        nutlichsu.Text = "Lịch sử mua hàng";
        nutlichsu.UseVisualStyleBackColor = false;
        // 
        // nhantrangthai
        // 
        nhantrangthai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nhantrangthai.ForeColor = Color.FromArgb(101, 119, 115);
        nhantrangthai.Location = new Point(22, 606);
        nhantrangthai.Name = "nhantrangthai";
        nhantrangthai.Size = new Size(994, 27);
        nhantrangthai.TabIndex = 11;
        nhantrangthai.Text = "Chưa kết nối SQL • Mở Thêm khách để xem form nhập liệu.";
        // 
        // quanlykhachhang
        // 
        AutoScaleDimensions = new SizeF(120F, 120F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(245, 247, 244);
        ClientSize = new Size(1040, 650);
        Controls.Add(nhantieude);
        Controls.Add(nhanmota);
        Controls.Add(otimkiem);
        Controls.Add(nuttimkiem);
        Controls.Add(nutthem);
        Controls.Add(nutsua);
        Controls.Add(nutxoa);
        Controls.Add(nutlammoi);
        Controls.Add(nutxuat);
        Controls.Add(bangkhachhang);
        Controls.Add(khungchitiet);
        Controls.Add(nhantrangthai);
        Font = new Font("Segoe UI", 10F);
        ForeColor = Color.FromArgb(23, 60, 59);
        FormBorderStyle = FormBorderStyle.None;
        Name = "quanlykhachhang";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Quản lý khách hàng";
        ((ISupportInitialize)bangkhachhang).EndInit();
        khungchitiet.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label nhantieude;
    private Label nhanmota;
    private TextBox otimkiem;
    private Button nuttimkiem;
    private Button nutthem;
    private Button nutsua;
    private Button nutxoa;
    private Button nutlammoi;
    private Button nutxuat;
    private DataGridView bangkhachhang;
    private DataGridViewTextBoxColumn bangkhachhangMa;
    private DataGridViewTextBoxColumn bangkhachhangHoten;
    private DataGridViewTextBoxColumn bangkhachhangDienthoai;
    private DataGridViewTextBoxColumn bangkhachhangEmail;
    private Panel khungchitiet;
    private Label nhanchitiet;
    private Label nhanthongtin;
    private Button nutlichsu;
    private Label nhantrangthai;
}
