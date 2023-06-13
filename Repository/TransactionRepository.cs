using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace KpopZtation.Repository
{
    public class TransactionRepository
    {
        public static KpopDatabaseEntities db = Connect.getInstance();

        public static String InsertTransactionHeader(TransactionHeader th)
        {
            db.TransactionHeaders.Add(th);
            db.SaveChanges();

            return null;
        }

        public static String InsertTransactionDetail(TransactionDetail td)
        {
            db.TransactionDetails.Add(td);
            db.SaveChanges();

            return null;
        }

        public static int GetThIdByCustomerId(int id)
        {
            return (from data in db.TransactionHeaders where id == data.CustomerID orderby data.TransactionID descending select data.TransactionID).FirstOrDefault();
        }


        public static List<TransactionHeader> GetTransactionHistory(int id)
        {
            return (from thdb in db.TransactionHeaders where id == thdb.CustomerID select thdb).ToList();
        }

        public static TransactionHeader GetThByTrId(int id)
        {
            return (from thdb in db.TransactionHeaders where id == thdb.TransactionID select thdb).FirstOrDefault();
        }

        public static TransactionDetail GetTdByTrId(int id, int AlbumID)
        {
            return (from tddb in db.TransactionDetails where (id == tddb.TransactionID && AlbumID == tddb.AlbumID) select tddb).FirstOrDefault();
        }

        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}