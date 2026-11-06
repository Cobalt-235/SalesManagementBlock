namespace Quanlycuahanggame
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "GameStoreManager - Trang Chủ";
            
            // Thêm các control cơ bản cho Giai đoạn 1
            Panel pnlMenu = new Panel { Dock = DockStyle.Left, Width = 220, BackColor = System.Drawing.Color.FromArgb(0, 50, 100) };
            this.Controls.Add(pnlMenu);

            Button btnSanPham = new Button { Text = "Sản phẩm", Dock = DockStyle.Top, Height = 50, ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat };
            pnlMenu.Controls.Add(btnSanPham);
            btnSanPham.Click += (s, e) => {
                FrmSanPham frm = new FrmSanPham();
                frm.ShowDialog();
            };
        }
    }
}