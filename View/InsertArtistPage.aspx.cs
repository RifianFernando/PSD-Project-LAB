using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class InsertArtistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                if (InsertArtistImage.HasFile)
                {
                    String ImagePath = Server.MapPath("~/Storage/Public/Images/Artists/" + InsertArtistImage.FileName);
                    InsertArtistImage.SaveAs(ImagePath);
                }
            }
        }
    }
}