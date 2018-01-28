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
    public partial class FrmDSLMH : Form
    {
        
        MatHang1 mh = null;
        public FrmDSLMH()
        {
            mh = new MatHang1();
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            txtMa.ResetText();
            txtTen.ResetText();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        int tam = 2;
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string err = "";
                bool f = false;
                DialogResult traloi;

                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    int r = dgvDSLMH.CurrentCell.RowIndex;

                    f = mh.XoaLoaiMatHang(ref err, dgvDSLMH.Rows[r].Cells[0].Value.ToString());
                    if (f)
                    {
                        MessageBox.Show("Đã Xóa xong!");

                    }
                    else
                    {
                        MessageBox.Show(" Chưa Xóa được !\n\r" + "Lỗi:" + err);

                    }

                }
            }
            catch { MessageBox.Show("Chưa chọn đối tượng!!"); }
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            
        }
        string b = "";
        string a = "";
        public void LoadData()
        {
            dgvDSLMH.DataSource = mh.LayLoaiMatHang();
            tam = 2;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMa.ResetText();
            txtTen.ResetText();
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
        private void FrmDSLMH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string err = "";
            bool f = false;
            int r = dgvDSLMH.CurrentCell.RowIndex;
            if (txtMa.Text != "" && txtTen.Text != null  && tam ==0)
            {
                f = mh.ThemLoaiMatHang(ref err, txtMa.Text.ToString(), txtTen.Text.ToString());
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }

            }
            if (txtMa.Text != "" && txtTen.Text != null  && tam == 1)
            {

                f = mh.SuaLoaiMatHang(ref err, txtMa.Text.ToString().Trim(),a.Trim(), txtTen.Text.ToString().Trim());
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

        private void dgvDSLMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSLMH.CurrentCell.RowIndex;
            txtMa.Text = dgvDSLMH.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dgvDSLMH.Rows[r].Cells[1].Value.ToString();
            if (dgvDSLMH.Rows[r].Cells[0].Value.ToString() == "Q")
                btnXoa.Enabled = false;
            else
                btnXoa.Enabled = true;
            a = txtMa.Text;
            b = txtTen.Text;
        }
    }
}
