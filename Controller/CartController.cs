using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CartController
    {
        public static void InsertCart(int CustomerID, int AlbumID, int Quantity)
        {
            CartHandler.InsertCart(CustomerID, AlbumID, Quantity);
            return;
        }
    }
}