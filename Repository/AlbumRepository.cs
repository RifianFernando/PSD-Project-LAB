using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AlbumRepository
    {

        public static KpopDatabaseEntities db = new KpopDatabaseEntities();

        public static String InsertAlbum(Album album)
        {
            db.Albums.Add(album);
            db.SaveChanges();

            return null;
        }

        public static Album GetDataById(int ID)
        {
            return (from data in db.Albums where ID == data.AlbumID select data).FirstOrDefault();
        }


    }
}