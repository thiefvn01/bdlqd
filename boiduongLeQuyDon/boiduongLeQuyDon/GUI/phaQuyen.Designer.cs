namespace boiduongLeQuyDon.GUI
{
    partial class phaQuyen
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bntThem = new DevExpress.XtraEditors.SimpleButton();
            this.hv = new DevExpress.XtraEditors.CheckEdit();
            this.nv = new DevExpress.XtraEditors.CheckEdit();
            this.kq = new DevExpress.XtraEditors.CheckEdit();
            this.pq = new DevExpress.XtraEditors.CheckEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pq.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(885, 313);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 344);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Học viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(274, 348);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Kết quả";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(274, 402);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Phân quyền";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(36, 398);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Nhân viên/giảng viên";
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(331, 482);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 35;
            this.bntThem.Text = "Thêm";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // hv
            // 
            this.hv.EditValue = null;
            this.hv.Location = new System.Drawing.Point(143, 341);
            this.hv.Name = "hv";
            this.hv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.hv.Properties.Caption = "";
            this.hv.Size = new System.Drawing.Size(72, 19);
            this.hv.TabIndex = 28;
            // 
            // nv
            // 
            this.nv.EditValue = null;
            this.nv.Location = new System.Drawing.Point(143, 395);
            this.nv.Name = "nv";
            this.nv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.nv.Properties.Caption = "";
            this.nv.Size = new System.Drawing.Size(72, 19);
            this.nv.TabIndex = 34;
            // 
            // kq
            // 
            this.kq.EditValue = null;
            this.kq.Location = new System.Drawing.Point(343, 345);
            this.kq.Name = "kq";
            this.kq.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.kq.Properties.Caption = "";
            this.kq.Size = new System.Drawing.Size(72, 19);
            this.kq.TabIndex = 30;
            // 
            // pq
            // 
            this.pq.EditValue = null;
            this.pq.Location = new System.Drawing.Point(343, 399);
            this.pq.Name = "pq";
            this.pq.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.pq.Properties.Caption = "";
            this.pq.Size = new System.Drawing.Size(72, 19);
            this.pq.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(625, 348);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 13);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "Học viên";
            this.lblID.Visible = false;
            // 
            // phaQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.hv);
            this.Controls.Add(this.nv);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.pq);
            this.Name = "phaQuyen";
            this.Size = new System.Drawing.Size(896, 645);
            this.Load += new System.EventHandler(this.phaQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pq.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton bntThem;
        private DevExpress.XtraEditors.CheckEdit hv;
        private DevExpress.XtraEditors.CheckEdit nv;
        private DevExpress.XtraEditors.CheckEdit kq;
        private DevExpress.XtraEditors.CheckEdit pq;
        private DevExpress.XtraEditors.LabelControl lblID;

    }
}
