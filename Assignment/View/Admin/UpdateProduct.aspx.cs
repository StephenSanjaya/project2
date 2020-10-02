using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Update Product Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            _prodtable.DataSource = RepositoryProduct.GetAll();
            _prodtable.DataBind();
        }
        
        protected void selectid_Click(object sender, EventArgs e)
        {
            Int32 myid = 0;
            Int32.TryParse(id.Text.ToString(), out myid);
            bool cekid = RepositoryProduct.CekID(myid);
            
            if (cekid)
            {
                Response.Redirect("InsertNewProductPage.aspx?id=" + myid);
            }
            else
            {
                Response.Write("<script>alert('ID does not exists.')</script>");
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}