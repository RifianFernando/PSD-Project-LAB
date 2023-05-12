using KpopZtation.Handler;
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
            //else if (!ArtistHandler.FindUniqueArtist(Name))
            //{
            //    return "Artist name already exist";
            //}
            return "";
        }
        public static String ValidateArtistImage(String ArtistImage,int ImageSize)
        { 

            if (ArtistImage.Equals(""))
            {
                return "Image must be chosen!";
            }else if(ImageSize > 2097152)
            {
                return "max file size is 2 mb!";
            }
            return "";
        }
    }
}