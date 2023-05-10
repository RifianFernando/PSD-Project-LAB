using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class LoginController
    {
       public static String ValidateEmailLogin(String Email)
        {
            if (Email.Equals(""))
            {
                return "Email must not be empty";
            }else if (!CustomerRepository.FindLoginEmail(Email) )
            {
                return "Email does not exist";
            }
            return "";
        }
        public static String ValidatePasswordLogin(String Email,String Password)
        {
            if (Password.Equals(""))
            {
                return "Password must not be empty";
            }
            else if (!CustomerRepository.FindLoginPassword(Email,Password))
            {
                return "Password does not match";
            }
            return "";
        }
    }

}