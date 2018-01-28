using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class Class1
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
       // public static  dbs;
        
        public static SqlDataAdapter da;
        public static SqlDataReader myreader;
        public static String servername = "";
        public static String username;
        public static String password;
        public static String database = "QuanLiBanHangQuaMang1";
        public static String mGroup;
        public static String mlogin;
        // public static String mHoten;
        public static int Ketnoi()
        {
            if (Class1.conn != null && Class1.conn.State == ConnectionState.Open)
                Class1.conn.Close();
            try
            {
                Class1.connstr = "Data Source=" + Class1.servername + ";Initial Catalog=" + Class1.database + ";User ID=" +
                    Class1.mlogin + ";password=" + Class1.password;
                Class1.conn.ConnectionString = Class1.connstr;
               // dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
                Class1.conn.Open();
                return 1;

            }
            catch 
            {
               
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        {
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Class1.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Class1.conn.State == ConnectionState.Closed)
                Class1.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch 
            { 
                Class1.conn.Close();
                return null;
            }
        }
        public static DataTable execSQLquery(String cmd, String connectionstring)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            return dt;
        }
    }

   
}
