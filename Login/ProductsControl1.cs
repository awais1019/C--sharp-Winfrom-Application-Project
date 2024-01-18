using Login.BL;
using Login.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ProductsControl1 : UserControl
    {
        public ProductsControl1()
        {
            InitializeComponent();
            databind();

        }

        private void ProductsControl1_Load(object sender, EventArgs e)
        {

        }

    
        private void txtPrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text)&&int.Parse(txtQuantity.Text)>0&&float.Parse(txtPrice.Text)>0)
            {
                string name = txtName.Text;
                float price = float.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                Product obj = new Product(name, price, quantity);
                clearfields();
                bool Exits = ProductDL.AddProductsInList(obj);
                if (Exits)
                {
                    MessageBox.Show("Product Added","Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    databind();
                }
                else
                {
                    MessageBox.Show("Already Exists","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill All Fields && Price and Qunatity greater than 0","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void databind()
        {
            GridProducts.DataSource = null;
            GridProducts.DataSource = ProductDL.AllProductsList;
            ProductDL.StoreIntoFileProducts();
            GridProducts.Refresh();
        }
        void clearfields()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void GridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = GridProducts.Rows[index];
                txtName.Text = row.Cells[0].Value.ToString();
                txtPrice.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message,"Warning");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text) && int.Parse(txtQuantity.Text) > 0 && float.Parse(txtPrice.Text) > 0)
            {
                string name = txtName.Text;
                float price = float.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                Product newitem = new Product(name, price, quantity);
                bool istrue = ProductDL.EditProducts(newitem);
                if (istrue)
                {
                    MessageBox.Show("Item Edited Successfully","Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else
                {
                    MessageBox.Show("Item does not Exits","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearfields();
                databind();
            }
            else
            {
                MessageBox.Show("Select item && Price and Qunatity greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                string name = txtName.Text;
                float price = float.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                Product newitem = new Product(name, price, quantity);
                bool isdone = ProductDL.RemoveProduct(newitem);
                if (isdone)
                {
                    MessageBox.Show("Item deleted Successfully","Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Item does not Exits","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearfields();
                databind();
            }
            else
            {
                MessageBox.Show("Select item","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            clearfields();
        }



        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
   
                string name= Searchbox.Text;
            List<Product> fillterlist = ProductDL.Search(name);    
                    GridProducts.DataSource = null;
                    GridProducts.DataSource =fillterlist ;
                    GridProducts.Refresh();
             
               
             
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to  Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
