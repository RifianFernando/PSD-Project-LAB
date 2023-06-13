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

        public static void CheckOutCartItem(List<int> cartData, int CustomerID)
        {
            DateTime today = DateTime.Today.Date;

            TransactionHeader th = TransactionFactory.CreateTransactionHeader(today, CustomerID);
            TransactionRepository.InsertTransactionHeader(th);

            int TransactionID = TransactionRepository.GetThIdByCustomerId(CustomerID);

            foreach (int i in cartData)
            {
                Cart c = CartRepository.GetCartDataById(i);

                TransactionDetail td = TransactionFactory.CreateTransactionDetail(TransactionID, c.AlbumID, c.Qty);
                TransactionRepository.InsertTransactionDetail(td);

                CartRepository.RemoveCartItem(c);
            }
        }

        public static TransactionHeader GetThByTrId(int id)
        {
            return TransactionRepository.GetThByTrId(id);
        }

        public static TransactionDetail GetTdByTrId(int id, int AlbumID)
        {
            return TransactionRepository.GetTdByTrId(id, AlbumID);
        }

        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return TransactionRepository.GetAllTransactionHeader();
        }
    }
}