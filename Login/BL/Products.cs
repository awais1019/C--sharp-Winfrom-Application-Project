using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.BL
{
  public  class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, float price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }

}

