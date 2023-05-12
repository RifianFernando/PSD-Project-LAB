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

        public static String InsertCustomer(Customer user)
        {
            db.Customers.Add(user);
            db.SaveChanges();

            return null;
        }

        public static bool FindUniqueEmail(String Email)
        {
            Customer EmailData = (from email in db.Customers where Email.Equals(email.CustomerEmail) select email).FirstOrDefault();

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

        public static Customer GetDataById(int ID)
        {
            return (from data in db.Customers where ID == data.CustomerID select data).FirstOrDefault();
        }

        public static int GetIdByEmail(String Email)
        {
            return (from data in db.Customers where Email.Equals(data.CustomerEmail) select data.CustomerID).FirstOrDefault();
        }

        public static String UpdateProfile(Customer c, String NewName, String NewEmail, String NewGender, String NewAddress, String NewPassword)
        {
            c.CustomerName = NewName;
            c.CustomerEmail = NewEmail;
            c.CustomerGender = NewGender;
            c.CustomerAddress = NewAddress;
            c.CustomerPassword = NewPassword;

            db.SaveChanges();

            return null;
        }
    }
}