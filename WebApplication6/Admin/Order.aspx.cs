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
    public partial class Order : System.Web.UI.Page
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

        private void GetUsers()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string cmd = "SELECT O.UserOrderId ,U.Name, U.Email , U.Mobile,U.Address , O.OrderName ,O.OrderDate FROM Users U " +
                "INNER JOIN UserOrders O ON U.UserId = O.UserId ORDER BY O.OrderDate DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            adapter.Fill(ds);
            rOrder.DataSource = ds;
            rOrder.DataBind();
        }
        protected void rOrder_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           if (e.CommandName == "delete")
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
    }
}