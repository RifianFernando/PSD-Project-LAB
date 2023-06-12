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
        public static void InsertCart(int CustomerID, int AlbumID, int Quantity)
        {
            var checkData = CartHandler.GetCustomerCartInfoByID(CustomerID, AlbumID);
            if (checkData == null)
            {
                CartHandler.InsertCart(CustomerID, AlbumID, Quantity);
                AlbumHandler.UpdateStockAlbum(AlbumID, Quantity);
                return;
            }
            else
            {
                //This Will be update the Cart Controller of user
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