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
        public static List<Cart> GetAllCartItemData(int id)
        {
            return CartRepository.GetAllCartItemData(id);
        }

        public static void RemoveCartItem(int id)
        {
            Cart c = CartRepository.GetCartDataById(id);

            CartRepository.RemoveCartItem(c);
        }

        public static List<int> GetAllCustomerCartAlbumId(int id)
        {
            return CartRepository.GetAllCustomerCartAlbumId(id);
        }
    }
}