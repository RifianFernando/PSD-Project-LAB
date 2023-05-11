using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class ArtistRepository
    {
        public static KpopDatabaseEntities db = Connect.getInstance();

        public static String InsertArtist(Artist artist)
        {
            db.Artists.Add(artist);
            db.SaveChanges();

            return null;
        }

    }
}