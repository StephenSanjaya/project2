using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class DeleteProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Delete Product Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            refresh();
        }

        private void refresh()
        {
            _allproduct.DataSource = RepositoryProduct.GetAll();
            _allproduct.DataBind();
        }

        protected void deleteproduct_Click(object sender, EventArgs e)
        {
            Int32 deletebyID = 0;
            Int32.TryParse(id.Text.ToString(), out deletebyID);
            bool cek = RepositoryProduct.CekID(deletebyID);
            if (cek)
            {
                RepositoryProduct.DeleteProduct(deletebyID);
                Response.Write("<script>alert('Delete product successfully.')</script>");
                refresh();
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