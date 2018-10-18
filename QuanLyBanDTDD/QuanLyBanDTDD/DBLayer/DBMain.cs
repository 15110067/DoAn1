using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.DBLayer
{
    class DBMain
    {
        // chuỗi kết nối
        string ConnStr = "Data Source=(local);Initial Catalog=QLBanHangDD;Integrated Security=True";

        // đối tượng kết nối
        SqlConnection conn = null;

        // đối tượng thực hiện các câu lệnh sql
        SqlCommand cmd = null;

        // đối tượng đưa dữ liệu lên form
        SqlDataAdapter da = null;

        public DBMain() // khởi tạo Constructor
        {
            conn = new SqlConnection(ConnStr);
            cmd = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            cmd.CommandText = strSQL; // strSQL: câu lệnh SQL
            cmd.CommandType = ct; // ct: kiểu text
            da = new SqlDataAdapter(cmd); // nạp dữ liệu từ câu lệnh sql vào đối tượng da
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
