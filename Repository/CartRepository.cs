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
        public static void InsertCart(Cart c)
        {
            db.Carts.Add(c);
            db.SaveChanges();

            return;
        }
        public static List<Cart> GetAllCartData(int id)
        {
            return (from cartdb in db.Carts where id == cartdb.CustomerID select cartdb).ToList();
        }
    }
}