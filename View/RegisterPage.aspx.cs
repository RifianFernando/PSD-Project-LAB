using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register_Click(object sender, EventArgs e)
        {
            String RegName = RegisterName.Text;
            String RegEmail = RegisterEmail.Text;
            int RegGender = RegisterGender.SelectedIndex;
            String RegAddress = RegisterAddress.Text;
            String RegPassword = RegisterPassword.Text;

            WarningName.Text = RegisterController.ValidateRegisterName(RegName);
            WarningEmail.Text = RegisterController.ValidateRegisterEmail(RegEmail);
            WarningGender.Text = RegisterController.ValidateRegisterGenderSelect(RegGender);
            WarningAddress.Text = RegisterController.ValidateRegisterAddress(RegAddress);
            WarningPassword.Text = RegisterController.ValidateRegisterPassword(RegPassword);
            String RegGenderString = RegisterController.InsertGenderValue(RegGender);
        }
    }
}