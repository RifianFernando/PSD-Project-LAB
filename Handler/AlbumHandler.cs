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


    }
}