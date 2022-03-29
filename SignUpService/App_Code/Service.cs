using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        SqlConnection con = new SqlConnection("Data Source=MSSQLLocalDB;Initial Catalog=FoodieDB;Persist Security Info=True;Pooling=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into Users(Name,Email,Password,Mobile,Address,CreatedDate) values(@Name,@Email,@Password,@Mobile,@Address,@CreatedDate)", con);
        cmd.Parameters.AddWithValue("@Name", user.Name);
        cmd.Parameters.AddWithValue("@Email", user.Email);
        cmd.Parameters.AddWithValue("@Password", user.Password);
        cmd.Parameters.AddWithValue("@Mobile", user.Mobile);
        cmd.Parameters.AddWithValue("@Address", user.Address);
        cmd.Parameters.AddWithValue("@CreatedDate", user.CreatedDate);

        int g = cmd.ExecuteNonQuery();
        if (g == 1)
        {
            msg = "Successfully signUp";
        }
        else
        {
            msg = "Failed to singup ";
        }
        return msg;
    }
}
