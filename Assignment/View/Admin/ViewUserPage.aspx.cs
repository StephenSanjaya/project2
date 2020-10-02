using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment.Repository;

namespace Assignment.View.Admin
{
    public partial class ViewUserPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "View User Page";
            if (Session["UserName"] == null) {
                Response.Redirect("../HomePage.aspx");
            }
            refresh();
        }

        private void refresh()
        {
            _allUser.DataSource = RepositoryUser.GetAll();
            _allUser.DataBind();
        }

        protected void _allUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "changestatus")
            {
                Int32 id = Int32.Parse(e.CommandArgument.ToString());
                String status = _allUser.Rows[id].Cells[5].Text.ToString();
                String email = _allUser.Rows[id].Cells[3].Text.ToString();

                if (RepositoryUser.Email(email).Email != Session["Email"].ToString())
                {
                    if (status == "Active")
                    {
                        RepositoryUser.ChangeToBlocked(email);
                    }
                    else if (status == "Blocked")
                    {
                        RepositoryUser.ChangeToActive(email);
                    }
                }
                else
                {
                    Response.Write("<script>alert('Can not change current login admin status.')</script>");
                }
            }
            refresh();
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }

        protected void update_Click(object sender, EventArgs e)
        {
            Int32 myid = 0;
            Int32.TryParse(id.Text.ToString(), out myid);
            Int32 roleid = 0;
            bool cek = RepositoryUser.cekID(myid);

            if (cek)
            {
                Int32.TryParse(RepositoryUser.FindID(myid).RoleID.ToString(), out roleid);
                if (RepositoryUser.FindID(myid).Email != Session["Email"].ToString())
                {
                    if (roleid == 2)
                    {
                        RepositoryUser.ChangeToAdmin(myid);
                    }
                    else if (roleid == 1)
                    {
                        RepositoryUser.ChangeToMember(myid);
                    }
                }
                else
                {
                    Response.Write("<script>alert('Can not change current login admin role.')</script>");
                }
                refresh();
            }
            else
            {
                Response.Write("<script>alert('ID does not exists.')</script>");
            }
        }
    }
}