using Login.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DL
{
    class PersonDL
    {

        public static List<Person> PersonList = new List<Person>();
        public static bool AddinList(Person obj)
        {
            foreach (var item in PersonList)
            {
                if (obj.Name == item.Name)
                {
                    return false;
                }
            }
            PersonList.Add(obj);
            return true;


        }
    

        public static void StoreCredentialsinFile()
        {
            string path = "Credentials.txt";

            StreamWriter obj = new StreamWriter(path);
            char ch = (char)223;

            try
            {
                foreach (var user in PersonList)
                {
                    obj.WriteLine(user.Name + ch + user.Password + ch + user.Role);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured while storing data :" + ex.Message);

            }
            finally
            {
                obj.Close();
            }


        }
        public static void LoadUsers()
        {
            char ch = (char)223;
            string path = "Credentials.txt";
            string Line;
            StreamReader obj = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((Line = obj.ReadLine()) != null)
                {
                    string[] array = Line.Split(ch);
                    if (array.Length >= 2)
                    {
                        string Name = array[0];
                        string Password = (array[1]);
                        string Role = (array[2]);
                        if (Role == "Admin"||Role=="Owner")
                        {
                            Admin admin = new Admin(Name, Password, Role);
                            PersonList.Add(admin);
                        }
                        else
                        {
                            Customer customer = new Customer(Name, Password, Role);
                            PersonList.Add(customer);

                        }

                    }

                }
            }
            obj.Close();
        }
        public static bool UserExist(string Name)
        {

            foreach (var item in PersonList)
            {
                if (Name == item.Name)
                {
                    return false;
                }
            }
            return true;

        }
        public static Person ReturnRole(string name, string Password)
        {
            foreach (var item in PersonList)
            {
                if (name == item.Name && Password == item.Password)
                {
                    return item;
                }
            }
            return null;
        }
        public static bool RemoveProduct(Person obj)
        {
            foreach (var item in PersonList)
            {
                if (obj.Name == item.Name)
                {
                    PersonList.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public static bool EditUsers(Person obj)
        {
            foreach (var item in PersonList)
            {
                if (obj.Name == item.Name)
                {
                    item.Name = obj.Name;
                    item.Password = obj.Password;
                    item.Role = obj.Role;
                    return true;
                }
            }
            return false;
        }
        public static List<Person> Search(string name)
        {
            List<Person> FillterList = new List<Person>();
            foreach (var item in PersonList)
            {
                if (item.Name.Contains(name) && item.Role!="Owner")
                {
                    FillterList.Add(item);

                }
            }
            return FillterList;

        }

    }
}

