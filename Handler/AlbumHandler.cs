using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class AlbumHandler
    {

        public static void InsertAlbum(int ArtID, String Name, String Image, int Price, int Stock, String Desc)
        {
            Album album = AlbumFactory.CreateAlbum(ArtID, Name, Image, Price, Stock, Desc);

            AlbumRepository.InsertAlbum(album);

            return;
        }

        public static void DeleteAlbum(int ID)
        {
            Album ab = AlbumRepository.GetDataById(ID);

            AlbumRepository.DeleteAlbum(ab);

            return;
        }

        public static void UpdateAlbum(int ID, int NewArtID, String NewName, String NewImage, int NewPrice, int NewStock, String NewDesc)
        {
            Album ab = AlbumRepository.GetDataById(ID);

            AlbumRepository.UpdateAlbum(ab, NewArtID, NewName, NewImage, NewPrice, NewStock, NewDesc);

            return;
        }

        public static void AlbumQuantityPurchase(int ID, int Purchase, int NewArtID, String NewName, String NewImage, int NewPrice, String NewDesc)
        {
            Album ab = AlbumRepository.GetDataById(ID);

            int stockLeft = ab.AlbumStock - Purchase;

            AlbumRepository.UpdateAlbum(ab, NewArtID, NewName, NewImage, NewPrice, stockLeft, NewDesc);

            return;
        }
        public static List<Album> GetAllArtistAlbumData(int ID)
        {
            return AlbumRepository.GetAllArtistAlbumData(ID);
        }
        public static Album GetDataById(int ID)
        {
            return AlbumRepository.GetDataById(ID);
        }
    }
}