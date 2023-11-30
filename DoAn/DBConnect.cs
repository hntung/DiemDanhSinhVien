using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn
{
    class DBConnect
    {
        private static string stringConnection = "Data Source=MSI\\QUANGDIEU;Initial Catalog= DDSV_Last;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

        SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public DBConnect()
        {
            connect = new SqlConnection(stringConnection);
        }

        public void open()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }

        public void close() 
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }

        public int getNonQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }

        public SqlDataReader getDataReader(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }

        public object getScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }

        public DataTable getDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        public int updateDatabase(string sql, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
    }
}
