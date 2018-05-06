namespace boiduongLeQuyDon.GUI
{
    partial class xuatLSHV
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bntExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lkPhep = new DevExpress.XtraEditors.LookUpEdit();
            this.cktt = new DevExpress.XtraEditors.CheckEdit();
            this.cktc = new DevExpress.XtraEditors.CheckEdit();
            this.bntNhan = new DevExpress.XtraEditors.SimpleButton();
            this.bdlqdDataSet1 = new boiduongLeQuyDon.bdlqdDataSet1();
            this.getKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getKhoaHocTableAdapter = new boiduongLeQuyDon.bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cktt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cktc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(107, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Khóa học";
            // 
            // bntExport
            // 
            this.bntExport.Location = new System.Drawing.Point(269, 113);
            this.bntExport.Name = "bntExport";
            this.bntExport.Size = new System.Drawing.Size(75, 23);
            this.bntExport.TabIndex = 15;
            this.bntExport.Text = "Xuất nhãn";
            this.bntExport.Click += new System.EventHandler(this.bntExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(408, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lkPhep
            // 
            this.lkPhep.Location = new System.Drawing.Point(194, 61);
            this.lkPhep.Name = "lkPhep";
            this.lkPhep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhep.Properties.DataSource = this.getKhoaHocBindingSource;
            this.lkPhep.Properties.DisplayMember = "TenTKB";
            this.lkPhep.Properties.NullText = "";
            this.lkPhep.Properties.ValueMember = "id";
            this.lkPhep.Size = new System.Drawing.Size(230, 20);
            this.lkPhep.TabIndex = 10;
            // 
            // cktt
            // 
            this.cktt.Location = new System.Drawing.Point(107, 13);
            this.cktt.Name = "cktt";
            this.cktt.Properties.Caption = "Xếp theo STT";
            this.cktt.Size = new System.Drawing.Size(127, 19);
            this.cktt.TabIndex = 17;
            // 
            // cktc
            // 
            this.cktc.Location = new System.Drawing.Point(349, 13);
            this.cktc.Name = "cktc";
            this.cktc.Properties.Caption = "Tất cả các khóa đang học";
            this.cktc.Size = new System.Drawing.Size(191, 19);
            this.cktc.TabIndex = 17;
            // 
            // bntNhan
            // 
            this.bntNhan.Location = new System.Drawing.Point(159, 113);
            this.bntNhan.Name = "bntNhan";
            this.bntNhan.Size = new System.Drawing.Size(75, 23);
            this.bntNhan.TabIndex = 18;
            this.bntNhan.Text = "Xuất";
            this.bntNhan.Click += new System.EventHandler(this.bntNhan_Click);
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
            // xuatLSHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 163);
            this.Controls.Add(this.bntNhan);
            this.Controls.Add(this.cktc);
            this.Controls.Add(this.cktt);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bntExport);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lkPhep);
            this.Name = "xuatLSHV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.xuatLSHV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkPhep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cktt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cktc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlqdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKhoaHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bntExport;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LookUpEdit lkPhep;
        private DevExpress.XtraEditors.CheckEdit cktt;
        private DevExpress.XtraEditors.CheckEdit cktc;
        private DevExpress.XtraEditors.SimpleButton bntNhan;
        private bdlqdDataSet1 bdlqdDataSet1;
        private System.Windows.Forms.BindingSource getKhoaHocBindingSource;
        private bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter getKhoaHocTableAdapter;
    }
}
