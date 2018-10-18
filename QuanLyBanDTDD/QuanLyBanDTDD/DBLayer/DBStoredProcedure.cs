using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn1Demo.DB
{
    class DBClassStoredProcedure
    {
        string connectionStr = "Data Source=(local);Initial Catalog=QLBanHangDD;Integrated Security=True";

        SqlConnection conn = null;

        SqlCommand cmd = null;

        SqlDataAdapter da = null;

        public DBClassStoredProcedure()
        {
            conn = new SqlConnection(connectionStr);
            cmd = conn.CreateCommand();
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
