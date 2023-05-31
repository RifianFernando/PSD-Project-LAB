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

        public static String CheckOutCartItem(int id)
        {
            TransactionHandler.CheckOutCartItem(id);

            return null;
        }
    }
}