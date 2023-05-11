using KpopZtation.Repository;
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
            else if (CustomerRepository.FindUniqueEmail(RegEmail) == true)
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

        public static String AddCustomer(String Name, String Email, String Gender, String Address, String Password)
        {
            CustomerRepository.InsertCustomer(Name, Email, Gender, Address, Password);
            return "Register Success!";
        }

        public static String ValidateEmailLogin(String Email)
        {
            if (Email.Equals(""))
            {
                return "Email must not be empty";
            }
            else if (!CustomerRepository.FindLoginEmail(Email))
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
            else if (!CustomerRepository.FindLoginPassword(Email, Password))
            {
                return "Password does not match";
            }
            return "";
        }

    }
}