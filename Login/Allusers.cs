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
    public partial class Allusers : UserControl
    {
        public Allusers()
        {
            InitializeComponent();
            databind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(cmbrole.Text))
            {
                string name = txtName.Text;
                string password = txtPrice.Text;
                string role = cmbrole.SelectedItem.ToString();
        
                if(role=="Admin")
                {
                    Admin admin = new Admin(name, password, role);
                  
                  bool istrue=  PersonDL.AddinList(admin);
                    if(istrue)
                    {
                        PersonDL.StoreCredentialsinFile();
                        MessageBox.Show("Admin Added Successfully","Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clearfields();
                        databind();
                    }
                    else
                    {
                        MessageBox.Show("Already Exits","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    Customer customer = new Customer(name, password, role);
              
                    bool istrue = PersonDL.AddinList(customer);
                    if (istrue)
                    {
                        PersonDL.StoreCredentialsinFile();
                        MessageBox.Show("User Added Succesfully","Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                      

                    }
                    else
                    {
                        MessageBox.Show("Already Exits","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      

                    }
                    Clearfields();
                    databind();
                }
            }
            else
            {
                MessageBox.Show("All Fields Required","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        void Clearfields()
        {
            txtName.Clear();
            txtPrice.Clear();
            cmbrole.SelectedIndex=-1;
        }
        void databind()
        {
            Gridusers.DataSource = null;
            Gridusers.DataSource = PersonDL.PersonList;
            Gridusers.Refresh();
        }

        private void Gridusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = Gridusers.Rows[index];
                txtName.Text = row.Cells[0].Value.ToString();
                txtPrice.Text = row.Cells[1].Value.ToString();
                cmbrole.Text = row.Cells[2].Value.ToString();
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message,"Warning");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(cmbrole.Text))
            {
                string name = txtName.Text;
                string password = txtPrice.Text;
                string role = cmbrole.SelectedItem.ToString();
                Admin newitem = new Admin(name, password, role);
                bool isdone = PersonDL.RemoveProduct(newitem);
            if (isdone)
            {
                MessageBox.Show("User deleted Succesfully","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PersonDL.StoreCredentialsinFile();
               
                  
            }
            else
            {
                MessageBox.Show("User does not Exits","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                Clearfields();
                databind();

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clearfields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(cmbrole.Text))
            {
                string name = txtName.Text;
                string password = txtPrice.Text;
                string role = cmbrole.SelectedItem.ToString();
                Admin admin = new Admin(name, password, role);
             bool istrue=   PersonDL.EditUsers(admin);
                if(istrue)
                {
                    MessageBox.Show("User Edited Successfully","Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonDL.StoreCredentialsinFile();
                   
                   
                }
                else
                {
                    MessageBox.Show("User does not Exits","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Clearfields();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Clearfields();
            databind();

        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            string name = Searchbox.Text;
            List<Person> fillterlist = PersonDL.Search(name);
            Gridusers.DataSource = null;
            Gridusers.DataSource = fillterlist;
            Gridusers.Refresh();
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
