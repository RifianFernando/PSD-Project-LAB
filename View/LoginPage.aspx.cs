using System;

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
            
            WarningLoginEmail.Text = 
        }
    }
}