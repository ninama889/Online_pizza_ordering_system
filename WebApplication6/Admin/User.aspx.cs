using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6.Admin
{
    public partial class User : System.Web.UI.Page
    {
        private string strcon = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["breadCrum"] = "User";
            }
            lblMsg.Visible = false;
            GetUsers();

        }
        protected void btnClear_Click(object sender, EventArgs e) => Clear();

        private void GetUsers()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string cmd = "SELECT * FROM Users ORDER BY CreatedDate DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            adapter.Fill(ds);
            rUser.DataSource = ds;
            rUser.DataBind();
        }

        protected void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(hdnId.Value);
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            if (userId == 0)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Users(Name,Email,Password,Mobile,Address,CreatedDate) values(@Name,@Email,@Password,@Mobile,@Address,@CreatedDate)", con);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    lblMsg.Visible = true;
                    lblMsg.Text = "User is Added!!!";
                    lblMsg.CssClass = "alert alert-success";
                }
                catch (Exception)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Something went wrong please try again later!!!";
                    lblMsg.CssClass = "alert alert-success";
                }
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("UPDATE  Categories SET Name=@Name, Email=@Email , Password=@Password, " +
                        "Mobile=@Mobile , Address=@Address WHERE UserId=@UserId", con);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    lblMsg.Visible = true;
                    lblMsg.Text = "User is Added!!!";
                    lblMsg.CssClass = "alert alert-success";
                }
                catch (Exception)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Something went wrong please try again later!!!";
                    lblMsg.CssClass = "alert alert-success";
                }
            }
            con.Close();

            Clear();

        }
        protected void rUser_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                lblMsg.Text = id.ToString();
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                string cmd = "SELECT * FROM Users WHERE UserId =" +id+
                    "ORDER BY CreatedDate DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
                adapter.Fill(ds);
                txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString(); ;
                txtPass.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();

                hdnId.Value = ds.Tables[0].Rows[0]["UserId"].ToString();
                btnAddOrUpdate.Text = "Update";
                LinkButton btn = e.Item.FindControl("lnkEdit") as LinkButton;
                btn.CssClass = "badge badge-warning";
            }
            else if (e.CommandName == "delete")
            {
                ServiceReferenceAdmin.AdminControlClient pd = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
                if (pd.DeleteProduct(Convert.ToInt32(e.CommandArgument)))
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Product is Deleted!!!";
                    lblMsg.CssClass = "alert alert-success";
                    GetUsers();
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Error while delete Product please try again later!!!";
                    lblMsg.CssClass = "alert alert-danger";

                }
            }

        }


        private void Clear()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtPass.Text = string.Empty;
            hdnId.Value = "0";
            btnAddOrUpdate.Text = "Add";
        }
    }
}