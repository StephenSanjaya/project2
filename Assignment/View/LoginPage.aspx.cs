using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Login Page";
            if (!IsPostBack)
            {
                if (Request.Cookies["Email"] != null && Request.Cookies["Password"] != null)
                {
                    EmailField.Text = Request.Cookies["Email"].Value;
                    PasswordField.Text = Request.Cookies["Password"].Value;
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            String email = EmailField.Text.ToString();
            String password = PasswordField.Text.ToString();
            String name = RepositoryUser.getName(email,password);
            Session["UserName"] = name.ToString();
            Session["Email"] = email.ToString();

            if (name != "")
            {
                if (remember.Checked)
                {
                    Response.Cookies["Password"].Value = password;
                    Response.Cookies["Email"].Value = email;
                    Response.Cookies["Email"].Expires = DateTime.Now.AddMinutes(30);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(30);
                }
                else
                { 
                    Response.Cookies["Email"].Expires = DateTime.Now.AddMinutes(-1);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);
                }
                String stat = RepositoryUser.checkStatus(email,password);
                if (stat == "Blocked")
                {
                    Response.Write("<script>alert('Your account is banned')</script>");
                }
                else
                {
                    if (RepositoryUser.Email(email).RoleID == 1)
                    {
                        Response.Redirect("Admin/AdminHomePage.aspx");
                    }
                    else
                    {
                        Response.Redirect("Member/MemberHomePage.aspx");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid username or password')</script>");
            }
        }
    }
}
