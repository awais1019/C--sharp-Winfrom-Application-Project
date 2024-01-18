using Login.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DL
{
    public class CustomerProductsDL
    {
        public static void Store(Customer obj)
        {

            DateTime datetime = DateTime.Now;
            string path = "History.txt";
            char ch = (char)223;
            StreamWriter writer = new StreamWriter(path, true);
       
            foreach (var product in obj.PurchasedProducts)
            {
                writer.Write(obj.Name + ch + obj.Password + ch + obj.Role + ch);
                writer.WriteLine(product.Name + ch + product.Price + ch + product.Quantity + ch + datetime.ToString());
            }
            writer.Flush();
            writer.Close();
        }
    }

}


