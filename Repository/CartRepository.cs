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
        public static List<Cart> GetAllCartItemData(int id)
        {
            return (from cartdb in db.Carts join albumdb in db.Albums on cartdb.AlbumID equals albumdb.AlbumID where id == cartdb.CustomerID select cartdb).ToList();
        }

        public static Cart GetCartDataById(int id)
        {
            return (from cartdb in db.Carts where id == cartdb.AlbumID select cartdb).FirstOrDefault();
        }

        public static Cart GetCartDataBy2ID(int AlbumID, int CustomerID)
        {
            return (from cartdb in db.Carts 
                    where AlbumID == cartdb.AlbumID && CustomerID == cartdb.CustomerID
                    select cartdb).FirstOrDefault();
        }

        public static Cart GetCustomerCartInfoByID(int CustomerID, int AlbumID)
        {
            return (from cartdb in db.Carts
                    where cartdb.CustomerID == CustomerID && cartdb.AlbumID == AlbumID
                    select cartdb).FirstOrDefault();
        }

        public static void RemoveCartItem(Cart c)
        {
            db.Carts.Remove(c);
            db.SaveChanges();
        }

        public static List<int> GetAllCustomerCartAlbumId(int id)
        {
            return (from cartdb in db.Carts where id == cartdb.CustomerID select cartdb.AlbumID).ToList();
        }
    }
}