using KpopZtation.Handler;
using KpopZtation.Model;
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
            else if (AlbumDescription.Length > 255)
            {
                return "Album Description must be less than 255 characters!";
            }

            return "";
        }
        public static String ValidateAlbumPrice(String AlbumPriceString)
        {
            if (AlbumPriceString.Equals(""))
            {
                return "Album Price must not be empty";
            }

            int AlbumPrice = int.Parse(AlbumPriceString);

            if (AlbumPrice < 100000 || AlbumPrice > 1000000)
            {
                return "Album Price must range betweeen 100000 to 1000000";
            }

            return "";
        }
        
        public static String ValidateAlbumStock(String AlbumStockString)
        {
            if (AlbumStockString == null)
            {
                return "Address must be filled!";
            }

            int AlbumStock = int.Parse(AlbumStockString);

            if (AlbumStock == 0)
            {
                return "Stock must be more than 0";
            }

            return "";
        }
        public static String ValidateAlbumImage(String AlbumImage, int ImageSize)
        {
            if (AlbumImage.Equals(""))
            {
                return "Album Image must be filled!";
            }
            else if (ImageSize > 2097152)
            {
                return "File size must be less than 2MB!";
            }

            return "";
        }

        public static String AddAlbum(int ArtID, String AlbumName, String AlbumDesc, String AlbumPrice, String AlbumStock, String AlbumImage, int ImageSize)
        {
            String name = ValidateAlbumName(AlbumName);
            String desc = ValidateAlbumDescription(AlbumDesc);
            String price = ValidateAlbumPrice(AlbumPrice);
            String stock = ValidateAlbumStock(AlbumStock);
            String image = ValidateAlbumImage(AlbumImage, ImageSize);

            bool validate = name.Equals("") && desc.Equals("") && price.Equals("") && stock.Equals("") && image.Equals("");

            if(validate == true)
            {
                int PriceInt = int.Parse(AlbumPrice);
                int StockInt = int.Parse(AlbumStock);

                AlbumHandler.InsertAlbum(ArtID, AlbumName, AlbumImage, PriceInt, StockInt, AlbumDesc);

                return "Album Added Successfully!";
            }
            else
            {
                return "Failed to add album!";
            }
        }
        public static List<Album> GetAllArtistAlbumData(int ID)
        {
            return AlbumHandler.GetAllArtistAlbumData(ID);
        }

        public static String DeleteAlbum(int ID)
        {
            AlbumHandler.DeleteAlbum(ID);

            return null;
        }

        public static Album GetDataById(int ID)
        {
            return AlbumHandler.GetDataById(ID);
        }
        public static Album GetDataByArtistId(int ID)
        {
            return AlbumHandler.GetDataByArtistId(ID);
        }

        public static String ValidateUpdateImage(String AlbumImage, int ImageSize)
        {
            if (AlbumImage.Equals(""))
            {
                return "No New Album Image Uploaded";
            }
            else if (ImageSize > 2097152)
            {
                return "File size must be less than 2MB!";
            }

            return "";
        }

        public static String UpdateAlbum (int ID, String Name, String NewImage, String Image, int ImageSize, String AlbumPrice, String AlbumStock, String AlbumDesc)
        {
            String name = ValidateAlbumName(Name);
            String image = ValidateUpdateImage(NewImage, ImageSize);
            String price = ValidateAlbumPrice(AlbumPrice);
            String stock = ValidateAlbumStock(AlbumStock);
            String desc = ValidateAlbumDescription(AlbumDesc);

            bool noNewImage = name.Equals("") && image.Equals("No New Image Uploaded") && desc.Equals("") && price.Equals("") && stock.Equals("");

            bool validateAll = name.Equals("") && image.Equals("") && desc.Equals("") && price.Equals("") && stock.Equals("");

            int PriceInt = int.Parse(AlbumPrice);
            int StockInt = int.Parse(AlbumStock);

            if (noNewImage == true)
            {
                AlbumHandler.UpdateAlbum(ID, Name, Image, PriceInt, StockInt, AlbumDesc);

                return "Update saved!";
            }
            else if (validateAll == true)
            {
                AlbumHandler.UpdateAlbum(ID, Name, NewImage, PriceInt, StockInt, AlbumDesc);

                return "Update saved!";
            }

            return "Update failed!";
        }
    }
}