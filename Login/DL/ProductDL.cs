using Login.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DL
{
    class ProductDL
    {
       public  static List<Product> AllProductsList = new List<Product>();
        public static bool AddProductsInList(Product obj)
        {
            foreach ( var item in AllProductsList)
            {
                if(obj.Name==item.Name)
                {
                    return false;
                }
            }
            AllProductsList.Add(obj);
            return true;
         
        }
        public static bool EditProducts(Product obj)
        {
            foreach (var item in AllProductsList)
            {
                if (obj.Name == item.Name)
                {
                    item.Name = obj.Name;
                    item.Price = obj.Price;
                    item.Quantity = obj.Quantity;
                    return true;
                }
            }
                return false;
        }
        public static bool IncreaseQunatity(string name, int qunatity)
        {
            foreach (var item in AllProductsList)
            {
                if (name == item.Name)
                {
                    item.Quantity += qunatity;
                    return true;
                }
            }
            return true;
        }

        public static bool RemoveProduct(Product obj)
        {
            foreach (var item in AllProductsList)
            {
                if(obj.Name==item.Name)
                {
                    AllProductsList.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public static void StoreIntoFileProducts()
        {
            string path = "Products.txt";
            if (File.Exists(path))
            {
                char ch = (char)223;
                StreamWriter writer = new StreamWriter(path);
                try
                {
                    foreach (var product in AllProductsList)
                    {
                        writer.WriteLine(product.Name + ch + product.Price + ch + product.Quantity);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occured while storing data :" + ex.Message);

                }
                finally
                {
                    writer.Close();
                }
            }
        }
        public static void LoadProducts()
        {
            char ch = (char)223;
            string path = "Products.txt";
            string Line;
            StreamReader obj = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((Line = obj.ReadLine()) != null)
                {
                    string[] array = Line.Split(ch);
                    if (array.Length == 3)
                    {
                        string Name = array[0];
                        float Price = float.Parse(array[1]);
                        int Quantity = int.Parse(array[2]);
                        Product obj1 = new Product(Name, Price, Quantity);
                        AddProductsInList(obj1);
                    }

                }
            }
            obj.Close();
        }
        public static float Check(int quantiy, string name)
        {

            foreach (var item in AllProductsList)
            {
                if (name == item.Name && quantiy <= item.Quantity&&quantiy>0)
                {
     
                    item.Quantity -= quantiy;
                    return item.Price;

                }

            }
            return 0;
        }
        public static List<Product> Search(string name)
        {
            List<Product> FillterList= new List<Product>();
            foreach (var item in AllProductsList)
            {
                if(item.Name.Contains(name))
                {
                    FillterList.Add(item);
                   
                }
            }
            return FillterList;

        }
    }
}
