namespace NShop
{
    partial class frmMainControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainControl));
            btnAddNewProduct = new Button();
            btnViewProductList = new Button();
            btnInVoice = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.BackColor = Color.Transparent;
            btnAddNewProduct.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddNewProduct.FlatAppearance.BorderColor = Color.GreenYellow;
            btnAddNewProduct.FlatAppearance.BorderSize = 5;
            btnAddNewProduct.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddNewProduct.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAddNewProduct.FlatStyle = FlatStyle.Flat;
            btnAddNewProduct.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewProduct.ForeColor = Color.GreenYellow;
            btnAddNewProduct.Location = new Point(40, 34);
            btnAddNewProduct.Margin = new Padding(0, 2, 0, 0);
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.Size = new Size(230, 70);
            btnAddNewProduct.TabIndex = 0;
            btnAddNewProduct.Text = "Add new product";
            btnAddNewProduct.UseVisualStyleBackColor = false;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // btnViewProductList
            // 
            btnViewProductList.BackColor = SystemColors.ActiveBorder;
            btnViewProductList.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnViewProductList.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnViewProductList.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnViewProductList.FlatStyle = FlatStyle.Flat;
            btnViewProductList.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewProductList.ForeColor = SystemColors.ActiveCaptionText;
            btnViewProductList.Location = new Point(40, 120);
            btnViewProductList.Margin = new Padding(0, 2, 0, 0);
            btnViewProductList.Name = "btnViewProductList";
            btnViewProductList.Size = new Size(230, 70);
            btnViewProductList.TabIndex = 3;
            btnViewProductList.Text = "View product list";
            btnViewProductList.UseVisualStyleBackColor = false;
//            btnViewProductList.Click += this.btnViewProductList_Click;
            // 
            // btnInVoice
            // 
            btnInVoice.BackColor = SystemColors.ActiveBorder;
            btnInVoice.FlatStyle = FlatStyle.Flat;
            btnInVoice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInVoice.Location = new Point(40, 209);
            btnInVoice.Margin = new Padding(0, 2, 0, 0);
            btnInVoice.Name = "btnInVoice";
            btnInVoice.Size = new Size(230, 70);
            btnInVoice.TabIndex = 4;
            btnInVoice.Text = "Bills";
            btnInVoice.UseVisualStyleBackColor = false;
      //      btnInVoice.Click += this.btnInVoice_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(40, 297);
            button1.Name = "button1";
            button1.Size = new Size(230, 70);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmMainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1032, 553);
            Controls.Add(button1);
            Controls.Add(btnInVoice);
            Controls.Add(btnViewProductList);
            Controls.Add(btnAddNewProduct);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMainControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Control Panel";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddNewProduct;
        private Button btnViewProductList;
        private Button btnInVoice;
        private Button button1;
    }
}
