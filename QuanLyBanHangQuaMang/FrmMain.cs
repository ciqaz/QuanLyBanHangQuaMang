using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DALayer; 
namespace QuanLyBanHangQuaMang
{
    public partial class FrmMain : Form
    {
        bool a=true;
        BALayer.TinhTrangDon ttd = null;
        ThongTinNhanVien tt = null;
        MatHang1 mh = null;
        string TenNhanVien="";
        public FrmMain()
        {
            InitializeComponent();
            ttd = new BALayer.TinhTrangDon();
            mh = new MatHang1();
            tt = new ThongTinNhanVien();
            //DangNhap();
        }
        public void DangNhap(){
            Class1.mlogin = "1";
            Class1.password = "2";
            Class1.servername = "DESKTOP-VPRNUC5\\SQLEXPRESS";
            int c = Class1.Ketnoi();
            String strLenh = "select name from sys.sysusers where sid =SUSER_sID('" + Class1.mlogin + "')";
            Class1.myreader = Class1.ExecSqlDataReader(strLenh, Class1.connstr);
            Class1.myreader.Read();
            Class1.username = Class1.myreader.GetString(0);
        }
        public void LayTenNhanVien1()
        {
            string err = "";
            try
            {
                TenNhanVien = tt.LayTenNhanVien(ref err, Class1.username.ToString());
            }
            catch { MessageBox.Show(err); }
            
        }
        public void DayLenToolStrips()
        {
            
            if (Class1.mGroup.ToString() == "QUANLY")
            {
                tslTenNhanVien.Text = "QUẢN LÝ: " + TenNhanVien;
               
                rbAdmin.Visible = true;
                rbQLKH.Visible = true;
                rbQLDH.Visible = true;
                rbQLKho.Visible = true;
                rbQLDT.Visible = true;
                btnTinhTrangDon.Visible = true;
            }
            if (Class1.mGroup.ToString() == "NHANVIENBANHANG")
            {
                tslTenNhanVien.Text = "NHÂN VIÊN BÁN HÀNG: " + TenNhanVien;
                
                rbAdmin.Visible = false;
                rbQLKH.Visible = true;
                rbQLDH.Visible = true;
                rbQLKho.Visible = false;
                rbQLDT.Visible = true;
                btnTinhTrangDon.Visible = true;
            }

            if (Class1.mGroup.ToString() == "NHANVIENNHAPKHO")
            {
                tslTenNhanVien.Text = "NHÂN VIÊN NHẬP KHO: " + TenNhanVien;
               
                rbAdmin.Visible = false;
                rbQLKH.Visible = false;
                rbQLDH.Visible = false;
                rbQLKho.Visible = true;
                rbQLDT.Visible = false;
                btnTinhTrangDon.Visible = false;
            }
        }
        public void LoadData()
        {
            dgvTinhTrangDon.DataSource = ttd.LayTinhTrangDon();
            dgvKhoHang.DataSource = mh.LayMatHang();
            dgvKhoQua.DataSource = mh.LayQua();
        }
       
        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void dgvTinhTrangDon_Click(object sender, EventArgs e)
        {

        }

        private void btDSDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDonHang f = new FrmDanhSachDonHang();
            f.ShowDialog();
            LoadData();
        }

