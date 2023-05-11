using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class AlbumHandler
    {
        public static void insertCustomer(String name, String email, String gender, String address, String password)
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
    }
}