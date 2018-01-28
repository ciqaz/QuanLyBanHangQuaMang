namespace QuanLyBanHangQuaMang
{
    partial class FrmNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.cbMaHang = new System.Windows.Forms.ComboBox();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBanHangQuaMang1DataSet = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSet();
            this.deNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHangTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.MatHangTableAdapter();
            this.nhanVienTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.NhanVienTableAdapter();
            this.txtNguoiNhap = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLuu,
            this.btnHuy,
            this.btnTaiLai,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnNhapHang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(789, 141);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 1;
            this.btnLuu.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._3;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 2;
            this.btnHuy.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._4;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải Lại";
            this.btnTaiLai.Id = 3;
            this.btnTaiLai.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Apps_Accessibility_icon;
            this.btnTaiLai.Name = "btnTaiLai";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 4;
            this.btnThem.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._21;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 5;
            this.btnSua.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Contacts_icon__1_;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 6;
            this.btnXoa.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Books_icon3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Caption = "Nhập Hàng";
            this.btnNhapHang.Id = 7;
            this.btnNhapHang.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.DigitalColorMeter_icon;
            this.btnNhapHang.Name = "btnNhapHang";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThem, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHuy);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lưu - Hủy - Load ";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Location = new System.Drawing.Point(15, 253);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.Size = new System.Drawing.Size(754, 150);
            this.dgvNhapHang.TabIndex = 2;
            this.dgvNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellClick);
            // 
            // cbMaHang
            // 
            this.cbMaHang.DataSource = this.matHangBindingSource;
            this.cbMaHang.DisplayMember = "TenHang";
            this.cbMaHang.FormattingEnabled = true;
            this.cbMaHang.Location = new System.Drawing.Point(73, 181);
            this.cbMaHang.Name = "cbMaHang";
            this.cbMaHang.Size = new System.Drawing.Size(121, 21);
            this.cbMaHang.TabIndex = 5;
            this.cbMaHang.ValueMember = "MaHang";
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // quanLiBanHangQuaMang1DataSet
            // 
            this.quanLiBanHangQuaMang1DataSet.DataSetName = "QuanLiBanHangQuaMang1DataSet";
            this.quanLiBanHangQuaMang1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deNgayNhap
            // 
            this.deNgayNhap.EditValue = null;
            this.deNgayNhap.Enabled = false;
            this.deNgayNhap.Location = new System.Drawing.Point(73, 218);
            this.deNgayNhap.MenuManager = this.ribbonControl1;
            this.deNgayNhap.Name = "deNgayNhap";
            this.deNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayNhap.Size = new System.Drawing.Size(121, 20);
            this.deNgayNhap.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(317, 218);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(317, 177);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(121, 20);
            this.txtSL.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Người Nhập";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // txtNguoiNhap
            // 
            this.txtNguoiNhap.Enabled = false;
            this.txtNguoiNhap.Location = new System.Drawing.Point(574, 177);
            this.txtNguoiNhap.Name = "txtNguoiNhap";
            this.txtNguoiNhap.Size = new System.Drawing.Size(121, 20);
            this.txtNguoiNhap.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 406);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslTenNhanVien
            // 
            this.tslTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tslTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tslTenNhanVien.Name = "tslTenNhanVien";
            this.tslTenNhanVien.Size = new System.Drawing.Size(40, 22);
            this.tslTenNhanVien.Text = "null";
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 431);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtNguoiNhap);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.deNgayNhap);
            this.Controls.Add(this.cbMaHang);
            this.Controls.Add(this.dgvNhapHang);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmNhapHang";
            this.Text = "FrmNhapHang";
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnNhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.ComboBox cbMaHang;
        private DevExpress.XtraEditors.DateEdit deNgayNhap;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.TextBox txtNguoiNhap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}