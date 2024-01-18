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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Increment(1);
            if (guna2ProgressBar1.Value == 100)
            {
                guna2ProgressBar1.Value = 0;
                Signin obj=new Signin();
         
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                obj.ShowDialog();
            }

        }


    }
}
