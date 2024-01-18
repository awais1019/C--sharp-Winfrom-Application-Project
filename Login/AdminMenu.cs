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
    public partial class AdminMenu : Form
    {

        public AdminMenu(Person obj)
        {
            InitializeComponent();
            LabelName.Text = obj.Name;
     



        }
      




     


      

        private void btnHome_Click(object sender, EventArgs e)
        {
            productsControl12.Visible = false;
            allusers1.Visible = false;
            newControl1.Visible = true;
            customers1.Visible = false;




        }



        private void btnProducts_Click(object sender, EventArgs e)
        {
            newControl1.Visible = false;
            allusers1.Visible = false;
            productsControl12.Visible = true;
            customers1.Visible = false;



        }

  
        void Setcolorproducts()
        {

            if(productsControl12.Visible==true)
            {
                btnproducts.FillColor = Color.Gold;
            }
            else
            {
                btnproducts.FillColor= AdminMenusPanel2.FillColor;
            }
        }
        void Setcolorforusers()
        {

            if (allusers1.Visible == true)
            {
               btnAllUsers.FillColor = Color.Gold;
            }
            else
            {
                btnAllUsers.FillColor = AdminMenusPanel2.FillColor;
            }
        }
        void homecolor()
        {
            if(newControl1.Visible==true)
            {
                btnHome.FillColor = Color.Gold;
            }
            else
            {
                btnHome.FillColor = Color.White;
            }
        }
        void homecustomer()
        {
            if (customers1.Visible == true)
            {
                customerbtn.FillColor = Color.Gold;
            }
            else
            {
                customerbtn.FillColor = Color.White;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            Setcolorproducts();
            Setcolorforusers();
            homecolor();
            homecustomer();
        }


        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            productsControl12.Visible = false;
            newControl1.Visible = false;
            allusers1.Visible = true;
            customers1.Visible = false;
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            productsControl12.Visible = false;
            newControl1.Visible = false;
            allusers1.Visible = false;
            customers1.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Go Back", "Confirm Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProductDL.StoreIntoFileProducts();
                PersonDL.StoreCredentialsinFile();
               
                this.Close();
            }
    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to  Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProductDL.StoreIntoFileProducts();
                PersonDL.StoreCredentialsinFile();
                Application.Exit();
            }
        }
    }
}
