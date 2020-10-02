using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Member
{
    public partial class ProfileUserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Profile Page";
            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }

            String sess = Session["UserName"].ToString();

            _user.DataSource = RepositoryUser.GetProfile(sess);
            _user.DataBind();
        }

        protected void changepassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePasswordPage.aspx");
        }

        protected void updateprofile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfilePage.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberHomePage.aspx");
        }
    }
}