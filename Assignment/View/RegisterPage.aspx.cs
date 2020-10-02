using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Register Page";
        }

        private bool cek(String gender, String username, String pass, String confpass, String email)
        {
            if (gender != "" && username != "" && pass != "" && confpass != "" && email != "")
            {
                return true;
            }
            return false;
        }

        protected void registerbutton_Click(object sender, EventArgs e)
        {
            String gender;
            String username = UsernameField.Text.ToString();
            String password = PasswordField.Text.ToString();
            String confpass = confirm_password.Text.ToString();
            String email = EmailField.Text.ToString();
            String status = "Active";
            Int32 roleid = 2;
            bool cekEmail = RepositoryUser.cekEmail(email);

            if (RB1.Checked)
            {
                gender = RB1.Text;
            }
            else if(RB2.Checked)
            {
                gender = RB2.Text;
            }
            else
            {
                gender = "";
            }

            bool ceknull = cek(gender, username, password, confpass, email);

            if (ceknull)
            {
                if (password == confpass)
                {
                    if (cekEmail)
                    {
                        Response.Write("<script>alert('User is registered successfully')</script>");
                        RepositoryUser.InsertUser(roleid, username, password, email, gender, status);
                        Response.Redirect("LoginPage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Email already registered !')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid Confirmation Password')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Data can not be null.')</script>");
            }
        }
    }
}