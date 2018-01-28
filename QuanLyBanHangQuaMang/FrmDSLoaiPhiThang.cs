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
    public partial class FrmDSLoaiPhiThang : Form
    {
        DoanhThu dt = null;
        public FrmDSLoaiPhiThang()
        {
            dt = new DoanhThu();
            InitializeComponent();
        }
        int tam = 2;
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tam = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            textBox1.ResetText();
            textBox2.ResetText();
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
            if (textBox1.Text!="1" || textBox1.Text != "2" || textBox1.Text != "3" )
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
                        f = dt.XoaLoaiPhi(ref err, textBox1.Text.ToString());
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

            }
            else
            {
                MessageBox.Show("Loại Phí Này Không Được Xóa. Phí Mặc Định!!!");    
            }
            LoadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool f = false;
            string err = "";
            if (textBox1.Text != "" && textBox2.Text != "" && tam == 1)
            {

                f = dt.ThemLoaiPhi(ref err,textBox1.Text.ToString(), textBox2.Text.ToString());
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

                f = dt.SuaLoaiPhi(ref err, a1,textBox1.Text.ToString(), textBox2.Text.ToString());
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
        string a1 = "";

        private void FrmDSLoaiPhiThang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = dt.LayDSPhi();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
    }
}
