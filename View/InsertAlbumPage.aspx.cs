using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Controller;
using KpopZtation.Middleware;

namespace KpopZtation.View
{
    public partial class InsertAlbumPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionMiddleware.isLogin(Page);
        }

        protected void InsertAlbumButton_Click(object sender, EventArgs e)
        {
            String AlbumName = InsertAlbumName.Text;
            String AlbumDesc = InsertAlbumDescription.Text;
            String AlbumPrice = InsertAlbumPrice.Text;
            String AlbumImage = FileUpload.FileName;
            String AlbumStock = InsertAlbumStock.Text;

            WarningAlbumName.Text = AlbumController.ValidateAlbumName(AlbumName);
            WarningAlbumDescription.Text = AlbumController.ValidateAlbumDescription(AlbumDesc);
            WarningAlbumPrice.Text = AlbumController.ValidateAlbumPrice(AlbumPrice);
            WarningAlbumImage.Text = AlbumController.ValidateAlbumImage(AlbumImage);
            WarningAlbumStock.Text = AlbumController.ValidateAlbumStock(AlbumStock);


        }
    }
}