using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class UpdateProductTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Update Product Type Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            _prodtype.DataSource = RepositoryProductType.GetAll();
            _prodtype.DataBind();
        }

        protected void newproducttype_Click(object sender, EventArgs e)
        {
            Int32 myid = 0;
            Int32.TryParse(id.Text.ToString(), out myid);
            bool cekid = RepositoryProductType.CekID(myid);

            if (cekid)
            {
                Response.Redirect("InsertNewProductTypePage.aspx?id=" + myid);
            }
            else
            {
                Response.Write("<script>alert('ID does not exists.')</script>");
            }
        }

        protected void text_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}