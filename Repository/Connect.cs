using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Model;

namespace KpopZtation.Repository
{
    public class Connect
    {
        public static KpopDatabaseEntities db = null;

        public static KpopDatabaseEntities getInstance()
        {
            if(db == null)
            {
                db = new KpopDatabaseEntities();
            }

            return db;
        }
    }
}