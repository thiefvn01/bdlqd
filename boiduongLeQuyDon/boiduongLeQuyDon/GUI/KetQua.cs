using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class KetQua : DevExpress.XtraEditors.XtraUserControl
    {
        BUSKetQuaToan bus = new BUSKetQuaToan();
        public KetQua()
        {
            InitializeComponent();
        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
            gridView1.PopulateColumns();
        }
    }
}
