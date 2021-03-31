using System.Data;
using System.Data.SqlClient;

namespace WpfApp1_finalproject
{
    internal class Datahandle
    {
        public readonly string conn = @"Server=(localdb)\mssqllocaldb;Database=bhawesh1;Trusted_Connection=True;";
        public DataTable getdata()
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("select * from product",sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlConnection.Open();
            da.Fill(dt);
            sqlConnection.Close();
            return dt;
            
        }

        public int insertdata(Product p)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertProduct";
            cmd.Parameters.AddWithValue("@stock", p.Stock);
            cmd.Parameters.AddWithValue("@type", p.Type);
            cmd.Parameters.AddWithValue("@company", p.Company);
            sqlConnection.Open();
            int x = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return x;

        }

        public void deletedata(Product p)
        {

        }

    }
}