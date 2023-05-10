using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class RegisterRepository
    {
        public static KpopDatabaseEntities db = Connect.getInstance();

        public static bool FindUniqueEmail(String Email)
        {
            Customer EmailData = (from EmailDatas in db.Customers where Email.Equals(EmailDatas.CustomerEmail) select EmailDatas).FirstOrDefault();
            if (EmailData == null)
            {
                return false;
            }
            return true;
        }
    }
}