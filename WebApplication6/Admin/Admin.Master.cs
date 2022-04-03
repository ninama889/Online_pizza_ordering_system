using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session["name"] = null;
            Session["email"] = null;
            Session["role"] = null;
            Session["userId"] = null;
            Session["userMobile"] = null;
            Session["userAdress"] = null;

            Response.Redirect("../Default.aspx");
        }
    }
}