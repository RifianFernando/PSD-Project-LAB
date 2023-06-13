using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Handler;

namespace KpopZtation.Controller
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetTransactionHistoryByID(int ID)
        {
            return TransactionHandler.GetTransactionHistory(ID);
        }

        public static String CheckOutCartItem(List<int> cartData, int CustomerID)
        {
            TransactionHandler.CheckOutCartItem(cartData, CustomerID);

            return null;
        }

        public static TransactionHeader GetThByTrId(int id)
        {
            return TransactionHandler.GetThByTrId(id);
        }

        public static TransactionDetail GetTdByTrId(int id, int AlbumID)
        {
            return TransactionHandler.GetTdByTrId(id, AlbumID);
        }

        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return TransactionHandler.GetAllTransactionHeader();
        }
    }
}