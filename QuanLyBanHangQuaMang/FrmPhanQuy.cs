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
    public partial class FrmPhanQuy : Form
    {
        BALayer.PhanQuyen pq = null;
        public FrmPhanQuy()
        {
            pq = new BALayer.PhanQuyen();
            InitializeComponent();
        }

        private void FrmPhanQuy_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgvNV.DataSource = pq.LayNV();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
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
        int tam = 2;

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 0;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int r = dgvNV.CurrentCell.RowIndex;
                bool f = false;
                string err = "";
                DialogResult traloi;

                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    int r1 = dgvNV.CurrentCell.RowIndex;
                    f = pq.XoaNV(ref err, dgvNV.Rows[r].Cells[0].Value.ToString());
                    if (f)
                    {
                        MessageBox.Show("Đã Xóa xong!");

                    }
                    else
                    {
                        MessageBox.Show(" Chưa xóa được: !\n\r" + "Lỗi:" + err);

                    }

                }


            }
            catch
            {
                MessageBox.Show("Chưa chọn đối tượng!!!!");
            }

            LoadData();
        }

        public void ThemNV()
        {
           
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            if (txtMaNV.Text!="" &&txtDiaChi.Text!=""&&txtMK.Text!=""&&txtSDT.Text!=""&&txtTenNhanVien.Text!=""&txtTenTK.Text!="" &&tam==1)
            {
                string quyen="";
                if (ceBH.Checked == true &&ceQL.Checked==false &&ceNhapKho.Checked==false)
                    quyen = "NHANVIENBANHANG";
                if (ceBH.Checked == false && ceQL.Checked == true && ceNhapKho.Checked == false)
                    quyen = "QUANLY";
                if (ceBH.Checked == false && ceQL.Checked == false && ceNhapKho.Checked == true)
                    quyen = "NHANVIENNHAPKHO";
                if(quyen!="")
                {
                    f = pq.ThemNV(ref err, txtMaNV.Text.ToString().Trim(), txtTenNhanVien.Text.ToString(), txtDiaChi.Text.ToString(), txtSDT.Text.ToString(), txtTenTK.Text.ToString(), txtMK.Text.ToString(), quyen.ToString());
                }
                if (f == true)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Chưa thêm được!!"+err);

            }
            if(txtMaNV.Text != "" && txtDiaChi.Text != "" && txtMK.Text != "" && txtSDT.Text != "" && txtTenNhanVien.Text != "" & txtTenTK.Text != "" && tam == 0)
            {
                string quyen = "";
                if (ceBH.Checked == true && ceQL.Checked == false && ceNhapKho.Checked == false)
                    quyen = "NHANVIENBANHANG";
                if (ceBH.Checked == false && ceQL.Checked == true && ceNhapKho.Checked == false)
                    quyen = "QUANLY";
                if (ceBH.Checked == false && ceQL.Checked == false && ceNhapKho.Checked == true)
                    quyen = "NHANVIENNHAPKHO";
                string MaNV = txtMaNV.Text;
                string Ten = txtTenNhanVien.Text;
                string DiaChi = txtDiaChi.Text;
                string SDT = txtSDT.Text;
                string TK = txtTenTK.Text;
                string MK = txtMK.Text;
                string err1 = "";
                    bool a = pq.XoaNV(ref err1, txtMaNV.Text.ToString().Trim());
                if (a == true)
                {
                    bool b = pq.ThemNV(ref err, MaNV.Trim(), Ten.Trim(), DiaChi.Trim(), SDT.Trim(), TK.Trim(), MK.Trim(), quyen.Trim());
                    if (b == true)
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Chưa sửa được" + err);
                    tam = 2;
                }
                else
                {
                    MessageBox.Show("Chưa sửa được!!!" + err1);
                }
            }
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNV.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
            txtTenNhanVien.Text= dgvNV.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text= dgvNV.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text= dgvNV.Rows[r].Cells[3].Value.ToString();
            txtTenTK.Text= dgvNV.Rows[r].Cells[4].Value.ToString();
            txtMK.Text= dgvNV.Rows[r].Cells[5].Value.ToString();
            if (dgvNV.Rows[r].Cells[6].Value.ToString().Trim() == "NHANVIENBANHANG")
            { ceBH.Checked = true;
                ceQL.Checked = false;
                ceNhapKho.Checked = false;

            }
            if (dgvNV.Rows[r].Cells[6].Value.ToString().Trim() == "NHANVIENNHAPKHO")
            {
                ceBH.Checked = false;
                ceQL.Checked = false;
                ceNhapKho.Checked = true;

            }
            if (dgvNV.Rows[r].Cells[6].Value.ToString().Trim() == "QUANLY")
            {
                ceBH.Checked = false;
                ceQL.Checked = true;
                ceNhapKho.Checked = false;

            }
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text != "")
                try
                {
                    QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext();
                    dgvNV.DataSource = dbs.SP_TimNV(txtTenNhanVien.Text.Trim());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            else MessageBox.Show("Chưa gõ tên");
        }
    }
}
