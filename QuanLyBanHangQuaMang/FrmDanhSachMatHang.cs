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
    public partial class FrmDanhSachMatHang : Form
    {
        MatHang1 mh = null;
        int tam = 2;

        public FrmDanhSachMatHang()
        {
            InitializeComponent();
            mh = new MatHang1();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {}

        private void FrmDanhSachMatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = new DataTable();
            cbLoaiHang.DataSource = mh.LayLoaiMatHang();
            cbLoaiHang.DisplayMember = "TenLoaiSanPham";
            cbLoaiHang.ValueMember = "LoaiID";
            cbLoaiHang.Text = "";
            dgvDSMH.DataSource = mh.LayTatCa();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
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
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDSMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSMH.CurrentCell.RowIndex;
            txtMaMatHang.Text = dgvDSMH.Rows[r].Cells[0].Value.ToString();
            cbLoaiHang.SelectedValue= dgvDSMH.Rows[r].Cells[1].Value.ToString();
            txtTenMatHang.Text= dgvDSMH.Rows[r].Cells[2].Value.ToString();
            rtbThongTinHang.Text= dgvDSMH.Rows[r].Cells[3].Value.ToString();
            txtDonGia.Text = dgvDSMH.Rows[r].Cells[4].Value.ToString();
            txtSL.Text = dgvDSMH.Rows[r].Cells[5].Value.ToString();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaMatHang.ResetText();
            txtDonGia.ResetText();
            txtTenMatHang.ResetText();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                bool f = false;
                string err = "";
                int r = dgvDSMH.CurrentCell.RowIndex;
                DialogResult traloi;
                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    f = mh.XoaMatHang(ref err, dgvDSMH.Rows[r].Cells[0].Value.ToString());
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
                MessageBox.Show("Chưa chọn hàng cần xóa!!!");
            }
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            if (txtMaMatHang.Text!="" &&txtTenMatHang.Text!=""&&txtDonGia.Text!=""&&tam==1)
            {
                f = mh.ThemMatHang(ref err, txtMaMatHang.Text.ToString(), cbLoaiHang.SelectedValue.ToString(), txtTenMatHang.Text.ToString(), Decimal.Parse(txtDonGia.Text.ToString()), rtbThongTinHang.Text.ToString());
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }
            }
            if (txtMaMatHang.Text != "" && txtTenMatHang.Text != "" && txtDonGia.Text != "" && tam == 0)
            {
                

                 f = mh.SuaMatHang(ref err, txtMaMatHang.Text.ToString(), cbLoaiHang.SelectedValue.ToString(), txtTenMatHang.Text.ToString(), Decimal.Parse(txtDonGia.Text.ToString()), rtbThongTinHang.Text.ToString());
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

        private void btnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapHang f = new FrmNhapHang();
            try
            {
                int r = dgvDSMH.CurrentCell.RowIndex;
                f.MaHang = dgvDSMH.Rows[r].Cells[0].Value.ToString();
                f.ShowDialog();
                LoadData();
            }
            catch
            {
                MessageBox.Show("Chưa chọn mặt hàng!!!");
            }
            LoadData();
        }

        private void btnThemLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDSLMH f = new FrmDSLMH();
            f.ShowDialog();
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            if (txtTenMatHang.Text != "")
                try
                {
                    QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext();
                    dgvDSMH.DataSource = dbs.SP_TimMatHang(txtTenMatHang.Text.Trim());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            else MessageBox.Show("Chưa gõ tên");
        }

    }
}
