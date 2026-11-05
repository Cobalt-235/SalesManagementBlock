namespace NShop.UI
{
    partial class frmAddProductDetails
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
            label1 = new Label();
            txtProductId = new TextBox();
            txtProductPrice = new TextBox();
            txtDesc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnConfirmAdd = new Button();
            btnCancel = new Button();
            button3 = new Button();
            btnPreviousStep = new Button();
            cmbCategory = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(50, 10, 500, 20);
            label1.Size = new Size(770, 61);
            label1.TabIndex = 0;
            label1.Text = "Add product details";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(64, 161);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(386, 27);
            txtProductId.TabIndex = 1;
            txtProductId.Text = "(Product's ID, ex: P3215..)";
            txtProductId.TextChanged += textBox1_TextChanged;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(64, 232);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(386, 27);
            txtProductPrice.TabIndex = 2;
            txtProductPrice.Text = "(Regular Price)";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(64, 304);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(386, 27);
            txtDesc.TabIndex = 3;
            txtDesc.Text = "(Enter short description)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 138);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 4;
            label2.Text = "Product ID (*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 209);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Price (*)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 281);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "Short Desc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 92);
            label5.Name = "label5";
            label5.Size = new Size(250, 23);
            label5.TabIndex = 7;
            label5.Text = "Please fill out necessary details:";
            // 
            // btnConfirmAdd
            // 
            btnConfirmAdd.BackColor = Color.DodgerBlue;
            btnConfirmAdd.FlatStyle = FlatStyle.Flat;
            btnConfirmAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmAdd.ForeColor = SystemColors.ControlLightLight;
            btnConfirmAdd.Location = new Point(368, 436);
            btnConfirmAdd.Name = "btnConfirmAdd";
            btnConfirmAdd.Size = new Size(150, 45);
            btnConfirmAdd.TabIndex = 11;
            btnConfirmAdd.Text = "Confirm add";
            btnConfirmAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(212, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 436);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnPreviousStep
            // 
            btnPreviousStep.FlatStyle = FlatStyle.Flat;
            btnPreviousStep.Location = new Point(56, 436);
            btnPreviousStep.Name = "btnPreviousStep";
            btnPreviousStep.Size = new Size(150, 45);
            btnPreviousStep.TabIndex = 14;
            btnPreviousStep.Text = "Previous step";
            btnPreviousStep.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(64, 368);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(386, 28);
            cmbCategory.TabIndex = 15;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 345);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 16;
            label7.Text = "Category";
            // 
            // frmAddProductDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 506);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(cmbCategory);
            Controls.Add(btnPreviousStep);
            Controls.Add(button3);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDesc);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddProductDetails";
            Text = "Add product details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductId;
        private TextBox txtProductPrice;
        private TextBox txtDesc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnConfirmAdd;
        private Button btnCancel;
        private Button button3;
        private Button btnPreviousStep;
        private ComboBox cmbCategory;
        private Label label7;
    }
}