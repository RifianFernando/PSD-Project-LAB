using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CustomerHandler
    {
        public static void InsertCustomer(String name, String email, String gender, String address, String password)
        {
            Customer user = CustomerFactory.CreateCustomer(name, email, password, gender, address, "Customer");

            CustomerRepository.InsertCustomer(user);

            return;
        }

        public static bool FindUniqueEmail(String Email)
        {
            bool email = CustomerRepository.FindUniqueEmail(Email);

            return email;
        }

        public static bool FindLoginEmail(String Email)
        {
            bool email = CustomerRepository.FindLoginEmail(Email);

            return email;
        }

        public static bool FindLoginPassword(String Email, String Password)
        {
            bool password = CustomerRepository.FindLoginPassword(Email, Password);

            return password;
        }

        public static void UpdateProfile(int ID, String Name, String Email, String Gender, String Address, String Password)
        {
            Customer c = CustomerRepository.GetDataById(ID);

            CustomerRepository.UpdateProfile(c, Name, Email, Gender, Address, Password);

            return;
        }

        public static Customer GetDataById(int ID)
        {
            return CustomerRepository.GetDataById(ID);
        }

        public static int GetIdByEmail(String Email)
        {
            return CustomerRepository.GetIdByEmail(Email);
        }
        public static String GetRoleByEmail(String Email)
        {
            return CustomerRepository.GetDataById(CustomerRepository.GetIdByEmail(Email)).CustomerRole.ToString();
        }
    }
}