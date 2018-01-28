using System;
using System.Data;
using System.Windows.Forms;
using DALayer;
namespace QuanLyBanHangQuaMang
{
    public partial class FrmDangNhap : Form
    {
        bool a ;
        bool b ;
        //QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext();
        public FrmDangNhap()
        {
            
            InitializeComponent();
        }
       // public static string tennv;
        public static string nhom;
        DataTable dt = new DataTable();
        public static string server;
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            
            /* try
             {
                 RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                 RegistryKey rk = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");
                 foreach (string ex in rk.GetValueNames())
                 {
                     if (ex == "MSSQLSERVER")
                     {
                         server = (System.Environment.MachineName);
                         cbServer.Items.Add(ex);
                     }
                     else
                     {
                         cbServer.Items.Add(ex);
                         MessageBox.Show("Lỗi!!!");
                     }

                 }
                       //}
             //catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            // }*/
            cbServer.Items.Add("DESKTOP-VPRNUC5\\SQLEXPRESS");
            cbServer.Items.Add("JB\\ASUS");
            cbServer.SelectedIndex = 0;
        }
        
        private void btnDN_Click(object sender, EventArgs e)
        {
            Class1.mlogin = txtTenDN.Text.Trim();
            Class1.password = txtMK.Text.Trim();
            Class1.servername = cbServer.Text.Trim();
            int c = Class1.Ketnoi();
            if (c == 0)
            {
                MessageBox.Show("Không thể vào được tài khoản này! Kiểm tra lại thông tin nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
               
            }

            String strLenh = "select name from sys.sysusers where sid =SUSER_sID('" + Class1.mlogin + "')";
            Class1.myreader = Class1.ExecSqlDataReader(strLenh, Class1.connstr);
            Class1.myreader.Read();
            Class1.username = Class1.myreader.GetString(0);
            KTTrangThaiTK();
            if (a == false)
            {
                if (Convert.IsDBNull(Class1.username))
                {
                    MessageBox.Show("Bạn không có quyền truy câp vào dữ liệu");
                    return;
                }
                Class1.myreader.Close();
                strLenh = "sp_helpuser '" + Class1.username + "'";
                // tra ve username group loginname dbname userid sid
                try
                {
                    Class1.myreader = Class1.ExecSqlDataReader(strLenh, Class1.connstr);

                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Mã nhân viên chưa có quyền truy cập");
                    return;
                }

                if (Class1.myreader.Read())
                {
                    Class1.mGroup = Class1.myreader.GetString(1);
                }
                else
                {
                    MessageBox.Show("Lỗi xác định user");
                }
                Class1.myreader.Close();
                nhom = Class1.mGroup;
                FrmMain fr = new FrmMain();
                this.Hide();
                fr.ShowDialog();
            }
        }
        public void KTTrangThaiTK()
        {
            
            QuanLyBanHangQuaMangDataContext dbs = new QuanLyBanHangQuaMangDataContext(Class1.connstr);
            //a = Boolean.Parse(dbs.F_LayTinhTrangTK(Class1.username).ToString());
            //if (a == true)
            //{

            //    MessageBox.Show("Tài khoản này đang được sử dụng. Vui lòng kiểm tra lại", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
                
            //else
            {
                try
                {
                    dbs.SP_CapNhatTrangThaiTaiKhoan(Class1.username);      
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = new DialogResult();
            traloi = MessageBox.Show("Thoát chương trình", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                this.Close();
                temp = true;
            }
        }
        bool temp = false;
        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDN_Click(null,null);
        }
        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (temp != true)
            {
                DialogResult traloi = new DialogResult();
                traloi = MessageBox.Show("Thoát chương trình", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    this.Close();
                    temp = true;
                }
            }
           
            
        }

        private void FrmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
