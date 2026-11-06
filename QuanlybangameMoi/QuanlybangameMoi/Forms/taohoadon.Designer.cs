using System.ComponentModel;

namespace QuanlybangameMoi_UI.Forms
{
    partial class taohoadon
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
            nhankhach = new Label();
            chonkhachhang = new ComboBox();
            nutthemkhach = new Button();
            nuttailai = new Button();
            nhangame = new Label();
            chongame = new ComboBox();
            nhansl = new Label();
            osoluong = new NumericUpDown();
            nutthem = new Button();
            nutcapnhat = new Button();
            banggiohang = new DataGridView();
            banggiohangMa = new DataGridViewTextBoxColumn();
            banggiohangTen = new DataGridViewTextBoxColumn();
            banggiohangDongia = new DataGridViewTextBoxColumn();
            banggiohangSoluong = new DataGridViewTextBoxColumn();
            banggiohangThanhtien = new DataGridViewTextBoxColumn();
            nutxoadong = new Button();
            nhanton = new Label();
            nhangiam = new Label();
            ogiamgia = new NumericUpDown();
            nhanghichu = new Label();
            oghichu = new TextBox();
            nhantong = new Label();
            nhantrangthai = new Label();
            nutluu = new Button();
            nuthuy = new Button();
            ((ISupportInitialize)osoluong).BeginInit();
            ((ISupportInitialize)banggiohang).BeginInit();
            ((ISupportInitialize)ogiamgia).BeginInit();
            SuspendLayout();
            // 
            // nhantieude
            // 
            nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
            nhantieude.Location = new Point(18, 1);
            nhantieude.Name = "nhantieude";
            nhantieude.Size = new Size(516, 57);
            nhantieude.TabIndex = 0;
            nhantieude.Text = "Tạo hóa đơn bán game";
            // 
            // nhanmota
            // 
            nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
            nhanmota.Location = new Point(22, 58);
            nhanmota.Name = "nhanmota";
            nhanmota.Size = new Size(1076, 26);
            nhanmota.TabIndex = 1;
            nhanmota.Text = "Chọn khách hàng, thêm game vào giỏ, kiểm tra tổng tiền rồi thanh toán";
            // 
            // nhankhach
            // 
            nhankhach.ForeColor = Color.FromArgb(101, 119, 115);
            nhankhach.Location = new Point(20, 99);
            nhankhach.Name = "nhankhach";
            nhankhach.Size = new Size(180, 24);
            nhankhach.TabIndex = 2;
            nhankhach.Text = "Khách hàng";
            // 
            // chonkhachhang
            // 
            chonkhachhang.DropDownHeight = 300;
            chonkhachhang.DropDownStyle = ComboBoxStyle.DropDownList;
            chonkhachhang.IntegralHeight = false;
            chonkhachhang.Location = new Point(20, 129);
            chonkhachhang.Name = "chonkhachhang";
            chonkhachhang.Size = new Size(425, 31);
            chonkhachhang.TabIndex = 3;
            // 
            // nutthemkhach
            // 
            nutthemkhach.BackColor = Color.White;
            nutthemkhach.Cursor = Cursors.Hand;
            nutthemkhach.FlatStyle = FlatStyle.Flat;
            nutthemkhach.ForeColor = Color.FromArgb(23, 60, 59);
            nutthemkhach.Location = new Point(460, 125);
            nutthemkhach.Name = "nutthemkhach";
            nutthemkhach.Size = new Size(145, 36);
            nutthemkhach.TabIndex = 4;
            nutthemkhach.Text = "+ Khách hàng";
            nutthemkhach.UseVisualStyleBackColor = false;
            // 
            // nuttailai
            // 
            nuttailai.BackColor = Color.White;
            nuttailai.Cursor = Cursors.Hand;
            nuttailai.FlatStyle = FlatStyle.Flat;
            nuttailai.ForeColor = Color.FromArgb(23, 60, 59);
            nuttailai.Location = new Point(619, 125);
            nuttailai.Name = "nuttailai";
            nuttailai.Size = new Size(150, 36);
            nuttailai.TabIndex = 5;
            nuttailai.Text = "Tải game / KH";
            nuttailai.UseVisualStyleBackColor = false;
            // 
            // nhangame
            // 
            nhangame.ForeColor = Color.FromArgb(101, 119, 115);
            nhangame.Location = new Point(20, 176);
            nhangame.Name = "nhangame";
            nhangame.Size = new Size(500, 24);
            nhangame.TabIndex = 6;
            nhangame.Text = "Chọn game";
            // 
            // chongame
            // 
            chongame.DisplayMember = "Hienthi";
            chongame.DropDownHeight = 300;
            chongame.DropDownStyle = ComboBoxStyle.DropDownList;
            chongame.IntegralHeight = false;
            chongame.Location = new Point(20, 206);
            chongame.Name = "chongame";
            chongame.Size = new Size(565, 31);
            chongame.TabIndex = 7;
            // 
            // nhansl
            // 
            nhansl.ForeColor = Color.FromArgb(101, 119, 115);
            nhansl.Location = new Point(604, 176);
            nhansl.Name = "nhansl";
            nhansl.Size = new Size(120, 24);
            nhansl.TabIndex = 8;
            nhansl.Text = "Số lượng";
            // 
            // osoluong
            // 
            osoluong.Location = new Point(604, 206);
            osoluong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            osoluong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            osoluong.Name = "osoluong";
            osoluong.Size = new Size(115, 30);
            osoluong.TabIndex = 9;
            osoluong.TextAlign = HorizontalAlignment.Right;
            osoluong.ThousandsSeparator = true;
            osoluong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nutthem
            // 
            nutthem.BackColor = Color.FromArgb(23, 60, 59);
            nutthem.Cursor = Cursors.Hand;
            nutthem.FlatAppearance.BorderSize = 0;
            nutthem.FlatStyle = FlatStyle.Flat;
            nutthem.ForeColor = Color.White;
            nutthem.Location = new Point(735, 203);
            nutthem.Name = "nutthem";
            nutthem.Size = new Size(165, 36);
            nutthem.TabIndex = 10;
            nutthem.Text = "Thêm vào giỏ";
            nutthem.UseVisualStyleBackColor = false;
            // 
            // nutcapnhat
            // 
            nutcapnhat.BackColor = Color.White;
            nutcapnhat.Cursor = Cursors.Hand;
            nutcapnhat.FlatStyle = FlatStyle.Flat;
            nutcapnhat.ForeColor = Color.FromArgb(23, 60, 59);
            nutcapnhat.Location = new Point(913, 203);
            nutcapnhat.Name = "nutcapnhat";
            nutcapnhat.Size = new Size(180, 36);
            nutcapnhat.TabIndex = 11;
            nutcapnhat.Text = "Cập nhật SL";
            nutcapnhat.UseVisualStyleBackColor = false;
            // 
            // banggiohang
            // 
            banggiohang.AllowUserToAddRows = false;
            banggiohang.AllowUserToDeleteRows = false;
            banggiohang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 247);
            banggiohang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            banggiohang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            banggiohang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            banggiohang.BackgroundColor = Color.White;
            banggiohang.BorderStyle = BorderStyle.None;
            banggiohang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 239, 233);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 239, 233);
            banggiohang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            banggiohang.ColumnHeadersHeight = 42;
            banggiohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            banggiohang.Columns.AddRange(new DataGridViewColumn[] { banggiohangMa, banggiohangTen, banggiohangDongia, banggiohangSoluong, banggiohangThanhtien });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(209, 229, 218);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            banggiohang.DefaultCellStyle = dataGridViewCellStyle6;
            banggiohang.EnableHeadersVisualStyles = false;
            banggiohang.GridColor = Color.FromArgb(231, 235, 230);
            banggiohang.Location = new Point(20, 260);
            banggiohang.MultiSelect = false;
            banggiohang.Name = "banggiohang";
            banggiohang.ReadOnly = true;
            banggiohang.RowHeadersVisible = false;
            banggiohang.RowHeadersWidth = 51;
            banggiohang.RowTemplate.Height = 37;
            banggiohang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            banggiohang.Size = new Size(1075, 268);
            banggiohang.TabIndex = 12;
            // 
            // banggiohangMa
            // 
            banggiohangMa.HeaderText = "Mã game";
            banggiohangMa.MinimumWidth = 65;
            banggiohangMa.Name = "banggiohangMa";
            banggiohangMa.ReadOnly = true;
            // 
            // banggiohangTen
            // 
            banggiohangTen.FillWeight = 300F;
            banggiohangTen.HeaderText = "Tên game";
            banggiohangTen.MinimumWidth = 65;
            banggiohangTen.Name = "banggiohangTen";
            banggiohangTen.ReadOnly = true;
            // 
            // banggiohangDongia
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            banggiohangDongia.DefaultCellStyle = dataGridViewCellStyle3;
            banggiohangDongia.FillWeight = 120F;
            banggiohangDongia.HeaderText = "Đơn giá (đ)";
            banggiohangDongia.MinimumWidth = 65;
            banggiohangDongia.Name = "banggiohangDongia";
            banggiohangDongia.ReadOnly = true;
            // 
            // banggiohangSoluong
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            banggiohangSoluong.DefaultCellStyle = dataGridViewCellStyle4;
            banggiohangSoluong.FillWeight = 85F;
            banggiohangSoluong.HeaderText = "Số lượng";
            banggiohangSoluong.MinimumWidth = 65;
            banggiohangSoluong.Name = "banggiohangSoluong";
            banggiohangSoluong.ReadOnly = true;
            // 
            // banggiohangThanhtien
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            banggiohangThanhtien.DefaultCellStyle = dataGridViewCellStyle5;
            banggiohangThanhtien.FillWeight = 140F;
            banggiohangThanhtien.HeaderText = "Thành tiền (đ)";
            banggiohangThanhtien.MinimumWidth = 65;
            banggiohangThanhtien.Name = "banggiohangThanhtien";
            banggiohangThanhtien.ReadOnly = true;
            // 
            // nutxoadong
            // 
            nutxoadong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nutxoadong.BackColor = Color.FromArgb(174, 64, 64);
            nutxoadong.Cursor = Cursors.Hand;
            nutxoadong.FlatAppearance.BorderSize = 0;
            nutxoadong.FlatStyle = FlatStyle.Flat;
            nutxoadong.ForeColor = Color.White;
            nutxoadong.Location = new Point(20, 545);
            nutxoadong.Name = "nutxoadong";
            nutxoadong.Size = new Size(125, 36);
            nutxoadong.TabIndex = 18;
            nutxoadong.Text = "Xóa dòng";
            nutxoadong.UseVisualStyleBackColor = false;
            // 
            // nhanton
            // 
            nhanton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhanton.ForeColor = Color.FromArgb(101, 119, 115);
            nhanton.Location = new Point(166, 552);
            nhanton.Name = "nhanton";
            nhanton.Size = new Size(910, 26);
            nhanton.TabIndex = 19;
            nhanton.Text = "Chọn game để xem tồn kho và giá bán.";
            // 
            // nhangiam
            // 
            nhangiam.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nhangiam.ForeColor = Color.FromArgb(101, 119, 115);
            nhangiam.Location = new Point(20, 603);
            nhangiam.Name = "nhangiam";
            nhangiam.Size = new Size(210, 24);
            nhangiam.TabIndex = 20;
            nhangiam.Text = "Giảm giá (đ)";
            // 
            // ogiamgia
            // 
            ogiamgia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ogiamgia.Location = new Point(20, 634);
            ogiamgia.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            ogiamgia.Name = "ogiamgia";
            ogiamgia.Size = new Size(210, 30);
            ogiamgia.TabIndex = 21;
            ogiamgia.TextAlign = HorizontalAlignment.Right;
            ogiamgia.ThousandsSeparator = true;
            // 
            // nhanghichu
            // 
            nhanghichu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nhanghichu.ForeColor = Color.FromArgb(101, 119, 115);
            nhanghichu.Location = new Point(250, 603);
            nhanghichu.Name = "nhanghichu";
            nhanghichu.Size = new Size(470, 24);
            nhanghichu.TabIndex = 22;
            nhanghichu.Text = "Ghi chú";
            // 
            // oghichu
            // 
            oghichu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oghichu.BorderStyle = BorderStyle.FixedSingle;
            oghichu.Location = new Point(250, 634);
            oghichu.MaxLength = 500;
            oghichu.Name = "oghichu";
            oghichu.Size = new Size(490, 30);
            oghichu.TabIndex = 23;
            // 
            // nhantong
            // 
            nhantong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nhantong.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            nhantong.ForeColor = Color.FromArgb(23, 60, 59);
            nhantong.Location = new Point(765, 619);
            nhantong.Name = "nhantong";
            nhantong.Size = new Size(330, 50);
            nhantong.TabIndex = 24;
            nhantong.Text = "0 đ";
            nhantong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nhantrangthai
            // 
            nhantrangthai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhantrangthai.ForeColor = Color.FromArgb(101, 119, 115);
            nhantrangthai.Location = new Point(20, 697);
            nhantrangthai.Name = "nhantrangthai";
            nhantrangthai.Size = new Size(1060, 26);
            nhantrangthai.TabIndex = 25;
            nhantrangthai.Text = "Chưa kết nối SQL.";
            // 
            // nutluu
            // 
            nutluu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nutluu.BackColor = Color.FromArgb(23, 60, 59);
            nutluu.Cursor = Cursors.Hand;
            nutluu.FlatAppearance.BorderSize = 0;
            nutluu.FlatStyle = FlatStyle.Flat;
            nutluu.ForeColor = Color.White;
            nutluu.Location = new Point(739, 744);
            nutluu.Name = "nutluu";
            nutluu.Size = new Size(210, 40);
            nutluu.TabIndex = 26;
            nutluu.Text = "Thanh toán & lưu";
            nutluu.UseVisualStyleBackColor = false;
            // 
            // nuthuy
            // 
            nuthuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nuthuy.BackColor = Color.White;
            nuthuy.Cursor = Cursors.Hand;
            nuthuy.DialogResult = DialogResult.Cancel;
            nuthuy.FlatStyle = FlatStyle.Flat;
            nuthuy.ForeColor = Color.FromArgb(23, 60, 59);
            nuthuy.Location = new Point(962, 744);
            nuthuy.Name = "nuthuy";
            nuthuy.Size = new Size(132, 40);
            nuthuy.TabIndex = 27;
            nuthuy.Text = "Đóng";
            nuthuy.UseVisualStyleBackColor = false;
            // 
            // taohoadon
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 247, 244);
            CancelButton = nuthuy;
            ClientSize = new Size(1120, 800);
            Controls.Add(nhantieude);
            Controls.Add(nhanmota);
            Controls.Add(nhankhach);
            Controls.Add(chonkhachhang);
            Controls.Add(nutthemkhach);
            Controls.Add(nuttailai);
            Controls.Add(nhangame);
            Controls.Add(chongame);
            Controls.Add(nhansl);
            Controls.Add(osoluong);
            Controls.Add(nutthem);
            Controls.Add(nutcapnhat);
            Controls.Add(banggiohang);
            Controls.Add(nutxoadong);
            Controls.Add(nhanton);
            Controls.Add(nhangiam);
            Controls.Add(ogiamgia);
            Controls.Add(nhanghichu);
            Controls.Add(oghichu);
            Controls.Add(nhantong);
            Controls.Add(nhantrangthai);
            Controls.Add(nutluu);
            Controls.Add(nuthuy);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(23, 60, 59);
            MinimumSize = new Size(1120, 800);
            Name = "taohoadon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tạo hóa đơn bán game";
            ((ISupportInitialize)osoluong).EndInit();
            ((ISupportInitialize)banggiohang).EndInit();
            ((ISupportInitialize)ogiamgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label nhantieude;
        private Label nhanmota;
        private Label nhankhach;
        private ComboBox chonkhachhang;
        private Button nutthemkhach;
        private Button nuttailai;
        private Label nhangame;
        private ComboBox chongame;
        private Label nhansl;
        private NumericUpDown osoluong;
        private Button nutthem;
        private Button nutcapnhat;
        private DataGridView banggiohang;
        private DataGridViewTextBoxColumn banggiohangMa;
        private DataGridViewTextBoxColumn banggiohangTen;
        private DataGridViewTextBoxColumn banggiohangDongia;
        private DataGridViewTextBoxColumn banggiohangSoluong;
        private DataGridViewTextBoxColumn banggiohangThanhtien;
        private Button nutxoadong;
        private Label nhanton;
        private Label nhangiam;
        private NumericUpDown ogiamgia;
        private Label nhanghichu;
        private TextBox oghichu;
        private Label nhantong;
        private Label nhantrangthai;
        private Button nutluu;
        private Button nuthuy;

        #endregion
    }
}