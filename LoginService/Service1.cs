using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LoginService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string Insert(InsertUser user)
        {
            string msg;
            SqlConnection con = new SqlConnection("Data Source=MSSQLLocalDB;Initial Catalog=FoodieDB;Persist Security Info=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Users(Email,Pass) values(@Email,@Pass)", con);
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
}
