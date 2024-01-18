using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Customers : UserControl
    {
        DataTable dataTable = new DataTable();
        public Customers()
        {
            InitializeComponent();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
            dataTable.Columns.Add("Products", typeof(string));
            dataTable.Columns.Add("Price", typeof(float));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Bill", typeof(float));
            dataTable.Columns.Add("Date", typeof(string));
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnbillrecord_Click(object sender, EventArgs e)
        {
            string path = "History.txt";
       
            char ch = (char)223;

            string record;

         
            float totalbill = 0;
            int count = 0;
           

            StreamReader read = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = read.ReadLine()) != null)
                {
                    string[] user = record.Split(ch);

                    string Username = user[0];
                    string Password = user[1];
                    string ProductName = user[3];
                   float Price = float.Parse(user[4]);
                  int   Quantity = int.Parse(user[5]);
                string  Date = user[6];
                  float  bill = Price * Quantity;
                    totalbill += bill;
                    count++;
                    dataTable.Rows.Add(Username, Password, ProductName, Price, Quantity, bill, Date);
                }


            }

            dataTable.Rows.Add("Total Earning", DBNull.Value, DBNull.Value, totalbill);
            dataTable.Rows.Add("Total items", DBNull.Value, DBNull.Value, count);
            read.Close();
            databind();

        }


        void databind()
        {
            GridProducts.DataSource = null;
            GridProducts.DataSource = dataTable;
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
    
