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
            artists = ArtistController.GetAllArtistData();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            string artistName = DeleteButton.CommandArgument;
            Test.Text = artistName;
            Response.Write(artistName);
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}