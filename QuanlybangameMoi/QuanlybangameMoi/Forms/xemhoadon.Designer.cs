using System.ComponentModel;

namespace QuanlybangameMoi_UI.Forms
{
    partial class xemhoadon
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
            nhanthongtin = new Label();
            bangchitiet = new DataGridView();
            bangchitietMa = new DataGridViewTextBoxColumn();
            bangchitietTen = new DataGridViewTextBoxColumn();
            bangchitietDongia = new DataGridViewTextBoxColumn();
            bangchitietSoluong = new DataGridViewTextBoxColumn();
            bangchitietThanhtien = new DataGridViewTextBoxColumn();
            nhantong = new Label();
            nhanghichu = new Label();
            nutxuat = new Button();
            nutxemin = new Button();
            nutin = new Button();
            nutdong = new Button();
            ((ISupportInitialize)bangchitiet).BeginInit();
            SuspendLayout();
            // 
            // nhantieude
            // 
            nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
            nhantieude.Location = new Point(20, 9);
            nhantieude.Name = "nhantieude";
            nhantieude.Size = new Size(383, 43);
            nhantieude.TabIndex = 0;
            nhantieude.Text = "Chi tiết hóa đơn";
            // 
            // nhanmota
            // 
            nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
            nhanmota.Location = new Point(22, 58);
            nhanmota.Name = "nhanmota";
            nhanmota.Size = new Size(966, 26);
            nhanmota.TabIndex = 1;
            nhanmota.Text = "Phiếu bán hàng nội bộ • Có thể xuất HTML, JSON hoặc in thành PDF";
            // 
            // nhanthongtin
            // 
            nhanthongtin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanthongtin.ForeColor = Color.FromArgb(23, 60, 59);
            nhanthongtin.Location = new Point(22, 105);
            nhanthongtin.Name = "nhanthongtin";
            nhanthongtin.Size = new Size(962, 76);
            nhanthongtin.TabIndex = 2;
            nhanthongtin.Text = "Chưa chọn hóa đơn.";
            // 
            // bangchitiet
            // 
            bangchitiet.AllowUserToAddRows = false;
            bangchitiet.AllowUserToDeleteRows = false;
            bangchitiet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 247);
            bangchitiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bangchitiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bangchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bangchitiet.BackgroundColor = Color.White;
            bangchitiet.BorderStyle = BorderStyle.None;
            bangchitiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 239, 233);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 239, 233);
            bangchitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bangchitiet.ColumnHeadersHeight = 42;
            bangchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            bangchitiet.Columns.AddRange(new DataGridViewColumn[] { bangchitietMa, bangchitietTen, bangchitietDongia, bangchitietSoluong, bangchitietThanhtien });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(209, 229, 218);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(23, 60, 59);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            bangchitiet.DefaultCellStyle = dataGridViewCellStyle6;
            bangchitiet.EnableHeadersVisualStyles = false;
            bangchitiet.GridColor = Color.FromArgb(231, 235, 230);
            bangchitiet.Location = new Point(20, 199);
            bangchitiet.MultiSelect = false;
            bangchitiet.Name = "bangchitiet";
            bangchitiet.ReadOnly = true;
            bangchitiet.RowHeadersVisible = false;
            bangchitiet.RowHeadersWidth = 51;
            bangchitiet.RowTemplate.Height = 37;
            bangchitiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bangchitiet.Size = new Size(968, 290);
            bangchitiet.TabIndex = 3;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            bangchitietDongia.DefaultCellStyle = dataGridViewCellStyle3;
            bangchitietDongia.FillWeight = 120F;
            bangchitietDongia.HeaderText = "Đơn giá (đ)";
            bangchitietDongia.MinimumWidth = 65;
            bangchitietDongia.Name = "bangchitietDongia";
            bangchitietDongia.ReadOnly = true;
            // 
            // bangchitietSoluong
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            bangchitietSoluong.DefaultCellStyle = dataGridViewCellStyle4;
            bangchitietSoluong.FillWeight = 85F;
            bangchitietSoluong.HeaderText = "Số lượng";
            bangchitietSoluong.MinimumWidth = 65;
            bangchitietSoluong.Name = "bangchitietSoluong";
            bangchitietSoluong.ReadOnly = true;
            // 
            // bangchitietThanhtien
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            bangchitietThanhtien.DefaultCellStyle = dataGridViewCellStyle5;
            bangchitietThanhtien.FillWeight = 140F;
            bangchitietThanhtien.HeaderText = "Thành tiền (đ)";
            bangchitietThanhtien.MinimumWidth = 65;
            bangchitietThanhtien.Name = "bangchitietThanhtien";
            bangchitietThanhtien.ReadOnly = true;
            // 
            // nhantong
            // 
            nhantong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhantong.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            nhantong.ForeColor = Color.FromArgb(23, 60, 59);
            nhantong.Location = new Point(22, 511);
            nhantong.Name = "nhantong";
            nhantong.Size = new Size(960, 76);
            nhantong.TabIndex = 4;
            nhantong.Text = "Tổng thanh toán: —";
            // 
            // nhanghichu
            // 
            nhanghichu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhanghichu.ForeColor = Color.FromArgb(101, 119, 115);
            nhanghichu.Location = new Point(22, 597);
            nhanghichu.Name = "nhanghichu";
            nhanghichu.Size = new Size(960, 38);
            nhanghichu.TabIndex = 5;
            // 
            // nutxuat
            // 
            nutxuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nutxuat.BackColor = Color.FromArgb(189, 135, 67);
            nutxuat.Cursor = Cursors.Hand;
            nutxuat.FlatAppearance.BorderSize = 0;
            nutxuat.FlatStyle = FlatStyle.Flat;
            nutxuat.ForeColor = Color.White;
            nutxuat.Location = new Point(20, 659);
            nutxuat.Name = "nutxuat";
            nutxuat.Size = new Size(200, 36);
            nutxuat.TabIndex = 11;
            nutxuat.Text = "Xuất HTML / JSON";
            nutxuat.UseVisualStyleBackColor = false;
            // 
            // nutxemin
            // 
            nutxemin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nutxemin.BackColor = Color.White;
            nutxemin.Cursor = Cursors.Hand;
            nutxemin.FlatStyle = FlatStyle.Flat;
            nutxemin.ForeColor = Color.FromArgb(23, 60, 59);
            nutxemin.Location = new Point(234, 659);
            nutxemin.Name = "nutxemin";
            nutxemin.Size = new Size(190, 36);
            nutxemin.TabIndex = 12;
            nutxemin.Text = "Xem trước khi in";
            nutxemin.UseVisualStyleBackColor = false;
            // 
            // nutin
            // 
            nutin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nutin.BackColor = Color.FromArgb(23, 60, 59);
            nutin.Cursor = Cursors.Hand;
            nutin.FlatAppearance.BorderSize = 0;
            nutin.FlatStyle = FlatStyle.Flat;
            nutin.ForeColor = Color.White;
            nutin.Location = new Point(438, 659);
            nutin.Name = "nutin";
            nutin.Size = new Size(170, 36);
            nutin.TabIndex = 13;
            nutin.Text = "In / Lưu PDF";
            nutin.UseVisualStyleBackColor = false;
            // 
            // nutdong
            // 
            nutdong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nutdong.BackColor = Color.White;
            nutdong.Cursor = Cursors.Hand;
            nutdong.DialogResult = DialogResult.Cancel;
            nutdong.FlatStyle = FlatStyle.Flat;
            nutdong.ForeColor = Color.FromArgb(23, 60, 59);
            nutdong.Location = new Point(857, 659);
            nutdong.Name = "nutdong";
            nutdong.Size = new Size(130, 36);
            nutdong.TabIndex = 14;
            nutdong.Text = "Đóng";
            nutdong.UseVisualStyleBackColor = false;
            // 
            // xemhoadon
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 247, 244);
            CancelButton = nutdong;
            ClientSize = new Size(1010, 720);
            Controls.Add(nhantieude);
            Controls.Add(nhanmota);
            Controls.Add(nhanthongtin);
            Controls.Add(bangchitiet);
            Controls.Add(nhantong);
            Controls.Add(nhanghichu);
            Controls.Add(nutxuat);
            Controls.Add(nutxemin);
            Controls.Add(nutin);
            Controls.Add(nutdong);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(23, 60, 59);
            MinimumSize = new Size(1010, 720);
            Name = "xemhoadon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết hóa đơn";
            ((ISupportInitialize)bangchitiet).EndInit();
            ResumeLayout(false);
        }

        private Label nhantieude;
        private Label nhanmota;
        private Label nhanthongtin;
        private DataGridView bangchitiet;
        private DataGridViewTextBoxColumn bangchitietMa;
        private DataGridViewTextBoxColumn bangchitietTen;
        private DataGridViewTextBoxColumn bangchitietDongia;
        private DataGridViewTextBoxColumn bangchitietSoluong;
        private DataGridViewTextBoxColumn bangchitietThanhtien;
        private Label nhantong;
        private Label nhanghichu;
        private Button nutxuat;
        private Button nutxemin;
        private Button nutin;
        private Button nutdong;
    }

        #endregion
    }
