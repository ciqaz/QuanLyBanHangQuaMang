using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using DALayer;
namespace BALayer
{
    public class TinhTrangDon
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);

        public DataTable LayTinhTrangDon()
        {
            
            var tt = from p in dbs.V_LoadTinhTrangDons
             select new { p.MaDonHang,p.NgayXacNhan, p.TinhTrang};

            if (tt != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(tt);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
                return null;

        }
        public bool SuaTinhTrangDon(ref string err, int MaDonHang, int DaThanhToan)
        { bool f = false;
          
            try
            {
                dbs.SP_SuaTinhTrangDon(MaDonHang, DaThanhToan);
                f = true;
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return f;
        }

    }
}
