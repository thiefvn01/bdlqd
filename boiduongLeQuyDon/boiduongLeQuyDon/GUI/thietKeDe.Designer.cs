namespace boiduongLeQuyDon.GUI
{
    partial class thietKeDe
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bntDelete = new DevExpress.XtraEditors.SimpleButton();
            this.bntEdit = new DevExpress.XtraEditors.SimpleButton();
            this.bntThem = new DevExpress.XtraEditors.SimpleButton();
            this.lkde = new DevExpress.XtraEditors.LookUpEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.bntKT = new DevExpress.XtraEditors.SimpleButton();
            this.txttd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtfrom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtmax = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCauLon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhomCau = new DevExpress.XtraEditors.ComboBoxEdit();
       //     this.coSoBoiDuongDataSet = new boiduongLeQuyDon.coSoBoiDuongDataSet();
            this.deBindingSource = new System.Windows.Forms.BindingSource(this.components);
      //      this.deTableAdapter = new boiduongLeQuyDon.coSoBoiDuongDataSetTableAdapters.deTableAdapter();
            this.kiemTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
    //        this.kiemTraTableAdapter = new boiduongLeQuyDon.coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCâu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãđề = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLớp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐiểmtốiđa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCâulớn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhómcâu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauLon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomCau.Properties)).BeginInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.coSoBoiDuongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.deBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1029, 308);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCâu,
            this.colMãđề,
            this.colLớp,
            this.colĐiểmtốiđa,
            this.colCâulớn,
            this.colNhómcâu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Location = new System.Drawing.Point(24, 348);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đợt kiểm tra";
            // 
            // txtCau
            // 
            this.txtCau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCau.Location = new System.Drawing.Point(355, 336);
            this.txtCau.Name = "txtCau";
            this.txtCau.Size = new System.Drawing.Size(100, 20);
            this.txtCau.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Location = new System.Drawing.Point(287, 343);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên câu";
            // 
            // bntDelete
            // 
            this.bntDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntDelete.Location = new System.Drawing.Point(561, 434);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 14;
            this.bntDelete.Text = "Xóa";
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntEdit.Location = new System.Drawing.Point(442, 434);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(75, 23);
            this.bntEdit.TabIndex = 13;
            this.bntEdit.Text = "Sửa";
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // bntThem
            // 
            this.bntThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntThem.Location = new System.Drawing.Point(323, 434);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 12;
            this.bntThem.Text = "Thêm";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // lkde
            // 
            this.lkde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkde.Location = new System.Drawing.Point(131, 340);
            this.lkde.Name = "lkde";
            this.lkde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkde.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lớp", "Lớp", 27, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mã đề", "Mã đề", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ngày làm", "Ngày làm", 54, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkde.Properties.DataSource = this.kiemTraBindingSource;
            this.lkde.Properties.DropDownRows = 15;
            this.lkde.Properties.NullText = "";
            this.lkde.Size = new System.Drawing.Size(100, 20);
            this.lkde.TabIndex = 2;
            this.lkde.EditValueChanged += new System.EventHandler(this.lkde_EditValueChanged);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(510, 362);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "hana";
            this.lblID.Visible = false;
            // 
            // bntKT
            // 
            this.bntKT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntKT.Location = new System.Drawing.Point(670, 434);
            this.bntKT.Name = "bntKT";
            this.bntKT.Size = new System.Drawing.Size(95, 23);
            this.bntKT.TabIndex = 16;
            this.bntKT.Text = "Thêm  TN";
            this.bntKT.Click += new System.EventHandler(this.bntKT_Click);
            // 
            // txttd
            // 
            this.txttd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txttd.Location = new System.Drawing.Point(924, 332);
            this.txttd.Name = "txttd";
            this.txttd.Size = new System.Drawing.Size(100, 20);
            this.txttd.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Location = new System.Drawing.Point(856, 339);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Điểm tối đa";
            // 
            // txtfrom
            // 
            this.txtfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtfrom.Location = new System.Drawing.Point(128, 381);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(100, 20);
            this.txtfrom.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Location = new System.Drawing.Point(60, 388);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Từ câu";
            // 
            // txtto
            // 
            this.txtto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtto.Location = new System.Drawing.Point(355, 381);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(100, 20);
            this.txtto.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl5.Location = new System.Drawing.Point(287, 388);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Đến câu";
            // 
            // txtmax
            // 
            this.txtmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtmax.Location = new System.Drawing.Point(560, 381);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 20);
            this.txtmax.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl6.Location = new System.Drawing.Point(492, 388);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Điểm";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl7.Location = new System.Drawing.Point(492, 343);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Câu lớn";
            // 
            // txtCauLon
            // 
            this.txtCauLon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCauLon.Location = new System.Drawing.Point(560, 336);
            this.txtCauLon.Name = "txtCauLon";
            this.txtCauLon.Size = new System.Drawing.Size(100, 20);
            this.txtCauLon.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl8.Location = new System.Drawing.Point(666, 343);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Nhóm câu";
            // 
            // txtNhomCau
            // 
            this.txtNhomCau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNhomCau.Location = new System.Drawing.Point(734, 336);
            this.txtNhomCau.Name = "txtNhomCau";
            this.txtNhomCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNhomCau.Properties.Items.AddRange(new object[] {
            "",
            "Đại số",
            "Hình học",
            "Tự luận",
            "Trắc nghiệm"});
            this.txtNhomCau.Size = new System.Drawing.Size(100, 20);
            this.txtNhomCau.TabIndex = 6;
            // 
            // coSoBoiDuongDataSet
            // 
        //    this.coSoBoiDuongDataSet.DataSetName = "coSoBoiDuongDataSet";
       //     this.coSoBoiDuongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deBindingSource
            // 
            this.deBindingSource.DataMember = "de";
     //       this.deBindingSource.DataSource = this.coSoBoiDuongDataSet;
            // 
            // deTableAdapter
            // 
    //        this.deTableAdapter.ClearBeforeFill = true;
            // 
            // kiemTraBindingSource
            // 
            this.kiemTraBindingSource.DataMember = "kiemTra";
     //       this.kiemTraBindingSource.DataSource = this.coSoBoiDuongDataSet;
            // 
            // kiemTraTableAdapter
            // 
     //       this.kiemTraTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCâu
            // 
            this.colCâu.FieldName = "Câu";
            this.colCâu.Name = "colCâu";
            this.colCâu.Visible = true;
            this.colCâu.VisibleIndex = 4;
            // 
            // colMãđề
            // 
            this.colMãđề.FieldName = "Mã đề";
            this.colMãđề.Name = "colMãđề";
            this.colMãđề.Visible = true;
            this.colMãđề.VisibleIndex = 1;
            // 
            // colLớp
            // 
            this.colLớp.FieldName = "Lớp";
            this.colLớp.Name = "colLớp";
            this.colLớp.Visible = true;
            this.colLớp.VisibleIndex = 2;
            // 
            // colĐiểmtốiđa
            // 
            this.colĐiểmtốiđa.FieldName = "Điểm tối đa";
            this.colĐiểmtốiđa.Name = "colĐiểmtốiđa";
            this.colĐiểmtốiđa.Visible = true;
            this.colĐiểmtốiđa.VisibleIndex = 5;
            // 
            // colCâulớn
            // 
            this.colCâulớn.FieldName = "Câu lớn";
            this.colCâulớn.Name = "colCâulớn";
            this.colCâulớn.Visible = true;
            this.colCâulớn.VisibleIndex = 3;
            // 
            // colNhómcâu
            // 
            this.colNhómcâu.FieldName = "Nhóm câu";
            this.colNhómcâu.Name = "colNhómcâu";
            this.colNhómcâu.Visible = true;
            this.colNhómcâu.VisibleIndex = 6;
            // 
            // thietKeDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtCauLon);
            this.Controls.Add(this.txttd);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.bntKT);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntEdit);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.txtCau);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lkde);
            this.Controls.Add(this.txtNhomCau);
            this.Name = "thietKeDe";
            this.Size = new System.Drawing.Size(1035, 463);
            this.Load += new System.EventHandler(this.thietKeDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauLon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomCau.Properties)).EndInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.coSoBoiDuongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemTraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bntDelete;
        private DevExpress.XtraEditors.SimpleButton bntEdit;
        private DevExpress.XtraEditors.SimpleButton bntThem;
        private DevExpress.XtraEditors.LookUpEdit lkde;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.SimpleButton bntKT;
        private DevExpress.XtraEditors.TextEdit txttd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtfrom;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtto;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtmax;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCauLon;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit txtNhomCau;
        private System.Windows.Forms.BindingSource deBindingSource;
     //   private coSoBoiDuongDataSet coSoBoiDuongDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCâu;
        private DevExpress.XtraGrid.Columns.GridColumn colMãđề;
        private DevExpress.XtraGrid.Columns.GridColumn colLớp;
        private DevExpress.XtraGrid.Columns.GridColumn colĐiểmtốiđa;
        private DevExpress.XtraGrid.Columns.GridColumn colCâulớn;
        private DevExpress.XtraGrid.Columns.GridColumn colNhómcâu;
        private System.Windows.Forms.BindingSource kiemTraBindingSource;
     //   private coSoBoiDuongDataSetTableAdapters.deTableAdapter deTableAdapter;
     //   private coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter kiemTraTableAdapter;
    }
}
