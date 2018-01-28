namespace QuanLyBanHangQuaMang
{
    partial class FrmQLDTTN
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
            this.btnQLDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDenTTD = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deNgay = new DevExpress.XtraEditors.DateEdit();
            this.quanLiBanHangQuaMang1DataSet = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSet();
            this.tongTienNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tongTienNgayTableAdapter = new QuanLyBanHangQuaMang.QuanLiBanHangQuaMang1DataSetTableAdapters.TongTienNgayTableAdapter();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtTT = new DevExpress.XtraEditors.TextEdit();
            this.la = new System.Windows.Forms.Label();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.dgvTTN = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongTienNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTN)).BeginInit();
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
            this.btnQLDH,
            this.btnDenTTD});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(489, 141);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 1;
            this.btnLuu.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._3;
            this.btnLuu.Name = "btnLuu";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 2;
            this.btnHuy.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._4;
            this.btnHuy.Name = "btnHuy";
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
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 5;
            this.btnSua.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Contacts_icon__1_;
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 6;
            this.btnXoa.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources.Books_icon3;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnQLDH
            // 
            this.btnQLDH.Caption = "Đến QL Đơn Hàng";
            this.btnQLDH.Id = 7;
            this.btnQLDH.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._31;
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLDH_ItemClick);
            // 
            // btnDenTTD
            // 
            this.btnDenTTD.Caption = "Đến Tình Trạng Đơn";
            this.btnDenTTD.Id = 8;
            this.btnDenTTD.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._4;
            this.btnDenTTD.Name = "btnDenTTD";
            this.btnDenTTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDenTTD_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQLDH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thao Tác";
            // 
            // deNgay
            // 
            this.deNgay.EditValue = null;
            this.deNgay.Location = new System.Drawing.Point(100, 160);
            this.deNgay.MenuManager = this.ribbonControl1;
            this.deNgay.Name = "deNgay";
            this.deNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Size = new System.Drawing.Size(134, 20);
            this.deNgay.TabIndex = 2;
            // 
            // quanLiBanHangQuaMang1DataSet
            // 
            this.quanLiBanHangQuaMang1DataSet.DataSetName = "QuanLiBanHangQuaMang1DataSet";
            this.quanLiBanHangQuaMang1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tongTienNgayBindingSource
            // 
            this.tongTienNgayBindingSource.DataMember = "TongTienNgay";
            this.tongTienNgayBindingSource.DataSource = this.quanLiBanHangQuaMang1DataSet;
            // 
            // tongTienNgayTableAdapter
            // 
            this.tongTienNgayTableAdapter.ClearBeforeFill = true;
            // 
            // txtSL
            // 
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(100, 193);
            this.txtSL.MenuManager = this.ribbonControl1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(134, 20);
            this.txtSL.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số Lượng Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(268, 158);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 23);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTT
            // 
            this.txtTT.Enabled = false;
            this.txtTT.Location = new System.Drawing.Point(100, 219);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(134, 20);
            this.txtTT.TabIndex = 4;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Enabled = false;
            this.la.Location = new System.Drawing.Point(9, 222);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(56, 13);
            this.la.TabIndex = 5;
            this.la.Text = "Tổng Tiền";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(383, 158);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Tải Lại";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvTTN
            // 
            this.dgvTTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTN.Location = new System.Drawing.Point(12, 245);
            this.dgvTTN.Name = "dgvTTN";
            this.dgvTTN.Size = new System.Drawing.Size(460, 150);
            this.dgvTTN.TabIndex = 7;
            this.dgvTTN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTN_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 399);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(489, 25);
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
            // FrmQLDTTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 424);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvTTN);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.la);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.deNgay);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmQLDTTN";
            this.Text = "FrmQLDTTN";
            this.Load += new System.EventHandler(this.FrmQLDTTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangQuaMang1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongTienNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTN)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.DateEdit deNgay;
        private QuanLiBanHangQuaMang1DataSet quanLiBanHangQuaMang1DataSet;
        private System.Windows.Forms.BindingSource tongTienNgayBindingSource;
        private QuanLiBanHangQuaMang1DataSetTableAdapters.TongTienNgayTableAdapter tongTienNgayTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.TextEdit txtTT;
        private System.Windows.Forms.Label la;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.DataGridView dgvTTN;
        private DevExpress.XtraBars.BarButtonItem btnQLDH;
        private DevExpress.XtraBars.BarButtonItem btnDenTTD;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}