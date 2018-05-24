namespace boiduongLeQuyDon.GUI
{
    partial class QLCaBiet
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getCaBiet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdlqdDataSet1 = new boiduongLeQuyDon.bdlqdDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọvàtên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐặcđiểm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNộidungviphạm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốlần = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguyênnhân = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhắcphục = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ckTatCa = new DevExpress.XtraEditors.CheckEdit();
            this.lkHocVien = new DevExpress.XtraEditors.LookUpEdit();
            this.getHocVienDangHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDacDiem = new DevExpress.XtraEditors.TextEdit();
            this.txtNguyenNhan = new DevExpress.XtraEditors.TextEdit();
            this.txtKhacPhuc = new DevExpress.XtraEditors.TextEdit();
            this.txtViPham = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLan = new DevExpress.XtraEditors.TextEdit();
            this.ckGiaiQuyet = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.getHocVienDangHocTableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getHocVienDangHocTableAdapter();
            this.getCaBiet1TableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getCaBiet1TableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.getKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.getKhoaHocTableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCaBiet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckTatCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkHocVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHocVienDangHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDacDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhacPhuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckGiaiQuyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.getCaBiet1BindingSource;
            this.gridControl1.Location = new System.Drawing.Point(4, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(937, 285);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getCaBiet1BindingSource
            // 
            this.getCaBiet1BindingSource.DataMember = "getCaBiet1";
            this.getCaBiet1BindingSource.DataSource = this.bdlqdDataSet1;
            // 
            // bdlqdDataSet1
            // 
            this.bdlqdDataSet1.DataSetName = "bdlqdDataSet1";
            this.bdlqdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colHọvàtên,
            this.colĐặcđiểm,
            this.colNộidungviphạm,
            this.colSốlần,
            this.colNguyênnhân,
            this.colKhắcphục});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colHọvàtên
            // 
            this.colHọvàtên.FieldName = "Họ và tên";
            this.colHọvàtên.Name = "colHọvàtên";
            this.colHọvàtên.Visible = true;
            this.colHọvàtên.VisibleIndex = 1;
            // 
            // colĐặcđiểm
            // 
            this.colĐặcđiểm.FieldName = "Đặc điểm";
            this.colĐặcđiểm.Name = "colĐặcđiểm";
            this.colĐặcđiểm.Visible = true;
            this.colĐặcđiểm.VisibleIndex = 2;
            // 
            // colNộidungviphạm
            // 
            this.colNộidungviphạm.FieldName = "Nội dung vi phạm";
            this.colNộidungviphạm.Name = "colNộidungviphạm";
            this.colNộidungviphạm.Visible = true;
            this.colNộidungviphạm.VisibleIndex = 3;
            // 
            // colSốlần
            // 
            this.colSốlần.FieldName = "Số lần";
            this.colSốlần.Name = "colSốlần";
            this.colSốlần.Visible = true;
            this.colSốlần.VisibleIndex = 4;
            // 
            // colNguyênnhân
            // 
            this.colNguyênnhân.FieldName = "Nguyên nhân";
            this.colNguyênnhân.Name = "colNguyênnhân";
            this.colNguyênnhân.Visible = true;
            this.colNguyênnhân.VisibleIndex = 5;
            // 
            // colKhắcphục
            // 
            this.colKhắcphục.FieldName = "Khắc phục";
            this.colKhắcphục.Name = "colKhắcphục";
            this.colKhắcphục.Visible = true;
            this.colKhắcphục.VisibleIndex = 6;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblID.Location = new System.Drawing.Point(701, 295);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "labelControl1";
            this.lblID.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Location = new System.Drawing.Point(701, 323);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Học viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Location = new System.Drawing.Point(24, 369);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Đặc điểm";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Location = new System.Drawing.Point(4, 429);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Nguyên nhân";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl5.Location = new System.Drawing.Point(345, 426);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Khắc phục";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl6.Location = new System.Drawing.Point(345, 364);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Vi phạm";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl7.Location = new System.Drawing.Point(704, 364);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Số lần";
            // 
            // ckTatCa
            // 
            this.ckTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ckTatCa.Location = new System.Drawing.Point(16, 295);
            this.ckTatCa.Name = "ckTatCa";
            this.ckTatCa.Properties.Caption = "Tất cả trường hợp";
            this.ckTatCa.Size = new System.Drawing.Size(162, 19);
            this.ckTatCa.TabIndex = 2;
            this.ckTatCa.CheckStateChanged += new System.EventHandler(this.ckTatCa_CheckStateChanged);
            // 
            // lkHocVien
            // 
            this.lkHocVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkHocVien.Location = new System.Drawing.Point(796, 316);
            this.lkHocVien.Name = "lkHocVien";
            this.lkHocVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkHocVien.Properties.DataSource = this.getHocVienDangHocBindingSource;
            this.lkHocVien.Properties.DisplayMember = "Họ tên";
            this.lkHocVien.Properties.ValueMember = "id";
            this.lkHocVien.Size = new System.Drawing.Size(100, 20);
            this.lkHocVien.TabIndex = 3;
            // 
            // getHocVienDangHocBindingSource
            // 
            this.getHocVienDangHocBindingSource.DataMember = "getHocVienDangHoc";
            this.getHocVienDangHocBindingSource.DataSource = this.bdlqdDataSet1;
            // 
            // txtDacDiem
            // 
            this.txtDacDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDacDiem.Location = new System.Drawing.Point(87, 361);
            this.txtDacDiem.Name = "txtDacDiem";
            this.txtDacDiem.Size = new System.Drawing.Size(239, 20);
            this.txtDacDiem.TabIndex = 4;
            // 
            // txtNguyenNhan
            // 
            this.txtNguyenNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNguyenNhan.Location = new System.Drawing.Point(87, 423);
            this.txtNguyenNhan.Name = "txtNguyenNhan";
            this.txtNguyenNhan.Size = new System.Drawing.Size(252, 20);
            this.txtNguyenNhan.TabIndex = 7;
            // 
            // txtKhacPhuc
            // 
            this.txtKhacPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtKhacPhuc.Location = new System.Drawing.Point(405, 423);
            this.txtKhacPhuc.Name = "txtKhacPhuc";
            this.txtKhacPhuc.Size = new System.Drawing.Size(328, 20);
            this.txtKhacPhuc.TabIndex = 8;
            // 
            // txtViPham
            // 
            this.txtViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtViPham.Location = new System.Drawing.Point(422, 361);
            this.txtViPham.Name = "txtViPham";
            this.txtViPham.Size = new System.Drawing.Size(261, 20);
            this.txtViPham.TabIndex = 5;
            // 
            // txtSoLan
            // 
            this.txtSoLan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSoLan.Location = new System.Drawing.Point(798, 361);
            this.txtSoLan.Name = "txtSoLan";
            this.txtSoLan.Size = new System.Drawing.Size(100, 20);
            this.txtSoLan.TabIndex = 6;
            // 
            // ckGiaiQuyet
            // 
            this.ckGiaiQuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ckGiaiQuyet.Location = new System.Drawing.Point(764, 423);
            this.ckGiaiQuyet.Name = "ckGiaiQuyet";
            this.ckGiaiQuyet.Properties.Caption = "Đã giải quyết";
            this.ckGiaiQuyet.Size = new System.Drawing.Size(162, 19);
            this.ckGiaiQuyet.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton1.Location = new System.Drawing.Point(316, 482);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton2.Location = new System.Drawing.Point(443, 482);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Sửa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton3.Location = new System.Drawing.Point(554, 482);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Xóa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // getHocVienDangHocTableAdapter
            // 
            this.getHocVienDangHocTableAdapter.ClearBeforeFill = true;
            // 
            // getCaBiet1TableAdapter
            // 
            this.getCaBiet1TableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Location = new System.Drawing.Point(27, 323);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Khóa";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lookUpEdit1.Location = new System.Drawing.Point(122, 316);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.getKhoaHocBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "TenTKB";
            this.lookUpEdit1.Properties.ValueMember = "id";
            this.lookUpEdit1.Size = new System.Drawing.Size(177, 20);
            this.lookUpEdit1.TabIndex = 1;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // getKhoaHocBindingSource
            // 
            this.getKhoaHocBindingSource.DataMember = "getKhoaHoc";
            this.getKhoaHocBindingSource.DataSource = this.bdlqdDataSet1;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl8.Location = new System.Drawing.Point(341, 323);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(17, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Lớp";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lookUpEdit2.Location = new System.Drawing.Point(436, 316);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "Họ tên";
            this.lookUpEdit2.Properties.ValueMember = "id";
            this.lookUpEdit2.Size = new System.Drawing.Size(182, 20);
            this.lookUpEdit2.TabIndex = 2;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // getKhoaHocTableAdapter
            // 
            this.getKhoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkEdit1.Location = new System.Drawing.Point(220, 295);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(162, 19);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.CheckStateChanged += new System.EventHandler(this.checkEdit1_CheckStateChanged);
            // 
            // QLCaBiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtNguyenNhan);
            this.Controls.Add(this.txtSoLan);
            this.Controls.Add(this.txtViPham);
            this.Controls.Add(this.txtKhacPhuc);
            this.Controls.Add(this.txtDacDiem);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.lkHocVien);
            this.Controls.Add(this.ckGiaiQuyet);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.ckTatCa);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gridControl1);
            this.Name = "QLCaBiet";
            this.Size = new System.Drawing.Size(944, 550);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCaBiet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckTatCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkHocVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHocVienDangHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDacDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhacPhuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckGiaiQuyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit ckTatCa;
        private DevExpress.XtraEditors.LookUpEdit lkHocVien;
        private DevExpress.XtraEditors.TextEdit txtDacDiem;
        private DevExpress.XtraEditors.TextEdit txtNguyenNhan;
        private DevExpress.XtraEditors.TextEdit txtKhacPhuc;
        private DevExpress.XtraEditors.TextEdit txtViPham;
        private DevExpress.XtraEditors.TextEdit txtSoLan;
        private DevExpress.XtraEditors.CheckEdit ckGiaiQuyet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.BindingSource getHocVienDangHocBindingSource;
        private bdlqdDataSet1 bdlqdDataSet1;
        private bdlqdDataSet1TableAdapters.getHocVienDangHocTableAdapter getHocVienDangHocTableAdapter;
        private System.Windows.Forms.BindingSource getCaBiet1BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colHọvàtên;
        private DevExpress.XtraGrid.Columns.GridColumn colĐặcđiểm;
        private DevExpress.XtraGrid.Columns.GridColumn colNộidungviphạm;
        private DevExpress.XtraGrid.Columns.GridColumn colSốlần;
        private DevExpress.XtraGrid.Columns.GridColumn colNguyênnhân;
        private DevExpress.XtraGrid.Columns.GridColumn colKhắcphục;
        private bdlqdDataSet1TableAdapters.getCaBiet1TableAdapter getCaBiet1TableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private System.Windows.Forms.BindingSource getKhoaHocBindingSource;
        private bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter getKhoaHocTableAdapter;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
