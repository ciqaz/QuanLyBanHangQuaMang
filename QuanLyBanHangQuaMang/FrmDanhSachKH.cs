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
    public partial class FrmDanhSachKH : Form
    {
        int tam = 2;
        bool f;
        string err = "";
        BALayer.KhachHang kh = null;
        public FrmDanhSachKH()
        {
            InitializeComponent();
            kh = new BALayer.KhachHang();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if ( txtTen.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" &&tam==1)
            {

                f = kh.ThemKhachHang(ref err,txtTen.Text,txtSDT.Text,txtDiaChi.Text);
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }

            }
            if (tam == 0)
            {
                int r = dgvDSKH.CurrentCell.RowIndex;

                f = kh.SuaKhachHang(ref err, Int32.Parse(dgvDSKH.Rows[r].Cells[0].Value.ToString()), txtTen.Text, txtSDT.Text, txtDiaChi.Text);
                if (f)
                {
                    MessageBox.Show("Đã sửa xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa sửa được !\n\r" + "Lỗi:" + err);
                }
            }
            LoadData();
            
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTen.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            LoadData();
        }

        private void FrmThemKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
           
            dgvDSKH.DataSource = kh.LayKhachHang();
            KH();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSKH.CurrentCell.RowIndex;
            txtTen.Text = dgvDSKH.Rows[r].Cells[1].Value.ToString();
            txtSDT.Text = dgvDSKH.Rows[r].Cells[2].Value.ToString();
            txtDiaChi.Text= dgvDSKH.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            txtTen.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            VHH();
        }
        public void VHH()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        public void KH()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            VHH();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VHH();
            try
            {
                int r = dgvDSKH.CurrentCell.RowIndex;
                DialogResult traloi;
                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    f = kh.XoaKhachHang(ref err, Int32.Parse(dgvDSKH.Rows[r].Cells[0].Value.ToString()));
                    if (f)
                    {
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show(" Chưa xóa được !\n\r" + "Lỗi:" + err);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Chưa chọn KH");
            }

            LoadData();
        }
        
        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTen.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            LoadData();
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
                try
                {
                    QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext();
                    dgvDSKH.DataSource = dbs.SP_TimKH(txtTen.Text.Trim());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            else MessageBox.Show("Chưa gõ tên");   

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
