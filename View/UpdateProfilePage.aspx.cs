using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Middleware;

namespace KpopZtation.View
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionMiddleware.isLogin(Page);
            String Email = Session["User"].ToString();

            Customer c = CustomerController.GetDataById(CustomerController.GetIdByEmail(Email));

            if (!IsPostBack)
            {
                UpdateName.Text = c.CustomerName;
                UpdateEmail.Text = c.CustomerEmail;
                UpdateGender.Items.FindByText(c.CustomerGender).Selected = true;
                UpdateAddress.Text = c.CustomerAddress;
                UpdatePassword.Text = c.CustomerPassword;
            }
        }

        protected void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            String Name = UpdateName.Text;
            String Email = UpdateEmail.Text;
            int Gender = UpdateGender.SelectedIndex;
            String Address = UpdateAddress.Text;
            String Password = UpdatePassword.Text;

            String UserEmail = Session["User"].ToString();

            WarningName.Text = CustomerController.ValidateRegisterName(Name);
            WarningEmail.Text = CustomerController.ValidateUpdateEmail(Email, UserEmail);
            WarningGender.Text = CustomerController.ValidateRegisterGenderSelect(Gender);
            WarningAddress.Text = CustomerController.ValidateRegisterAddress(Address);
            WarningPassword.Text = CustomerController.ValidateRegisterPassword(Password);

            int ID = CustomerController.GetIdByEmail(UserEmail);

            SuccessLabel.Text = CustomerController.UpdateCustomerProfile(ID, Name, Email, UserEmail, Gender, Address, Password);
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            String Email = Session["User"].ToString();

            int ID = CustomerController.GetIdByEmail(Email);
            CustomerController.DeleteAccount(ID);
        }
    }
}