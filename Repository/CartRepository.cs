using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CartRepository
    {
        public static KpopDatabaseEntities db = Connect.getInstance();
        public static String InsertCart(Cart c)
        {
            db.Carts.Add(c);
            Save();

            return null;
        }
        public static List<Cart> GetAllCartItemData(int id)
        {
            return (from cartdb in db.Carts where id == cartdb.CustomerID select cartdb).ToList();
        }

        public static bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                PrintError(ex);
                return false;
            }
        }

        public static void PrintError(System.Data.Entity.Validation.DbEntityValidationException ex)
        {
            foreach(var entityValidationErrors in ex.EntityValidationErrors)
            {
                foreach(var validationError in entityValidationErrors.ValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " error: " + validationError.ErrorMessage);
                }
            }
        }
    }
}