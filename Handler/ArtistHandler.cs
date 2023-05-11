using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class ArtistHandler
    {

        public static void InsertArtist(String Name, String Image)
        {
            Artist artist = ArtistFactory.CreateArtist(Name, Image);

            ArtistRepository.InsertArtist(artist);

            return;
        }

    }
}