﻿using KpopZtation.Model;
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
    }
}