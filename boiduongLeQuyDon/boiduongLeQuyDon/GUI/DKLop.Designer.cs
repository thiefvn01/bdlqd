namespace boiduongLeQuyDon.GUI
{
    partial class DKLop
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsbl = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtadGC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.idHV = new DevExpress.XtraEditors.LabelControl();
            this.idLop = new DevExpress.XtraEditors.LabelControl();
            this.bntDK = new DevExpress.XtraEditors.SimpleButton();
            this.dkTKB = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLop = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.dtngay = new DevExpress.XtraEditors.DateEdit();
            this.bdlqdDataSet1 = new boiduongLeQuyDon.bdlqdDataSet1();
            this.getKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getKhoaHocTableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsbl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadGC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkTKB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(991, 507);
            this.groupControl2.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 20);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(987, 485);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsFind.FindFilterColumns = "Họ tên lót";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(173, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Khóa học";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(173, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Lớp";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.textEdit1);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.txtsbl);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.txtadGC);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.idHV);
            this.groupControl3.Controls.Add(this.idLop);
            this.groupControl3.Controls.Add(this.bntDK);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.dkTKB);
            this.groupControl3.Controls.Add(this.lkLop);
            this.groupControl3.Controls.Add(this.dtngay);
            this.groupControl3.Location = new System.Drawing.Point(12, 526);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(928, 167);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Đăng ký";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(720, 24);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 13;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(670, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Số tiền";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtsbl
            // 
            this.txtsbl.Location = new System.Drawing.Point(519, 60);
            this.txtsbl.Name = "txtsbl";
            this.txtsbl.Size = new System.Drawing.Size(105, 20);
            this.txtsbl.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số biên lai";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(564, 125);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Đóng";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtadGC
            // 
            this.txtadGC.Location = new System.Drawing.Point(720, 58);
            this.txtadGC.Name = "txtadGC";
            this.txtadGC.Size = new System.Drawing.Size(100, 20);
            this.txtadGC.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(670, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ghi chú";
            // 
            // idHV
            // 
            this.idHV.Location = new System.Drawing.Point(5, 149);
            this.idHV.Name = "idHV";
            this.idHV.Size = new System.Drawing.Size(24, 13);
            this.idHV.TabIndex = 8;
            this.idHV.Text = "hana";
            this.idHV.Visible = false;
            // 
            // idLop
            // 
            this.idLop.Location = new System.Drawing.Point(5, 114);
            this.idLop.Name = "idLop";
            this.idLop.Size = new System.Drawing.Size(24, 13);
            this.idLop.TabIndex = 9;
            this.idLop.Text = "hana";
            this.idLop.Visible = false;
            // 
            // bntDK
            // 
            this.bntDK.Location = new System.Drawing.Point(368, 125);
            this.bntDK.Name = "bntDK";
            this.bntDK.Size = new System.Drawing.Size(75, 23);
            this.bntDK.TabIndex = 5;
            this.bntDK.Text = "Đăng ký";
            this.bntDK.Click += new System.EventHandler(this.bntDK_Click);
            // 
            // dkTKB
            // 
            this.dkTKB.Location = new System.Drawing.Point(258, 28);
            this.dkTKB.Name = "dkTKB";
            this.dkTKB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dkTKB.Properties.DataSource = this.getKhoaHocBindingSource;
            this.dkTKB.Properties.DisplayMember = "TenTKB";
            this.dkTKB.Properties.DropDownRows = 15;
            this.dkTKB.Properties.NullText = "";
            this.dkTKB.Properties.ValueMember = "ID";
            this.dkTKB.Size = new System.Drawing.Size(100, 20);
            this.dkTKB.TabIndex = 2;
            this.dkTKB.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // lkLop
            // 
            this.lkLop.Location = new System.Drawing.Point(258, 54);
            this.lkLop.Name = "lkLop";
            this.lkLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLop.Properties.DropDownRows = 15;
            this.lkLop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkLop.Size = new System.Drawing.Size(100, 20);
            this.lkLop.TabIndex = 3;
            // 
            // dtngay
            // 
            this.dtngay.EditValue = null;
            this.dtngay.Location = new System.Drawing.Point(524, 24);
            this.dtngay.Name = "dtngay";
            this.dtngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngay.Properties.Mask.EditMask = "";
            this.dtngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtngay.Size = new System.Drawing.Size(100, 20);
            this.dtngay.TabIndex = 3;
            // 
            // bdlqdDataSet1
            // 
            this.bdlqdDataSet1.DataSetName = "bdlqdDataSet1";
            this.bdlqdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getKhoaHocBindingSource
            // 
            this.getKhoaHocBindingSource.DataMember = "getKhoaHoc";
            this.getKhoaHocBindingSource.DataSource = this.bdlqdDataSet1;
            // 
            // getKhoaHocTableAdapter
            // 
            this.getKhoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // DKLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 715);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "DKLop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DKLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsbl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadGC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkTKB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton bntDK;
        private DevExpress.XtraEditors.LabelControl idHV;
        private DevExpress.XtraEditors.LabelControl idLop;
        private DevExpress.XtraEditors.LookUpEdit dkTKB;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lkLop;
        private DevExpress.XtraEditors.TextEdit txtadGC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtsbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtngay;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private bdlqdDataSet1 bdlqdDataSet1;
        private System.Windows.Forms.BindingSource getKhoaHocBindingSource;
        private bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter getKhoaHocTableAdapter;
    }
}
