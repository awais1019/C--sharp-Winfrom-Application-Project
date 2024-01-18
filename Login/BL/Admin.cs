using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.BL
{
  
        class Admin : Person
        {
            public Admin(string name, string password, string role) : base(name, password, role)
            {

            }
        public override void Form(Person obj)
        {
            AdminMenu admin = new AdminMenu(obj);
            admin.ShowDialog();
        }
    }
  }


