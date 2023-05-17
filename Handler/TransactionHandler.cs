using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TransactionHandler
    {
        public static int InsertTransactionHeader(DateTime TransactionDate, int CustomerID)
        {
            TransactionHeader th = TransactionFactory.CreateTransactionHeader(TransactionDate, CustomerID);

            return th.TransactionID;
        }

        public static void InsertTransactionDetail(int TransactionID, int AlbumID, int Qty)
        {
            TransactionDetail td = TransactionFactory.CreateTransactionDetail(TransactionID, AlbumID, Qty);

            return;
        }

        public static void GetTransactionHistory()
    }
}