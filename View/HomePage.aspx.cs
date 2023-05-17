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
    public partial class HomePage : System.Web.UI.Page
    {
        public List<Artist> artists = new List<Artist>();

        protected void Page_Load(object sender, EventArgs e)
        {
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

            if (!IsPostBack)
            {
                // Retrieve the list of artists and bind it to the DataList control
                List<Artist> artists = ArtistController.GetAllArtistData();
                ArtistDataList.DataSource = artists;
                ArtistDataList.DataBind();
            }
            //artists = ArtistController.GetAllArtistData();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {

            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == true)
                {
                    Button deleteButton = (Button)sender;
                    string ArtistID = deleteButton.CommandArgument;
                    int ID = int.Parse(ArtistID);
                    ArtistController.DeleteArtist(ID);
                    Response.Redirect("HomePage.aspx");
                }
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {


            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == true)
                {
                    Button deleteButton = (Button)sender;
                    string ArtistID = deleteButton.CommandArgument;
                    int ID = int.Parse(ArtistID);
                    Response.Redirect("~/View/UpdateArtistPage.aspx?id=" + ID);
                }
            }
        }
    }
}