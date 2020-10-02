using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class InsertProductTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Insert Product Type Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx);");
            }
        }

        private bool validation(String prodtype, String desc)
        {
            Int32 length = prodtype.Length;
            if (length >= 5 && desc != "")
            {
                return true;
            }
            return false;
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            String prodtype = producttype.Text.ToString();
            String desc = description.Text.ToString();

            if (validation(prodtype, desc))
            {
                RepositoryProductType.InsertProductType(prodtype, desc);
                Response.Write("<script>alert('Insert product type successfully.')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product type must be consist of 5 character or more.')</script>");
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}