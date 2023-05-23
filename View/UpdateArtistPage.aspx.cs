using KpopZtation.Controller;
using KpopZtation.Middleware;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateArtistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionMiddleware.isLogin(Page);
            string test = Request.QueryString["ID"];
            if (String.IsNullOrEmpty(test))
            {
                Response.Redirect("HomePage.aspx");
            }

            int id = int.Parse(Request.QueryString["ID"]);


            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == true)
                {
                    Response.Write("Welcome, Admin!");

                    Artist a = ArtistController.GetDataById(id);

                    if (!IsPostBack)
                    {
                        UpdateArtistName.Text = a.ArtistName;
                        ArtistImage.ImageUrl = "https://localhost:44302/Storage/Public/Images/Artists/" + a.ArtistImage;
                    }

                    return;
                }
            }
            Response.Redirect("HomePage.aspx");
        }

        protected void UpdateArtistButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);

            Artist a = ArtistController.GetDataById(id);

            String ArtistName = a.ArtistName;
            String ArtistImage = a.ArtistImage;

            String NewArtistName = UpdateArtistName.Text;
            String NewArtistImage = UpdateArtistImage.FileName;
            int ImageSize = UpdateArtistImage.PostedFile.ContentLength;

            WarningArtistName.Text = ArtistController.ValidateUpdateName(NewArtistName, ArtistName);

            SuccessLabel.Text = ArtistController.UpdateArtist(id, NewArtistName, ArtistName, NewArtistImage, ArtistImage, ImageSize);

            if (SuccessLabel.Text.Equals("Update saved!"))
            {
                if (UpdateArtistImage.HasFile)
                {
                    String FolderDirectory = Server.MapPath("~/Storage/Public/Images/Artists/");
                    String ImageFolder = Server.MapPath("~/Storage/Public/Images/Artists/" + NewArtistImage);

                    if (!Directory.Exists(FolderDirectory))
                    {
                        Directory.CreateDirectory(FolderDirectory);
                    }

                    UpdateArtistImage.SaveAs(ImageFolder);

                    Response.Redirect("HomePage.aspx");
                }
            }
        }
    }
}