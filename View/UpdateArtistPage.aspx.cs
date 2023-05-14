using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateArtistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);

        }
    }
}