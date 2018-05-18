using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace boiduongLeQuyDon.GUI
{
    public partial class QLCaBiet : DevExpress.XtraEditors.XtraUserControl
    {
        public QLCaBiet()
        {
            InitializeComponent();
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
            if (ckTatCa.CheckState == CheckState.Checked)
            {
                load();
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
            queries.deleteCaBiet(Convert.ToInt32(lblID.Text));
            load();
        }
        void load()
        {
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = cabiet.GetData();
            gridView1.PopulateColumns();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtDacDiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Đặc điểm").ToString();
            txtViPham.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nội dung vi phạm").ToString();
            txtSoLan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số lần").ToString();
            txtNguyenNhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nguyên nhân").ToString();
            txtKhacPhuc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Khắc phục").ToString();
            
        }
    }
}
