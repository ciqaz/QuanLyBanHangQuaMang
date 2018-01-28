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
    public class ThongTinNhanVien
    {
        QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);


        public DataTable LayNhanVien(string MaNhanVien)
        {
            
            var dh = from p in dbs.NhanViens where p.MaNhanVien == MaNhanVien
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

        public string LayTenNhanVien(ref string err, object username)
        {
            return dbs.F_LayTenNhanVien(Class1.username);
        }

        public DataTable LayNhanVien1()
        {

            var dh = from p in dbs.NhanViens
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
        public bool SuaTTNV(ref string err, string MaNhanVien,string TenNhanVien,string DiaChi,string SDT, byte[] Hinh)
        {
            

            bool f = false;
            NhanVien d = dbs.NhanViens.Single(p => p.MaNhanVien == MaNhanVien);
            try
            {
                if (d != null)
                {
                    d.TenNhanVien = TenNhanVien;
                    d.DiaChi = DiaChi;
                    d.SDT = SDT;
                    d.Hinh = Hinh;
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
        public bool XoaNhanVien(ref string err, string MaNhanVien)
        {
            

            bool f = false;
            NhanVien hs = dbs.NhanViens.Single(p => p.MaNhanVien == MaNhanVien);
            try
            {
                if (hs != null)
                {
                    dbs.NhanViens.DeleteOnSubmit(hs);
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
        
        public bool ThemNhanVien(ref string err, string TenNhanVien, string DiaChi, string SDT, byte[] Hinh)
        {
            
            bool f = false;
            NhanVien n = new NhanVien();
            n.TenNhanVien = TenNhanVien;
            n.DiaChi = DiaChi;
            n.SDT = SDT;
            
            n.Hinh = Hinh;
            try
            {
                dbs.NhanViens.InsertOnSubmit(n);
                dbs.SubmitChanges();   
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
