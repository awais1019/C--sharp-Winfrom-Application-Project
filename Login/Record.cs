using Login.BL;
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
    public partial class Record : UserControl
    {
        DataTable dataTable = new DataTable();
        Customer customer;
        public Record()
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


        public void getobject(Customer obj)
        {
            this.customer = obj;
        }
        private void btnbillrecord_Click(object sender, EventArgs e)
        {
            string name = customer.Name;
            string path = "History.txt";

            char ch = (char)223;

            string record;
       
            string Username = string.Empty;
            string Password = string.Empty;
            string ProductName = string.Empty;
            float Price = 0;
            float bill = 0;
            int Quantity = 0;
            float totalbill = 0;
            int count = 0;
            string Date = string.Empty;

            StreamReader read = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = read.ReadLine()) != null)
                {
                    string[] user = record.Split(ch);
                    if (user[0] == name)
                    {
                        Username = user[0];
                        Password = user[1];
                        ProductName = user[3];
                        Price = float.Parse(user[4]);
                        Quantity = int.Parse(user[5]);
                        Date = user[6];
                        bill = Price * Quantity;
                        totalbill += bill;
                        count++;
                        dataTable.Rows.Add(Username, Password, ProductName, Price, Quantity, bill, Date);
                    }
                 
                   
                  }
          

                }
            
            dataTable.Rows.Add("Total", DBNull.Value, DBNull.Value, totalbill);
            dataTable.Rows.Add("Count", DBNull.Value, DBNull.Value, count);
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

        private void btnbillrecord_Leave(object sender, EventArgs e)
        {
            dataTable.Clear();
        }
    }
    }

