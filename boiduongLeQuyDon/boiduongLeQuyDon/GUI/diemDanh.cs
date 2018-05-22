using System;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraEditors;
using System.Data;
namespace boiduongLeQuyDon.GUI
{
    public partial class diemDanh : DevExpress.XtraEditors.XtraUserControl
    {
        BUSDiemDanh bus = new BUSDiemDanh();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        //coSoBoiDuongDataSetTableAdapters.LopTableAdapter loptb = new coSoBoiDuongDataSetTableAdapters.LopTableAdapter();
        DataTable dtlop = new DataTable();
      //  coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter diemdanh = new coSoBoiDuongDataSetTableAdapters.diemDanhTableAdapter();
        public diemDanh()
        {
            InitializeComponent();
        }

        private void diemDanh_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
       //     gridView1.PopulateColumns();
            lkKhoa.Properties.DataSource = tkb.gettt().Tables[0];
            lkKhoa.Properties.DisplayMember = "Tên TKB";
            lkKhoa.Properties.ValueMember = "ID";
            //lkLop.Properties.DataSource = ck.get().Tables[0];
            //lkLop.Properties.DisplayMember = "Lớp";
            //lkLop.Properties.ValueMember = "ID";
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
        }
        private void load()
        {
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
        //    gridView1.PopulateColumns();
        }
        private void lkKhoa_EditValueChanged(object sender, EventArgs e)
        {
            lkLop.Properties.DataSource = ck.get(lkKhoa.EditValue.ToString()).Tables[0];
            lkLop.Properties.DisplayMember = "Lớp";
            lkLop.Properties.ValueMember = "ID";
        }

        private void lkLop_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get(lkLop.EditValue.ToString()).Tables[0];
       //     gridView1.PopulateColumns();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            ThemDiemDanh dd = new ThemDiemDanh();
            dd.Show();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                bus.delete(lblID.Text);
                load();
            }
            catch
            {
                XtraMessageBox.Show("Vui lòng chọn 1 dòng để xóa");
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtGhichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
        }

        private void dtngay_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get(lkLop.EditValue.ToString(), dtngay.Text.ToString()).Tables[0];
    //        gridView1.PopulateColumns();
        }

        private void bntRf_Click(object sender, EventArgs e)
        {
            load();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bus.update(txtGhichu.Text, lblID.Text);
            load();
        }
       
        private void bntExport_Click(object sender, EventArgs e)
        {
            exportVang v = new exportVang();
            v.Show();
          
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
