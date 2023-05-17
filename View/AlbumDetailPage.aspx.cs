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
    public partial class AlbumDetailPage : System.Web.UI.Page
    {
        int CustomerID;
        int AlbumID;
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
            ConfirmButton.Visible = true;
            Quantity.Visible = true;
            QtyText.Visible = true;
            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == false)
                {
                    Button cartButton = (Button)sender;
                    AlbumID = int.Parse(cartButton.CommandArgument);
                    CustomerID = CustomerController.GetIdByEmail(Email);

                }
            }
        }
        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            ConfirmButton.Visible = false;
            Quantity.Visible = false;
            QtyText.Visible = false;
            Success.Text = "Album has been inserted to the cart";
            int Qty = int.Parse(QtyText.Text);
            if(int.)
            CartController.InsertCart();
        }
    }
}