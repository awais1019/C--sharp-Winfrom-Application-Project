using Login.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.BL
{
    public class Customer : Person
    {
      
       
           
            public List<Product> PurchasedProducts { get; set; }
   
    
        public Customer(string name, string password, string role) : base(name, password, role)
        {
            PurchasedProducts = new List<Product>();
        }
 
      
        public bool addinlist(Product obj)
        {
            foreach (var item in PurchasedProducts)
            {
                if (obj.Name == item.Name)
                {
                    item.Quantity += obj.Quantity;
                    return true;
                }
            }
            PurchasedProducts.Add(obj);
            return true;
        }

        public bool decreasequnatity(string name, int qunatity)
        {
            foreach (var item in PurchasedProducts)
            {
                if(name==item.Name&& qunatity<item.Quantity )
                {
                    int remainingquantity = item.Quantity - qunatity;
                    ProductDL.IncreaseQunatity(name, remainingquantity);
                    item.Quantity = qunatity;
                    return true;
                }
            }
            return false; 
        }
        public bool removeitem(string name, int qunatity)
        {
            foreach (var item in PurchasedProducts)
            {
                if (name == item.Name && qunatity <= item.Quantity)
                {
                    PurchasedProducts.Remove(item);
                    ProductDL.IncreaseQunatity(name, qunatity);

                    return true;
                }
             
            }
            return false;
        }
        public  List<Product> Search(string name)
        {
           List<Product> FillterList = new List<Product>();
            foreach (var item in PurchasedProducts)
            {
                if (item.Name.Contains(name))
                {
                    FillterList.Add(item);
                }
            }
            return FillterList;

        }

        public override void Form(Person obj)
        {
            if (obj is Customer customer)
            {
                UserMenu user = new UserMenu (customer);
                try
                {
                    user.ShowDialog();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                
            }
        }

     
    }
}
