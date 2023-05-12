using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CustomerController
    {

        public static String ValidateRegisterName(String RegName)
        {
            if (RegName.Equals(""))
            {
                return "Name must be filled!";
            }
            else if (RegName.Length < 5 || RegName.Length > 50)
            {
                return "Name must be between 5 to 50 characters!";
            }
            return "";
        }
        public static String ValidateRegisterEmail(String RegEmail)
        {
            if (RegEmail.Equals(""))
            {
                return "Email must be filled!";
            }
            else if (CustomerHandler.FindUniqueEmail(RegEmail) == true)
            {
                return "Email has been registered!";
            }
            return "";
        }
        public static String ValidateRegisterGenderSelect(int RegGender)
        {
            if (RegGender == -1)
            {
                return "Gender must be Selected";
            }
            return "";
        }
        public static String InsertGenderValue(int RegGender)
        {
            if (RegGender == 1)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }
        public static String ValidateRegisterAddress(String RegAddress)
        {
            if (RegAddress.Equals(""))
            {
                return "Address must be filled!";
            }
            else if (!RegAddress.EndsWith("Street"))
            {
                return "The address must ends with street";
            }
            return "";
        }
        public static String ValidateRegisterPassword(String RegPassword)
        {
            if (RegPassword.Equals(""))
            {
                return " Password must be filled!";
            }
            else if (!RegPassword.Any(char.IsLetter) || !RegPassword.Any(char.IsDigit))
            {
                return "Password must be alphanumeric";
            }
            return "";
        }

        public static String AddCustomer(String Name, String Email, int Gender, String Address, String Password)
        {
            String name = ValidateRegisterName(Name);
            String email = ValidateRegisterEmail(Email);
            String gender = ValidateRegisterGenderSelect(Gender);
            String address = ValidateRegisterAddress(Address);
            String password = ValidateRegisterPassword(Password);

            bool validate = name.Equals("") && email.Equals("") && gender.Equals("") && address.Equals("") && password.Equals("");

            if (validate == true)
            {
                String genderValue = InsertGenderValue(Gender);

                CustomerHandler.InsertCustomer(Name, Email, genderValue, Address, Password);

                return "Register Success!";
            }
            else
            {
                return "Register Failed!";
            }
        }

        public static String ValidateEmailLogin(String Email)
        {
            if (Email.Equals(""))
            {
                return "Email must not be empty";
            }
            else if (!CustomerHandler.FindLoginEmail(Email))
            {
                return "Email does not exist";
            }
            return "";
        }
        public static String ValidatePasswordLogin(String Email, String Password)
        {
            if (Password.Equals(""))
            {
                return "Password must not be empty";
            }
            else if (!CustomerHandler.FindLoginPassword(Email, Password))
            {
                return "Password does not match";
            }
            return "";
        }

        public static String ValidateUpdateEmail(String UpdtEmail, String OldEmail)
        {
            if (UpdtEmail.Equals(""))
            {
                return "Email must be filled!";
            }
            else if (UpdtEmail.Equals(OldEmail))
            {
                return ("");
            }
            else if (CustomerHandler.FindUniqueEmail(UpdtEmail) == true)
            {
                return "Email has been registered!";
            }

            return "";
        }

        public static String UpdateCustomerProfile(int ID, String Name, String Email, String OldEmail, int Gender, String Address, String Password)
        {
            String name = ValidateRegisterName(Name);
            String email = ValidateUpdateEmail(Email, OldEmail);
            String gender = ValidateRegisterGenderSelect(Gender);
            String address = ValidateRegisterAddress(Address);
            String password = ValidateRegisterPassword(Password);

            bool validate = name.Equals("") && email.Equals("") && gender.Equals("") && address.Equals("") && password.Equals("");

            if (validate == true)
            {
                String genderValue = InsertGenderValue(Gender);

                CustomerHandler.UpdateProfile(ID, Name, Email, genderValue, Address, Password);

                return "Profile has been saved!";
            }
            else
            {
                return "Update failed!";
            }
        }

        public static Customer GetDataById(int ID)
        {
            return CustomerHandler.GetDataById(ID);
        }

        public static int GetIdByEmail(String Email)
        {
            return CustomerHandler.GetIdByEmail(Email);
        }
    }
}