using System.ComponentModel;

namespace QuanlybangameMoi_UI.Forms
{
    partial class quanlydoanhthu
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            nhantieude = new Label();
            nhanmota = new Label();
            nhantu = new Label();
            ngaytu = new DateTimePicker();
            nhanden = new Label();
            ngayden = new DateTimePicker();
            nutthongke = new Button();
            nutxuat = new Button();
            khungthe = new TableLayoutPanel();
            khungdoanhthu = new Panel();
            nhantendoanhthu = new Label();
            nhandoanhthu = new Label();
            khungbinhquanhd = new Panel();
            nhantenbinhquanhd = new Label();
            nhanbinhquanhd = new Label();
            khungbinhquanngay = new Panel();
            nhantenbinhquanngay = new Label();
            nhanbinhquanngay = new Label();
            khungsohoadon = new Panel();
            nhantensohoadon = new Label();
            nhansohoadon = new Label();
            bangdoanhthu = new DataGridView();
            bangdoanhthuNgay = new DataGridViewTextBoxColumn();
            bangdoanhthuSohoadon = new DataGridViewTextBoxColumn();
            bangdoanhthuDoanhthu = new DataGridViewTextBoxColumn();
            khungbieudo = new Panel();
            nhanchuthich = new Label();
            nhantrangthai = new Label();
            khungthe.SuspendLayout();
            khungdoanhthu.SuspendLayout();
            khungbinhquanhd.SuspendLayout();
            khungbinhquanngay.SuspendLayout();
            khungsohoadon.SuspendLayout();
            ((ISupportInitialize)bangdoanhthu).BeginInit();
            SuspendLayout();
            // 
            // nhantieude
            // 
            nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
            nhantieude.Location = new Point(20, 6);
            nhantieude.Name = "nhantieude";
            nhantieude.Size = new Size(486, 49);
            nhantieude.TabIndex = 0;
            nhantieude.Text = "Quản lý doanh thu";
            // 
            // nhanmota
            // 
            nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
            nhanmota.Location = new Point(22, 58);
            nhanmota.Name = "nhanmota";
            nhanmota.Size = new Size(996, 26);
            nhanmota.TabIndex = 1;
            nhanmota.Text = "Doanh thu từ hóa đơn đã thanh toán, sau giảm giá và loại trừ hóa đơn hủy";
            // 
            // nhantu
            // 
            nhantu.ForeColor = Color.FromArgb(101, 119, 115);
            nhantu.Location = new Point(20, 102);
            nhantu.Name = "nhantu";
            nhantu.Size = new Size(64, 24);
            nhantu.TabIndex = 2;
            nhantu.Text = "Từ ngày";
            // 
            // ngaytu
            // 
            ngaytu.CustomFormat = "dd/MM/yyyy";
            ngaytu.Format = DateTimePickerFormat.Custom;
            ngaytu.Location = new Point(88, 98);
            ngaytu.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            ngaytu.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            ngaytu.Name = "ngaytu";
            ngaytu.Size = new Size(145, 30);
            ngaytu.TabIndex = 3;
            // 
            // nhanden
            // 
            nhanden.ForeColor = Color.FromArgb(101, 119, 115);
            nhanden.Location = new Point(250, 102);
            nhanden.Name = "nhanden";
            nhanden.Size = new Size(78, 24);
            nhanden.TabIndex = 4;
            nhanden.Text = "Đến ngày";
            // 
            // ngayden
            // 
            ngayden.CustomFormat = "dd/MM/yyyy";
            ngayden.Format = DateTimePickerFormat.Custom;
            ngayden.Location = new Point(332, 98);
            ngayden.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            ngayden.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            ngayden.Name = "ngayden";
            ngayden.Size = new Size(145, 30);
            ngayden.TabIndex = 5;
            // 
            // nutthongke
            // 
            nutthongke.BackColor = Color.FromArgb(23, 60, 59);
            nutthongke.Cursor = Cursors.Hand;
            nutthongke.FlatAppearance.BorderSize = 0;
            nutthongke.FlatStyle = FlatStyle.Flat;
            nutthongke.ForeColor = Color.White;
            nutthongke.Location = new Point(496, 95);
            nutthongke.Name = "nutthongke";
            nutthongke.Size = new Size(145, 36);
            nutthongke.TabIndex = 6;
            nutthongke.Text = "Xem báo cáo";
            nutthongke.UseVisualStyleBackColor = false;
            // 
            // nutxuat
            // 
            nutxuat.BackColor = Color.White;
            nutxuat.Cursor = Cursors.Hand;
            nutxuat.FlatStyle = FlatStyle.Flat;
            nutxuat.ForeColor = Color.FromArgb(23, 60, 59);
            nutxuat.Location = new Point(654, 95);
            nutxuat.Name = "nutxuat";
            nutxuat.Size = new Size(124, 36);
            nutxuat.TabIndex = 7;
            nutxuat.Text = "Xuất CSV";
            nutxuat.UseVisualStyleBackColor = false;
            // 
            // khungthe
            // 
            khungthe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            khungthe.ColumnCount = 4;
            khungthe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            khungthe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            khungthe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            khungthe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            khungthe.Controls.Add(khungdoanhthu);
            khungthe.Controls.Add(khungbinhquanhd);
            khungthe.Controls.Add(khungbinhquanngay);
            khungthe.Controls.Add(khungsohoadon);
            khungthe.Location = new Point(20, 156);
            khungthe.Name = "khungthe";
            khungthe.RowCount = 1;
            khungthe.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            khungthe.Size = new Size(1000, 110);
            khungthe.TabIndex = 8;
            // 
            // khungdoanhthu
            // 
            khungdoanhthu.BackColor = Color.White;
            khungdoanhthu.Controls.Add(nhantendoanhthu);
            khungdoanhthu.Controls.Add(nhandoanhthu);
            khungdoanhthu.Dock = DockStyle.Fill;
            khungdoanhthu.Location = new Point(0, 0);
            khungdoanhthu.Margin = new Padding(0, 0, 14, 0);
            khungdoanhthu.Name = "khungdoanhthu";
            khungdoanhthu.Size = new Size(236, 110);
            khungdoanhthu.TabIndex = 0;
            // 
            // nhantendoanhthu
            // 
            nhantendoanhthu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantendoanhthu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nhantendoanhthu.ForeColor = Color.FromArgb(101, 119, 115);
            nhantendoanhthu.Location = new Point(16, 17);
            nhantendoanhthu.Name = "nhantendoanhthu";
            nhantendoanhthu.Size = new Size(204, 25);
            nhantendoanhthu.TabIndex = 0;
            nhantendoanhthu.Text = "TỔNG DOANH THU";
            // 
            // nhandoanhthu
            // 
            nhandoanhthu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhandoanhthu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            nhandoanhthu.ForeColor = Color.FromArgb(23, 60, 59);
            nhandoanhthu.Location = new Point(16, 53);
            nhandoanhthu.Name = "nhandoanhthu";
            nhandoanhthu.Size = new Size(204, 38);
            nhandoanhthu.TabIndex = 1;
            nhandoanhthu.Text = "—";
            // 
            // khungbinhquanhd
            // 
            khungbinhquanhd.BackColor = Color.White;
            khungbinhquanhd.Controls.Add(nhantenbinhquanhd);
            khungbinhquanhd.Controls.Add(nhanbinhquanhd);
            khungbinhquanhd.Dock = DockStyle.Fill;
            khungbinhquanhd.Location = new Point(250, 0);
            khungbinhquanhd.Margin = new Padding(0, 0, 14, 0);
            khungbinhquanhd.Name = "khungbinhquanhd";
            khungbinhquanhd.Size = new Size(236, 110);
            khungbinhquanhd.TabIndex = 1;
            // 
            // nhantenbinhquanhd
            // 
            nhantenbinhquanhd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantenbinhquanhd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nhantenbinhquanhd.ForeColor = Color.FromArgb(101, 119, 115);
            nhantenbinhquanhd.Location = new Point(16, 17);
            nhantenbinhquanhd.Name = "nhantenbinhquanhd";
            nhantenbinhquanhd.Size = new Size(204, 25);
            nhantenbinhquanhd.TabIndex = 0;
            nhantenbinhquanhd.Text = "BÌNH QUÂN / HÓA ĐƠN";
            // 
            // nhanbinhquanhd
            // 
            nhanbinhquanhd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanbinhquanhd.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            nhanbinhquanhd.ForeColor = Color.FromArgb(23, 60, 59);
            nhanbinhquanhd.Location = new Point(16, 53);
            nhanbinhquanhd.Name = "nhanbinhquanhd";
            nhanbinhquanhd.Size = new Size(204, 38);
            nhanbinhquanhd.TabIndex = 1;
            nhanbinhquanhd.Text = "—";
            // 
            // khungbinhquanngay
            // 
            khungbinhquanngay.BackColor = Color.White;
            khungbinhquanngay.Controls.Add(nhantenbinhquanngay);
            khungbinhquanngay.Controls.Add(nhanbinhquanngay);
            khungbinhquanngay.Dock = DockStyle.Fill;
            khungbinhquanngay.Location = new Point(500, 0);
            khungbinhquanngay.Margin = new Padding(0, 0, 14, 0);
            khungbinhquanngay.Name = "khungbinhquanngay";
            khungbinhquanngay.Size = new Size(236, 110);
            khungbinhquanngay.TabIndex = 2;
            // 
            // nhantenbinhquanngay
            // 
            nhantenbinhquanngay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantenbinhquanngay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nhantenbinhquanngay.ForeColor = Color.FromArgb(101, 119, 115);
            nhantenbinhquanngay.Location = new Point(16, 17);
            nhantenbinhquanngay.Name = "nhantenbinhquanngay";
            nhantenbinhquanngay.Size = new Size(204, 25);
            nhantenbinhquanngay.TabIndex = 0;
            nhantenbinhquanngay.Text = "BÌNH QUÂN / NGÀY";
            // 
            // nhanbinhquanngay
            // 
            nhanbinhquanngay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanbinhquanngay.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            nhanbinhquanngay.ForeColor = Color.FromArgb(23, 60, 59);
            nhanbinhquanngay.Location = new Point(16, 53);
            nhanbinhquanngay.Name = "nhanbinhquanngay";
            nhanbinhquanngay.Size = new Size(204, 38);
            nhanbinhquanngay.TabIndex = 1;
            nhanbinhquanngay.Text = "—";
            // 
            // khungsohoadon
            // 
            khungsohoadon.BackColor = Color.White;
            khungsohoadon.Controls.Add(nhantensohoadon);
            khungsohoadon.Controls.Add(nhansohoadon);
            khungsohoadon.Dock = DockStyle.Fill;
            khungsohoadon.Location = new Point(750, 0);
            khungsohoadon.Margin = new Padding(0, 0, 14, 0);
            khungsohoadon.Name = "khungsohoadon";
            khungsohoadon.Size = new Size(236, 110);
            khungsohoadon.TabIndex = 3;
            // 
            // nhantensohoadon
            // 
            nhantensohoadon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantensohoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nhantensohoadon.ForeColor = Color.FromArgb(101, 119, 115);
            nhantensohoadon.Location = new Point(16, 17);
            nhantensohoadon.Name = "nhantensohoadon";
            nhantensohoadon.Size = new Size(204, 25);
            nhantensohoadon.TabIndex = 0;
            nhantensohoadon.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // nhansohoadon
            // 
            nhansohoadon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhansohoadon.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            nhansohoadon.ForeColor = Color.FromArgb(23, 60, 59);
            nhansohoadon.Location = new Point(16, 53);
            nhansohoadon.Name = "nhansohoadon";
            nhansohoadon.Size = new Size(204, 38);
            nhansohoadon.TabIndex = 1;
            nhansohoadon.Text = "—";
            // 
            // bangdoanhthu
            // 
            bangdoanhthu.AllowUserToAddRows = false;
            bangdoanhthu.AllowUserToDeleteRows = false;
            bangdoanhthu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 247);
            bangdoanhthu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bangdoanhthu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            bangdoanhthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bangdoanhthu.BackgroundColor = Color.White;
            bangdoanhthu.BorderStyle = BorderStyle.None;
            bangdoanhthu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 239, 233);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 239, 233);
            bangdoanhthu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bangdoanhthu.ColumnHeadersHeight = 42;
            bangdoanhthu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            bangdoanhthu.Columns.AddRange(new DataGridViewColumn[] { bangdoanhthuNgay, bangdoanhthuSohoadon, bangdoanhthuDoanhthu });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(209, 229, 218);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            bangdoanhthu.DefaultCellStyle = dataGridViewCellStyle6;
            bangdoanhthu.EnableHeadersVisualStyles = false;
            bangdoanhthu.GridColor = Color.FromArgb(231, 235, 230);
            bangdoanhthu.Location = new Point(20, 300);
            bangdoanhthu.MultiSelect = false;
            bangdoanhthu.Name = "bangdoanhthu";
            bangdoanhthu.ReadOnly = true;
            bangdoanhthu.RowHeadersVisible = false;
            bangdoanhthu.RowHeadersWidth = 51;
            bangdoanhthu.RowTemplate.Height = 37;
            bangdoanhthu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bangdoanhthu.Size = new Size(490, 273);
            bangdoanhthu.TabIndex = 21;
            // 
            // bangdoanhthuNgay
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            bangdoanhthuNgay.DefaultCellStyle = dataGridViewCellStyle3;
            bangdoanhthuNgay.FillWeight = 140F;
            bangdoanhthuNgay.HeaderText = "Ngày";
            bangdoanhthuNgay.MinimumWidth = 65;
            bangdoanhthuNgay.Name = "bangdoanhthuNgay";
            bangdoanhthuNgay.ReadOnly = true;
            // 
            // bangdoanhthuSohoadon
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            bangdoanhthuSohoadon.DefaultCellStyle = dataGridViewCellStyle4;
            bangdoanhthuSohoadon.HeaderText = "Số hóa đơn";
            bangdoanhthuSohoadon.MinimumWidth = 65;
            bangdoanhthuSohoadon.Name = "bangdoanhthuSohoadon";
            bangdoanhthuSohoadon.ReadOnly = true;
            // 
            // bangdoanhthuDoanhthu
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            bangdoanhthuDoanhthu.DefaultCellStyle = dataGridViewCellStyle5;
            bangdoanhthuDoanhthu.FillWeight = 160F;
            bangdoanhthuDoanhthu.HeaderText = "Doanh thu (đ)";
            bangdoanhthuDoanhthu.MinimumWidth = 65;
            bangdoanhthuDoanhthu.Name = "bangdoanhthuDoanhthu";
            bangdoanhthuDoanhthu.ReadOnly = true;
            // 
            // khungbieudo
            // 
            khungbieudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            khungbieudo.BackColor = Color.White;
            khungbieudo.Location = new Point(530, 300);
            khungbieudo.Name = "khungbieudo";
            khungbieudo.Size = new Size(490, 273);
            khungbieudo.TabIndex = 22;
            // 
            // nhanchuthich
            // 
            nhanchuthich.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhanchuthich.ForeColor = Color.FromArgb(101, 119, 115);
            nhanchuthich.Location = new Point(22, 587);
            nhanchuthich.Name = "nhanchuthich";
            nhanchuthich.Size = new Size(995, 27);
            nhanchuthich.TabIndex = 23;
            nhanchuthich.Text = "Bình quân/ngày tính cả ngày không bán được hàng. Mỗi hóa đơn hủy được loại khỏi báo cáo.";
            // 
            // nhantrangthai
            // 
            nhantrangthai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhantrangthai.ForeColor = Color.FromArgb(101, 119, 115);
            nhantrangthai.Location = new Point(22, 621);
            nhantrangthai.Name = "nhantrangthai";
            nhantrangthai.Size = new Size(995, 24);
            nhantrangthai.TabIndex = 24;
            nhantrangthai.Text = "Chọn khoảng ngày rồi bấm Xem báo cáo.";
            // 
            // quanlydoanhthu
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
            Controls.Add(nutthongke);
            Controls.Add(nutxuat);
            Controls.Add(khungthe);
            Controls.Add(bangdoanhthu);
            Controls.Add(khungbieudo);
            Controls.Add(nhanchuthich);
            Controls.Add(nhantrangthai);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(23, 60, 59);
            FormBorderStyle = FormBorderStyle.None;
            Name = "quanlydoanhthu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý doanh thu";
            khungthe.ResumeLayout(false);
            khungdoanhthu.ResumeLayout(false);
            khungbinhquanhd.ResumeLayout(false);
            khungbinhquanngay.ResumeLayout(false);
            khungsohoadon.ResumeLayout(false);
            ((ISupportInitialize)bangdoanhthu).EndInit();
            ResumeLayout(false);
        }

        private Label nhantieude;
        private Label nhanmota;
        private Label nhantu;
        private DateTimePicker ngaytu;
        private Label nhanden;
        private DateTimePicker ngayden;
        private Button nutthongke;
        private Button nutxuat;
        private TableLayoutPanel khungthe;
        private Panel khungdoanhthu;
        private Label nhantendoanhthu;
        private Label nhandoanhthu;
        private Panel khungbinhquanhd;
        private Label nhantenbinhquanhd;
        private Label nhanbinhquanhd;
        private Panel khungbinhquanngay;
        private Label nhantenbinhquanngay;
        private Label nhanbinhquanngay;
        private Panel khungsohoadon;
        private Label nhantensohoadon;
        private Label nhansohoadon;
        private DataGridView bangdoanhthu;
        private DataGridViewTextBoxColumn bangdoanhthuNgay;
        private DataGridViewTextBoxColumn bangdoanhthuSohoadon;
        private DataGridViewTextBoxColumn bangdoanhthuDoanhthu;
        private Panel khungbieudo;
        private Label nhanchuthich;
        private Label nhantrangthai;

        #endregion
    }
}