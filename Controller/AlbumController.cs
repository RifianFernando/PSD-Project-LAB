using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class AlbumController
    {
        public static String ValidateAlbumName(String AlbumName)
        {
            if (AlbumName.Equals(""))
            {
                return "Album Name must be filled!";
            }
            else if (AlbumName.Length > 50)
            {
                return "Album Name must be less than 50 characters!";
            }
            return "";
        }
        public static String ValidateAlbumDescription(String AlbumDescription)
        {
            if (AlbumDescription.Equals(""))
            {
                return "Album Description must be filled!";
            }
            else if (AlbumDescription.Length <255)
            {
                return "Album Description must be less than 255 characters!";
            }
            return "";
        }
        public static String ValidateAlbumPrice(String AlbumPriceString)
        {
            int AlbumPrice = Int32.Parse(AlbumPriceString);
            if (AlbumPrice < 100000 || AlbumPrice > 1000000)
            {
                return "Album Price must range betweeen 100000 to 1000000";
            }
            return "";
        }
        
        public static String ValidateAlbumStock(String RegAddress)
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
    }
}