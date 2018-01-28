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
    public partial class FrmTinhTrangDon : Form
    {
        int tam = 0;
        BALayer.TinhTrangDon tt = null;
        public FrmTinhTrangDon()
        {
            tt = new BALayer.TinhTrangDon();
            InitializeComponent();
        }

        private void FrmTinhTrangDon_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void cbMaDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt= tt.LayTinhTrangDon();
            cbMaDonHang.DataSource = dt;
            cbMaDonHang.DisplayMember = "MaDonHang";
            cbMaDonHang.ValueMember = "MaDonHang";
            dgvTinhTrangDon.DataSource = tt.LayTinhTrangDon();
            btnLuu.Enabled = false;
           /* try
            {
                int r = dgvTinhTrangDon.CurrentCell.RowIndex;
                if (dgvTinhTrangDon.Rows[r].Cells[2].Value.ToString() == "Chưa Xác Nhận")
                {
                    cbChuaNhan.Checked = true;
                    cbDaNhan.Checked = false;
                    cbBiHuy.Checked = false;
                }
                if (dgvTinhTrangDon.Rows[r].Cells[2].Value.ToString() == "Đã Xác Nhận")
                {
                    cbChuaNhan.Checked = false;
                    cbDaNhan.Checked = true;
                    cbBiHuy.Checked = false;
                }
                if (dgvTinhTrangDon.Rows[r].Cells[2].Value.ToString() == "Đã Hủy")
                {
                    cbChuaNhan.Checked = false;
                    cbDaNhan.Checked = false;
                    cbBiHuy.Checked = true;
                }
            }
            catch(Exception e) {
                // MessageBox.Show("Chưa có đơn hàng nào chọn");
                MessageBox.Show(e.Message);
                this.Close();
            }*/

            LayTenNhanVien();
            DayLenToolStrips();
        }
        string TenNhanVien;
        ThongTinNhanVien tt1 = new ThongTinNhanVien();
        public void LayTenNhanVien()
        {
            string err = "";
            TenNhanVien = tt1.LayTenNhanVien(ref err, Class1.username);
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

        private void dgvTinhTrangDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTinhTrangDon.CurrentCell.RowIndex;
            cbMaDonHang.SelectedValue = dgvTinhTrangDon.Rows[r].Cells[0].Value;
            if (dgvTinhTrangDon.Rows[r].Cells[2].Value.ToString()== "Chưa Xác Nhận")
            {
                cbChuaNhan.Checked = true;
                cbDaNhan.Checked = false;
                cbBiHuy.Checked = false;
            }
            if (dgvTinhTrangDon.Rows[r].Cells[2].Value.ToString() == "Đã Xác Nhận")
            {
                cbChuaNhan.Checked =false ;
                cbDaNhan.Checked = true;
                cbBiHuy.Checked = false;
            }
            if (dgvTinhTrangDon.Rows[r].Cells[2].Value.ToString() == "Đã Hủy")
            {
                cbChuaNhan.Checked = false;
                cbDaNhan.Checked = false;
                cbBiHuy.Checked = true;
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            bool f=false;
            string err="";
            if(tam==1)
            {
                if((cbChuaNhan.Checked == true&& cbDaNhan.Checked == false && cbBiHuy.Checked == false)||
                   (cbChuaNhan.Checked == false && cbDaNhan.Checked == true && cbBiHuy.Checked == false)||
                   (cbChuaNhan.Checked == false && cbDaNhan.Checked == false && cbBiHuy.Checked == true))
                {
                    if (cbChuaNhan.Checked == true)
                      f= tt.SuaTinhTrangDon(ref err,Int32.Parse(cbMaDonHang.SelectedValue.ToString()), 0);
                    if (cbDaNhan.Checked == true)
                      f= tt.SuaTinhTrangDon(ref err, Int32.Parse(cbMaDonHang.SelectedValue.ToString()), 2);
                    if (cbBiHuy.Checked == true)
                      f= tt.SuaTinhTrangDon(ref err, Int32.Parse(cbMaDonHang.SelectedValue.ToString()), -2);

                    if (f)
                    {
                        MessageBox.Show("Đã sửa xong!");
                    }
                    else
                    {
                        MessageBox.Show(" Chưa sửa được !\n\r" + "Lỗi:" + err);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ Liệu Không Hợp Lệ!!!!");
                }

            }
            LoadData();
            btnSua.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            tam = 1;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            btnSua.Enabled = true ;
        }

        private void cbDaNhan_CheckedChanged(object sender, EventArgs e)
        {
            cbBiHuy.Checked = false;
            cbChuaNhan.Checked = false;
        }

        private void cbBiHuy_CheckedChanged(object sender, EventArgs e)
        {
            cbDaNhan.Checked = false;
            cbChuaNhan.Checked = false;
        }

        private void cbChuaNhan_CheckedChanged(object sender, EventArgs e)
        {
            cbBiHuy.Checked = false;
            cbDaNhan.Checked = false;
        }

        private void dgvTinhTrangDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
