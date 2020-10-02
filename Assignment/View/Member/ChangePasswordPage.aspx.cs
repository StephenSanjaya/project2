using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Member
{
    public partial class ChangePasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Change Password Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }
        }

        private bool validation(String newpass)
        {
            Int32 length = newpass.Length;
            if (length >= 5)
            {
                return true;
            }
            return false;
        }

        protected void changebutton_Click(object sender, EventArgs e)
        {
            String oldpass = oldpassword.Text.ToString();
            String newpass = newpassword.Text.ToString();
            String confpass = confirmpassword.Text.ToString();
            bool cekPW = RepositoryUser.cekPass(oldpass);

            if (cekPW)
            {
                if (validation(newpass))
                {
                    if (newpass == confpass)
                    {
                        RepositoryUser.InsertNewPassword(oldpass, newpass);
                        Response.Redirect("ProfileMemberPage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Your new password does not match with the confirmation password !')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('New password must atleast consists of 5 words.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Your old password does not match with your current login password !')</script>");
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberHomePage.aspx");
        }
    }
}