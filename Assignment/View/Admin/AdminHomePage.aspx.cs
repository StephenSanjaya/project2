using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View.Admin
{
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Admin Home Page";
            if (Session["UserName"] != null)
            {
                welTxt.Text = "Welcome " + Session["UserName"];
            }
            else
            {
                Response.Redirect("../HomePage.aspx");
            }
        }

        protected void viewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUserPage.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Cookies["Email"].Expires = DateTime.Now.AddMinutes(-1);
            Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);
            Response.Redirect("../HomePage.aspx");
        }

        protected void viewproduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductPage.aspx");
        }

        protected void viewproducttype_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductTypePage.aspx");
        }
    }
}