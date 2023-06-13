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
                return "maaf website belum bisa insert lagi kalo mau update lagi dalam tahap pengembangan";
            }
        }

        public static List<Cart> GetAllCartItemData(int id)
        {
            return CartHandler.GetAllCartItemData(id);
        }

        public static void RemoveCartItem(int AlbumID, int CustomerID)
        {
            CartHandler.RemoveCartItem(AlbumID, CustomerID);
            //AlbumHandler.UpdateStockAlbum(AlbumID);
        }

        public static List<int> GetAllCustomerCartAlbumId(int id)
        {
            return CartHandler.GetAllCustomerCartAlbumId(id);
        }
    }
}