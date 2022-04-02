using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* When Nobody Logged In */
            try
            {
                if (Session["role"] == null)
                {
                    LinkButton1.Visible = true;     //user login link button
                    LinkButton4.Visible = true;     //sign up link button
                    LinkButton5.Visible = false;     //menu link button

                    LinkButton2.Visible = false;     //logout link button
                    LinkButton3.Visible = false;     //hello user link button
                    LinkButton6.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;     //user login link button
                    LinkButton4.Visible = false;     //sign up link button
                    LinkButton5.Visible = true;     //menu link button
                    LinkButton6.Visible = false;
                    LinkButton2.Visible = true;     //logout link button
                    LinkButton3.Visible = true;     //hello user link button
                    LinkButton3.Text = "Hello " + Session["name"].ToString() ;
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;     //user login link button
                    LinkButton4.Visible = false;     //sign up link button
                    LinkButton5.Visible = true;     //menu link button

                    LinkButton2.Visible = true;     //logout link button
                    LinkButton3.Visible = true;     //hello user link button
                    LinkButton3.Text = "Hello " + Session["name"].ToString() ;
                    LinkButton6.Visible = true;
                    Response.Redirect("Admin/Dashboard.aspx");
                }

            }
            catch (Exception)
            {

            }
        }
        
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["name"] = "";
            Session["email"] = "";
            Session["role"] = "";

            LinkButton1.Visible = true;     //user login link button
            LinkButton4.Visible = true;     //sign up link button

            LinkButton2.Visible = false;     //logout link button
            LinkButton3.Visible = false;     //hello user link button
            LinkButton6.Visible = false;
            LinkButton5.Visible = false;

            Response.Redirect("default.aspx");
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin/DashBoard.aspx");
        }
    }

}