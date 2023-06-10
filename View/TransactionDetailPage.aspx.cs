using KpopZtation.Controller;
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
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                int id = int.Parse(Request.QueryString["ID"]);

                TransactionHeader th = TransactionController.GetThByTrId(id);
                TransactionDetail td = TransactionController.GetTdByTrId(id);


                
            }
        }
    }
}