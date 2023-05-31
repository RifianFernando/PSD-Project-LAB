using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> GetTransactionHistory(int ID)
        {
            return TransactionRepository.GetTransactionHistory(ID);
        }

        public static void CheckOutCartItem(int id)
        {
            Cart c = CartRepository.GetCartDataById(id);

            DateTime today = DateTime.Today.Date;

            TransactionHeader th = TransactionFactory.CreateTransactionHeader(today, c.CustomerID);
            TransactionRepository.InsertTransactionHeader(th);

            int TransactionID = TransactionRepository.GetThIdByCustomerId(c.CustomerID);

            TransactionDetail td = TransactionFactory.CreateTransactionDetail(TransactionID, c.AlbumID, c.Qty);
            TransactionRepository.InsertTransactionDetail(td);

            CartRepository.RemoveCartItem(c);
        }
    }
}