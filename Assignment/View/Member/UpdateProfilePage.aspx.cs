using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Member
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Update Profile Page";

            if (Session["UserName"] == null)
            {
                Response.Redirect("../HomePage.aspx");
            }

            if (!IsPostBack)
            {
                emailfield.Text = Session["Email"].ToString();
                namefield.Text = Session["UserName"].ToString();
            }
        }

        private bool cek(String email, String name, String gender)
        {
            if (email != "" && name != "" && gender != "")
            {
                return true;
            }
            return false;
        }

        protected void updateprofile_Click(object sender, EventArgs e)
        {
            String email = emailfield.Text.ToString();
            String name = namefield.Text.ToString();
            String gender;
            String oldemail = Session["Email"].ToString();

            if (RB1.Checked)
            {
                gender = RB1.Text.ToString();
            }
            else if (RB2.Checked)
            {
                gender = RB2.Text.ToString();
            }
            else
            {
                gender = "";
            }
            bool cekInput = cek(email, name, gender);
            if (cekInput)
            {
                Session["Email"] = email;
                Session["UserName"] = name;
                RepositoryUser.UpdateProfile(oldemail, email, name, gender);
                Response.Redirect("ProfileMemberPage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Data can not be null.')</script>");
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberHomePage.aspx");
        }
    }
}