namespace boiduongLeQuyDon.GUI
{
    partial class thoiKhoaBieu
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblKQ = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.bntDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bntSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.bntAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtSTT = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiaoVien = new DevExpress.XtraEditors.TextEdit();
            this.txtHocPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtThoiGian = new DevExpress.XtraEditors.TextEdit();
            this.txtThu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkTKB = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaoVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTKB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Location = new System.Drawing.Point(602, 364);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 61;
            this.labelControl3.Text = "Lớp";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Location = new System.Drawing.Point(366, 364);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Môn học";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Location = new System.Drawing.Point(150, 364);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "STT";
            // 
            // lblKQ
            // 
            this.lblKQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKQ.Location = new System.Drawing.Point(66, 325);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(24, 13);
            this.lblKQ.TabIndex = 58;
            this.lblKQ.Text = "hana";
            this.lblKQ.Visible = false;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(31, 325);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 57;
            this.lblID.Text = "hana";
            this.lblID.Visible = false;
            // 
            // bntDelete
            // 
            this.bntDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntDelete.Location = new System.Drawing.Point(567, 484);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 11;
            this.bntDelete.Text = "Xóa";
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1038, 303);
            this.gridControl1.TabIndex = 49;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bntSubmit
            // 
            this.bntSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntSubmit.Location = new System.Drawing.Point(381, 484);
            this.bntSubmit.Name = "bntSubmit";
            this.bntSubmit.Size = new System.Drawing.Size(75, 23);
            this.bntSubmit.TabIndex = 10;
            this.bntSubmit.Text = "Cập nhật";
            this.bntSubmit.Click += new System.EventHandler(this.bntSubmit_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntAdd.Location = new System.Drawing.Point(264, 486);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 9;
            this.bntAdd.Text = "Thêm mới";
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtLop
            // 
            this.txtLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLop.Location = new System.Drawing.Point(700, 357);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(100, 20);
            this.txtLop.TabIndex = 3;
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMonHoc.Location = new System.Drawing.Point(464, 357);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(100, 20);
            this.txtMonHoc.TabIndex = 2;
            // 
            // txtSTT
            // 
            this.txtSTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSTT.Location = new System.Drawing.Point(239, 357);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(100, 20);
            this.txtSTT.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Location = new System.Drawing.Point(137, 486);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 23);
            this.simpleButton1.TabIndex = 63;
            this.simpleButton1.Text = "Thêm khóa học";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtGiaoVien
            // 
            this.txtGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGiaoVien.Location = new System.Drawing.Point(239, 400);
            this.txtGiaoVien.Name = "txtGiaoVien";
            this.txtGiaoVien.Size = new System.Drawing.Size(100, 20);
            this.txtGiaoVien.TabIndex = 4;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHocPhi.Location = new System.Drawing.Point(239, 440);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(100, 20);
            this.txtHocPhi.TabIndex = 7;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtThoiGian.Location = new System.Drawing.Point(700, 400);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(100, 20);
            this.txtThoiGian.TabIndex = 6;
            // 
            // txtThu
            // 
            this.txtThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtThu.Location = new System.Drawing.Point(464, 400);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(100, 20);
            this.txtThu.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Location = new System.Drawing.Point(150, 447);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 69;
            this.labelControl4.Text = "Học phí";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl6.Location = new System.Drawing.Point(602, 403);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 70;
            this.labelControl6.Text = "Thời gian";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl7.Location = new System.Drawing.Point(366, 407);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(19, 13);
            this.labelControl7.TabIndex = 71;
            this.labelControl7.Text = "Thứ";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl8.Location = new System.Drawing.Point(150, 407);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 72;
            this.labelControl8.Text = "Giáo viên";
            // 
            // lkTKB
            // 
            this.lkTKB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lkTKB.Location = new System.Drawing.Point(239, 318);
            this.lkTKB.Name = "lkTKB";
            this.lkTKB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTKB.Properties.DropDownRows = 15;
            this.lkTKB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkTKB.Size = new System.Drawing.Size(100, 20);
            this.lkTKB.TabIndex = 1;
            this.lkTKB.EditValueChanged += new System.EventHandler(this.lkTKB_EditValueChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl10.Location = new System.Drawing.Point(150, 325);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 13);
            this.labelControl10.TabIndex = 75;
            this.labelControl10.Text = "Thời khóa biểu";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkEdit1.Location = new System.Drawing.Point(379, 318);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tất cả các lớp";
            this.checkEdit1.Size = new System.Drawing.Size(99, 19);
            this.checkEdit1.TabIndex = 76;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // thoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.lkTKB);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.txtGiaoVien);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntSubmit);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtSTT);
            this.Name = "thoiKhoaBieu";
            this.Size = new System.Drawing.Size(1044, 512);
            this.Load += new System.EventHandler(this.thoiKhoaBieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaoVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTKB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblKQ;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.SimpleButton bntDelete;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton bntSubmit;
        private DevExpress.XtraEditors.SimpleButton bntAdd;
        private DevExpress.XtraEditors.TextEdit txtLop;
        private DevExpress.XtraEditors.TextEdit txtMonHoc;
        private DevExpress.XtraEditors.TextEdit txtSTT;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtGiaoVien;
        private DevExpress.XtraEditors.TextEdit txtHocPhi;
        private DevExpress.XtraEditors.TextEdit txtThoiGian;
        private DevExpress.XtraEditors.TextEdit txtThu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lkTKB;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
