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
    public partial class FrmDanhSachPhiShip : Form
    {
        PhiShip ps = null;
        public FrmDanhSachPhiShip()
        {
            ps = new PhiShip();
            InitializeComponent();
        }

        private void FrmDanhSachPhiShip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiBanHangQuaMang1DataSet.PhiShipSP' table. You can move, or remove it, as needed.
            // this.phiShipSPTableAdapter.Fill(this.quanLiBanHangQuaMang1DataSet.PhiShipSP);
            LoadData();
        }
        public void LoadData()
        {
            if(MaDonHang.ToString()!="0")
                dgvDSPS.DataSource = ps.LayPhiShipTheoMa(MaDonHang);
            else
                dgvDSPS.DataSource = ps.LayPhiShip();
            txtMaDonHang.Text = MaDonHang.ToString();
            btnSua.Enabled = true;
            btnluu.Enabled = false;
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
        public int MaDonHang { get; set; }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnluu.Enabled = true;
        }
        int tam = 0;

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string err = "";
            bool f = false ;
            if (tam == 1 && txtDonGia.ToString() != null)
            {
               f = ps.SuaPhiShip(ref err, Int32.Parse(txtMaDonHang.Text.ToString()), decimal.Parse(txtDonGia.Text.ToString()));
            }
            if (f)
            {
                MessageBox.Show("Đã sửa xong!");
            }
            else
            {
                MessageBox.Show(" Chưa sửa được !\n\r" + "Lỗi:" + err);
            }
            LoadData();
        }

        private void dgvDSPS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSPS.CurrentCell.RowIndex;
            txtMaDonHang.Text = dgvDSPS.Rows[r].Cells[0].Value.ToString();
            txtDonGia.Text= dgvDSPS.Rows[r].Cells[2].Value.ToString();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }


    }
}
