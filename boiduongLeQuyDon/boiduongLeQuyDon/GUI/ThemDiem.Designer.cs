namespace boiduongLeQuyDon.GUI
{
    partial class ThemDiem
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
            this.lblCau = new DevExpress.XtraEditors.LabelControl();
            this.txtDiem = new DevExpress.XtraEditors.TextEdit();
            this.bntCN = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txterr = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCau
            // 
            this.lblCau.Location = new System.Drawing.Point(87, 61);
            this.lblCau.Name = "lblCau";
            this.lblCau.Size = new System.Drawing.Size(12, 13);
            this.lblCau.TabIndex = 0;
            this.lblCau.Text = "1a";
            // 
            // txtDiem
            // 
            this.txtDiem.EditValue = "0";
            this.txtDiem.Location = new System.Drawing.Point(118, 94);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDiem.TabIndex = 1;
            // 
            // bntCN
            // 
            this.bntCN.Location = new System.Drawing.Point(133, 159);
            this.bntCN.Name = "bntCN";
            this.bntCN.Size = new System.Drawing.Size(75, 23);
            this.bntCN.TabIndex = 2;
            this.bntCN.Text = "Cập nhật";
            this.bntCN.Click += new System.EventHandler(this.bntCN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đóng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txterr
            // 
            this.txterr.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txterr.Location = new System.Drawing.Point(252, 97);
            this.txterr.Name = "txterr";
            this.txterr.Size = new System.Drawing.Size(117, 13);
            this.txterr.TabIndex = 0;
            this.txterr.Text = "Điểm lớn hơn điểm tối đa";
            this.txterr.Visible = false;
            // 
            // ThemDiem
            // 
            this.AcceptButton = this.bntCN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCN);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txterr);
            this.Controls.Add(this.lblCau);
            this.Name = "ThemDiem";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ThemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCau;
        private DevExpress.XtraEditors.TextEdit txtDiem;
        private DevExpress.XtraEditors.SimpleButton bntCN;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl txterr;

    }
}
