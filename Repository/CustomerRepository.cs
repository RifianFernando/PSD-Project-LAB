using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepository
    {
        public static KpopDatabaseEntities db = Connect.getInstance();

        public static String InsertCustomer(String Name, String Email, String Gender, String Address, String Password)
        {
            Customer C = CustomerFactory.createCustomer(Name,Email,Password,Gender,Address,"Customer");
            db.Customers.Add(C);
            db.SaveChanges();
            return null;
        }
        public static bool FindUniqueEmail(String Email)
        {
            Customer EmailData = (from EmailDatas in db.Customers where Email.Equals(EmailDatas.CustomerEmail) select EmailDatas).FirstOrDefault();
            if (EmailData == null)
            {
                return false;
            }
            return true;
        }
        public static bool FindLoginEmail(String Email)
        {
            String LoginEmail = (from Emails in db.Customers where Email.Equals(Emails.CustomerEmail) select Emails.CustomerEmail).FirstOrDefault();
            if(LoginEmail == null)
            {
                return false;
            }
            else if (LoginEmail.Equals(Email))
            {
                return true;
            }
            return false;
        }
        public static bool FindLoginPassword(String Email, String Password)
        {
            String LoginPassword = (from Passwords in db.Customers where Email.Equals(Passwords.CustomerEmail) select Passwords.CustomerPassword).FirstOrDefault();
            if (LoginPassword == null)
            {
                return false;
            }
            else if (LoginPassword.Equals(Password))
            {
                return true;
            }
            return false;
        }
    }
}