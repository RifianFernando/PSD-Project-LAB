using KpopZtation.Controller;
using KpopZtation.Middleware;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionMiddleware.isLogin(Page);
            if (Session["User"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }

            String Email = Session["User"].ToString();
            bool isAdmin = CustomerController.ValidateAdmin(Email);
            int id = CustomerController.GetIdByEmail(Email);   
            if (!IsPostBack)
            {
                List<Cart> carts = CartController.GetAllCartItemData(id);
                CartDataList.DataSource = carts;
                CartDataList.DataBind();
            }
        }

        protected void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        protected void CheckOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}