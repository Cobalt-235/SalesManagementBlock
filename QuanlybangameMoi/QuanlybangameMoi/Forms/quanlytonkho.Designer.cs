using System.ComponentModel;

namespace QuanlybangameMoi_UI.Forms
{
    partial class quanlytonkho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            otimkiem = new TextBox();
            nuttimkiem = new Button();
            chonsaphethang = new CheckBox();
            nutnhap = new Button();
            nutlammoi = new Button();
            nutxuat = new Button();
            nhantong = new Label();
            bangtonkho = new DataGridView();
            bangtonkhoMa = new DataGridViewTextBoxColumn();
            bangtonkhoTen = new DataGridViewTextBoxColumn();
            bangtonkhoNentang = new DataGridViewTextBoxColumn();
            bangtonkhoGiaban = new DataGridViewTextBoxColumn();
            bangtonkhoTonkho = new DataGridViewTextBoxColumn();
            bangtonkhoTrangthai = new DataGridViewTextBoxColumn();
            nhanlichsu = new Label();
            banglichsu = new DataGridView();
            banglichsuNgay = new DataGridViewTextBoxColumn();
            banglichsuLoai = new DataGridViewTextBoxColumn();
            banglichsuSoluong = new DataGridViewTextBoxColumn();
            banglichsuTonsau = new DataGridViewTextBoxColumn();
            banglichsuThamchieu = new DataGridViewTextBoxColumn();
            banglichsuGhichu = new DataGridViewTextBoxColumn();
            nhantrangthai = new Label();
            ((ISupportInitialize)bangtonkho).BeginInit();
            ((ISupportInitialize)banglichsu).BeginInit();
            SuspendLayout();
            // 
            // nhantieude
            // 
            nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
            nhantieude.Location = new Point(20, 4);
            nhantieude.Name = "nhantieude";
            nhantieude.Size = new Size(299, 55);
            nhantieude.TabIndex = 0;
            nhantieude.Text = "Quản lý tồn kho";
            // 
            // nhanmota
            // 
            nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
            nhanmota.Location = new Point(22, 58);
            nhanmota.Name = "nhanmota";
            nhanmota.Size = new Size(996, 26);
            nhanmota.TabIndex = 1;
            nhanmota.Text = "Nhập hàng, cảnh báo sắp hết và tra cứu biến động số lượng";
            // 
            // otimkiem
            // 
            otimkiem.BorderStyle = BorderStyle.FixedSingle;
            otimkiem.Location = new Point(20, 99);
            otimkiem.Name = "otimkiem";
            otimkiem.PlaceholderText = "Tìm mã game hoặc tên game…";
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
            // chonsaphethang
            // 
            chonsaphethang.Location = new Point(550, 99);
            chonsaphethang.Name = "chonsaphethang";
            chonsaphethang.Size = new Size(330, 28);
            chonsaphethang.TabIndex = 4;
            chonsaphethang.Text = "Chỉ xem hàng sắp hết / hết hàng";
            // 
            // nutnhap
            // 
            nutnhap.BackColor = Color.FromArgb(23, 60, 59);
            nutnhap.Cursor = Cursors.Hand;
            nutnhap.FlatAppearance.BorderSize = 0;
            nutnhap.FlatStyle = FlatStyle.Flat;
            nutnhap.ForeColor = Color.White;
            nutnhap.Location = new Point(20, 139);
            nutnhap.Name = "nutnhap";
            nutnhap.Size = new Size(132, 36);
            nutnhap.TabIndex = 5;
            nutnhap.Text = "+ Nhập kho";
            nutnhap.UseVisualStyleBackColor = false;
            // 
            // nutlammoi
            // 
            nutlammoi.BackColor = Color.White;
            nutlammoi.Cursor = Cursors.Hand;
            nutlammoi.FlatStyle = FlatStyle.Flat;
            nutlammoi.ForeColor = Color.FromArgb(23, 60, 59);
            nutlammoi.Location = new Point(162, 139);
            nutlammoi.Name = "nutlammoi";
            nutlammoi.Size = new Size(112, 36);
            nutlammoi.TabIndex = 6;
            nutlammoi.Text = "Làm mới";
            nutlammoi.UseVisualStyleBackColor = false;
            // 
            // nutxuat
            // 
            nutxuat.BackColor = Color.White;
            nutxuat.Cursor = Cursors.Hand;
            nutxuat.FlatStyle = FlatStyle.Flat;
            nutxuat.ForeColor = Color.FromArgb(23, 60, 59);
            nutxuat.Location = new Point(284, 139);
            nutxuat.Name = "nutxuat";
            nutxuat.Size = new Size(112, 36);
            nutxuat.TabIndex = 7;
            nutxuat.Text = "Xuất CSV";
            nutxuat.UseVisualStyleBackColor = false;
            // 
            // nhantong
            // 
            nhantong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            nhantong.ForeColor = Color.FromArgb(23, 60, 59);
            nhantong.Location = new Point(420, 145);
            nhantong.Name = "nhantong";
            nhantong.Size = new Size(600, 26);
            nhantong.TabIndex = 8;
            nhantong.Text = "Tồn kho: —   |   Game sắp hết: —";
            // 
            // bangtonkho
            // 
            bangtonkho.AllowUserToAddRows = false;
            bangtonkho.AllowUserToDeleteRows = false;
            bangtonkho.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 247);
            bangtonkho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bangtonkho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bangtonkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bangtonkho.BackgroundColor = Color.White;
            bangtonkho.BorderStyle = BorderStyle.None;
            bangtonkho.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 239, 233);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 239, 233);
            bangtonkho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bangtonkho.ColumnHeadersHeight = 42;
            bangtonkho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            bangtonkho.Columns.AddRange(new DataGridViewColumn[] { bangtonkhoMa, bangtonkhoTen, bangtonkhoNentang, bangtonkhoGiaban, bangtonkhoTonkho, bangtonkhoTrangthai });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(209, 229, 218);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            bangtonkho.DefaultCellStyle = dataGridViewCellStyle5;
            bangtonkho.EnableHeadersVisualStyles = false;
            bangtonkho.GridColor = Color.FromArgb(231, 235, 230);
            bangtonkho.Location = new Point(20, 191);
            bangtonkho.MultiSelect = false;
            bangtonkho.Name = "bangtonkho";
            bangtonkho.ReadOnly = true;
            bangtonkho.RowHeadersVisible = false;
            bangtonkho.RowHeadersWidth = 51;
            bangtonkho.RowTemplate.Height = 37;
            bangtonkho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bangtonkho.Size = new Size(1000, 192);
            bangtonkho.TabIndex = 9;
            // 
            // bangtonkhoMa
            // 
            bangtonkhoMa.FillWeight = 80F;
            bangtonkhoMa.HeaderText = "Mã game";
            bangtonkhoMa.MinimumWidth = 65;
            bangtonkhoMa.Name = "bangtonkhoMa";
            bangtonkhoMa.ReadOnly = true;
            // 
            // bangtonkhoTen
            // 
            bangtonkhoTen.FillWeight = 220F;
            bangtonkhoTen.HeaderText = "Tên game";
            bangtonkhoTen.MinimumWidth = 65;
            bangtonkhoTen.Name = "bangtonkhoTen";
            bangtonkhoTen.ReadOnly = true;
            // 
            // bangtonkhoNentang
            // 
            bangtonkhoNentang.FillWeight = 85F;
            bangtonkhoNentang.HeaderText = "Nền tảng";
            bangtonkhoNentang.MinimumWidth = 65;
            bangtonkhoNentang.Name = "bangtonkhoNentang";
            bangtonkhoNentang.ReadOnly = true;
            // 
            // bangtonkhoGiaban
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            bangtonkhoGiaban.DefaultCellStyle = dataGridViewCellStyle3;
            bangtonkhoGiaban.HeaderText = "Giá bán (đ)";
            bangtonkhoGiaban.MinimumWidth = 65;
            bangtonkhoGiaban.Name = "bangtonkhoGiaban";
            bangtonkhoGiaban.ReadOnly = true;
            // 
            // bangtonkhoTonkho
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            bangtonkhoTonkho.DefaultCellStyle = dataGridViewCellStyle4;
            bangtonkhoTonkho.FillWeight = 65F;
            bangtonkhoTonkho.HeaderText = "Tồn";
            bangtonkhoTonkho.MinimumWidth = 65;
            bangtonkhoTonkho.Name = "bangtonkhoTonkho";
            bangtonkhoTonkho.ReadOnly = true;
            // 
            // bangtonkhoTrangthai
            // 
            bangtonkhoTrangthai.HeaderText = "Trạng thái";
            bangtonkhoTrangthai.MinimumWidth = 65;
            bangtonkhoTrangthai.Name = "bangtonkhoTrangthai";
            bangtonkhoTrangthai.ReadOnly = true;
            // 
            // nhanlichsu
            // 
            nhanlichsu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanlichsu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nhanlichsu.ForeColor = Color.FromArgb(23, 60, 59);
            nhanlichsu.Location = new Point(22, 399);
            nhanlichsu.Name = "nhanlichsu";
            nhanlichsu.Size = new Size(990, 26);
            nhanlichsu.TabIndex = 10;
            nhanlichsu.Text = "LỊCH SỬ KHO • Tối đa 1.000 biến động gần nhất của game đang chọn";
            // 
            // banglichsu
            // 
            banglichsu.AllowUserToAddRows = false;
            banglichsu.AllowUserToDeleteRows = false;
            banglichsu.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(248, 250, 247);
            banglichsu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            banglichsu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            banglichsu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            banglichsu.BackgroundColor = Color.White;
            banglichsu.BorderStyle = BorderStyle.None;
            banglichsu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(231, 239, 233);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle7.Padding = new Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 239, 233);
            banglichsu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            banglichsu.ColumnHeadersHeight = 42;
            banglichsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            banglichsu.Columns.AddRange(new DataGridViewColumn[] { banglichsuNgay, banglichsuLoai, banglichsuSoluong, banglichsuTonsau, banglichsuThamchieu, banglichsuGhichu });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle11.Padding = new Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(209, 229, 218);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            banglichsu.DefaultCellStyle = dataGridViewCellStyle11;
            banglichsu.EnableHeadersVisualStyles = false;
            banglichsu.GridColor = Color.FromArgb(231, 235, 230);
            banglichsu.Location = new Point(20, 435);
            banglichsu.MultiSelect = false;
            banglichsu.Name = "banglichsu";
            banglichsu.ReadOnly = true;
            banglichsu.RowHeadersVisible = false;
            banglichsu.RowHeadersWidth = 51;
            banglichsu.RowTemplate.Height = 37;
            banglichsu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            banglichsu.Size = new Size(1000, 153);
            banglichsu.TabIndex = 17;
            // 
            // banglichsuNgay
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "dd/MM/yyyy HH:mm";
            banglichsuNgay.DefaultCellStyle = dataGridViewCellStyle8;
            banglichsuNgay.FillWeight = 150F;
            banglichsuNgay.HeaderText = "Thời gian";
            banglichsuNgay.MinimumWidth = 65;
            banglichsuNgay.Name = "banglichsuNgay";
            banglichsuNgay.ReadOnly = true;
            // 
            // banglichsuLoai
            // 
            banglichsuLoai.FillWeight = 120F;
            banglichsuLoai.HeaderText = "Thao tác";
            banglichsuLoai.MinimumWidth = 65;
            banglichsuLoai.Name = "banglichsuLoai";
            banglichsuLoai.ReadOnly = true;
            // 
            // banglichsuSoluong
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            banglichsuSoluong.DefaultCellStyle = dataGridViewCellStyle9;
            banglichsuSoluong.FillWeight = 90F;
            banglichsuSoluong.HeaderText = "Biến động";
            banglichsuSoluong.MinimumWidth = 65;
            banglichsuSoluong.Name = "banglichsuSoluong";
            banglichsuSoluong.ReadOnly = true;
            // 
            // banglichsuTonsau
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            banglichsuTonsau.DefaultCellStyle = dataGridViewCellStyle10;
            banglichsuTonsau.FillWeight = 80F;
            banglichsuTonsau.HeaderText = "Tồn sau";
            banglichsuTonsau.MinimumWidth = 65;
            banglichsuTonsau.Name = "banglichsuTonsau";
            banglichsuTonsau.ReadOnly = true;
            // 
            // banglichsuThamchieu
            // 
            banglichsuThamchieu.FillWeight = 110F;
            banglichsuThamchieu.HeaderText = "Tham chiếu";
            banglichsuThamchieu.MinimumWidth = 65;
            banglichsuThamchieu.Name = "banglichsuThamchieu";
            banglichsuThamchieu.ReadOnly = true;
            // 
            // banglichsuGhichu
            // 
            banglichsuGhichu.FillWeight = 250F;
            banglichsuGhichu.HeaderText = "Ghi chú";
            banglichsuGhichu.MinimumWidth = 65;
            banglichsuGhichu.Name = "banglichsuGhichu";
            banglichsuGhichu.ReadOnly = true;
            // 
            // nhantrangthai
            // 
            nhantrangthai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhantrangthai.ForeColor = Color.FromArgb(101, 119, 115);
            nhantrangthai.Location = new Point(22, 606);
            nhantrangthai.Name = "nhantrangthai";
            nhantrangthai.Size = new Size(994, 27);
            nhantrangthai.TabIndex = 18;
            nhantrangthai.Text = "Chưa kết nối SQL • Mở Nhập kho để xem form.";
            // 
            // quanlytonkho
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 247, 244);
            ClientSize = new Size(1040, 650);
            Controls.Add(nhantieude);
            Controls.Add(nhanmota);
            Controls.Add(otimkiem);
            Controls.Add(nuttimkiem);
            Controls.Add(chonsaphethang);
            Controls.Add(nutnhap);
            Controls.Add(nutlammoi);
            Controls.Add(nutxuat);
            Controls.Add(nhantong);
            Controls.Add(bangtonkho);
            Controls.Add(nhanlichsu);
            Controls.Add(banglichsu);
            Controls.Add(nhantrangthai);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(23, 60, 59);
            FormBorderStyle = FormBorderStyle.None;
            Name = "quanlytonkho";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý tồn kho";
            ((ISupportInitialize)bangtonkho).EndInit();
            ((ISupportInitialize)banglichsu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label nhantieude;
        private Label nhanmota;
        private TextBox otimkiem;
        private Button nuttimkiem;
        private CheckBox chonsaphethang;
        private Button nutnhap;
        private Button nutlammoi;
        private Button nutxuat;
        private Label nhantong;
        private DataGridView bangtonkho;
        private DataGridViewTextBoxColumn bangtonkhoMa;
        private DataGridViewTextBoxColumn bangtonkhoTen;
        private DataGridViewTextBoxColumn bangtonkhoNentang;
        private DataGridViewTextBoxColumn bangtonkhoGiaban;
        private DataGridViewTextBoxColumn bangtonkhoTonkho;
        private DataGridViewTextBoxColumn bangtonkhoTrangthai;
        private Label nhanlichsu;
        private DataGridView banglichsu;
        private DataGridViewTextBoxColumn banglichsuNgay;
        private DataGridViewTextBoxColumn banglichsuLoai;
        private DataGridViewTextBoxColumn banglichsuSoluong;
        private DataGridViewTextBoxColumn banglichsuTonsau;
        private DataGridViewTextBoxColumn banglichsuThamchieu;
        private DataGridViewTextBoxColumn banglichsuGhichu;
        private Label nhantrangthai;
        #endregion
    }
}