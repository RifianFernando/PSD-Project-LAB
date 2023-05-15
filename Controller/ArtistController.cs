using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class ArtistController
    {
        public static String ValidateArtistName(String Name)
        {
            if (Name.Equals(""))
            {
                return "Artist Name must not be empty";
            }
            else if (!ArtistHandler.FindUniqueArtist(Name))
            {
                return "Artist name already exist";
            }
            return "";
        }
        public static String ValidateArtistImage(String ArtistImage,int ImageSize)
        { 

            if (ArtistImage.Equals(""))
            {
                return "Image must be chosen!";
            }else if(ImageSize > 2097152)
            {
                return "File size must be less than 2MB!";
            }
            return "";
        }

        public static String InsertArtist(String Name, String Image, int ImageSize)
        {
            String name = ValidateArtistName(Name);
            String image = ValidateArtistImage(Image, ImageSize);

            bool validate = name.Equals("") && image.Equals("");

            if (validate == true)
            {
                ArtistHandler.InsertArtist(Name, Image);

                return "Successfully insert new Artist";
            }
            else
            {
                return "Insert Failed";
            }
        }

        public static void DeleteArtist(int ID)
        {
            ArtistHandler.DeleteArtist(ID);

            return;
        }

        public static String ValidateUpdateImage(String ArtistImage, int ImageSize)
        {
            if (ImageSize > 2097152)
            {
                return "File size must be less than 2MB!";
            }
            return "";
        }

        public static Artist GetDataById(int ID)
        {
            return ArtistHandler.GetDataById(ID);
        }

        public static int GetIdByName(String Name)
        {
            return ArtistHandler.GetIdByName(Name);
        }

        public static String UpdateArtist(int ID, String Name, String Image, int ImageSize)
        {
            String name = ValidateArtistName(Name);
            String image = ValidateArtistImage(Image, ImageSize);

            bool validate = name.Equals("") && image.Equals("");

            if (validate == true)
            {
                ArtistHandler.UpdateArtist(ID, Name, Image);

                return "Update saved!";
            }

            return "Update failed!";
        }

        public static List<Artist> GetAllArtistData()
        {
            return ArtistHandler.GetAllArtistData();
        }

       
    }
}