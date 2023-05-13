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
        private string Cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
            else
            {
                Cookie = "Guest";
            }
        }
    }
}