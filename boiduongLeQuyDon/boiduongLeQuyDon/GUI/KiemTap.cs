using System;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class KiemTap : DevExpress.XtraEditors.XtraUserControl
    {
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSHocVien hv = new BUSHocVien();
        public KiemTap()
        {
            InitializeComponent();
        }
        bdlqdDataSet1TableAdapters.getChamTap_allTableAdapter chamtapall = new bdlqdDataSet1TableAdapters.getChamTap_allTableAdapter();
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
    //    coSoBoiDuongDataSetTableAdapters.chamTapTableAdapter da = new coSoBoiDuongDataSetTableAdapters.chamTapTableAdapter();
        private void KiemTap_Load(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
            //coSoBoiDuongDataSet ds= new coSoBoiDuongDataSet();
          
            gridControl1.DataSource = chamtapall.GetData();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            this.Dock = DockStyle.Fill;
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
         //   gridControl1.RefreshDataSource();
        }
        void load()
        {
            gridControl1.RefreshDataSource();
            //coSoBoiDuongDataSet ds= new coSoBoiDuongDataSet();

            gridControl1.DataSource = chamtapall.GetData();
        }
        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void lkLop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lkPhep.Properties.DataSource = hv.getdiemdanh(lkLop.EditValue.ToString()).Tables[0];
                lkPhep.Properties.DisplayMember = "Họ tên";
                lkPhep.Properties.ValueMember = "ID";
            }
            catch
            {
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          //  foreach (var item in lkPhep.Properties.Items.GetCheckedValues())
           // {
                try
                {
                    queries.insertChamTap(Convert.ToInt32(lkPhep.EditValue.ToString()), Convert.ToDateTime(dtNgay.Text), txtGhichu.Text, Convert.ToInt32(lkLop.EditValue.ToString()));
                    load();
                }
                catch
                {
                }
         //   }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtGhichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kiểm tra").ToString();
          //  txtMon.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Môn chuyên").ToString();
          //  txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                queries.updateChamTap(txtGhichu.Text,Convert.ToInt32(lblID.Text));
                load();
            }
            catch
            {
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                queries.xoaChamtap(Convert.ToInt32(lblID.Text));
                load();
            }
            catch
            {
            }
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
