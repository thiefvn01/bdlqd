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
        bdlqdDataSet1TableAdapters.getLopHienTaiTableAdapter lophientai = new bdlqdDataSet1TableAdapters.getLopHienTaiTableAdapter();
        bdlqdDataSet1TableAdapters.getTatCaCacLopTableAdapter tatcalop = new bdlqdDataSet1TableAdapters.getTatCaCacLopTableAdapter();
        bdlqdDataSet1TableAdapters.QueriesTableAdapter queries = new bdlqdDataSet1TableAdapters.QueriesTableAdapter();
        public QLHocPhi()
        {
            InitializeComponent();
            gridView2.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsBehavior.Editable = false;
        }
        string idlop = "";
        private void QLHocPhi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            gridControl2.DataSource = lophientai.GetData();
            upTKB.Properties.DataSource = tkb.gettt().Tables[0];
            upTKB.Properties.DisplayMember = "Tên TKB";
            upTKB.Properties.ValueMember = "ID";
        }

        private void bntDK_Click(object sender, EventArgs e)
        {

        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
           /// lopcc = Convert.ToInt32(lblLC.Text);
         //   if (lopcc != 0 && Convert.ToInt32(upLop.EditValue.ToString()) != lopcc)
            //    checkchange = 1;
            //else
            //checkchange = 0;
            bdlqdDataSet1TableAdapters.getLop1TableAdapter getlopgoc = new bdlqdDataSet1TableAdapters.getLop1TableAdapter();
            DataTable dt1 = getlopgoc.GetData(Convert.ToInt32(lblID.Text), Convert.ToInt32(lblLC.Text));
            int lopgoc = Convert.ToInt32(dt1.Rows[0][0].ToString());
            int idlop = Convert.ToInt32(dt1.Rows[0][1].ToString());
            //insert vào 1 lớp
            if (checkchange!=0)
            {
                //trường hợp đổi lớp

               
                //insert vào 1 dòng mới
                queries.insertLop(Convert.ToInt32(lblID.Text), Convert.ToInt32(upLop.EditValue.ToString()), txtusbl.Text, 1, idlop , lopgoc, "'Chuyển lớp'", Convert.ToInt32(textEdit2.Text), txtupGC.Text);
                //cập nhật lớp gốc
                queries.updateDoiLop(Convert.ToInt32(lblID.Text), idlop);
                checkchange = 0;
            }
            else
            {
                //trường hợp ko đổi lớp
                //Bình thường
                //Chuyển lớp
                //Nghỉ học
                //  Nghỉ học
                //Nghỉ tất cả cả lớp
                if (cbTrangThai.Text== "Nghỉ học")
                {
                    //trường hợp nghỉ của lớp đó
                    //cập nhật lại lớp đó với trạng thái = đã nghỉ
                    //tính số tiền còn lại của học viên đó để trả lại
                    queries.updateLopNghiHoc(Convert.ToInt32(lblID.Text), idlop);
                }
                else if(cbTrangThai.Text== "Nghỉ tất cả cả lớp")
                {
                    //trường hợp nghỉ tất cả các lớp
                    //cập nhật lại các lớp đang diễn ra của học viên đó với trạng thái là đã nghỉ
                    //tính số tiền còn lại của học viên đó ở tất cả các lớp để trả lại
                    queries.updateLopNghiHoc(1, Convert.ToInt32(lblLC.Text));
                }
                else if(cbTrangThai.Text!= "Nghỉ tất cả cả lớp" && cbTrangThai.Text!= "Nghỉ học")
                {
                    //trưởng hợp cập nhật số tiền đã đóng
                    if(textEdit2.Text!="")
                    queries.updateLopHocPhi(Convert.ToInt32(lblID.Text), idlop, txtusbl.Text, Convert.ToInt32(textEdit2.Text));
                }
                load();
            }
            //cập nhật lớp gốc
            //cập nhật 1 lớp
            //nếu nghỉ => set số tiền cần thanh toán lại
            //trường hợp đổi lớp => id lớp thay đổi
            //trường hợp cập nhật học phí => số biên lai thay đổi hoặc số tiền thay đổi  
        }
        void load()
        {
            gridControl2.RefreshDataSource();
            gridControl2.DataSource = lophientai.GetData();
            gridView2.PopulateColumns();
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
        int checkchange = 0;
        int lopcc = 0;
        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
            lblID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID Học sinh").ToString();
            lblLC.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID lớp").ToString();
            txtupGC.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Ghi chú").ToString();
            txtusbl.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Biên lai").ToString();
            textEdit2.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Học phí đã đóng").ToString();
            cbTrangThai.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Trạng thái").ToString();
            //upLop.EditValue=gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID lớp").ToString();
            lopcc = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID lớp").ToString());
            idlop = lblLC.Text;
        }

        private void checkEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkEdit1.CheckState == CheckState.Checked)
            {
          //      gridControl2.RefreshDataSource();
                gridControl2.DataSource=tatcalop.GetData();
                gridView2.PopulateColumns();
                upTKB.Properties.DataSource = tkb.get(1).Tables[0];
                upTKB.Properties.DisplayMember = "Tên TKB";
                upTKB.Properties.ValueMember = "ID";
            }
            else
            {
              //  gridControl2.RefreshDataSource();
                gridControl2.DataSource = lophientai.GetData();
                gridView2.PopulateColumns();
                upTKB.Properties.DataSource = tkb.gettt().Tables[0];
                upTKB.Properties.DisplayMember = "Tên TKB";
                upTKB.Properties.ValueMember = "ID";
            }
        }

        private void upLop_EditValueChanged(object sender, EventArgs e)
        {
            if (lopcc != 0 && Convert.ToInt32(upLop.EditValue.ToString()) != lopcc)
                checkchange = 1;
            else
            checkchange = 0;
        }


    }
}
