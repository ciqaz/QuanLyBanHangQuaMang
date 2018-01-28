using DALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangQuaMang
{
    public partial class FrmA : Form
    {
        public FrmA()
        {
            InitializeComponent();
        }

        private void ce_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void btnTinhTrangDon_Click(object sender, EventArgs e)
        {

        }

        private void FrmA_Load(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult traloi = new DialogResult();
            traloi = MessageBox.Show("Thoát chương trình", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            f.ShowDialog();
        }

        private void FrmA_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult traloi = new DialogResult();
            traloi = MessageBox.Show("Thoát chương trình", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
        
}
