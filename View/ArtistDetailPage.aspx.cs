using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class ArtistDetailPage : System.Web.UI.Page
    {
        public List<Album> albums = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {


            Artist a = ArtistController.GetDataById();

            if (!IsPostBack)
            {
                ArtistImage.ImageUrl = "https://localhost:44302/Storage/Public/Images/Artists/" + a.ArtistImage;
                ArtistName.Text = a.ArtistName;
            }

            List<Album> albums = AlbumController.GetAllAlbumData();
            AlbumDataList.DataSource = albums;
            AlbumDataList.DataBind();
        }
        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string ArtistID = deleteButton.CommandArgument;
            int ID = int.Parse(ArtistID);
            ArtistController.DeleteArtist(ID);
            Response.Redirect("HomePage.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string ArtistID = deleteButton.CommandArgument;
            int ID = int.Parse(ArtistID);
            Response.Redirect("~/View/UpdateArtistPage.aspx?ID=" + ID);
        }
    }
}