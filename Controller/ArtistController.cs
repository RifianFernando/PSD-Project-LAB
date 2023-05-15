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

        public static String ValidateUpdateName(String NewName, String Name)
        {
            if (NewName.Equals(""))
            {
                return "Artist Name must not be empty";
            }
            else if (NewName.Equals(Name))
            {
                return "";
            }
            else if (!ArtistHandler.FindUniqueArtist(NewName))
            {
                return "Artist name already exist";
            }
            return "";
        }

        public static String ValidateUpdateImage(String ArtistImage, int ImageSize)
        {
            if (ArtistImage.Equals(""))
            {
                return "No New Image Uploaded";
            }
            else if (ImageSize > 2097152)
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

        public static String UpdateArtist(int ID, String NewName, String Name, String NewImage, String Image, int ImageSize)
        {
            String name = ValidateUpdateName(NewName, Name);
            String image = ValidateUpdateImage(NewImage, ImageSize);

            bool noNewImage = name.Equals("") && image.Equals("No New Image Uploaded");

            bool validateAll = name.Equals("") && image.Equals("");

            if(noNewImage == true)
            {
                ArtistHandler.UpdateArtist(ID, NewName, Image);

                return "Update saved!";
            }
            else if (validateAll == true)
            {
                ArtistHandler.UpdateArtist(ID, NewName, NewImage);

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