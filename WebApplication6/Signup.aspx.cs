using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class Signup : System.Web.UI.Page
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

                SqlCommand cmd = new SqlCommand("INSERT INTO Users(Name,Email,Password,Mobile,Address,CreatedDate) values(@Name,@Email,@Password,@Mobile,@Address,@CreatedDate)", con);

                cmd.Parameters.AddWithValue("@Name", nameText.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", emailText.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", passText.Text.Trim());
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Sign Up Successful .Go to Login to login');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}