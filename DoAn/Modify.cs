using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DoAn
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCmd; // dung de truy van 
        SqlDataReader datareader;//doc du lieu    
        public List<TaiKhoan> DSTaiKhoan(string query)
        {
            List<TaiKhoan> DSTaiKhoan = new List<TaiKhoan>();
            using (SqlConnection Conn = DBConnect.GetSqlConnection())
            {
                Conn.Open();
                sqlCmd = new SqlCommand(query, Conn);
                //query: cau truy van truyen vao
                datareader = sqlCmd.ExecuteReader();
                while (datareader.Read())
                {
                    DSTaiKhoan.Add(new TaiKhoan(datareader.GetString(0),datareader.GetString(1)));
                }
                Conn.Close();

            }
            return DSTaiKhoan;
        }

    }
}
