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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
           

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp obj = new SignUp();
            ClearFields();
            obj.ShowDialog();

            this.Show();
           

        }

        private void ImgHideEye_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar=='*')
            {
                txtPassword.PasswordChar = '\0';
                ImgHideEye.Image = Properties.Resources.unhidden;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                ImgHideEye.Image = Properties.Resources.hidden__1_;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to  Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
           {
                string name = txtName.Text;
                string password = txtPassword.Text;
                Person obj = PersonDL.ReturnRole(name, password);
                if (obj != null)
                {

                    if (obj.Role == "Customer" && obj is Customer customer)
                    {

                        this.Hide();
                        ClearFields();
                        customer.Form(obj);
                        this.Show();
                   


                    }
                    else if(obj is Admin admin)
                    {
                        this.Hide();
                        ClearFields();
                       admin.Form(obj);
                        this.Show();
                 
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password or Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to  Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

     

        private void Signin_Load(object sender, EventArgs e)
        {

        }

   
    }
}
