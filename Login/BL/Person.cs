using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
  public abstract  class Person
    {
      
            public string Name { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
     

            public Person(string name, string password, string role)
            {
                this.Name = name;
                this.Password = password;
                this.Role = role;
            }
              public abstract void Form(Person obj);
        }
}
