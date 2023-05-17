﻿using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class AlbumDetailPage : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve the list of artists and bind it to the DataList control
                List<Album> Albums = AlbumController.GetAllAlbumData();
                AlbumDataList.DataSource = Albums;
                AlbumDataList.DataBind();
            }

        }
        protected void CartButton_Click(object sender, EventArgs e)
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

        protected void ConfirmButton_Click(object sender, EventArgs e)
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
}