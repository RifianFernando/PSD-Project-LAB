using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Controller;
using KpopZtation.Middleware;
using System.IO;

namespace KpopZtation.View
{
    public partial class InsertAlbumPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionMiddleware.isLogin(Page);
            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == true)
                {
                    Response.Write("Welcome, Admin!");
                    return;
                }
            }
            Response.Redirect("HomePage.aspx");
        }

        protected void InsertAlbumButton_Click(object sender, EventArgs e)
        {
            String AlbumName = InsertAlbumName.Text;
            String AlbumDesc = InsertAlbumDescription.Text;
            String AlbumPrice = InsertAlbumPrice.Text;
            String AlbumImage = InsertAlbumImage.FileName;
            int ImageSize = InsertAlbumImage.PostedFile.ContentLength;
            String AlbumStock = InsertAlbumStock.Text;

            WarningAlbumName.Text = AlbumController.ValidateAlbumName(AlbumName);
            WarningAlbumDescription.Text = AlbumController.ValidateAlbumDescription(AlbumDesc);
            WarningAlbumPrice.Text = AlbumController.ValidateAlbumPrice(AlbumPrice);
            WarningAlbumImage.Text = AlbumController.ValidateAlbumImage(AlbumImage, ImageSize);
            WarningAlbumStock.Text = AlbumController.ValidateAlbumStock(AlbumStock);

            if (SuccessLabel.Text.Equals("Successfully insert new Artist"))
            {
                String FolderDirectory = Server.MapPath("~/Storage/Public/Images/Albums/");
                String ImageFolder = Server.MapPath("~/Storage/Public/Images/Albums/" + InsertAlbumImage.FileName);

                if (!Directory.Exists(FolderDirectory))
                {
                    Directory.CreateDirectory(FolderDirectory);
                }

                InsertAlbumImage.SaveAs(ImageFolder);
            }

        }
    }
}