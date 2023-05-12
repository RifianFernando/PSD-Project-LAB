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

        public static bool ValidateUniqueArtistName(String Name)
        {
            Artist UniqueArtistName = (from data in db.Artists where Name.Equals(data.ArtistName) select data).FirstOrDefault();
            if(UniqueArtistName == null)
            {
                return true;
            }
            return false;
        }
        public static Artist GetDataById(int ID)
        {
            return (from data in db.Artists where ID == data.ArtistID select data).FirstOrDefault();
        }

        public static String DeleteArtist(Artist a)
        {
            db.Artists.Remove(a);
            db.SaveChanges();

            return null;
        }

        public static String UpdateArtist(Artist a, String NewName, String NewImage)
        {
            a.ArtistName = NewName;
            a.ArtistImage = NewImage;
            db.SaveChanges();

            return null;
        }
    }
}