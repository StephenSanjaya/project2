using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class ViewProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "View Product Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            _allproduct.DataSource = RepositoryProduct.GetAll();
            _allproduct.DataBind();
        }

        protected void insertproduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductPage.aspx");
        }

        protected void updateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProduct.aspx");
        }

        protected void deleteproduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteProductPage.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}