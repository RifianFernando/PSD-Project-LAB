using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CartController
    {
        public static bool ValidateQty(String QtyString)
        {
            if (QtyString.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
        public static String InsertCart(int CustomerID, int AlbumID, int Quantity)
        {
            int AlbumStock = AlbumHandler.GetAlbumStockById(AlbumID);

            if(Quantity > AlbumStock)
            {
                return "Sorry the album stock is only " + AlbumStock.ToString() + " left";
            }
            else
            {
                CartHandler.InsertCart(CustomerID, AlbumID, Quantity);
                return "Album has been added to cart";
            }
        }

        public static List<Cart> GetAllCartItemData(int id)
        {
            return CartHandler.GetAllCartItemData(id);
        }

        public static void RemoveCartItem(int id)
        {
            CartHandler.RemoveCartItem(id);
        }

        public static List<int> GetAllCustomerCartAlbumId(int id)
        {
            return CartHandler.GetAllCustomerCartAlbumId(id);
        }
    }
}