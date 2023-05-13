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
    }
}