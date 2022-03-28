using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminControl
{
    public class AdminControlService : IAdminControl
    {
        [Obsolete]
        public bool AddCategory(Category ct)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True;Pooling=False");
            SqlDataAdapter adapter = new SqlDataAdapter();
            con.Open();
            if (ct.ImageUrl !=null)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Categories (Name, ImageUrl , IsActive , CreatedDate) VALUES (@Name, @ImageUrl , @IsActive , @CreatedDate)", con);
                cmd.Parameters.Add("@Name", ct.Name);
                cmd.Parameters.Add("@ImageUrl", ct.ImageUrl);
                cmd.Parameters.Add("@IsActive", ct.IsActive);
                cmd.Parameters.Add("@CreatedDate", ct.CreatedDate);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Categories (Name , IsActive , CreatedDate) VALUES (@Name, @ImageUrl , @IsActive , @CreatedDate)", con);
                cmd.Parameters.Add("@Name", ct.Name);
                cmd.Parameters.Add("@IsActive", ct.IsActive);
                cmd.Parameters.Add("@CreatedDate", ct.CreatedDate);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

            }
            con.Close();
            return true;
        }

        [Obsolete]
        public bool DeleteCategory(int CategoryId)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True;Pooling=False");
            SqlDataAdapter adapter = new SqlDataAdapter();
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE CategoryId = @CategoryId", con);
            cmd.Parameters.Add("@CategoryId", CategoryId);
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.ExecuteNonQuery();
            return true;
        }

        public DataSet SelectCategories()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True;Pooling=False");
            DataSet ds = new DataSet();
            con.Open();
            string cmd = "SELECT * FROM Categories ORDER BY CreatedDate DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            adapter.Fill(ds); 
            return ds;

        }

        public DataSet SelectCategoryById(int CategoryId)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True;Pooling=False");
            DataSet ds = new DataSet();
            string cmd = "SELECT * FROM Categories WHERE CategoryId = " + CategoryId;
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            adapter.Fill(ds);
            return ds;
        }

        [Obsolete]
        public bool UpdateCategory(Category ct)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FoodieDB;Integrated Security=True;Pooling=False");
            SqlDataAdapter adapter = new SqlDataAdapter();
            con.Open();
            if (ct.ImageUrl != null)
            {
                SqlCommand cmd = new SqlCommand("UPDATE  Categories SET Name=@Name, ImageUrl=@ImageUrl , IsActive=@IsActive WHERE CategoryId=@CategoryId", con);
                cmd.Parameters.Add("@CategoryId", ct.CategoryId);
                cmd.Parameters.Add("@Name", ct.Name);
                cmd.Parameters.Add("@ImageUrl", ct.ImageUrl);
                cmd.Parameters.Add("@IsActive", ct.IsActive);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE  Categories SET Name=@Name,  IsActive=@IsActive WHERE CategoryId=@CategoryId", con);
                cmd.Parameters.Add("@CategoryId", ct.CategoryId);
                cmd.Parameters.Add("@Name", ct.Name);
                cmd.Parameters.Add("@IsActive", ct.IsActive);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
            }
            con.Close();
            return true;
        }
    }
}
