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


        public static List<TransactionHeader> GetTransactionHistory(int ID)
        {
            
            List<TransactionHeader> transactionHistory = new List<TransactionHeader>();

            /*
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Path\To\Your\Database.mdf;Integrated Security=True";
            string query = @"
                SELECT th.TransactionID, th.TransactionDate, c.CustomerName, ab.AlbumImage, ab.AlbumName, td.Qty, ab.AlbumPrice
                FROM TransactionHeaders th
                JOIN TransactionDetails td ON th.TransactionID = td.TransactionID
                JOIN Customers c ON th.CustomerID = c.CustomerID
                JOIN Albums ab ON td.AlbumID = ab.AlbumID
                WHERE th.CustomerID = " + ID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TransactionHeader transaction = new TransactionHeader
                            {
                                TransactionID = (int)reader["TransactionID"],
                                TransactionDate = (DateTime)reader["TransactionDate"],
                                CustomerName = (string)reader["CustomerName"],
                                AlbumPicture = (string)reader["AlbumImage"],
                                AlbumName = (string)reader["AlbumName"],
                                AlbumQuantity = (int)reader["Qty"],
                                AlbumPrice = (decimal)reader["AlbumPrice"]
                            };

                            transactionHistory.Add(transaction);
                        }
                    }
                }
            }

            */
            return transactionHistory;
        }
    }
}