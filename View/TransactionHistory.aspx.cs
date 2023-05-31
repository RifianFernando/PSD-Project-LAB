using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Middleware;
using KpopZtation.Controller;
using KpopZtation.Model;

namespace KpopZtation.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //-------------Authentication----------------//
            SessionMiddleware.isLogin(Page);

            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin)
                {
                    Response.Redirect("HomePage.aspx");
                }
            }

            if (!IsPostBack)
            {
                String Email = Session["User"].ToString();
                int id = CustomerController.GetIdByEmail(Email);

                List<TransactionHeader> transactions = TransactionController.GetTransactionHistoryByID(id);
                TransactionHistoryDataList.DataSource = transactions;
                TransactionHistoryDataList.DataBind();
            }
        }
    }
}