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
    public partial class BillControl : UserControl
    {
        DataTable dataTable = new DataTable();
        Customer customer;
        public BillControl()
        {
            InitializeComponent();

            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Price", typeof(float));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Bill", typeof(float));




        }
        public void getobject(Customer obj)
        {
            this.customer = obj;
        }

        private void btnbillview_Click(object sender, EventArgs e)
        {
        
                DateTime time = DateTime.Now;
                float totalbill = 0;
                if (customer.PurchasedProducts.Count > 0)
                {
                    foreach (var product in customer.PurchasedProducts)
                    {
                        float bill = product.Price * product.Quantity;
                        dataTable.Rows.Add(product.Name, product.Price, product.Quantity, bill);
                        totalbill = totalbill + bill;
                    }
                    dataTable.Rows.Add("Total Bill", DBNull.Value, DBNull.Value, totalbill);
                    dataTable.Rows.Add($"Time:   \t\t\t{time.ToString()} ");

                    databind();
                }
      
        
        }
        void databind()
        {
            GridProducts.DataSource = null;
            GridProducts.DataSource = dataTable;
            GridProducts.Refresh();
        }

        private void btnbillview_Leave(object sender, EventArgs e)
        {
            dataTable.Clear();
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
