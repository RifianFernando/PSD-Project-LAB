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
            db.SaveChanges();

            return null;
        }
        public static List<Cart> GetAllArtistData()
        {
            return (from cartdb in db.Carts select cartdb).ToList();
        }
    }
}