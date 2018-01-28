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
    public partial class FrmDSPhi : Form
    {
        DoanhThu dt = null;
        public FrmDSPhi()
        {
            dt = new DoanhThu();
            InitializeComponent();
        }

        private void FrmDSPhi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtTongTien.Enabled = true;
            dataGridView1.DataSource = dt.TimPhi();
            DataTable dt1 = null;
            dt1 = new DataTable();
            dt1 = dt.LayDSPhi();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "TenPhi";
            comboBox1.ValueMember = "MaPhi";
            tam = 2;
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
            DateTime a = DateTime.Now;
            txtTHang.Text = a.Month.ToString();
            txtNam.Text = a.Year.ToString();
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
            bool f = false;
            string err = "";
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                
                DialogResult traloi;
                traloi = MessageBox.Show("Có muốn xóa không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    f = dt.XoaPhiThang(ref err, Int32.Parse(dataGridView1.Rows[r].Cells[0].Value.ToString()), Int32.Parse(dataGridView1.Rows[r].Cells[1].Value.ToString()),comboBox1.SelectedValue.ToString());
                    
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
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
               // MessageBox.Show("Chưa chọn ");
            }

            LoadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            if (txtTongTien.Text != "" &&  tam == 1)
            {
                f = dt.ThemPhiThang(ref err, Int32.Parse(txtTHang.Text.Trim()), Int32.Parse(txtNam.Text.Trim()),comboBox1.SelectedValue.ToString(),Decimal.Parse(txtTongTien.Text.ToString()));
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
                int r = dataGridView1.CurrentCell.RowIndex;

                f = dt.SuaPhiThang(ref err, Int32.Parse(txtTHang.Text.Trim()), Int32.Parse(txtNam.Text.Trim()),comboBox1.SelectedValue.ToString(),a,Decimal.Parse(txtTongTien.Text.ToString()));
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTHang.Text != "" && txtNam.Text != "")
                try
                { dataGridView1.DataSource = dt.TimPhiTheoThang(DateTime.Parse("1-" + txtTHang.Text.Trim() + "-" + txtNam.Text.Trim()));
                    txtTHang.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txtNam.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    comboBox1.SelectedValue = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtTongTien.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString())).ToString(); }
                catch { MessageBox.Show("Chưa có phí"); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtTHang.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtNam.Text= dataGridView1.Rows[r].Cells[1].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtTongTien.Text = Decimal.Truncate(Decimal.Parse(dataGridView1.Rows[r].Cells[3].Value.ToString())).ToString();
            a = dataGridView1.Rows[r].Cells[2].Value.ToString();
        }
        string a;
        private void btnDSLP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDSLoaiPhiThang f = new FrmDSLoaiPhiThang();
            f.ShowDialog();
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           

        }
        public void TinhTienPhiMacDinh()
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void omboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if ((comboBox1.Text.Trim() == "Phí Mua Hàng" || comboBox1.Text.Trim() == "Phí Quà") && (tam == 1 || tam == 0))
            {

                txtTongTien.Enabled = false;
                MessageBox.Show("Phí này sẽ được hệ thống tính");
                if (comboBox1.Text.Trim() == "Phí Mua Hàng")
                    txtTongTien.Text = dt.LayTongPhiMuaHang(Int32.Parse(txtTHang.Text), Int32.Parse(txtNam.Text)).ToString();
                if (comboBox1.Text.Trim() == "Phí Quà")
                    txtTongTien.Text = dt.LayTongPhiMuaQua(Int32.Parse(txtTHang.Text), Int32.Parse(txtNam.Text)).ToString();
            }
            else
            {
                txtTongTien.Enabled = true;
            }
        }

        private void btnTinhLoiNhuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            txtTongTien.Enabled = false;
            comboBox1.Enabled = false;
            if (txtTHang.Text != "" && txtNam.Text!="")
            {
                f = dt.TinhLoiNhuan(ref err,Int32.Parse(txtTHang.Text), Int32.Parse(txtNam.Text));
                if (f)
                {
                    MessageBox.Show("Đã tính xong!");
                    txtTongTien.Enabled = true;
                    comboBox1.Enabled = true;
                }
                else
                {
                    MessageBox.Show(" Chưa tính được !\n\r" + "Lỗi:" + err);
                    txtTongTien.Enabled = true;
                    comboBox1.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn tháng và năm");
                txtTongTien.Enabled = true;
                comboBox1.Enabled = true;
            }
        }
    }
}
