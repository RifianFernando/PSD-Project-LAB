using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class AlbumController
    {
        public static String ValidateAlbumName(String RegName)
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
        public static String ValidateAlbumDescription(String RegEmail)
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
        
        public static String ValidateAlbumPrice(String RegAddress)
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
        public static String ValidateAlbumStock(String RegPassword)
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
        public static String ValidateAlbumImage(String RegPassword)
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

        public static String AddAllbum(String Name, String Email, String Gender, String Address, String Password)
        {
            CustomerRepository.InsertCustomer(Name, Email, Gender, Address, Password);
            return "Register Success!";
        }
    }
}