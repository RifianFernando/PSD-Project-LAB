using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace KpopZtation.Middleware
{
    public class SessionMiddleware
    {
        public static void isLogin(Page page)
        {
            if (page.Session["User"] == null)
            {
                page.Response.Redirect("LoginPage.aspx");
            }
            return;
        }
    }
}
