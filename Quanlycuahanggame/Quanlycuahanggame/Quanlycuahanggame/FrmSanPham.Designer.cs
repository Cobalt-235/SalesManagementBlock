namespace Quanlycuahanggame
{
    partial class FrmSanPham
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
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "Quản lý Sản phẩm";
            
            // Thêm các control cơ bản cho FrmSanPham
            Label lblTenSP = new Label { Text = "Tên SP:", Location = new System.Drawing.Point(20, 20) };
            TextBox txtTenSP = new TextBox { Location = new System.Drawing.Point(100, 20), Width = 200 };
            
            this.Controls.Add(lblTenSP);
            this.Controls.Add(txtTenSP);
        }
    }
}