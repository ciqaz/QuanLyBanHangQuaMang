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
    public partial class FrmNhapHang : Form
    {
        MatHang1 mh = new MatHang1();
        
        public FrmNhapHang()
        {
            InitializeComponent();
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
           
            LoadData();
        }
        public string MaHang { get; set; }
        public void LoadData()
        {
            cbMaHang.DataSource = mh.LayMatHang();
            cbMaHang.DisplayMember = "TenHang";
            cbMaHang.ValueMember = "MaHang";
            txtNguoiNhap.Text = Class1.username;
           
            if (MaHang.ToString()!= "0")
            {
                cbMaHang.SelectedValue = MaHang;
            }
            else
            {
                cbMaHang.Text = "";
            }
            dgvNhapHang.DataSource = mh.LayNhapHang();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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

        private void ceQua_CheckedChanged(object sender, EventArgs e)
        {
          
            
        }

        private void ceHang_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        int tam = 2;
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtDonGia.ResetText();
            txtSL.ResetText();
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
                int r = dgvNhapHang.CurrentCell.RowIndex;
                DialogResult traloi;
                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    f = mh.XoaNhapHang(ref err, Int32.Parse(dgvNhapHang.Rows[r].Cells[0].Value.ToString()));
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
                MessageBox.Show("Chứ chọn đối tượng!!!");
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
            if (txtDonGia.Text != "" && txtSL.Text != "" && tam == 1)
            {
                f = mh.ThemNhapHang(ref err, cbMaHang.SelectedValue.ToString(), Int32.Parse(txtSL.Text.ToString()), Class1.username.ToString(), Decimal.Parse(txtDonGia.Text.ToString()));
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show(" Chưa thêm được !\n\r" + "Lỗi:" + err);
                }
                
            }
            if (txtDonGia.Text != "" && txtSL.Text != "" && tam == 0)
            {

                int r = dgvNhapHang.CurrentCell.RowIndex;

                f = mh.SuaNhapHang(ref err, Int32.Parse(dgvNhapHang.Rows[r].Cells[0].Value.ToString()), cbMaHang.SelectedValue.ToString(), Int32.Parse(txtSL.Text.ToString()), Class1.username.ToString(), Decimal.Parse(txtDonGia.Text.ToString()));
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

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhapHang.CurrentCell.RowIndex;
            cbMaHang.SelectedValue = dgvNhapHang.Rows[r].Cells[1].Value.ToString();
            txtDonGia.Text = dgvNhapHang.Rows[r].Cells[5].Value.ToString();
            txtSL.Text = dgvNhapHang.Rows[r].Cells[3].Value.ToString();
            txtNguoiNhap.Text= dgvNhapHang.Rows[r].Cells[4].Value.ToString();
            deNgayNhap.Text= dgvNhapHang.Rows[r].Cells[2].Value.ToString();
        }
    }
}
