using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AlbumRepository
    {

        public static KpopDatabaseEntities db = Connect.getInstance();

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

        public static Album GetDataByArtistId(int ID)
        {
            return (from data in db.Albums where ID == data.ArtistID select data).FirstOrDefault();
        }

        public static String DeleteAlbum(Album ab)
        {
            db.Albums.Remove(ab);
            db.SaveChanges();

            return null;
        }

        public static String UpdateAlbum(Album ab, String NewName, String NewImage, int NewPrice, int NewStock, String NewDesc)
        {
            ab.AlbumName = NewName;
            ab.AlbumImage = NewImage;
            ab.AlbumPrice = NewPrice;
            ab.AlbumStock = NewStock;
            ab.AlbumDescription = NewDesc;

            db.SaveChanges();

            return null;
        }

        public static List<Album> GetAllArtistAlbumData(int ID)
        {
            return (from albumdb in db.Albums where ID == albumdb.ArtistID select albumdb).ToList();
        }
        public static String UpdateAlbum(Album Al, String NewName, String NewImage)
        {
            Al.AlbumName = NewName;
            Al.AlbumImage = NewImage;
            db.SaveChanges();

            return null;
        }

        public static int GetAlbumStockById(int id)
        {
            return (from adb in db.Albums where id == adb.AlbumID select adb.AlbumStock).FirstOrDefault();
        }
    }
}