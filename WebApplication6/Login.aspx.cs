using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.ServiceReference2;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference2.ServiceClient client = new ServiceReference2.ServiceClient();
        protected void emailText_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertUser u = new InsertUser();
            u.Email = emailText.Text;
            u.Pass = passText.Text;
            string r = client.Insert(u);
            Label1.Text = r.ToString();
        }
    }
}