using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View.Member
{
    public partial class MemberHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Member Home Page";
            if (Session["UserName"] != null ) 
            {
                welTxt.Text = "Welcome " + Session["UserName"];
            }
            else
            {
                Response.Redirect("../HomePage.aspx");
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Response.Cookies["Email"].Expires = DateTime.Now.AddMinutes(-1);
            Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);
            Response.Redirect("../HomePage.aspx");
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileMemberPage.aspx");
        }

        protected void viewPro_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductPageMember.aspx");
        }
    }
}