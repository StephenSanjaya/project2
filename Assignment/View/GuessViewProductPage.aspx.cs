using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Guess
{
    public partial class GuessViewProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "View Product Page";
            _allproduct.DataSource = RepositoryProduct.GetFiveProduct();
            _allproduct.DataBind();
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}