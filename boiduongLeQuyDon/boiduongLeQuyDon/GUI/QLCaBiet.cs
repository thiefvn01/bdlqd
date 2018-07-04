using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using boiduongLeQuyDon.BUS;


namespace boiduongLeQuyDon.GUI
{
    public partial class QLCaBiet : DevExpress.XtraEditors.XtraUserControl
    {
        public QLCaBiet()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            this.Dock = DockStyle.Fill;
        }
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        bdlqdDataSet1TableAdapters.getCaBiet1TableAdapter cabiet = new bdlqdDataSet1TableAdapters.getCaBiet1TableAdapter();
        bdlqdDataSet1TableAdapters.getCaBiet_allTableAdapter cabietall = new bdlqdDataSet1TableAdapters.getCaBiet_allTableAdapter();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(ckGiaiQuyet.CheckState==CheckState.Checked)
                queries.updateCaBiet(txtDacDiem.Text, txtNguyenNhan.Text, txtKhacPhuc.Text, txtViPham.Text, Convert.ToInt32(txtSoLan.Text), true, Convert.ToInt32(lblID.Text));
            else
                queries.updateCaBiet(txtDacDiem.Text, txtNguyenNhan.Text, txtKhacPhuc.Text, txtViPham.Text, Convert.ToInt32(txtSoLan.Text), false, Convert.ToInt32(lblID.Text));
            load();
        }

        private void ckTatCa_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckTatCa.CheckState == CheckState.Unchecked)
            {
                //  gridControl1.RefreshDataSource();
                gridControl1.RefreshDataSource();
                gridControl1.DataSource = cabiet.GetData();
                gridView1.PopulateColumns();
                //  gridControl1.RefreshDataSource();

            }
            else
            {
                gridControl1.RefreshDataSource();
                gridControl1.DataSource = cabietall.GetData();
               gridView1.PopulateColumns();
            }
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            queries.insertCaBiet(Convert.ToInt32(lkHocVien.EditValue), txtDacDiem.Text, txtNguyenNhan.Text, txtKhacPhuc.Text, txtViPham.Text);
            load();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                queries.deleteCaBiet(Convert.ToInt32(lblID.Text));
            load();
        }
        void load()
        {
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = cabiet.GetData();
          //  gridView1.PopulateColumns();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString();
            txtDacDiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Đặc điểm").ToString();
            txtViPham.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nội dung vi phạm").ToString();
            txtSoLan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số lần").ToString();
            txtNguyenNhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nguyên nhân").ToString();
            txtKhacPhuc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Khắc phục").ToString();
            
        }
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        BUSChiTietTKB ck = new BUSChiTietTKB();
        BUSHocVien hv1 = new BUSHocVien();

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = ck.get(lookUpEdit1.EditValue.ToString()).Tables[0];
            lookUpEdit2.Properties.DisplayMember = "Lớp";
            lookUpEdit2.Properties.ValueMember = "ID";
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            lkHocVien.Properties.DataSource = hv1.getdiemdanh(lookUpEdit2.EditValue.ToString()).Tables[0];
            lkHocVien.Properties.DisplayMember = "Họ tên";
            lkHocVien.Properties.ValueMember = "ID";
        }

        private void checkEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                lookUpEdit1.Properties.DataSource = tkb.get(1).Tables[0];
                lookUpEdit1.Properties.DisplayMember = "Ten TKB";
                lookUpEdit1.Properties.ValueMember = "ID";
            }
            else
            {
                lookUpEdit1.Properties.DataSource = tkb.gettt().Tables[0];
                lookUpEdit1.Properties.DisplayMember = "Ten TKB";
                lookUpEdit1.Properties.ValueMember = "ID";
            }
        }
    }
}
