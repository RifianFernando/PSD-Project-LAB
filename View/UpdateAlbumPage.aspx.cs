﻿using KpopZtation.Controller;
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
    public partial class UpdateAlbumPage : System.Web.UI.Page
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

                    Album Al = AlbumController.GetDataByArtistId(id);

                    if (!IsPostBack)
                    {
                        UpdateAlbumName.Text = Al.AlbumName;
                        AlbumImage.ImageUrl = "https://localhost:44302/Storage/Public/Images/Artists/" + Al.AlbumImage;
                        UpdateAlbumPrice.Text = Al.AlbumPrice.ToString();
                        UpdateAlbumStock.Text = Al.AlbumStock.ToString();
                        UpdateAlbumDescription.Text = Al.AlbumDescription;           
                    }

                    return;
                }
            }
        }

        protected void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);

            Album Al = AlbumController.GetDataByArtistId(id);

            String AlbumName = Al.AlbumName;
            String AlbumImage = Al.AlbumImage;

            String NewAlbumName = UpdateAlbumName.Text;
            String NewAlbumImage = UpdateAlbumImage.FileName;
            int ImageSize = UpdateAlbumImage.PostedFile.ContentLength;

            WarningAlbumName.Text = AlbumController.ValidateUpdateAlbumName(NewAlbumName, AlbumName);
            WarningAlbumImage.Text = AlbumController.ValidateUpdateImage(AlbumImage, ImageSize);

            SuccessLabel.Text = AlbumController.UpdateAlbum(id, NewAlbumName, AlbumName, NewAlbumImage, AlbumImage, ImageSize);

            if (SuccessLabel.Text.Equals("Update saved!"))
            {
                if (UpdateAlbumImage.HasFile)
                {
                    String FolderDirectory = Server.MapPath("~/Storage/Public/Images/Artists/");
                    String ImageFolder = Server.MapPath("~/Storage/Public/Images/Artists/" + NewAlbumImage);

                    if (!Directory.Exists(FolderDirectory))
                    {
                        Directory.CreateDirectory(FolderDirectory);
                    }

                    UpdateAlbumImage.SaveAs(ImageFolder);
                }
            }
        }
    }
}