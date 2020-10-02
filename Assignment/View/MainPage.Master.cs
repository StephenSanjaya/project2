using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class MainPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String theme = Response.Cookies["Theme"].Value;
            if (Request.Cookies["Theme"].Value == theme ) 
            {
                Response.Cookies["Theme"].Value = "green-theme";
            }
            Response.Cookies["Theme"].Value = "blue-theme";
           

            MainBody.Attributes.Add("class", Response.Cookies["Theme"].Value);

            /*Coba besok
            String theme = Response.Cookies["Theme"].Value;
            if (Request.Cookies["Theme"].Value == green-theme ) 
            {
                Response.Cookies["Theme"].Value = "green-theme";
            }
            Response.Cookies["Theme"].Value = "blue-theme";
             */
        }

        protected void ChangeTheme_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Theme"].Value == "green-theme")
            {
                ChangeTheme.Text = "Green Theme";
                Response.Cookies["Theme"].Value = "blue-theme";
            }
            else if(Request.Cookies["Theme"].Value == "blue-theme")
            {
                ChangeTheme.Text = "Blue Theme";
                Response.Cookies["Theme"].Value = "green-theme";
            }

            MainBody.Attributes.Add("class", Response.Cookies["Theme"].Value);
        }
    }
}