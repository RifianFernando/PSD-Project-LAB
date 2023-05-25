using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            String Email = LoginEmail.Text;
            String Password = LoginPassword.Text;

            WarningLoginEmail.Text = CustomerController.ValidateEmailLogin(Email);
            WarningLoginPassword.Text = CustomerController.ValidatePasswordLogin(Email, Password);

            bool isValid = WarningLoginEmail.Text.Equals("") && WarningLoginPassword.Text.Equals("");

            if (isValid)
            {
                Session["User"] = Email;
                HttpCookie userCookie = new HttpCookie("userCookie");
                userCookie.Value = Email.ToString();
                userCookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(userCookie);

                Response.Redirect("HomePage.aspx");
            }
        }
    }
}