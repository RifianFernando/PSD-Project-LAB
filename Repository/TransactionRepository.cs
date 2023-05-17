using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        //public static List<TransactionHeader> GetTransactionHistory()
        //{
        //    return (from th in db.TransactionHeaders
        //            join td in db.TransactionDetails on th.TransactionID equals td.TransactionID
        //            join c in db.Customers on th.CustomerID equals c.CustomerID
        //            join ab in db.Albums on td.AlbumID equals ab.AlbumID
        //            select new 
        //            {
        //                TransactionID = th.TransactionID,
        //                TransactionDate = th.TransactionDate,
        //                CustomerName = c.CustomerName,
        //                AlbumPicture = ab.AlbumImage,
        //                AlbumName = ab.AlbumName,
        //                AlbumQuantity = td.Qty,
        //                AlbumPrice = ab.AlbumPrice,

        //            }).ToList();
        //}
    }
}