using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI
{
    public partial class phaQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        BUSgiaoVien gv = new BUSgiaoVien();
        public phaQuyen()
        {
            InitializeComponent();
           // this.id = id;
        }
       // string id;
        private void bntThem_Click(object sender, EventArgs e)
        {
            int hvv,nvv,pqv,kqv;
            if(hv.Checked){
                hvv=1;
            }
            else{
                hvv=0;
            }
                 if(nv.Checked){
                nvv=1;
            }
            else{
                nvv=0;
            }
                 if(pq.Checked){
                pqv=1;
            }
            else{
                pqv=0;
            }
                 if(kq.Checked){
                kqv=1;
            }
            else{
                kqv=0;
            }
            try{
                gv.updatepq(nvv.ToString(), hvv.ToString(), kqv.ToString(), pqv.ToString(), lblID.Text);
                load();
            }
            catch{
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }


        private void phaQuyen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = gv.getpq().Tables[0];
            gridView1.PopulateColumns();
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
        }
        private void load()
        {
            this.Dock = DockStyle.Fill;
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = gv.getpq().Tables[0];
            gridView1.PopulateColumns();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            lblID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nhân viên").ToString() == "x")
                nv.Checked = true;
            else
                nv.Checked = false;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Học viên").ToString() == "x")
                hv.Checked = true;
            else
                hv.Checked = false;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kết quả").ToString() == "x")
                kq.Checked = true;
            else
                kq.Checked = false;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phân quyền").ToString() == "x")
                pq.Checked = true;
            else
                pq.Checked = false;
     
        }
    }
}
