using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class DoanhThu
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
        public DataTable Tim(DateTime  Ngay)
        {
            var dh = from p in dbs.F_TimTheoNgay(Ngay) 
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
        public DataTable Tim2(DateTime Thang)
        {
            var dh = from p in dbs.F_TimLoiNhuanTheoThang(Thang)
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
        public DataTable Tim1(DateTime Ngay)
        {
            var dh = from p in dbs.F_TimTheoThang(Ngay)
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
        public DataTable LayDSPhi()
        {
            var dh = from p in dbs.CacLoaiPhis
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
        public decimal LayTongPhiMuaHang(int Thang,int Nam)
        {
            try
            {
                return Decimal.Parse(dbs.F_LayTongTienTrongThang(Thang, Nam).ToString());
            }
            catch
            {
                return 0;
            }
        }
        public decimal LayTongPhiMuaQua(int Thang, int Nam)
        {
            try
            {
                return Decimal.Parse(dbs.F_LayTongTienQuaTrongThang(Thang, Nam).ToString());
            }
            catch
            {
                return 0;
            }
        }
        public DataTable TimPhiTheoThang(DateTime Ngay)
        {
            var dh = from p in dbs.F_TimPhiThang(Ngay)
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
        public DataTable TimPhi()
        {
            var dh = from p in dbs.PhiTheoThangs
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
        public bool XoaPhiThang(ref string err, int Thang1,int Nam1,string LoaiPhi)    
        {
            bool f = false;
            
            try
            {
                dbs.SP_XoaPhiTrongThang(Thang1, Nam1, LoaiPhi);  
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool TinhLoiNhuan(ref string err, int Thang1, int Nam1)
        {
            bool f = false;
            try
            {
                dbs.SP_TinhLoiNhuan(Thang1, Nam1);
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool XoaLoaiPhi(ref string err, string Ma)
        {
            bool f = false;
            CacLoaiPhi hs = dbs.CacLoaiPhis.Single(p => p.MaPhi==Ma);
            try
            {
                if (hs != null)
                {
                    dbs.CacLoaiPhis.DeleteOnSubmit(hs);
                    dbs.SubmitChanges();
                    f = true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool ThemPhiThang(ref string err, int Thang1, int Nam1, string LoaiPhi, decimal Gia)
        {
            bool f = false;
            try
            {
                dbs.SP_ThemPhiThang(Thang1, Nam1, LoaiPhi, Gia);
                dbs.SubmitChanges();
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool ThemLoaiPhi(ref string err, string Ma, string  Ten)
        {
            bool f = false;
            CacLoaiPhi hs = new CacLoaiPhi();
            hs.MaPhi = Ma;
            hs.TenPhi = Ten;
            try
            {
                dbs.CacLoaiPhis.InsertOnSubmit(hs);
                dbs.SubmitChanges();
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool SuaLoaiPhi(ref string err, string Ma1, string Ma2, string Ten)
        {
            bool f = false;
            CacLoaiPhi hs = dbs.CacLoaiPhis.Single(p => p.MaPhi==Ma1);
            try
            {
                if (hs != null)
                {
                    hs.MaPhi = Ma2;
                    hs.TenPhi = Ten;
                    dbs.SubmitChanges();
                    f = true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public bool SuaPhiThang(ref string err, int Thang1, int  Nam1, string  LoaiPhi,string LoaiPhiCu,decimal Gia)
        {
            bool f = false;
            
            try
            {
                dbs.SP_SuaPhiThang(Thang1, Nam1, LoaiPhi,LoaiPhiCu, Gia);
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }
        public DataTable Layhet()
        {
            var dh = from p in dbs.TongTienNgays
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
        public DataTable LayHetLoiNhuan()
        {
            var dh = from p in dbs.LoiNhuans
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
        public int LaySLDonTrongNgay(DateTime ngay)
        {
            try
            {
                return Int32.Parse( dbs.F_LaySLDonTrongNgay(ngay).ToString());
            }
            catch
            {
                return 0;
            }
        }
        public int LaySLDonTrongThang(DateTime ngay)
        {
            try
            {
                return Int32.Parse(dbs.F_LaySLDonTrongThang(ngay).ToString());
            }
            catch
            {
                return 0;
            }
        }
        
    }
}
