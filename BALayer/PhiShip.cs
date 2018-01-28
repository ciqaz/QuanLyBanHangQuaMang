using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DALayer;
namespace BALayer
{
    public class PhiShip
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
        public DataTable LayPhiShipTheoMa(int MaDonHang)
        {
            var dh = from p in dbs.PhiShipSPs where p.MaDonHang==MaDonHang
                     select p;
            if (dh != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(dh);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public DataTable LayPhiShip()
        {
            var dh = from p in dbs.PhiShipSPs
                     select p;
            if (dh != null)
            {
                SqlCommand cmd = (SqlCommand)dbs.GetCommand(dh);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
                return null;
        }
        public bool SuaPhiShip(ref string err, int MaDonHang, decimal SL)
        {
            bool f = false;
            try
            {
                dbs.SP_SuaPhiShip(MaDonHang, SL);
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
