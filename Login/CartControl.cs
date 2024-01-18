using Login.BL;
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
    public partial class CartControl : UserControl
    {
        List<Product> product;
        Customer customer;
        public CartControl()
        {

            InitializeComponent();
            databind();

        }

        private void GridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = GridProducts.Rows[index];
                    txtName.Text = row.Cells[0].Value.ToString();
                    txtQuantity.Text = row.Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
            else
            {
                MessageBox.Show("You are Clicking on Header","Warning");
            }
        }

        void ClearFields()
        {
            txtName.Clear();
            txtQuantity.Clear();
        }
        public void setdatasource(Customer obj)
        {
            this.customer = obj;
            this.product = customer.PurchasedProducts;
            if (Searchbox.Text.Length<=0)
            {
                databind();
            }
            }
        private void btnEdit_Click(object sender, EventArgs e)
        {
         
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text)&&int.Parse(txtQuantity.Text) > 0)
            {
                string name = txtName.Text;
                int quantity = int.Parse(txtQuantity.Text);
                bool istrue = customer.decreasequnatity(name, quantity);
                if (istrue)
                {
                    MessageBox.Show("Qunatity Decreased Successfully","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("wrong name or quantity excede","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFields();
                }
            }
        }
        void databind()
        {
            GridProducts.DataSource = null;
            GridProducts.DataSource = product;
            GridProducts.Refresh();
        }
        private void CartControl_Load(object sender, EventArgs e)
        {
  
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
        
                if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text)&&int.Parse(txtQuantity.Text)>0)
                {
                    string name = txtName.Text;
                    int quantity = int.Parse(txtQuantity.Text);
                    bool istrue = customer.removeitem(name, quantity);
                    if (istrue)
                    {
                        MessageBox.Show("Item Deleted Successfully","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("wrong name or quantity","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearFields();
                    }
                }
            }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            string name = Searchbox.Text;
            GridProducts.DataSource = null;
            List<Product> fillterlist = customer.Search(name);
            GridProducts.DataSource = fillterlist;
            GridProducts.Refresh();
        }

        private void GridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

