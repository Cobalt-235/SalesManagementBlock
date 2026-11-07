using System.ComponentModel;
namespace QuanlybangameMoi_UI.Forms
{
    partial class suasanpham
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

        private void InitializeComponent()
        {
            components = new Container();
            nhantieude = new Label();
            nhanmota = new Label();
            nhanoma = new Label();
            oma = new TextBox();
            nhanoten = new Label();
            oten = new TextBox();
            nhanotheloai = new Label();
            otheloai = new TextBox();
            nhanonentang = new Label();
            onentang = new TextBox();
            nhanonhaphathanh = new Label();
            onhaphathanh = new TextBox();
            chondangban = new CheckBox();
            nhangianhap = new Label();
            ogianhap = new NumericUpDown();
            nhangiaban = new Label();
            ogiaban = new NumericUpDown();
            nhantonkho = new Label();
            otonkho = new NumericUpDown();
            nhantoithieu = new Label();
            otoithieu = new NumericUpDown();
            nhanmotagame = new Label();
            omota = new TextBox();
            nutluu = new Button();
            nuthuy = new Button();
            kiemtraloi = new ErrorProvider(components);
            ((ISupportInitialize)ogianhap).BeginInit();
            ((ISupportInitialize)ogiaban).BeginInit();
            ((ISupportInitialize)otonkho).BeginInit();
            ((ISupportInitialize)otoithieu).BeginInit();
            ((ISupportInitialize)kiemtraloi).BeginInit();
            SuspendLayout();
            // 
            // nhantieude
            // 
            nhantieude.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhantieude.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nhantieude.ForeColor = Color.FromArgb(23, 60, 59);
            nhantieude.Location = new Point(20, 9);
            nhantieude.Name = "nhantieude";
            nhantieude.Size = new Size(306, 49);
            nhantieude.TabIndex = 0;
            nhantieude.Text = "Thông tin game";
            // 
            // nhanmota
            // 
            nhanmota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanmota.ForeColor = Color.FromArgb(101, 119, 115);
            nhanmota.Location = new Point(22, 58);
            nhanmota.Name = "nhanmota";
            nhanmota.Size = new Size(676, 26);
            nhanmota.TabIndex = 1;
            nhanmota.Text = "Nhập thông tin sản phẩm • Các mục có * là bắt buộc";
            // 
            // nhanoma
            // 
            nhanoma.ForeColor = Color.FromArgb(101, 119, 115);
            nhanoma.Location = new Point(24, 113);
            nhanoma.Name = "nhanoma";
            nhanoma.Size = new Size(302, 24);
            nhanoma.TabIndex = 2;
            nhanoma.Text = "Mã game *";
            // 
            // oma
            // 
            oma.BorderStyle = BorderStyle.FixedSingle;
            oma.Location = new Point(24, 142);
            oma.MaxLength = 30;
            oma.Name = "oma";
            oma.Size = new Size(302, 30);
            oma.TabIndex = 3;
            // 
            // nhanoten
            // 
            nhanoten.ForeColor = Color.FromArgb(101, 119, 115);
            nhanoten.Location = new Point(360, 113);
            nhanoten.Name = "nhanoten";
            nhanoten.Size = new Size(330, 24);
            nhanoten.TabIndex = 4;
            nhanoten.Text = "Tên game *";
            // 
            // oten
            // 
            oten.BorderStyle = BorderStyle.FixedSingle;
            oten.Location = new Point(360, 142);
            oten.MaxLength = 150;
            oten.Name = "oten";
            oten.Size = new Size(330, 30);
            oten.TabIndex = 5;
            // 
            // nhanotheloai
            // 
            nhanotheloai.ForeColor = Color.FromArgb(101, 119, 115);
            nhanotheloai.Location = new Point(24, 198);
            nhanotheloai.Name = "nhanotheloai";
            nhanotheloai.Size = new Size(302, 24);
            nhanotheloai.TabIndex = 6;
            nhanotheloai.Text = "Thể loại *";
            // 
            // otheloai
            // 
            otheloai.BorderStyle = BorderStyle.FixedSingle;
            otheloai.Location = new Point(24, 227);
            otheloai.MaxLength = 80;
            otheloai.Name = "otheloai";
            otheloai.Size = new Size(302, 30);
            otheloai.TabIndex = 7;
            // 
            // nhanonentang
            // 
            nhanonentang.ForeColor = Color.FromArgb(101, 119, 115);
            nhanonentang.Location = new Point(360, 198);
            nhanonentang.Name = "nhanonentang";
            nhanonentang.Size = new Size(330, 24);
            nhanonentang.TabIndex = 8;
            nhanonentang.Text = "Nền tảng *";
            // 
            // onentang
            // 
            onentang.BorderStyle = BorderStyle.FixedSingle;
            onentang.Location = new Point(360, 227);
            onentang.MaxLength = 50;
            onentang.Name = "onentang";
            onentang.Size = new Size(330, 30);
            onentang.TabIndex = 9;
            // 
            // nhanonhaphathanh
            // 
            nhanonhaphathanh.ForeColor = Color.FromArgb(101, 119, 115);
            nhanonhaphathanh.Location = new Point(24, 283);
            nhanonhaphathanh.Name = "nhanonhaphathanh";
            nhanonhaphathanh.Size = new Size(302, 24);
            nhanonhaphathanh.TabIndex = 10;
            nhanonhaphathanh.Text = "Nhà phát hành";
            // 
            // onhaphathanh
            // 
            onhaphathanh.BorderStyle = BorderStyle.FixedSingle;
            onhaphathanh.Location = new Point(24, 312);
            onhaphathanh.MaxLength = 100;
            onhaphathanh.Name = "onhaphathanh";
            onhaphathanh.Size = new Size(302, 30);
            onhaphathanh.TabIndex = 11;
            // 
            // chondangban
            // 
            chondangban.Checked = true;
            chondangban.CheckState = CheckState.Checked;
            chondangban.Location = new Point(360, 321);
            chondangban.Name = "chondangban";
            chondangban.Size = new Size(250, 28);
            chondangban.TabIndex = 12;
            chondangban.Text = "Đang bán";
            // 
            // nhangianhap
            // 
            nhangianhap.ForeColor = Color.FromArgb(101, 119, 115);
            nhangianhap.Location = new Point(24, 372);
            nhangianhap.Name = "nhangianhap";
            nhangianhap.Size = new Size(330, 24);
            nhangianhap.TabIndex = 13;
            nhangianhap.Text = "Giá nhập (đ)";
            // 
            // ogianhap
            // 
            ogianhap.Location = new Point(24, 401);
            ogianhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            ogianhap.Name = "ogianhap";
            ogianhap.Size = new Size(302, 30);
            ogianhap.TabIndex = 14;
            ogianhap.TextAlign = HorizontalAlignment.Right;
            ogianhap.ThousandsSeparator = true;
            // 
            // nhangiaban
            // 
            nhangiaban.ForeColor = Color.FromArgb(101, 119, 115);
            nhangiaban.Location = new Point(360, 372);
            nhangiaban.Name = "nhangiaban";
            nhangiaban.Size = new Size(330, 24);
            nhangiaban.TabIndex = 15;
            nhangiaban.Text = "Giá bán (đ) *";
            // 
            // ogiaban
            // 
            ogiaban.Location = new Point(360, 401);
            ogiaban.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            ogiaban.Name = "ogiaban";
            ogiaban.Size = new Size(302, 30);
            ogiaban.TabIndex = 16;
            ogiaban.TextAlign = HorizontalAlignment.Right;
            ogiaban.ThousandsSeparator = true;
            // 
            // nhantonkho
            // 
            nhantonkho.ForeColor = Color.FromArgb(101, 119, 115);
            nhantonkho.Location = new Point(24, 451);
            nhantonkho.Name = "nhantonkho";
            nhantonkho.Size = new Size(330, 24);
            nhantonkho.TabIndex = 17;
            nhantonkho.Text = "Tồn đầu kỳ (chỉ khi thêm mới)";
            // 
            // otonkho
            // 
            otonkho.Location = new Point(24, 480);
            otonkho.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            otonkho.Name = "otonkho";
            otonkho.Size = new Size(302, 30);
            otonkho.TabIndex = 18;
            otonkho.TextAlign = HorizontalAlignment.Right;
            otonkho.ThousandsSeparator = true;
            // 
            // nhantoithieu
            // 
            nhantoithieu.ForeColor = Color.FromArgb(101, 119, 115);
            nhantoithieu.Location = new Point(360, 451);
            nhantoithieu.Name = "nhantoithieu";
            nhantoithieu.Size = new Size(330, 24);
            nhantoithieu.TabIndex = 19;
            nhantoithieu.Text = "Ngưỡng cảnh báo tồn";
            // 
            // otoithieu
            // 
            otoithieu.Location = new Point(360, 480);
            otoithieu.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            otoithieu.Name = "otoithieu";
            otoithieu.Size = new Size(302, 30);
            otoithieu.TabIndex = 20;
            otoithieu.TextAlign = HorizontalAlignment.Right;
            otoithieu.ThousandsSeparator = true;
            // 
            // nhanmotagame
            // 
            nhanmotagame.ForeColor = Color.FromArgb(101, 119, 115);
            nhanmotagame.Location = new Point(24, 531);
            nhanmotagame.Name = "nhanmotagame";
            nhanmotagame.Size = new Size(300, 24);
            nhanmotagame.TabIndex = 21;
            nhanmotagame.Text = "Mô tả";
            // 
            // omota
            // 
            omota.BorderStyle = BorderStyle.FixedSingle;
            omota.Location = new Point(24, 560);
            omota.MaxLength = 1000;
            omota.Multiline = true;
            omota.Name = "omota";
            omota.ScrollBars = ScrollBars.Vertical;
            omota.Size = new Size(666, 58);
            omota.TabIndex = 22;
            // 
            // nutluu
            // 
            nutluu.BackColor = Color.FromArgb(23, 60, 59);
            nutluu.Cursor = Cursors.Hand;
            nutluu.FlatAppearance.BorderSize = 0;
            nutluu.FlatStyle = FlatStyle.Flat;
            nutluu.ForeColor = Color.White;
            nutluu.Location = new Point(408, 637);
            nutluu.Name = "nutluu";
            nutluu.Size = new Size(145, 36);
            nutluu.TabIndex = 23;
            nutluu.Text = "Lưu game";
            nutluu.UseVisualStyleBackColor = false;
            // 
            // nuthuy
            // 
            nuthuy.BackColor = Color.White;
            nuthuy.Cursor = Cursors.Hand;
            nuthuy.DialogResult = DialogResult.Cancel;
            nuthuy.FlatStyle = FlatStyle.Flat;
            nuthuy.ForeColor = Color.FromArgb(23, 60, 59);
            nuthuy.Location = new Point(565, 637);
            nuthuy.Name = "nuthuy";
            nuthuy.Size = new Size(124, 36);
            nuthuy.TabIndex = 24;
            nuthuy.Text = "Hủy";
            nuthuy.UseVisualStyleBackColor = false;
            // 
            // kiemtraloi
            // 
            kiemtraloi.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            kiemtraloi.ContainerControl = this;
            // 
            // suasanpham
            // 
            AcceptButton = nutluu;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 247, 244);
            CancelButton = nuthuy;
            ClientSize = new Size(720, 690);
            Controls.Add(nhantieude);
            Controls.Add(nhanmota);
            Controls.Add(nhanoma);
            Controls.Add(oma);
            Controls.Add(nhanoten);
            Controls.Add(oten);
            Controls.Add(nhanotheloai);
            Controls.Add(otheloai);
            Controls.Add(nhanonentang);
            Controls.Add(onentang);
            Controls.Add(nhanonhaphathanh);
            Controls.Add(onhaphathanh);
            Controls.Add(chondangban);
            Controls.Add(nhangianhap);
            Controls.Add(ogianhap);
            Controls.Add(nhangiaban);
            Controls.Add(ogiaban);
            Controls.Add(nhantonkho);
            Controls.Add(otonkho);
            Controls.Add(nhantoithieu);
            Controls.Add(otoithieu);
            Controls.Add(nhanmotagame);
            Controls.Add(omota);
            Controls.Add(nutluu);
            Controls.Add(nuthuy);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(23, 60, 59);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(720, 690);
            Name = "suasanpham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin sản phẩm";
            ((ISupportInitialize)ogianhap).EndInit();
            ((ISupportInitialize)ogiaban).EndInit();
            ((ISupportInitialize)otonkho).EndInit();
            ((ISupportInitialize)otoithieu).EndInit();
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
        private Label nhanotheloai;
        private TextBox otheloai;
        private Label nhanonentang;
        private TextBox onentang;
        private Label nhanonhaphathanh;
        private TextBox onhaphathanh;
        private CheckBox chondangban;
        private Label nhangianhap;
        private NumericUpDown ogianhap;
        private Label nhangiaban;
        private NumericUpDown ogiaban;
        private Label nhantonkho;
        private NumericUpDown otonkho;
        private Label nhantoithieu;
        private NumericUpDown otoithieu;
        private Label nhanmotagame;
        private TextBox omota;
        private Button nutluu;
        private Button nuthuy;
        private ErrorProvider kiemtraloi;
    }
}