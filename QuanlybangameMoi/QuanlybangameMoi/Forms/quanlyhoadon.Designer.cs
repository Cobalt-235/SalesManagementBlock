#nullable disable
using System.ComponentModel;

namespace Quanlybangame.UI.Forms;

partial class quanlyhoadon
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
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
        nhantieude = new Label();
        nhanmota = new Label();
        nhantu = new Label();
        ngaytu = new DateTimePicker();
        nhanden = new Label();
        ngayden = new DateTimePicker();
        otimkiem = new TextBox();
        nuttimkiem = new Button();
        nuttao = new Button();
        nutxem = new Button();
        nutxuat = new Button();
        nuthuy = new Button();
        nutlammoi = new Button();
        banghoadon = new DataGridView();
        banghoadonMa = new DataGridViewTextBoxColumn();
        banghoadonNgaylap = new DataGridViewTextBoxColumn();
        banghoadonKhachhang = new DataGridViewTextBoxColumn();
        banghoadonTongtien = new DataGridViewTextBoxColumn();
        banghoadonTrangthai = new DataGridViewTextBoxColumn();
        nhanchitiet = new Label();
        bangchitiet = new DataGridView();
        bangchitietMa = new DataGridViewTextBoxColumn();
        bangchitietTen = new DataGridViewTextBoxColumn();
        bangchitietDongia = new DataGridViewTextBoxColumn();
        bangchitietSoluong = new DataGridViewTextBoxColumn();
        bangchitietThanhtien = new DataGridViewTextBoxColumn();
        nhantong = new Label();
        nhantrangthai = new Label();
        ((ISupportInitialize)banghoadon).BeginInit();
        ((ISupportInitialize)bangchitiet).BeginInit();
        SuspendLayout();
        // 
        // nhantieude
        // 
        nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
        nhantieude.Location = new Point(20, 8);
        nhantieude.Name = "nhantieude";
        nhantieude.Size = new Size(414, 43);
        nhantieude.TabIndex = 0;
        nhantieude.Text = "Quản lý hóa đơn";
        // 
        // nhanmota
        // 
        nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
        nhanmota.Location = new Point(22, 58);
        nhanmota.Name = "nhanmota";
        nhanmota.Size = new Size(996, 26);
        nhanmota.TabIndex = 1;
        nhanmota.Text = "Tạo hóa đơn bán game, xem chi tiết, in và xuất phiếu bán hàng";
        // 
        // nhantu
        // 
        nhantu.ForeColor = Color.FromArgb(101, 119, 115);
        nhantu.Location = new Point(7, 99);
        nhantu.Name = "nhantu";
        nhantu.Size = new Size(41, 24);
        nhantu.TabIndex = 2;
        nhantu.Text = "Từ";
        // 
        // ngaytu
        // 
        ngaytu.CustomFormat = "dd/MM/yyyy";
        ngaytu.Format = DateTimePickerFormat.Custom;
        ngaytu.Location = new Point(51, 96);
        ngaytu.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
        ngaytu.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        ngaytu.Name = "ngaytu";
        ngaytu.Size = new Size(145, 30);
        ngaytu.TabIndex = 3;
        // 
        // nhanden
        // 
        nhanden.ForeColor = Color.FromArgb(101, 119, 115);
        nhanden.Location = new Point(202, 99);
        nhanden.Name = "nhanden";
        nhanden.Size = new Size(45, 24);
        nhanden.TabIndex = 4;
        nhanden.Text = "Đến";
        // 
        // ngayden
        // 
        ngayden.CustomFormat = "dd/MM/yyyy";
        ngayden.Format = DateTimePickerFormat.Custom;
        ngayden.Location = new Point(252, 96);
        ngayden.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
        ngayden.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        ngayden.Name = "ngayden";
        ngayden.Size = new Size(145, 30);
        ngayden.TabIndex = 5;
        // 
        // otimkiem
        // 
        otimkiem.BorderStyle = BorderStyle.FixedSingle;
        otimkiem.Location = new Point(412, 97);
        otimkiem.Name = "otimkiem";
        otimkiem.PlaceholderText = "Mã hóa đơn, khách hàng, điện thoại…";
        otimkiem.Size = new Size(330, 30);
        otimkiem.TabIndex = 6;
        // 
        // nuttimkiem
        // 
        nuttimkiem.BackColor = Color.White;
        nuttimkiem.Cursor = Cursors.Hand;
        nuttimkiem.FlatStyle = FlatStyle.Flat;
        nuttimkiem.ForeColor = Color.FromArgb(23, 60, 59);
        nuttimkiem.Location = new Point(754, 94);
        nuttimkiem.Name = "nuttimkiem";
        nuttimkiem.Size = new Size(115, 36);
        nuttimkiem.TabIndex = 7;
        nuttimkiem.Text = "Tìm kiếm";
        nuttimkiem.UseVisualStyleBackColor = false;
        // 
        // nuttao
        // 
        nuttao.BackColor = Color.FromArgb(23, 60, 59);
        nuttao.Cursor = Cursors.Hand;
        nuttao.FlatAppearance.BorderSize = 0;
        nuttao.FlatStyle = FlatStyle.Flat;
        nuttao.ForeColor = Color.White;
        nuttao.Location = new Point(20, 139);
        nuttao.Name = "nuttao";
        nuttao.Size = new Size(150, 36);
        nuttao.TabIndex = 8;
        nuttao.Text = "+ Tạo hóa đơn";
        nuttao.UseVisualStyleBackColor = false;
        // 
        // nutxem
        // 
        nutxem.BackColor = Color.White;
        nutxem.Cursor = Cursors.Hand;
        nutxem.FlatStyle = FlatStyle.Flat;
        nutxem.ForeColor = Color.FromArgb(23, 60, 59);
        nutxem.Location = new Point(180, 139);
        nutxem.Name = "nutxem";
        nutxem.Size = new Size(120, 36);
        nutxem.TabIndex = 9;
        nutxem.Text = "Xem / In";
        nutxem.UseVisualStyleBackColor = false;
        // 
        // nutxuat
        // 
        nutxuat.BackColor = Color.White;
        nutxuat.Cursor = Cursors.Hand;
        nutxuat.FlatStyle = FlatStyle.Flat;
        nutxuat.ForeColor = Color.FromArgb(23, 60, 59);
        nutxuat.Location = new Point(310, 139);
        nutxuat.Name = "nutxuat";
        nutxuat.Size = new Size(140, 36);
        nutxuat.TabIndex = 10;
        nutxuat.Text = "Xuất hóa đơn";
        nutxuat.UseVisualStyleBackColor = false;
        // 
        // nuthuy
        // 
        nuthuy.BackColor = Color.FromArgb(174, 64, 64);
        nuthuy.Cursor = Cursors.Hand;
        nuthuy.FlatAppearance.BorderSize = 0;
        nuthuy.FlatStyle = FlatStyle.Flat;
        nuthuy.ForeColor = Color.White;
        nuthuy.Location = new Point(460, 139);
        nuthuy.Name = "nuthuy";
        nuthuy.Size = new Size(140, 36);
        nuthuy.TabIndex = 11;
        nuthuy.Text = "Hủy hóa đơn";
        nuthuy.UseVisualStyleBackColor = false;
        // 
        // nutlammoi
        // 
        nutlammoi.BackColor = Color.White;
        nutlammoi.Cursor = Cursors.Hand;
        nutlammoi.FlatStyle = FlatStyle.Flat;
        nutlammoi.ForeColor = Color.FromArgb(23, 60, 59);
        nutlammoi.Location = new Point(610, 139);
        nutlammoi.Name = "nutlammoi";
        nutlammoi.Size = new Size(115, 36);
        nutlammoi.TabIndex = 12;
        nutlammoi.Text = "Làm mới";
        nutlammoi.UseVisualStyleBackColor = false;
        // 
        // banghoadon
        // 
        banghoadon.AllowUserToAddRows = false;
        banghoadon.AllowUserToDeleteRows = false;
        banghoadon.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 247);
        banghoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        banghoadon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        banghoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        banghoadon.BackgroundColor = Color.White;
        banghoadon.BorderStyle = BorderStyle.None;
        banghoadon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 239, 233);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle2.Padding = new Padding(5);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 239, 233);
        banghoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        banghoadon.ColumnHeadersHeight = 42;
        banghoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        banghoadon.Columns.AddRange(new DataGridViewColumn[] { banghoadonMa, banghoadonNgaylap, banghoadonKhachhang, banghoadonTongtien, banghoadonTrangthai });
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = SystemColors.Window;
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle5.Padding = new Padding(5);
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(209, 229, 218);
        dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
        banghoadon.DefaultCellStyle = dataGridViewCellStyle5;
        banghoadon.EnableHeadersVisualStyles = false;
        banghoadon.GridColor = Color.FromArgb(231, 235, 230);
        banghoadon.Location = new Point(20, 191);
        banghoadon.MultiSelect = false;
        banghoadon.Name = "banghoadon";
        banghoadon.ReadOnly = true;
        banghoadon.RowHeadersVisible = false;
        banghoadon.RowHeadersWidth = 51;
        banghoadon.RowTemplate.Height = 37;
        banghoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        banghoadon.Size = new Size(1000, 192);
        banghoadon.TabIndex = 13;
        // 
        // banghoadonMa
        // 
        banghoadonMa.HeaderText = "Mã hóa đơn";
        banghoadonMa.MinimumWidth = 65;
        banghoadonMa.Name = "banghoadonMa";
        banghoadonMa.ReadOnly = true;
        // 
        // banghoadonNgaylap
        // 
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm";
        banghoadonNgaylap.DefaultCellStyle = dataGridViewCellStyle3;
        banghoadonNgaylap.FillWeight = 140F;
        banghoadonNgaylap.HeaderText = "Ngày lập";
        banghoadonNgaylap.MinimumWidth = 65;
        banghoadonNgaylap.Name = "banghoadonNgaylap";
        banghoadonNgaylap.ReadOnly = true;
        // 
        // banghoadonKhachhang
        // 
        banghoadonKhachhang.FillWeight = 180F;
        banghoadonKhachhang.HeaderText = "Khách hàng";
        banghoadonKhachhang.MinimumWidth = 65;
        banghoadonKhachhang.Name = "banghoadonKhachhang";
        banghoadonKhachhang.ReadOnly = true;
        // 
        // banghoadonTongtien
        // 
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle4.Format = "N0";
        banghoadonTongtien.DefaultCellStyle = dataGridViewCellStyle4;
        banghoadonTongtien.FillWeight = 120F;
        banghoadonTongtien.HeaderText = "Thanh toán (đ)";
        banghoadonTongtien.MinimumWidth = 65;
        banghoadonTongtien.Name = "banghoadonTongtien";
        banghoadonTongtien.ReadOnly = true;
        // 
        // banghoadonTrangthai
        // 
        banghoadonTrangthai.FillWeight = 120F;
        banghoadonTrangthai.HeaderText = "Trạng thái";
        banghoadonTrangthai.MinimumWidth = 65;
        banghoadonTrangthai.Name = "banghoadonTrangthai";
        banghoadonTrangthai.ReadOnly = true;
        // 
        // nhanchitiet
        // 
        nhanchitiet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nhanchitiet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        nhanchitiet.ForeColor = Color.FromArgb(23, 60, 59);
        nhanchitiet.Location = new Point(22, 399);
        nhanchitiet.Name = "nhanchitiet";
        nhanchitiet.Size = new Size(990, 27);
        nhanchitiet.TabIndex = 14;
        nhanchitiet.Text = "CHI TIẾT HÓA ĐƠN";
        // 
        // bangchitiet
        // 
        bangchitiet.AllowUserToAddRows = false;
        bangchitiet.AllowUserToDeleteRows = false;
        bangchitiet.AllowUserToResizeRows = false;
        dataGridViewCellStyle6.BackColor = Color.FromArgb(248, 250, 247);
        bangchitiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
        bangchitiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        bangchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        bangchitiet.BackgroundColor = Color.White;
        bangchitiet.BorderStyle = BorderStyle.None;
        bangchitiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle7.BackColor = Color.FromArgb(231, 239, 233);
        dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle7.ForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle7.Padding = new Padding(5);
        dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 239, 233);
        bangchitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
        bangchitiet.ColumnHeadersHeight = 42;
        bangchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        bangchitiet.Columns.AddRange(new DataGridViewColumn[] { bangchitietMa, bangchitietTen, bangchitietDongia, bangchitietSoluong, bangchitietThanhtien });
        dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle11.BackColor = SystemColors.Window;
        dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle11.ForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle11.Padding = new Padding(5);
        dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(209, 229, 218);
        dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(23, 60, 59);
        dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
        bangchitiet.DefaultCellStyle = dataGridViewCellStyle11;
        bangchitiet.EnableHeadersVisualStyles = false;
        bangchitiet.GridColor = Color.FromArgb(231, 235, 230);
        bangchitiet.Location = new Point(20, 435);
        bangchitiet.MultiSelect = false;
        bangchitiet.Name = "bangchitiet";
        bangchitiet.ReadOnly = true;
        bangchitiet.RowHeadersVisible = false;
        bangchitiet.RowHeadersWidth = 51;
        bangchitiet.RowTemplate.Height = 37;
        bangchitiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        bangchitiet.Size = new Size(1000, 139);
        bangchitiet.TabIndex = 20;
        // 
        // bangchitietMa
        // 
        bangchitietMa.HeaderText = "Mã game";
        bangchitietMa.MinimumWidth = 65;
        bangchitietMa.Name = "bangchitietMa";
        bangchitietMa.ReadOnly = true;
        // 
        // bangchitietTen
        // 
        bangchitietTen.FillWeight = 300F;
        bangchitietTen.HeaderText = "Tên game";
        bangchitietTen.MinimumWidth = 65;
        bangchitietTen.Name = "bangchitietTen";
        bangchitietTen.ReadOnly = true;
        // 
        // bangchitietDongia
        // 
        dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle8.Format = "N0";
        bangchitietDongia.DefaultCellStyle = dataGridViewCellStyle8;
        bangchitietDongia.FillWeight = 120F;
        bangchitietDongia.HeaderText = "Đơn giá (đ)";
        bangchitietDongia.MinimumWidth = 65;
        bangchitietDongia.Name = "bangchitietDongia";
        bangchitietDongia.ReadOnly = true;
        // 
        // bangchitietSoluong
        // 
        dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle9.Format = "N0";
        bangchitietSoluong.DefaultCellStyle = dataGridViewCellStyle9;
        bangchitietSoluong.FillWeight = 85F;
        bangchitietSoluong.HeaderText = "Số lượng";
        bangchitietSoluong.MinimumWidth = 65;
        bangchitietSoluong.Name = "bangchitietSoluong";
        bangchitietSoluong.ReadOnly = true;
        // 
        // bangchitietThanhtien
        // 
        dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle10.Format = "N0";
        bangchitietThanhtien.DefaultCellStyle = dataGridViewCellStyle10;
        bangchitietThanhtien.FillWeight = 140F;
        bangchitietThanhtien.HeaderText = "Thành tiền (đ)";
        bangchitietThanhtien.MinimumWidth = 65;
        bangchitietThanhtien.Name = "bangchitietThanhtien";
        bangchitietThanhtien.ReadOnly = true;
        // 
        // nhantong
        // 
        nhantong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nhantong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        nhantong.ForeColor = Color.FromArgb(23, 60, 59);
        nhantong.Location = new Point(22, 587);
        nhantong.Name = "nhantong";
        nhantong.Size = new Size(996, 26);
        nhantong.TabIndex = 21;
        nhantong.Text = "Chọn một hóa đơn để xem các game đã bán.";
        // 
        // nhantrangthai
        // 
        nhantrangthai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nhantrangthai.ForeColor = Color.FromArgb(101, 119, 115);
        nhantrangthai.Location = new Point(22, 620);
        nhantrangthai.Name = "nhantrangthai";
        nhantrangthai.Size = new Size(996, 24);
        nhantrangthai.TabIndex = 22;
        nhantrangthai.Text = "Chưa kết nối SQL.";
        // 
        // quanlyhoadon
        // 
        AutoScaleDimensions = new SizeF(120F, 120F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(245, 247, 244);
        ClientSize = new Size(1040, 650);
        Controls.Add(nhantieude);
        Controls.Add(nhanmota);
        Controls.Add(nhantu);
        Controls.Add(ngaytu);
        Controls.Add(nhanden);
        Controls.Add(ngayden);
        Controls.Add(otimkiem);
        Controls.Add(nuttimkiem);
        Controls.Add(nuttao);
        Controls.Add(nutxem);
        Controls.Add(nutxuat);
        Controls.Add(nuthuy);
        Controls.Add(nutlammoi);
        Controls.Add(banghoadon);
        Controls.Add(nhanchitiet);
        Controls.Add(bangchitiet);
        Controls.Add(nhantong);
        Controls.Add(nhantrangthai);
        Font = new Font("Segoe UI", 10F);
        ForeColor = Color.FromArgb(23, 60, 59);
        FormBorderStyle = FormBorderStyle.None;
        Name = "quanlyhoadon";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Quản lý hóa đơn";
        ((ISupportInitialize)banghoadon).EndInit();
        ((ISupportInitialize)bangchitiet).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label nhantieude;
    private Label nhanmota;
    private Label nhantu;
    private DateTimePicker ngaytu;
    private Label nhanden;
    private DateTimePicker ngayden;
    private TextBox otimkiem;
    private Button nuttimkiem;
    private Button nuttao;
    private Button nutxem;
    private Button nutxuat;
    private Button nuthuy;
    private Button nutlammoi;
    private DataGridView banghoadon;
    private DataGridViewTextBoxColumn banghoadonMa;
    private DataGridViewTextBoxColumn banghoadonNgaylap;
    private DataGridViewTextBoxColumn banghoadonKhachhang;
    private DataGridViewTextBoxColumn banghoadonTongtien;
    private DataGridViewTextBoxColumn banghoadonTrangthai;
    private Label nhanchitiet;
    private DataGridView bangchitiet;
    private DataGridViewTextBoxColumn bangchitietMa;
    private DataGridViewTextBoxColumn bangchitietTen;
    private DataGridViewTextBoxColumn bangchitietDongia;
    private DataGridViewTextBoxColumn bangchitietSoluong;
    private DataGridViewTextBoxColumn bangchitietThanhtien;
    private Label nhantong;
    private Label nhantrangthai;
}
