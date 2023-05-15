using KpopZtation.Controller;
using KpopZtation.Middleware;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
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
            int id = int.Parse(Request.QueryString["ID"]);

            SessionMiddleware.isLogin(Page);
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
            String ArtistName = UpdateArtistName.Text;
            String ArtistImage = UpdateArtistImage.FileName;
            int ImageSize = UpdateArtistImage.PostedFile.ContentLength;

            int id = int.Parse(Request.QueryString["ID"]);

            WarningArtistName.Text = ArtistController.ValidateArtistName(ArtistName);
            WarningArtistImage.Text = ArtistController.ValidateArtistImage(ArtistImage, ImageSize);

            SuccessLabel.Text = ArtistController.UpdateArtist(id, ArtistName, ArtistImage, ImageSize);
        }
    }
}