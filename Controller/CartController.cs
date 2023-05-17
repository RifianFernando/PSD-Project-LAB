using KpopZtation.Handler;
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
            if (!QtyString.All(char.IsDigit) )
            {
                return false;
            }
            return true;
        }
        public static void InsertCart(int CustomerID, int AlbumID, int Quantity)
        {
            CartHandler.InsertCart(CustomerID, AlbumID, Quantity);
            return;
        }

    }
}