using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Home Page";
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void view_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuessViewProductPage.aspx");
        }
    }
}