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
    public partial class UserMenu : Form
    {
       public Customer obj;
     
        public UserMenu(Customer customer)
        {
            InitializeComponent();
            UserName.Text = customer.Name;
            this.obj = customer;
            billControl1.Visible = false;
            record1.Visible = false;





        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            newControl2.Visible = true;
            cartControl2.Visible = false;
            purchasecontrol2.Visible = false;
            billControl1.Visible = false;
            record1.Visible = false;
        }

 
        void homecolor()
        {
            if (newControl2.Visible == true)
            {
                btnHome.FillColor = Color.Gold;
            }
            else
            {
                btnHome.FillColor = Color.White;
            }
            
        }
        void Setcolorproducts()
        {

            if (purchasecontrol2.Visible == true)
            {
                btnproducts.FillColor = Color.Gold;
            }
            else
            {
                btnproducts.FillColor = AdminMenusPanel2.FillColor;
            }
        }
        void Setcolorcart()
        {

            if (cartControl2.Visible == true)
            {
                btncart.FillColor = Color.Gold;
            }
            else
            {
                btncart.FillColor = AdminMenusPanel2.FillColor;
            }
        }
        void Setcolorbill()
        {

            if (billControl1.Visible == true)
            {
                btnbill.FillColor = Color.Gold;
            }
            else
            {
                btnbill.FillColor = AdminMenusPanel2.FillColor;
            }
        }

            void SetcolorRecord()
            {

                if (record1.Visible == true)
                {
                    recordbtn.FillColor = Color.Gold;
                }
                else
                {
                    recordbtn.FillColor = AdminMenusPanel2.FillColor;
                }
            }
        private void timer1_Tick(object sender, EventArgs e)
        {
            homecolor();
            Setcolorproducts();
            Setcolorcart();
            Setcolorbill();
            SetcolorRecord();
            cartControl2.setdatasource(obj);
            purchasecontrol2.getobject(obj);
            billControl1.getobject(obj);
            record1.getobject(obj);

        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            cartControl2.Visible = false;
            newControl2.Visible = false;
            billControl1.Visible = false;
            record1.Visible = false;
            purchasecontrol2.Visible = true;

           

        }



        private void cartControl2_Load(object sender, EventArgs e)
        {

        }

        private void newControl2_Load(object sender, EventArgs e)
        {

        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
       
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            purchasecontrol2.Visible = false;
            newControl2.Visible = false;
            billControl1.Visible = false;
            record1.Visible = false;
            cartControl2.Visible = true;

        }


        private void btnbill_Click_1(object sender, EventArgs e)
        {
            purchasecontrol2.Visible = false;
            newControl2.Visible = false;
            cartControl2.Visible = false;
            record1.Visible = false;
            billControl1.Visible = true;
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Go Back", "Confirm Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProductDL.StoreIntoFileProducts();
                CustomerProductsDL.Store(obj);
                obj.PurchasedProducts.Clear();

                this.Close();
            
            }
        }

        private void recordbtn_Click(object sender, EventArgs e)
        {
            record1.Visible = true;
            purchasecontrol2.Visible = false;
            newControl2.Visible = false;
            cartControl2.Visible = false;
            billControl1.Visible = false;
            
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to  Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                ProductDL.StoreIntoFileProducts();
                CustomerProductsDL.Store(obj);
                obj.PurchasedProducts.Clear();
                Application.Exit();
            }
      
        }
    }
}
