using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Middleware;

namespace KpopZtation.View
{
    public partial class ArtistDetailPage : System.Web.UI.Page
    {
        public List<Album> albums = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionMiddleware.isLogin(Page);
            string idQueryString = Request.QueryString["ID"];
            if (string.IsNullOrEmpty(idQueryString))
            {
                Response.Redirect("HomePage.aspx");
            }

            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == true)
                {
                    ViewState["Cookie"] = "Admin";
                }
                else
                {
                    ViewState["Cookie"] = "Customer";
                }
            }
            else
            {
                ViewState["Cookie"] = "Guest";
            }

            int id = int.Parse(idQueryString);

            Artist a = ArtistController.GetDataById(id);

            if (!IsPostBack)
            {
                ArtistImage.ImageUrl = "https://localhost:44302/Storage/Public/Images/Artists/" + a.ArtistImage;
                ArtistName.Text = a.ArtistName;

                List<Album> albums = AlbumController.GetAllArtistAlbumData(id);
                AlbumDataList.DataSource = albums;
                AlbumDataList.DataBind();
            }
        }
        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string AlbumID = deleteButton.CommandArgument;
            int ID = int.Parse(AlbumID);
            AlbumController.DeleteAlbum(ID);

            Response.Redirect(Request.RawUrl);
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Button updateButton = (Button)sender;
            string AlbumID = updateButton.CommandArgument;
            int ID = int.Parse(AlbumID);
            Response.Redirect("~/View/UpdateAlbumPage.aspx?ID=" + ID);
        }

        protected void InsertAlbum_Button_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(Request.QueryString["ID"]);
            Response.Redirect("~/View/InsertAlbumPage.aspx?ID=" + ID);
        }
    }
}