using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangQuaMang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangNhap());
        }
       // public static SqlConnection conn = new SqlConnection();
       // public static String connstr;
       // public static SqlDataAdapter da;
       // public static SqlDataReader myreader;
       // public static String servername = "";
       // public static String username;
       // public static String password;
       // public static String database = "QuanLiBanHangQuaMang1";
       // public static String mGroup;
       // public static String mlogin;
       //// public static String mHoten;
       // public static int Ketnoi()
       // {
       //     if (Program.conn != null && Program.conn.State == ConnectionState.Open)
       //         Program.conn.Close();
       //     try
       //     {
       //         Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
       //             Program.mlogin + ";password=" + Program.password;
       //         Program.conn.ConnectionString = Program.connstr;
       //         Program.conn.Open();
       //         return 1;
                
       //     }
       //     catch (Exception e)
       //     {
       //         MessageBox.Show("Sai mật khẩu"+e);
       //         return 0;
       //     }
       // }
       // public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
       // {
       //     SqlDataReader myreader;

       //     SqlCommand sqlcmd = new SqlCommand();
       //     sqlcmd.Connection = Program.conn;
       //     sqlcmd.CommandText = cmd;
       //     sqlcmd.CommandType = CommandType.Text;
       //     sqlcmd.CommandTimeout = 300;
       //     if (Program.conn.State == ConnectionState.Closed)
       //         Program.conn.Open();
       //     try
       //     {
       //         myreader = sqlcmd.ExecuteReader();
       //         return myreader;
       //     }
       //     catch (SqlException e)
       //     {
       //         MessageBox.Show(e.Message + "Lỗi sqlreader");
       //         Program.conn.Close();
       //         return null;
       //     }
       // }
       // public static DataTable execSQLquery(String cmd, String connectionstring)
       // {
       //     DataTable dt = new DataTable();
       //     conn = new SqlConnection(connectionstring);
       //     da = new SqlDataAdapter(cmd, conn);
       //     da.Fill(dt);
       //     return dt;
       // }
    }
}
