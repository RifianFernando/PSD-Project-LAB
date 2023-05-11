using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class InsertAlbumPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertAlbumButton_Click(object sender, EventArgs e)
        {
            String AlbumName = InsertAlbumName.Text;
            String AlbumDesc = InsertAlbumDescription.Text;
            String AlbumPrice = InsertAlbumDescription.Text;
            String AlbumStock = InsertAlbumStock.Text;
            String AlbumImage = InsertAlbumImage.Text;

        }
    }
}