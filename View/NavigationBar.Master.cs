using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Controller;

namespace KpopZtation.View
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected String Page_Load(object sender, EventArgs e)
        {
            String Cookie;
            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == true)
                {
                    Cookie = "Admin";
                }
                else
                {
                    Cookie = "Customer";
                }
                return Cookie;
            }
            Cookie = "Guest";

            return Cookie;
        }
    }
}