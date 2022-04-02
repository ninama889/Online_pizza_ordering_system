using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.ServiceReference2;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string strcon = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + emailText.Text.Trim() + "' AND password='" + passText.Text.Trim() + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        Response.Write("<script>alert('Login Successfull');</script>");
                        string name = dr.GetValue(1).ToString();
                        Session["email"] = dr.GetValue(2).ToString();
                        Session["name"] = dr.GetValue(1).ToString();
                        
                        if (name== "admin" || name=="ADMIN" || name=="Admin")
                        {
                            Session["role"] = "admin";
                            Response.Redirect("admin/DashBoard.aspx");
                        }
                        else
                        {
                            Session["role"] = "user";
                            Response.Redirect("Default.aspx");
                        }
                    }

                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}