        private void navBarControl1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnTTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTinhTrangDon f = new FrmTinhTrangDon();
            f.ShowDialog();
            LoadData();
        }

        private void btnDSPS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachPhiShip f = new FrmDanhSachPhiShip();
            f.ShowDialog();
            LoadData();
        }

        private void btnDSHTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachHangTrongDon f = new FrmDanhSachHangTrongDon();
            f.MaDonHang = 0;
            f.ShowDialog();
            LoadData();
        }

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDSKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachKH f = new FrmDanhSachKH();
            f.ShowDialog();
            LoadData();
        }

        private void btnDSTQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDSGG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTongGiamGia f = new FrmTongGiamGia();
            f.ShowDialog();
            LoadData();
        }

        private void btnThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinCaNhan f = new FrmThongTinCaNhan();
            f.ShowDialog();
            LoadData();
        }

        private void btnDSGiamGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachKhuyenMai f = new FrmDanhSachKhuyenMai();
            f.ShowDialog();
            LoadData();
        }

   

        private void btnDSMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachMatHang f = new FrmDanhSachMatHang();
            f.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDSTQ_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTangQua1 f = new FrmTangQua1();
            f.ShowDialog();
            LoadData();
        }

        private void btnNhapMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapHang f = new FrmNhapHang();
            f.ShowDialog();
            LoadData();
        }

        private void ce_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void btnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapHang f = new FrmNhapHang();
            f.MaHang = "0";
            f.ShowDialog();
            LoadData();
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhanQuy f = new FrmPhanQuy();
            f.ShowDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CapNhatTrangThaiTK();
            DialogResult traloi = new DialogResult();
            traloi = MessageBox.Show("Thoát chương trình", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                    }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau f = new FrmDoiMatKhau();
            f.ShowDialog();
            if (f.tam==0)
            {
                Class1.mGroup = null;
                Class1.mlogin = null;
                Class1.myreader = null;
                Class1.password = null;
                Class1.username = null;
                FrmDangNhap f1 = new FrmDangNhap();
                this.Hide();
                f1.ShowDialog();
                
            }


        }
        public void CapNhatTrangThaiTK()
        {
            QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
            a = Boolean.Parse(dbs.F_LayTinhTrangTK(Class1.username).ToString());
            if (a == true)
            {
                try
                {
                    
                    dbs.SP_CapNhatTrangThaiTaiKhoan(Class1.username);
                    a = false;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }
        private void barButnItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CapNhatTrangThaiTK();
           if(a==false)
            {
                FrmDangNhap f = new FrmDangNhap();
                this.Hide();
                Class1.mGroup = "";
                Class1.mlogin = "";
                Class1.myreader = null;
                Class1.password = "";
                Class1.username = "";
                f.ShowDialog();
           }      
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult traloi = new DialogResult();
            traloi = MessageBox.Show("Thoát chương trình", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == true)
            {
                try
                {
                    QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
                    dbs.SP_CapNhatTrangThaiTaiKhoan(Class1.username);   
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            if (traloi == DialogResult.Yes)
            {

                Application.ExitThread();
            }
            
        }

        private void btnTinhTrangDon_Click(object sender, EventArgs e)
        {
            FrmThongTinDon f = new FrmThongTinDon();
            f.MaDonHang = 0;
            int r = 0;
            try
            {
                r = dgvTinhTrangDon.CurrentCell.RowIndex;
                f.MaDonHang = Int32.Parse(dgvTinhTrangDon.Rows[r].Cells[0].Value.ToString());
                f.ShowDialog();
            }
            catch { MessageBox.Show("Chưa chọn đơn hàng!!!"); }
           
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (Class1.password != "" && Class1.mlogin != "")
            {
                LoadData();
                LayTenNhanVien1();
                DayLenToolStrips();
            }
            else
            {
                FrmDangNhap f = new FrmDangNhap();
                this.Close();
                Class1.mGroup = "";
                Class1.mlogin = "";
                Class1.myreader = null;
                Class1.password = "";
                Class1.username = "";
                f.ShowDialog();
            }
        

        }

        private void btnDSLMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDSLMH f = new FrmDSLMH();
            f.ShowDialog();
            LoadData();
        }

        private void btnDTTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQLDTTN f = new FrmQLDTTN();
            f.ShowDialog();
        }

        private void btnChiTieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDSPhi f = new FrmDSPhi();
            f.ShowDialog();
            LoadData();
        }

        private void btnDTTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQLDTTT f = new FrmQLDTTT();
            f.ShowDialog();
            LoadData();
        }

        private void btnLoiNhuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLoiNhuan f = new FrmLoiNhuan();
            f.ShowDialog();
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
