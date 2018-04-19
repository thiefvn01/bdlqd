using System;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class thoiKhoaBieu : DevExpress.XtraEditors.XtraUserControl
    {
        BUSChiTietTKB bus = new BUSChiTietTKB();
        BUSThoiKhoaBieu bustkb = new BUSThoiKhoaBieu();
        public thoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void thoiKhoaBieu_Load(object sender, EventArgs e)
        {
            
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
            gridView1.PopulateColumns();
            lkTKB.Properties.DataSource = bustkb.gettt().Tables[0];
            lkTKB.Properties.ValueMember = "ID";
            lkTKB.Properties.DisplayMember = "Tên TKB";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemTKB tkb = new ThemTKB();
            tkb.Show();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            try
            {
             //   MessageBox.Show(lkTKB.EditValue.ToString());
                bus.insert(txtSTT.Text, txtMonHoc.Text, txtLop.Text, txtGiaoVien.Text, txtThu.Text, txtThoiGian.Text, txtHocPhi.Text, lkTKB.EditValue.ToString());
                load();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bus.update(txtSTT.Text,txtMonHoc.Text,txtLop.Text,txtGiaoVien.Text,txtThu.Text,txtThoiGian.Text,txtHocPhi.Text,lblID.Text);
                load();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                bus.delete(lblID.Text);
                load();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            txtSTT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "STT").ToString();
            txtLop.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Lớp").ToString();
            txtMonHoc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Môn học").ToString();
         //   txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtGiaoVien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Giáo Viên").ToString();
            txtThu.Text=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thứ").ToString();
            txtThoiGian.Text=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Thời gian").ToString();
            txtHocPhi.Text=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Học phí").ToString();
           // txtSoTuan.Text=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số tuần").ToString();
      //      txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
        }
        private void load()
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.get().Tables[0];
            gridView1.PopulateColumns();
            //  txtNgayKetThuc.Text = Convert.ToDateTime(txtNgayKetThuc.Text).ToShortDateString();
        }

        private void lkTKB_EditValueChanged(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bus.gettkb(lkTKB.EditValue.ToString()).Tables[0];
            gridView1.PopulateColumns();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                lkTKB.Properties.DataSource = bustkb.get(1).Tables[0];
            }
            else
            {
                lkTKB.Properties.DataSource = bustkb.gettt().Tables[0];
            }
        }
    }
}
