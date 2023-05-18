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
            int id = int.Parse(Request.QueryString["ID"]);

            Artist a = ArtistController.GetDataById(id);

            if (!IsPostBack)
            {
                ArtistImage.ImageUrl = "https://localhost:44302/Storage/Public/Images/Artists/" + a.ArtistImage;
                ArtistName.Text = a.ArtistName;
            }

            List<Album> albums = AlbumController.GetAllArtistAlbumData(id);
            AlbumDataList.DataSource = albums;
            AlbumDataList.DataBind();
        }
        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string AlbumID = deleteButton.CommandArgument;
            int ID = int.Parse(AlbumID);
            AlbumController.DeleteAlbum(ID);
            Response.Redirect("HomePage.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Button updateButton = (Button)sender;
            string AlbumID = updateButton.CommandArgument;
            int ID = int.Parse(AlbumID);
            Response.Redirect("~/View/UpdateAlbumPage.aspx?ID=" + ID);
        }
    }
}