using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class AlbumFactory
    {

        public static Album CreateAlbum(int ArtID, String Name, String Image, int Price, int Stock, String Desc)
        {
            Album ab = new Album();

            ab.ArtistID = ArtID;
            ab.AlbumName = Name;
            ab.AlbumImage = Image;
            ab.AlbumPrice = Price;
            ab.AlbumStock = Stock;
            ab.AlbumDescription = Desc;

            return ab;
        }

    }
}