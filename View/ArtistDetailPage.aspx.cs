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
        public List<Artist> artists = new List<Artist>();
        public List<Album> albums = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Artist> artists = ArtistController.GetAllArtistData();
            ArtistDataList.DataSource = artists;
            ArtistDataList.DataBind();

            List<Album> albums = AlbumController.GetAllAlbumData();
            ArtistDataList.DataSource = artists;
            ArtistDataList.DataBind();
        }
        protected void DeleteAlbumButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string ArtistID = deleteButton.CommandArgument;
            int ID = int.Parse(ArtistID);
            ArtistController.DeleteArtist(ID);
            Response.Redirect("HomePage.aspx");
        }

        protected void UpdateAlbumButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string ArtistID = deleteButton.CommandArgument;
            int ID = int.Parse(ArtistID);
            Response.Redirect("~/View/UpdateArtistPage.aspx?id=" + ID);
        }
    }
}