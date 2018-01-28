using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using DALayer;

namespace QuanLyBanHangQuaMang
{
    public partial class FrmThongTinDon : Form
    {
        BALayer.DonHang dh = null;
        public FrmThongTinDon()
        {
            dh = new BALayer.DonHang();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmThongTinDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {

                if (MaDonHang.ToString() != "0")
                {
                try
                {
                    dgvDonHang.DataSource = dh.F_LoadDonHang(MaDonHang);
                    dgvHoaDon.DataSource = dh.F_LoadHoaDon(MaDonHang);
                    dgvTangQua.DataSource = dh.F_LoadTangQua(MaDonHang);
                    dgvGiamGia.DataSource = dh.F_LoadGiamGia(MaDonHang);
                    LoadLenGroup();
                }
                catch { MessageBox.Show("Không Load "); }
                   
                }
            LayTenNhanVien();
            DayLenToolStrips();
        }
        string TenNhanVien;
        ThongTinNhanVien tt = new ThongTinNhanVien();
        public void LayTenNhanVien()
        {
            string err = "";
            TenNhanVien = tt.LayTenNhanVien(ref err, Class1.username);
        }
        public void DayLenToolStrips()
        {

            if (Class1.mGroup.ToString() == "QUANLY")
                tslTenNhanVien.Text = "QUẢN LÝ: " + TenNhanVien;
            if (Class1.mGroup.ToString() == "NHANVIENBANHANG")
            {
                tslTenNhanVien.Text = "NHÂN VIÊN BÁN HÀNG: " + TenNhanVien;

            }

            if (Class1.mGroup.ToString() == "NHANVIENNHAPKHO")
            {
                tslTenNhanVien.Text = "NHÂN VIÊN NHẬP KHO: " + TenNhanVien;

            }
        }
        public void LoadLenGroup()
        {
            
            txtMaDon.Text = dgvDonHang.Rows[0].Cells[0].Value.ToString();
            txtTenKH.Text= dgvDonHang.Rows[0].Cells[1].Value.ToString();
            deNgayDat.Text= dgvDonHang.Rows[0].Cells[2].Value.ToString();
            cbNoiThanh.Checked = Boolean.Parse( dgvDonHang.Rows[0].Cells[3].Value.ToString());
            deNgayChuyen.Text= dgvDonHang.Rows[0].Cells[4].Value.ToString();
            txtPhiShip.Text= Decimal.Truncate(Decimal.Parse(dgvDonHang.Rows[0].Cells[5].Value.ToString())).ToString();
            txtGiaTri.Text= Decimal.Truncate(Decimal.Parse(dgvDonHang.Rows[0].Cells[6].Value.ToString())).ToString();
            txtNhanVien.Text= dgvDonHang.Rows[0].Cells[7].Value.ToString();
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        public int MaDonHang { get; set; }

        private void btnDenDanhSachDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDonHang f = new FrmDanhSachDonHang();
            
            f.ShowDialog();
        }

        private void btnVeTrangChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTinhTrangDon f = new FrmTinhTrangDon();
            f.ShowDialog();
        }
    }
}
