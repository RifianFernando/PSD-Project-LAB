using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int CustomerID, int AlbumID, int Quantity)
        {
            Cart c = new Cart();

            c.CustomerID = CustomerID;
            c.AlbumID = AlbumID;
            c.Qty = Quantity;

            return c;
        }
    }
}