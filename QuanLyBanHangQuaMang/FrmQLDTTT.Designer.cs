namespace QuanLyBanHangQuaMang
{
    partial class FrmQLDTTT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvTTN = new System.Windows.Forms.DataGridView();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTT = new DevExpress.XtraEditors.TextEdit();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNam = new DevExpress.XtraEditors.TextEdit();
            this.txtThang = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTenNhanVien = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(593, 141);
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
            // dgvTTN
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTTN.Location = new System.Drawing.Point(12, 280);
            this.dgvTTN.Name = "dgvTTN";
            this.dgvTTN.Size = new System.Drawing.Size(569, 150);
            this.dgvTTN.TabIndex = 16;
            this.dgvTTN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTN_CellClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(313, 194);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Tải Lại";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(313, 156);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 23);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tháng";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Enabled = false;
            this.la.Location = new System.Drawing.Point(310, 247);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(56, 13);
            this.la.TabIndex = 12;
            this.la.Text = "Tổng Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số Lượng Đơn";
            // 
            // txtTT
            // 
            this.txtTT.Enabled = false;
            this.txtTT.Location = new System.Drawing.Point(401, 244);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(134, 20);
            this.txtTT.TabIndex = 9;
            // 
            // txtSL
            // 
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(113, 244);
            this.txtSL.MenuManager = this.ribbonControl1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(134, 20);
            this.txtSL.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(113, 185);
            this.txtNam.MenuManager = this.ribbonControl1;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(134, 20);
            this.txtNam.TabIndex = 18;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(113, 159);
            this.txtThang.MenuManager = this.ribbonControl1;
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(134, 20);
            this.txtThang.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslTenNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 432);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 25);
            this.toolStrip1.TabIndex = 21;
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
            // FrmQLDTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 457);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.dgvTTN);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.la);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmQLDTTT";
            this.Text = "FrmQLDTTT";
            this.Load += new System.EventHandler(this.FrmQLDTTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnQLDH;
        private DevExpress.XtraBars.BarButtonItem btnDenTTD;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.DataGridView dgvTTN;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTT;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtNam;
        private DevExpress.XtraEditors.TextEdit txtThang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslTenNhanVien;
    }
}