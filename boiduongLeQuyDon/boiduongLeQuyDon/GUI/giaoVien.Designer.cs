namespace boiduongLeQuyDon.GUI
{
    partial class giaoVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMucLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtHoLot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkChucDanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ckGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtPasswd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtUname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.bntUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.bntThem = new DevExpress.XtraEditors.SimpleButton();
            this.bntDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(694, 500);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(690, 477);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtEmail);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtTen);
            this.groupControl2.Controls.Add(this.txtDiaChi);
            this.groupControl2.Controls.Add(this.txtMucLuong);
            this.groupControl2.Controls.Add(this.txtDienThoai);
            this.groupControl2.Controls.Add(this.txtHoLot);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.lkChucDanh);
            this.groupControl2.Controls.Add(this.ckGioiTinh);
            this.groupControl2.Location = new System.Drawing.Point(5, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(385, 158);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(201, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Email";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(79, 36);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(79, 71);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.EditValue = "0";
            this.txtMucLuong.Location = new System.Drawing.Point(79, 112);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(100, 20);
            this.txtMucLuong.TabIndex = 4;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(274, 4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(79, 5);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(100, 20);
            this.txtHoLot.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 40);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(18, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Tên";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 75);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Địa chỉ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mức lương";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(201, 8);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Số điện thoại";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(201, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Chức danh";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(201, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Giới tính";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ tên lót";
            // 
            // lkChucDanh
            // 
            this.lkChucDanh.Location = new System.Drawing.Point(274, 35);
            this.lkChucDanh.Name = "lkChucDanh";
            this.lkChucDanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkChucDanh.Properties.Items.AddRange(new object[] {
            "Giáo viên",
            "Trợ giảng",
            "Nhân viên"});
            this.lkChucDanh.Properties.PopupSizeable = true;
            this.lkChucDanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.lkChucDanh.Size = new System.Drawing.Size(100, 20);
            this.lkChucDanh.TabIndex = 5;
            // 
            // ckGioiTinh
            // 
            this.ckGioiTinh.Location = new System.Drawing.Point(274, 72);
            this.ckGioiTinh.Name = "ckGioiTinh";
            this.ckGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ckGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.ckGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.ckGioiTinh.TabIndex = 6;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lblID);
            this.groupControl4.Controls.Add(this.txtGhiChu);
            this.groupControl4.Controls.Add(this.txtPasswd);
            this.groupControl4.Controls.Add(this.labelControl10);
            this.groupControl4.Controls.Add(this.txtUname);
            this.groupControl4.Controls.Add(this.labelControl11);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Location = new System.Drawing.Point(5, 188);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(385, 167);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Thông tin khác";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(5, 149);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "Ghi chú";
            this.lblID.Visible = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(79, 59);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 20);
            this.txtGhiChu.TabIndex = 11;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(274, 11);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Properties.UseSystemPasswordChar = true;
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 10;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(7, 62);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(35, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Ghi chú";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(79, 11);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(100, 20);
            this.txtUname.TabIndex = 9;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(222, 15);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 5;
            this.labelControl11.Text = "Password";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(6, 14);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 6;
            this.labelControl12.Text = "Username";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(155, 397);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 28);
            this.bntUpdate.TabIndex = 13;
            this.bntUpdate.Text = "Cập nhật";
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(60, 397);
            this.bntThem.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(59, 29);
            this.bntThem.TabIndex = 12;
            this.bntThem.Text = "Thêm";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(263, 397);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 28);
            this.bntDelete.TabIndex = 14;
            this.bntDelete.Text = "Xóa";
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.groupControl2);
            this.groupControl5.Controls.Add(this.bntDelete);
            this.groupControl5.Controls.Add(this.bntUpdate);
            this.groupControl5.Controls.Add(this.bntThem);
            this.groupControl5.Controls.Add(this.groupControl4);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl5.Location = new System.Drawing.Point(701, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(395, 506);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Thông tin cá nhân";
            // 
            // giaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl1);
            this.Name = "giaoVien";
            this.Size = new System.Drawing.Size(1096, 506);
            this.Load += new System.EventHandler(this.giaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtUname;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtMucLuong;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.TextEdit txtHoLot;
        private DevExpress.XtraEditors.TextEdit txtPasswd;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.SimpleButton bntUpdate;
        private DevExpress.XtraEditors.SimpleButton bntThem;
        private DevExpress.XtraEditors.SimpleButton bntDelete;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.ComboBoxEdit lkChucDanh;
        private DevExpress.XtraEditors.ComboBoxEdit ckGioiTinh;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
