using Login.BL;
using Login.DL;
using Login.UI;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            cmbrole.SelectedIndex = 0;




        }


        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            bool istrue = Validations.validate(txtPassword.Text);
            if (istrue)
            {
                lblInstructionsPassword.Visible = false;
                txtConfirmPassword.Enabled = true;

            }
            else if (txtPassword.Text.Length >= 1 && !istrue)
            {
                lblInstructionsPassword.ForeColor = Color.Red;
                lblInstructionsPassword.Text = "Length Should Be 4 to 12 Characters No Special Symbols";
                lblInstructionsPassword.Visible = true;
                txtConfirmPassword.Enabled = false;


            }
        }

    

        private void ImgHideEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
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



        private void btnBack_Click_1(object sender, EventArgs e)


        {
            DialogResult result = MessageBox.Show("Do you want to Go Back", "Confirm Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                this.Close();


            }
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            bool istrue = Validations.validate(txtName.Text);
            bool isExits = PersonDL.UserExist(txtName.Text);
            if (istrue && isExits)
            {
                lblInstructions.Visible = false;
                txtPassword.Enabled = true;
            }
            else if (!isExits)
            {
                lblInstructions.ForeColor = Color.Red;
                lblInstructions.Text = "Name Already Exits";
                lblInstructions.Visible = true;
                txtPassword.Enabled = false;
            }
            else if (txtName.Text.Length >= 1 && !istrue)
            {
                lblInstructions.ForeColor = Color.Red;
                lblInstructions.Text = "Length Should Be 4 to 12 Characters No Special Symbols";
                lblInstructions.Visible = true;
                txtPassword.Enabled = false;


            }
        }



        private void ImgHideEye2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '*')
            {
                txtConfirmPassword.PasswordChar = '\0';
                ImgHideEye2.Image = Properties.Resources.unhidden;
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
                ImgHideEye2.Image = Properties.Resources.hidden__1_;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text && txtConfirmPassword.Text.Length >= 1)
            {
                lblInstructionsCnfrmPassword.ForeColor = Color.Red;
                lblInstructionsCnfrmPassword.Text = "Password Not Matched";
                lblInstructionsCnfrmPassword.Visible = true;



            }
            else
            {
                lblInstructionsCnfrmPassword.Visible = false;

            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (lblInstructionsPassword.Visible == false && lblInstructions.Visible == false && lblInstructionsCnfrmPassword.Visible == false && txtPassword.Enabled == true && txtConfirmPassword.Enabled == true && txtPassword.Text == txtConfirmPassword.Text)
            {

                string name = txtName.Text;
                string password = txtConfirmPassword.Text;
                string role = cmbrole.SelectedItem.ToString();
                Customer obj = new Customer(name, password, role);
                PersonDL.AddinList(obj);
                PersonDL.StoreCredentialsinFile();
                MessageBox.Show("Account Added Sucessfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {

                MessageBox.Show("All Fields Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }






        }
        private void ClearFields()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtName.Focus();
            txtConfirmPassword.Enabled = false;
            txtPassword.Enabled = false;


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
