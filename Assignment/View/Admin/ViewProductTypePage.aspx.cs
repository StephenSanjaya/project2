using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class ViewProductTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "View Product Type Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            _allProduct.DataSource = RepositoryProductType.GetAll();
            _allProduct.DataBind();
        }

        protected void insertproducttype_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductTypePage.aspx");
        }

        protected void updateproducttype_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductTypePage.aspx");
        }

        protected void deleteproducttype_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteProductTypePage.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}