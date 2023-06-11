using KpopZtation.DataSet;
using KpopZtation.Model;
using KpopZtation.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateTransactionHeader(DateTime Date, int CstID)
        {
            TransactionHeader th = new TransactionHeader();

            th.TransactionDate = Date;
            th.CustomerID = CstID;

            return th;
        }

        public static TransactionDetail CreateTransactionDetail(int TransID, int AbmID, int Qty)
        {
            TransactionDetail td = new TransactionDetail();

            td.TransactionID = TransID;
            td.AlbumID = AbmID;
            td.Qty = Qty;

            return td;
        }

        public static TransactionReport CreateTransactionReport()
        {
            TransactionReport Report = new TransactionReport();

            return Report;
        }

        public static TransactionReportData CreateReportData()
        {
            TransactionReportData Data = new TransactionReportData();

            return Data;
        }
    }
}