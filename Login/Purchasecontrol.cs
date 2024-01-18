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
    public partial class Purchasecontrol : UserControl
    {
        Customer customerobj;
        public Purchasecontrol()
        {
            InitializeComponent();    
            databind();
        }

        private void purchasecontrol_Load(object sender, EventArgs e)
        {

        }
        void databind()
        {
            GridProducts.DataSource = null;
            GridProducts.DataSource = ProductDL.AllProductsList;
            GridProducts.Refresh();
        }
        void ClearFields()
        {
            txtName.Clear();
            txtQuantity.Clear();
        }
        private void purchasecontrol_Load_1(object sender, EventArgs e)
        {

        }
       public Customer  getobject(Customer  customer)
        {
            this.customerobj = customer;
            return customer;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                string name = txtName.Text;
                int quantity = int.Parse(txtQuantity.Text);
                float price = ProductDL.Check(quantity, name);
              
                if(price!=0)
                {
                
                    Product obj = new Product(name, price, quantity);       
                    customerobj.addinlist(obj);
                    MessageBox.Show("Added in Cart","Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    databind();
                }
                else
                {
                    MessageBox.Show("Wrong name or may be quantity exceede","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void GridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = GridProducts.Rows[index];
                txtName.Text = row.Cells[0].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }


        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            string name = Searchbox.Text;
            List<Product> fillterlist = ProductDL.Search(name);
            GridProducts.DataSource = null;
            GridProducts.DataSource = fillterlist;
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

