using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Middleware;
using KpopZtation.Controller;

namespace KpopZtation.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //-------------Authentication----------------//
            SessionMiddleware.isLogin(Page);

            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (!isAdmin)
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
            //-----------------------------//


            

            //Artist a = ArtistController.GetDataById(id);

            //if (!IsPostBack)
            //{
            //    ArtistImage.ImageUrl = "https://localhost:44302/Storage/Public/Images/Artists/" + a.ArtistImage;
            //    ArtistName.Text = a.ArtistName;
            //}

            //List<Album> albums = AlbumController.GetAllArtistAlbumData(id);
            //AlbumDataList.DataSource = albums;
            //AlbumDataList.DataBind();

        }
    }
}