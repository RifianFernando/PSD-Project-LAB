using KpopZtation.Controller;
using KpopZtation.DataSet;
using KpopZtation.Factory;
using KpopZtation.Middleware;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionMiddleware.isLogin(Page);

            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (!isAdmin)
                {
                    Response.Redirect("HomePage.aspx");
                }
            }

            if (!IsPostBack)
            {
                TransactionReport rpt = TransactionFactory.CreateTransactionReport();

                TransactionReportView.ReportSource = rpt;

                TransactionReportData Data = GetData(TransactionController.GetAllTransactionHeader());

                rpt.SetDataSource(Data);
            }
        }

        private TransactionReportData GetData(List<TransactionHeader> transaction)
        {
            TransactionReportData Data = TransactionFactory.CreateReportData();

            var Table_Header = Data.TransactionHeader;
            var Table_Detail = Data.TransactionDetail;

            foreach (TransactionHeader th in transaction)
            {
                var Header_Row = Table_Header.NewRow();
                Header_Row["TransactionID"] = th.TransactionID;
                Header_Row["CustomerID"] = th.CustomerID;
                Header_Row["TransactionDate"] = th.TransactionDate;

                int GrandTotalValue = 0;

                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    GrandTotalValue += td.Qty * td.Album.AlbumPrice;
                }

                Header_Row["GrandTotalValue"] = GrandTotalValue;

                Table_Header.Rows.Add(Header_Row);

                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    var Detail_Row = Table_Detail.NewRow();
                    Detail_Row["TransactionID"] = td.TransactionID;
                    Detail_Row["AlbumName"] = td.Album.AlbumName;
                    Detail_Row["Quantity"] = td.Qty;
                    Detail_Row["AlbumPrice"] = td.Album.AlbumPrice;
                    Detail_Row["SubTotalValue"] = td.Qty * td.Album.AlbumPrice;

                    Table_Detail.Rows.Add(Detail_Row);
                }
            }

            return Data;
        }
    }
}