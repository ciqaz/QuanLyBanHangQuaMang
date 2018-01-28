namespace QuanLyBanHangQuaMang
{
    partial class FrmThongTinDon
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDenDanhSachDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeTrangChinh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhiShip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNoiThanh = new DevExpress.XtraEditors.CheckEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.deNgayDat = new DevExpress.XtraEditors.DateEdit();
            this.deNgayChuyen = new DevExpress.XtraEditors.DateEdit();
            this.dgvTangQua = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvGiamGia = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNoiThanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayChuyen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTangQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDenDanhSachDon,
            this.btnVeTrangChinh,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1004, 141);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDenDanhSachDon
            // 
            this.btnDenDanhSachDon.Caption = "Đến Danh Sách Đơn";
            this.btnDenDanhSachDon.Id = 1;
            this.btnDenDanhSachDon.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._2;
            this.btnDenDanhSachDon.Name = "btnDenDanhSachDon";
            this.btnDenDanhSachDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDenDanhSachDon_ItemClick);
            // 
            // btnVeTrangChinh
            // 
            this.btnVeTrangChinh.Caption = "Về Trang Chính";
            this.btnVeTrangChinh.Id = 2;
            this.btnVeTrangChinh.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._11;
            this.btnVeTrangChinh.Name = "btnVeTrangChinh";
            this.btnVeTrangChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVeTrangChinh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đến Tình Trạng Đơn";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.LargeGlyph = global::QuanLyBanHangQuaMang.Properties.Resources._41;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDenDanhSachDon);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVeTrangChinh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(97, 35);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(145, 21);
            this.txtMaDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Chuyển";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(97, 72);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(145, 21);
            this.txtTenKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(385, 72);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(149, 21);
            this.txtGiaTri.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá Trị Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Đặt";
            // 
            // txtPhiShip
            // 
            this.txtPhiShip.Location = new System.Drawing.Point(385, 115);
            this.txtPhiShip.Name = "txtPhiShip";
            this.txtPhiShip.Size = new System.Drawing.Size(149, 21);
            this.txtPhiShip.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phí Ship";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Location = new System.Drawing.Point(9, 24);
            this.dgvHoaDon.MainView = this.gridView1;
            this.dgvHoaDon.MenuManager = this.ribbonControl1;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(604, 176);
            this.dgvHoaDon.TabIndex = 3;
            this.dgvHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvHoaDon;
            this.gridView1.Name = "gridView1";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(385, 154);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(149, 21);
            this.txtNhanVien.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhân Viên";
            // 
            // cbNoiThanh
            // 
            this.cbNoiThanh.Location = new System.Drawing.Point(97, 155);
            this.cbNoiThanh.MenuManager = this.ribbonControl1;
            this.cbNoiThanh.Name = "cbNoiThanh";
            this.cbNoiThanh.Properties.Caption = "Nội Thành";
            this.cbNoiThanh.Size = new System.Drawing.Size(75, 19);
            this.cbNoiThanh.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nội Thành";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.deNgayDat);
            this.groupControl1.Controls.Add(this.deNgayChuyen);
            this.groupControl1.Controls.Add(this.cbNoiThanh);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtNhanVien);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtPhiShip);
            this.groupControl1.Controls.Add(this.txtGiaTri);
            this.groupControl1.Controls.Add(this.txtTenKH);
            this.groupControl1.Controls.Add(this.txtMaDon);
            this.groupControl1.Location = new System.Drawing.Point(8, 148);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(633, 196);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông Tin Đơn Hàng";
            // 
            // deNgayDat
            // 
            this.deNgayDat.EditValue = null;
            this.deNgayDat.Location = new System.Drawing.Point(97, 117);
            this.deNgayDat.Name = "deNgayDat";
            this.deNgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDat.Size = new System.Drawing.Size(145, 20);
            this.deNgayDat.TabIndex = 5;
            // 
            // deNgayChuyen
            // 
            this.deNgayChuyen.EditValue = null;
            this.deNgayChuyen.Location = new System.Drawing.Point(385, 32);
            this.deNgayChuyen.MenuManager = this.ribbonControl1;
            this.deNgayChuyen.Name = "deNgayChuyen";
            this.deNgayChuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayChuyen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayChuyen.Size = new System.Drawing.Size(149, 20);
            this.deNgayChuyen.TabIndex = 5;
            // 
            // dgvTangQua
            // 
            this.dgvTangQua.Location = new System.Drawing.Point(15, 24);
            this.dgvTangQua.MainView = this.gridView3;
            this.dgvTangQua.Name = "dgvTangQua";
            this.dgvTangQua.Size = new System.Drawing.Size(330, 176);
            this.dgvTangQua.TabIndex = 3;
            this.dgvTangQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.dgvTangQua;
            this.gridView3.Name = "gridView3";
            // 
            // dgvGiamGia
            // 
            this.dgvGiamGia.Location = new System.Drawing.Point(15, 24);
            this.dgvGiamGia.MainView = this.gridView4;
            this.dgvGiamGia.Name = "dgvGiamGia";
            this.dgvGiamGia.Size = new System.Drawing.Size(330, 161);
            this.dgvGiamGia.TabIndex = 3;
            this.dgvGiamGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.dgvGiamGia;
            this.gridView4.Name = "gridView4";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvGiamGia);
            this.groupControl2.Location = new System.Drawing.Point(647, 149);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(357, 195);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Giảm Giá";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvTangQua);
            this.groupControl3.Location = new System.Drawing.Point(647, 357);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(357, 215);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Tặng Quà";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dgvHoaDon);
            this.groupControl4.Location = new System.Drawing.Point(8, 357);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(633, 215);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "Danh Sách Mặt Hàng";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Location = new System.Drawing.Point(710, 70);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(146, 55);
            this.dgvDonHang.TabIndex = 9;
            this.dgvDonHang.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 580);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
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
            // FrmThongTinDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 605);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmThongTinDon";
            this.Text = "FrmThongTinDon";
            this.Load += new System.EventHandler(this.FrmThongTinDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNoiThanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayChuyen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTangQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhiShip;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl dgvHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.CheckEdit cbNoiThanh;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgvTangQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl dgvGiamGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.DateEdit deNgayDat;
        private DevExpress.XtraEditors.DateEdit deNgayChuyen;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private DevExpress.XtraBars.BarButtonItem btnDenDanhSachDon;
        private DevExpress.XtraBars.BarButtonItem btnVeTrangChinh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}