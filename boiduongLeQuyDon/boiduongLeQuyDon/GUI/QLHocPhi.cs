using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class QLHocPhi : UserControl
    {
        BUSHocVien hv = new BUSHocVien();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSLop lop = new BUSLop();
        public QLHocPhi()
        {
            InitializeComponent();
        }

        private void QLHocPhi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void bntDK_Click(object sender, EventArgs e)
        {

        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bntXoa_Click(object sender, EventArgs e)
        {

        }

        private void upTKB_EditValueChanged(object sender, EventArgs e)
        {
            upLop.Properties.DataSource = ck.get(upTKB.EditValue.ToString()).Tables[0];
            upLop.Properties.DisplayMember = "Lớp";
            upLop.Properties.ValueMember = "ID";
        }
    }
}
