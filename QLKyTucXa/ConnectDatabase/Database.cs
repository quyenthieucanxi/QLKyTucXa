using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKyTucXa.ConnectDatabase
{
    internal class Database
    {
        static SqlConnection sqlConn;
        static SqlDataAdapter da;
        static DataSet ds;
        public  Database()
        {
            string strCnn = "Data Source=localhost,1433; Database=QuanLyKTX;user id =sa;password=123456;" +
                            "MultipleActiveResultSets=True;";
            sqlConn = new SqlConnection(strCnn);


        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        // Phuong thuc de thuc hien cac lenh Them, Sua, Xoa
        public void ExecuteNonQuery(string strSQl)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQl, sqlConn);
            sqlConn.Open();//Mo ket noi
            sqlcmd.ExecuteNonQuery();//Lenh thuc hien Them/Sua/Xoa
            sqlConn.Close();
        }
    }
}
