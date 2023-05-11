using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Middleware
{
    public class Middleware
    {
        public static void isLogin()
        {
            if(Session["User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            return;
        }
    }
}