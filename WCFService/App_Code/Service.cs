using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public string Insert(InsertUser user)
    {
        string msg;
        SqlConnection con = new SqlConnection("Data Source=MSSQLLocalDB;Initial Catalog=socP;Persist Security Info=True;Pooling=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into Table1(Email,Pass) values(@Email,@Pass)", con);
        cmd.Parameters.AddWithValue("@Email", user.Email);
        cmd.Parameters.AddWithValue("@Pass", user.Pass);

        int g = cmd.ExecuteNonQuery();
        if (g == 1)
        {
            msg = "Successfully login";
        }
        else
        {
            msg = "Failed to login ";
        }
        return msg;
    }
}
