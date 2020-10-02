using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class DeleteProductTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Delete Product Type Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            refresh();
        }
        
        private void refresh()
        {
            _allproduct.DataSource = RepositoryProductType.GetAll();
            _allproduct.DataBind();
        }

        protected void deleteproducttype_Click(object sender, EventArgs e)
        {
            Int32 deletebyID = 0;
            Int32.TryParse(id.Text.ToString(), out deletebyID);
            bool cekKedua = RepositoryProduct.CekProductTypeID(deletebyID);
            bool cekPertama = RepositoryProductType.CekID(deletebyID);
            if (cekPertama)
            {
                if (cekKedua)
                {
                    Response.Write("<script>alert('Deleted product type can not have reference to other table.')</script>");
                }
                else
                {
                    RepositoryProductType.DeleteProductType(deletebyID);
                    Response.Write("<script>alert('Delete product type successfully.')</script>");
                    refresh();
                }
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