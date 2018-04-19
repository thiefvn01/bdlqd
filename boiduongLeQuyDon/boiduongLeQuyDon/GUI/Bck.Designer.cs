namespace boiduongLeQuyDon.GUI
{
    partial class Bck
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
            this.bntBck = new DevExpress.XtraEditors.SimpleButton();
            this.bntRes = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // bntBck
            // 
            this.bntBck.Location = new System.Drawing.Point(48, 12);
            this.bntBck.Name = "bntBck";
            this.bntBck.Size = new System.Drawing.Size(75, 23);
            this.bntBck.TabIndex = 0;
            this.bntBck.Text = "Back up";
            this.bntBck.Click += new System.EventHandler(this.bntBck_Click);
            // 
            // bntRes
            // 
            this.bntRes.Location = new System.Drawing.Point(188, 12);
            this.bntRes.Name = "bntRes";
            this.bntRes.Size = new System.Drawing.Size(75, 23);
            this.bntRes.TabIndex = 0;
            this.bntRes.Text = "Restore";
            this.bntRes.Click += new System.EventHandler(this.bntRes_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(125, 62);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Đóng";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Bck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton2;
            this.ClientSize = new System.Drawing.Size(311, 103);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.bntRes);
            this.Controls.Add(this.bntBck);
            this.Name = "Bck";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Bck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bntBck;
        private DevExpress.XtraEditors.SimpleButton bntRes;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;

    }
}
