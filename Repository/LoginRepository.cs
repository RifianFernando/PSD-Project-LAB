using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class LoginRepository
    {
        public static KpopDatabaseEntities db = Connect.getInstance();
        public static bool FindLoginEmail(String Email)
        {
            Customer LoginEmail = (from Emails in db.Customers where Emails.Equals(Emails.CustomerEmail) select Emails).FirstOrDefault();
            if(LoginEmail.ToString() == Email)
            {
                return true;
            }
            return false;
        }
    }
}