using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using KpopZtation.Middleware;

namespace KpopZtation.View
{
    public partial class InsertArtistPage : System.Web.UI.Page
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
        protected void InsertArtistButton_Click(object sender, EventArgs e)
        {
            String ArtistName = InsertArtistName.Text;
            String ArtistImage = InsertArtistImage.FileName;
            int ImageSize = InsertArtistImage.PostedFile.ContentLength;

            WarningArtistName.Text = ArtistController.ValidateArtistName(ArtistName);
            WarningArtistImage.Text = ArtistController.ValidateArtistImage(ArtistImage,ImageSize);

            SuccessLabel.Text = ArtistController.InsertArtist(ArtistName, ArtistImage, ImageSize);
           
            if(SuccessLabel.Text.Equals("Successfully insert new Artist"))
            {
                String FolderDirectory = Server.MapPath("~/Storage/Public/Images/Artists/");
                String ImageFolder = Server.MapPath("~/Storage/Public/Images/Artists/" + ArtistImage);

                if (!Directory.Exists(FolderDirectory))
                {
                    Directory.CreateDirectory(FolderDirectory);
                }

                InsertArtistImage.SaveAs(ImageFolder);
            }
        }
    }
}