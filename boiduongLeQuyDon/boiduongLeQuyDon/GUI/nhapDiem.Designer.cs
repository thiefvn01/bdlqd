namespace boiduongLeQuyDon.GUI
{
    partial class nhapDiem
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
            this.ketQuaHocTapBindingSource = new System.Windows.Forms.BindingSource(this.components);
       //     this.coSoBoiDuongDataSet = new boiduongLeQuyDon.coSoBoiDuongDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọtên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLớp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐiểm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCâu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkdotkiemtra = new DevExpress.XtraEditors.LookUpEdit();
            this.kiemTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deBindingSource = new System.Windows.Forms.BindingSource(this.components);
       //     this.kiemTraTableAdapter = new boiduongLeQuyDon.coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
       //     this.deTableAdapter = new boiduongLeQuyDon.coSoBoiDuongDataSetTableAdapters.deTableAdapter();
            this.bntThem = new DevExpress.XtraEditors.SimpleButton();
            this.bntIn = new DevExpress.XtraEditors.SimpleButton();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.txtdiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bntEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtnx1 = new DevExpress.XtraEditors.TextEdit();
            this.lkLop = new DevExpress.XtraEditors.LookUpEdit();
            this.lkPhep = new DevExpress.XtraEditors.LookUpEdit();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lbdiem = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
      //      this.dataTable3TableAdapter = new boiduongLeQuyDon.coSoBoiDuongDataSetTableAdapters.DataTable3TableAdapter();
     //       this.ketQuaHocTapTableAdapter = new boiduongLeQuyDon.coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaHocTapBindingSource)).BeginInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.coSoBoiDuongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkdotkiemtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnx1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.ketQuaHocTapBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(997, 365);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ketQuaHocTapBindingSource
            // 
            this.ketQuaHocTapBindingSource.DataMember = "ketQuaHocTap";
   //         this.ketQuaHocTapBindingSource.DataSource = this.coSoBoiDuongDataSet;
            // 
            // coSoBoiDuongDataSet
            // 
  //          this.coSoBoiDuongDataSet.DataSetName = "coSoBoiDuongDataSet";
  //          this.coSoBoiDuongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colHọtên,
            this.colLớp,
            this.colĐiểm,
            this.colCâu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colHọtên
            // 
            this.colHọtên.FieldName = "Họ tên";
            this.colHọtên.Name = "colHọtên";
            this.colHọtên.OptionsColumn.ReadOnly = true;
            this.colHọtên.Visible = true;
            this.colHọtên.VisibleIndex = 1;
            // 
            // colLớp
            // 
            this.colLớp.FieldName = "Lớp";
            this.colLớp.Name = "colLớp";
            this.colLớp.Visible = true;
            this.colLớp.VisibleIndex = 2;
            // 
            // colĐiểm
            // 
            this.colĐiểm.FieldName = "Điểm";
            this.colĐiểm.Name = "colĐiểm";
            this.colĐiểm.Visible = true;
            this.colĐiểm.VisibleIndex = 4;
            // 
            // colCâu
            // 
            this.colCâu.FieldName = "Câu";
            this.colCâu.Name = "colCâu";
            this.colCâu.Visible = true;
            this.colCâu.VisibleIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Location = new System.Drawing.Point(340, 439);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Học viên";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Location = new System.Drawing.Point(131, 405);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Khóa";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Location = new System.Drawing.Point(340, 405);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Lớp";
            // 
            // lkKhoa
            // 
            this.lkKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkKhoa.Location = new System.Drawing.Point(216, 402);
            this.lkKhoa.Name = "lkKhoa";
            this.lkKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoa.Properties.DropDownRows = 15;
            this.lkKhoa.Properties.NullText = "";
            this.lkKhoa.Size = new System.Drawing.Size(100, 20);
            this.lkKhoa.TabIndex = 1;
            this.lkKhoa.EditValueChanged += new System.EventHandler(this.lkKhoa_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl5.Location = new System.Drawing.Point(131, 439);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Đợt kiểm tra";
            // 
            // lkdotkiemtra
            // 
            this.lkdotkiemtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkdotkiemtra.Location = new System.Drawing.Point(216, 436);
            this.lkdotkiemtra.Name = "lkdotkiemtra";
            this.lkdotkiemtra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkdotkiemtra.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lớp", "Lớp", 27, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mã đề", "Mã đề", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ngày làm", "Ngày làm", 54, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkdotkiemtra.Properties.DataSource = this.kiemTraBindingSource;
            this.lkdotkiemtra.Properties.DisplayMember = "Ngày làm";
            this.lkdotkiemtra.Properties.DropDownRows = 15;
            this.lkdotkiemtra.Properties.NullText = "";
            this.lkdotkiemtra.Properties.ValueMember = "ID";
            this.lkdotkiemtra.Size = new System.Drawing.Size(100, 20);
            this.lkdotkiemtra.TabIndex = 3;
            this.lkdotkiemtra.EditValueChanged += new System.EventHandler(this.lkdotkiemtra_EditValueChanged);
            // 
            // kiemTraBindingSource
            // 
            this.kiemTraBindingSource.DataMember = "kiemTra";
       //     this.kiemTraBindingSource.DataSource = this.coSoBoiDuongDataSet;
            // 
            // deBindingSource
            // 
            this.deBindingSource.DataMember = "de";
    //        this.deBindingSource.DataSource = this.coSoBoiDuongDataSet;
            // 
            // kiemTraTableAdapter
            // 
    //        this.kiemTraTableAdapter.ClearBeforeFill = true;
            // 
            // deTableAdapter
            // 
    //        this.deTableAdapter.ClearBeforeFill = true;
            // 
            // bntThem
            // 
            this.bntThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntThem.Location = new System.Drawing.Point(282, 506);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 7;
            this.bntThem.Text = "Nhập điểm";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntIn
            // 
            this.bntIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntIn.Location = new System.Drawing.Point(651, 506);
            this.bntIn.Name = "bntIn";
            this.bntIn.Size = new System.Drawing.Size(75, 23);
            this.bntIn.TabIndex = 10;
            this.bntIn.Text = "In phiếu điểm";
            this.bntIn.Click += new System.EventHandler(this.bntIn_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblID.Location = new System.Drawing.Point(855, 405);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 13);
            this.lblID.TabIndex = 43;
            this.lblID.Text = "Học viên";
            this.lblID.Visible = false;
            // 
            // txtdiem
            // 
            this.txtdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtdiem.Location = new System.Drawing.Point(571, 436);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(100, 20);
            this.txtdiem.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Location = new System.Drawing.Point(508, 443);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Điểm";
            // 
            // bntEdit
            // 
            this.bntEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntEdit.Location = new System.Drawing.Point(401, 506);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(75, 23);
            this.bntEdit.TabIndex = 8;
            this.bntEdit.Text = "Sửa";
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl6.Location = new System.Drawing.Point(710, 443);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "Nhận xét";
            // 
            // txtnx1
            // 
            this.txtnx1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnx1.Location = new System.Drawing.Point(796, 436);
            this.txtnx1.Name = "txtnx1";
            this.txtnx1.Size = new System.Drawing.Size(100, 20);
            this.txtnx1.TabIndex = 6;
            // 
            // lkLop
            // 
            this.lkLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkLop.Location = new System.Drawing.Point(390, 402);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.DropDownRows = 15;
            this.lkLop.Properties.NullText = "";
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 2;
            this.lkLop.EditValueChanged += new System.EventHandler(this.lkLop_EditValueChanged);
            // 
            // lkPhep
            // 
            this.lkPhep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkPhep.Location = new System.Drawing.Point(390, 436);
            this.lkPhep.Name = "lkPhep";
            this.lkPhep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhep.Properties.DropDownRows = 15;
            this.lkPhep.Properties.NullText = "";
            this.lkPhep.Size = new System.Drawing.Size(100, 20);
            this.lkPhep.TabIndex = 4;
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRefresh.Location = new System.Drawing.Point(571, 399);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 9;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // lbdiem
            // 
            this.lbdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbdiem.Location = new System.Drawing.Point(816, 374);
            this.lbdiem.Name = "lbdiem";
            this.lbdiem.Size = new System.Drawing.Size(41, 13);
            this.lbdiem.TabIndex = 43;
            this.lbdiem.Text = "Học viên";
            this.lbdiem.Visible = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(40, 374);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 47;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
     //       this.dataTable3BindingSource.DataSource = this.coSoBoiDuongDataSet;
            // 
            // dataTable3TableAdapter
            // 
   //         this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // ketQuaHocTapTableAdapter
            // 
     //       this.ketQuaHocTapTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Location = new System.Drawing.Point(526, 506);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(81, 23);
            this.simpleButton1.TabIndex = 48;
            this.simpleButton1.Text = "Xóa bộ điểm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Location = new System.Drawing.Point(753, 506);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 23);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "In điểm cá nhân";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton3.Location = new System.Drawing.Point(668, 399);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 49;
            this.simpleButton3.Text = "Xuất HV";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton4.Location = new System.Drawing.Point(753, 399);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 49;
            this.simpleButton4.Text = "Nhập Excel";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // nhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.bntEdit);
            this.Controls.Add(this.txtnx1);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbdiem);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.bntIn);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lkdotkiemtra);
            this.Controls.Add(this.lkKhoa);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lkLop);
            this.Controls.Add(this.lkPhep);
            this.Name = "nhapDiem";
            this.Size = new System.Drawing.Size(1003, 577);
            this.Load += new System.EventHandler(this.nhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaHocTapBindingSource)).EndInit();
     //       ((System.ComponentModel.ISupportInitialize)(this.coSoBoiDuongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkdotkiemtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnx1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lkdotkiemtra;
        private System.Windows.Forms.BindingSource kiemTraBindingSource;
   //     private coSoBoiDuongDataSet coSoBoiDuongDataSet;
        private System.Windows.Forms.BindingSource deBindingSource;
   //     private coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter kiemTraTableAdapter;
  //      private coSoBoiDuongDataSetTableAdapters.deTableAdapter deTableAdapter;
        private DevExpress.XtraEditors.SimpleButton bntThem;
        private DevExpress.XtraEditors.SimpleButton bntIn;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtdiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bntEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtnx1;
        private DevExpress.XtraEditors.LookUpEdit lkLop;
        private DevExpress.XtraEditors.LookUpEdit lkPhep;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraEditors.LabelControl lbdiem;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
  //      private coSoBoiDuongDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.BindingSource ketQuaHocTapBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colHọtên;
        private DevExpress.XtraGrid.Columns.GridColumn colLớp;
        private DevExpress.XtraGrid.Columns.GridColumn colCâu;
        private DevExpress.XtraGrid.Columns.GridColumn colĐiểm;
    //    private coSoBoiDuongDataSetTableAdapters.ketQuaHocTapTableAdapter ketQuaHocTapTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}
