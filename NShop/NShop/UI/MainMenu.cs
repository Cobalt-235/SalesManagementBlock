using NShop.UI;

namespace NShop
{
    public partial class frmMainControl : Form
    {
        public frmMainControl()
        {
            InitializeComponent();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmAddProductDetails addItemForm = new frmAddProductDetails();
            addItemForm.StartPosition = FormStartPosition.CenterScreen;
            addItemForm.ShowDialog();
            this.Show();

        }
    }
}
