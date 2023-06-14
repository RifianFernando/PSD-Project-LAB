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

            var checkData = CartHandler.GetCustomerCartInfoByID(CustomerID, AlbumID);
            if (checkData == null)
            {
                CartHandler.InsertCart(CustomerID, AlbumID, Quantity);
                AlbumHandler.UpdateStockAlbum(AlbumID, Quantity);
                return "Album has been added to cart";
            }
            else
            {
                //This Will be update the Cart Controller of user
                CartHandler.UpdateCartUser(CustomerID, AlbumID, Quantity);
                AlbumHandler.UpdateStockAlbum(AlbumID, Quantity);
                return "Album has been added to cart";
            }
        }

        public static List<Cart> GetAllCartItemData(int id)
        {
            return CartHandler.GetAllCartItemData(id);
        }

        public static void RemoveCartItem(int AlbumID, int CustomerID)
        {
            int Quantity = CartHandler.RemoveCartItem(AlbumID, CustomerID);
            Quantity = -Quantity;
            AlbumHandler.UpdateStockAlbum(AlbumID, Quantity);
        }

        public static List<int> GetAllCustomerCartAlbumId(int id)
        {
            return CartHandler.GetAllCustomerCartAlbumId(id);
        }
    }
}