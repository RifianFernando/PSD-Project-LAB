using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CartHandler
    {
        public static void InsertCart(int CustomerID, int AlbumID, int Quantity)
        {
            Cart cart = CartFactory.CreateCart(CustomerID, AlbumID, Quantity);

            CartRepository.InsertCart(cart);

            return;
        }
        
        public static void UpdateCartUser(int CustomerID, int AlbumID, int Quantity)
        {
            Cart cart = CartRepository.GetCartDataBy2ID(AlbumID, CustomerID);

            CartRepository.UpdateCartRepository(cart, Quantity);

            return;
        }

        public static List<Cart> GetAllCartItemData(int id)
        {
            return CartRepository.GetAllCartItemData(id);
        }
        public static Cart GetCustomerCartInfoByID(int CustomerID, int AlbumID)
        {
            var data = CartRepository.GetCustomerCartInfoByID(CustomerID, AlbumID);

            return data;
        }

        public static int RemoveCartItem(int AlbumID, int CustomerID)
        {
            Cart c = CartRepository.GetCartDataBy2ID(AlbumID, CustomerID);

            CartRepository.RemoveCartItem(c);

            return c.Qty;
        }

        public static List<int> GetAllCustomerCartAlbumId(int id)
        {
            return CartRepository.GetAllCustomerCartAlbumId(id);
        }
    }
}