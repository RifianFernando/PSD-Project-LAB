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
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);

            Album ab = AlbumController.GetDataById(id);

            if (!IsPostBack)
            {
                AlbumImage.ImageUrl = "https://localhost:44302/Storage/Public/Images/Albums/" + ab.AlbumImage;
                AlbumName.Text = ab.AlbumName;
                AlbumDesc.Text = ab.AlbumDescription;
                AlbumPrice.Text = ab.AlbumPrice.ToString();
                AlbumStock.Text = ab.AlbumStock.ToString();
            }

        }

        protected void CartButton_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                String Email = Session["User"].ToString();
                bool isAdmin = CustomerController.ValidateAdmin(Email);
                if (isAdmin == false)
                {
                    ConfirmButton.Visible = true;
                    Quantity.Visible = true;
                    QtyText.Visible = true;
                }
            }
        }
        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            string QtyString = Quantity.Text;

            if (CartController.ValidateQty(QtyString))
            {
                ConfirmButton.Visible = false;
                Quantity.Visible = false;
                QtyText.Visible = false;

                int CustomerID = CustomerController.GetIdByEmail(Session["User"].ToString());
                int AlbumID = int.Parse(Request.QueryString["ID"]);
                int QuantityInt = int.Parse(QtyString);

                CartController.InsertCart(CustomerID, AlbumID, QuantityInt);

                Success.ForeColor = System.Drawing.Color.Green;
                Success.Text = "Album has been added to cart";
            }
            else
            {
                Success.ForeColor = System.Drawing.Color.Red;
                Success.Text = "Quantity must be integer";
            }
        }
    }
}