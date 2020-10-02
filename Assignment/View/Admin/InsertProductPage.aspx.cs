using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class InsertProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Insert Product Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
            _allproducttype.DataSource = RepositoryProductType.GetAll();
            _allproducttype.DataBind();
            tableColor.Style.Add(HtmlTextWriterStyle.BackgroundColor, "Red");
        }

        private bool validation(Int32 price, Int32 stock)
        {
            if(stock >= 1 && price > 1000 && price % 1000 == 0)
            {
                return true;
            }
            return false;
        }

        protected void insertproduct_Click(object sender, EventArgs e)
        {
            Int32 prodtypeid = 0;
            Int32 stock = 0;
            Int32 price = 0;
            Int32 ID = 0;
            Int32.TryParse(producttypeid.Text.ToString(), out ID);
            bool cek = RepositoryProductType.CekID(ID);
            if (cek)
            {
                String name = productname.Text.ToString();
                if (Int32.TryParse(producttypeid.Text.ToString(), out prodtypeid) &&
                    Int32.TryParse(productstock.Text.ToString(), out stock) &&
                    Int32.TryParse(productprice.Text.ToString(), out price) && name != "")
                {
                    if (validation(price,stock))
                    {
                        RepositoryProduct.InsertProduct(name, prodtypeid, stock, price);
                        Response.Write("<script>alert('Insert product successfully.')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Stock must be 1 or more and price must be above 1000 and multiply of 1000.')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Data can not be null and non numeric value.')</script>");
                } 
            }
            else
            {
                Response.Write("<script>alert('Product type id does not exists.')</script>");
            } 
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}