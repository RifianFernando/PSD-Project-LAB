using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class ArtistFactory
    {

        public static Artist CreateArtist(String Name, String Image)
        {
            Artist a = new Artist();

            a.ArtistName = Name;
            a.ArtistImage = Image;

            return a;
        }

    }
}