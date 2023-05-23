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
            CartHandler.InsertCart(CustomerID, AlbumID, Quantity);
            return;
        }
<<<<<<< HEAD

        public static List<Cart> GetAllCartData(int id)
        {
            return CartHandler.GetAllCartData(id);
        }

=======
>>>>>>> ea0d03a7305b988ce811aa449433b2b938eb2493
    }
}