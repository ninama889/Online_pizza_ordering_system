using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class Default : System.Web.UI.Page
    {
        string strcon = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    txtName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtMobile.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
                else if (Session["role"].Equals("user"))
                {
                    txtAddress.Text = Session["userAddress"].ToString();
                    txtMobile.Text = Session["userMobile"].ToString();
                    txtName.Text = Session["name"].ToString();
                    txtEmail.Text = Session["email"].ToString();
                }
            }
            catch (Exception) { }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                try
                {

                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO UserOrders (UserId,OrderName,OrderDate) " +
                        "values(@UserId,@OrderName,@OrderDate)", con);
                    cmd.Parameters.AddWithValue("@UserId", Session["userId"].ToString());
                    cmd.Parameters.AddWithValue("@OrderName", txtFoodname.Text.Trim());
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Order is placed .. will be available at your home in 30 mins" +
                        "with cash on delivery .. thank you. ');</script>");

                }
                catch (Exception ex)
                { Response.Write("<script>alert('" + ex.Message + "');</script>"); }
            }
        }
    }
}