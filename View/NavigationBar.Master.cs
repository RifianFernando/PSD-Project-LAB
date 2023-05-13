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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == true)
                {
                    ViewState["Cookie"] = "Admin";
                }
                else
                {
                    ViewState["Cookie"] = "Customer";
                }
            }
            else
            {
                ViewState["Cookie"] = "Guest";
            }
        }

        protected void Logout(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("HomePage.aspx");
        }

        protected void Login(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void Register(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}