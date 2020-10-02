using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Member
{
    public partial class ViewProductPageMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "View Product Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            _allproduct.DataSource = RepositoryProduct.GetFiveProduct();
            _allproduct.DataBind();
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberHomePage.aspx");
        }
    }
}