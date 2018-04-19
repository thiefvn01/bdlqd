using System;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class dotKiemTra : DevExpress.XtraEditors.XtraUserControl
    {
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSHocVien hv = new BUSHocVien();
        public dotKiemTra()
        {
            InitializeComponent();
        }
        coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter da = new coSoBoiDuongDataSetTableAdapters.kiemTraTableAdapter();
        private void dotKiemTra_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = da.GetData();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            this.Dock = DockStyle.Fill;
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
        }

        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void lkLop_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertQuery(txtDe.Text, Convert.ToInt32(lkLop.EditValue.ToString()), Convert.ToDateTime(dtngay.Text), Convert.ToInt32(txtHeso.Text),dbdang.Text);
                load();
            }
            catch
            {
            }

        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                da.DeleteQuery(Convert.ToInt32(lblID.Text));
                load();
            }
            catch
            {
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtDe.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã đề").ToString();
            txtHeso.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Hệ số").ToString();
  
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            try
            {
                da.UpdateQuery(txtDe.Text, Convert.ToInt32(txtHeso.Text),Convert.ToInt32(lblID.Text));
                load();
            }
            catch
            {
            }
        }
        void load()
        {
            gridControl1.DataSource = da.GetData();

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                lkKhoa.Properties.DataSource = tkb.get(1).Tables[0];
            }
            else
            {
                lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            }
        }
    }
}
