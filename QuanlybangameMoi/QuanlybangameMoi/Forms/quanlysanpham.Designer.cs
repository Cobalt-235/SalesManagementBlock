using System.ComponentModel;

namespace QuanlybangameMoi_UI.Forms
{
    partial class quanlysanpham
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
            nhantieude = new Label();
            nhanmota = new Label();
            otimkiem = new TextBox();
            nuttimkiem = new Button();
            nutthem = new Button();
            nutsua = new Button();
            nutxoa = new Button();
            nutlammoi = new Button();
            nutxuat = new Button();
            bangsanpham = new DataGridView();
            bangsanphamMa = new DataGridViewTextBoxColumn();
            bangsanphamTen = new DataGridViewTextBoxColumn();
            bangsanphamNentang = new DataGridViewTextBoxColumn();
            bangsanphamGiaban = new DataGridViewTextBoxColumn();
            bangsanphamTonkho = new DataGridViewTextBoxColumn();
            bangsanphamTrangthai = new DataGridViewTextBoxColumn();
            khungchitiet = new Panel();
            nhanchitiet = new Label();
            nhanthongtin = new Label();
            nutnhapkho = new Button();
            nhantrangthai = new Label();
            ((ISupportInitialize)bangsanpham).BeginInit();
            khungchitiet.SuspendLayout();
            SuspendLayout();
            // 
            // nhantieude
            // 
            nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
            nhantieude.Location = new Point(20, 7);
            nhantieude.Name = "nhantieude";
            nhantieude.Size = new Size(352, 43);
            nhantieude.TabIndex = 0;
            nhantieude.Text = "Quản lý sản phẩm";
            // 
            // nhanmota
            // 
            nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
            nhanmota.Location = new Point(22, 58);
            nhanmota.Name = "nhanmota";
            nhanmota.Size = new Size(996, 26);
            nhanmota.TabIndex = 1;
            nhanmota.Text = "Danh mục game, giá bán và tình trạng hàng trong cửa hàng";
            // 
            // otimkiem
            // 
            otimkiem.BorderStyle = BorderStyle.FixedSingle;
            otimkiem.Location = new Point(20, 99);
            otimkiem.Name = "otimkiem";
            otimkiem.PlaceholderText = "Tìm mã, tên game, thể loại hoặc nền tảng…";
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
            nutthem.Text = "+ Thêm game";
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
            // bangsanpham
            // 
            bangsanpham.AllowUserToAddRows = false;
            bangsanpham.AllowUserToDeleteRows = false;
            bangsanpham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 247);
            bangsanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bangsanpham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bangsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bangsanpham.BackgroundColor = Color.White;
            bangsanpham.BorderStyle = BorderStyle.None;
            bangsanpham.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 239, 233);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 239, 233);
            bangsanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bangsanpham.ColumnHeadersHeight = 42;
            bangsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            bangsanpham.Columns.AddRange(new DataGridViewColumn[] { bangsanphamMa, bangsanphamTen, bangsanphamNentang, bangsanphamGiaban, bangsanphamTonkho, bangsanphamTrangthai });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(209, 229, 218);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            bangsanpham.DefaultCellStyle = dataGridViewCellStyle5;
            bangsanpham.EnableHeadersVisualStyles = false;
            bangsanpham.GridColor = Color.FromArgb(231, 235, 230);
            bangsanpham.Location = new Point(20, 191);
            bangsanpham.MultiSelect = false;
            bangsanpham.Name = "bangsanpham";
            bangsanpham.ReadOnly = true;
            bangsanpham.RowHeadersVisible = false;
            bangsanpham.RowHeadersWidth = 51;
            bangsanpham.RowTemplate.Height = 37;
            bangsanpham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bangsanpham.Size = new Size(704, 397);
            bangsanpham.TabIndex = 9;
            // 
            // bangsanphamMa
            // 
            bangsanphamMa.FillWeight = 80F;
            bangsanphamMa.HeaderText = "Mã game";
            bangsanphamMa.MinimumWidth = 65;
            bangsanphamMa.Name = "bangsanphamMa";
            bangsanphamMa.ReadOnly = true;
            // 
            // bangsanphamTen
            // 
            bangsanphamTen.FillWeight = 220F;
            bangsanphamTen.HeaderText = "Tên game";
            bangsanphamTen.MinimumWidth = 65;
            bangsanphamTen.Name = "bangsanphamTen";
            bangsanphamTen.ReadOnly = true;
            // 
            // bangsanphamNentang
            // 
            bangsanphamNentang.FillWeight = 85F;
            bangsanphamNentang.HeaderText = "Nền tảng";
            bangsanphamNentang.MinimumWidth = 65;
            bangsanphamNentang.Name = "bangsanphamNentang";
            bangsanphamNentang.ReadOnly = true;
            // 
            // bangsanphamGiaban
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            bangsanphamGiaban.DefaultCellStyle = dataGridViewCellStyle3;
            bangsanphamGiaban.HeaderText = "Giá bán (đ)";
            bangsanphamGiaban.MinimumWidth = 65;
            bangsanphamGiaban.Name = "bangsanphamGiaban";
            bangsanphamGiaban.ReadOnly = true;
            // 
            // bangsanphamTonkho
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            bangsanphamTonkho.DefaultCellStyle = dataGridViewCellStyle4;
            bangsanphamTonkho.FillWeight = 65F;
            bangsanphamTonkho.HeaderText = "Tồn";
            bangsanphamTonkho.MinimumWidth = 65;
            bangsanphamTonkho.Name = "bangsanphamTonkho";
            bangsanphamTonkho.ReadOnly = true;
            // 
            // bangsanphamTrangthai
            // 
            bangsanphamTrangthai.HeaderText = "Trạng thái";
            bangsanphamTrangthai.MinimumWidth = 65;
            bangsanphamTrangthai.Name = "bangsanphamTrangthai";
            bangsanphamTrangthai.ReadOnly = true;
            // 
            // khungchitiet
            // 
            khungchitiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            khungchitiet.BackColor = Color.White;
            khungchitiet.Controls.Add(nhanchitiet);
            khungchitiet.Controls.Add(nhanthongtin);
            khungchitiet.Controls.Add(nutnhapkho);
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
            nhanchitiet.Text = "THÔNG TIN GAME";
            // 
            // nhanthongtin
            // 
            nhanthongtin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhanthongtin.ForeColor = Color.FromArgb(23, 60, 59);
            nhanthongtin.Location = new Point(18, 65);
            nhanthongtin.Name = "nhanthongtin";
            nhanthongtin.Size = new Size(242, 260);
            nhanthongtin.TabIndex = 1;
            nhanthongtin.Text = "Chọn một game trong bảng để xem thông tin chi tiết.";
            // 
            // nutnhapkho
            // 
            nutnhapkho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nutnhapkho.BackColor = Color.FromArgb(189, 135, 67);
            nutnhapkho.Cursor = Cursors.Hand;
            nutnhapkho.FlatAppearance.BorderSize = 0;
            nutnhapkho.FlatStyle = FlatStyle.Flat;
            nutnhapkho.ForeColor = Color.White;
            nutnhapkho.Location = new Point(18, 337);
            nutnhapkho.Name = "nutnhapkho";
            nutnhapkho.Size = new Size(242, 40);
            nutnhapkho.TabIndex = 19;
            nutnhapkho.Text = "Nhập thêm hàng";
            nutnhapkho.UseVisualStyleBackColor = false;
            // 
            // nhantrangthai
            // 
            nhantrangthai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhantrangthai.ForeColor = Color.FromArgb(101, 119, 115);
            nhantrangthai.Location = new Point(22, 606);
            nhantrangthai.Name = "nhantrangthai";
            nhantrangthai.Size = new Size(994, 27);
            nhantrangthai.TabIndex = 11;
            nhantrangthai.Text = "Chưa kết nối SQL • Bạn có thể mở form Thêm game để xem giao diện.";
            // 
            // quanlysanpham
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
            Controls.Add(bangsanpham);
            Controls.Add(khungchitiet);
            Controls.Add(nhantrangthai);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(23, 60, 59);
            FormBorderStyle = FormBorderStyle.None;
            Name = "quanlysanpham";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý sản phẩm";
            ((ISupportInitialize)bangsanpham).EndInit();
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
        private DataGridView bangsanpham;
        private DataGridViewTextBoxColumn bangsanphamMa;
        private DataGridViewTextBoxColumn bangsanphamTen;
        private DataGridViewTextBoxColumn bangsanphamNentang;
        private DataGridViewTextBoxColumn bangsanphamGiaban;
        private DataGridViewTextBoxColumn bangsanphamTonkho;
        private DataGridViewTextBoxColumn bangsanphamTrangthai;
        private Panel khungchitiet;
        private Label nhanchitiet;
        private Label nhanthongtin;
        private Button nutnhapkho;
        private Label nhantrangthai;

        #endregion
    }
}