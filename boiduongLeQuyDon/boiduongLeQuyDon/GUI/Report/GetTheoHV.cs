using System;
using DevExpress.XtraPivotGrid;
using boiduongLeQuyDon.BUS;
using System.Data;

namespace boiduongLeQuyDon.GUI.Report
{
    public partial class GetTheoHV : DevExpress.XtraReports.UI.XtraReport
    {
        BUSChiTietTKB bus = new BUSChiTietTKB();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
     
        int  lop;
   
     
        coSoBoiDuongDataSetTableAdapters.DataTable4TableAdapter kq = new coSoBoiDuongDataSetTableAdapters.DataTable4TableAdapter();
        coSoBoiDuongDataSetTableAdapters.deTableAdapter dedt = new coSoBoiDuongDataSetTableAdapters.deTableAdapter();
    
        public GetTheoHV(DataTable dtmp,string lop, string tenlop,  string hovaten, int idhocvien,  DataTable data2, DataTable data3, DataTable data4, int sotrang)
        {
            InitializeComponent();
            xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = false;
            xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            lbtende.Text = hovaten;      
            this.lop = Convert.ToInt32(lop);   
                xrPivotGrid1.DataSource = dtmp;
                xrPivotGrid2.DataSource = data2;
                xrPivotGrid3.DataSource = data3;
                xrPivotGrid4.DataSource = data4;
                if (sotrang == 1)
                {
                    xrPivotGrid2.Visible = false;
                    xrPivotGrid3.Visible = false;
                    xrPivotGrid4.Visible = false;
                }
                if (sotrang == 2)
                {
                    xrPivotGrid3.Visible = false;
                    xrPivotGrid4.Visible = false;
                }
                if (sotrang == 3)
                {
                    xrPivotGrid4.Visible = false;
                }
               
     
      
            string giangvien = bus.getgv(lop).Tables[0].Rows[0]["Giáo viên"].ToString();
        
            lbgv.Text = "Giáo viên:" + giangvien;
            string namhoc = bus.getgv(lop).Tables[0].Rows[0]["Giáo viên"].ToString();
            lblop.Text = "Lớp: " + tenlop;         
        }

        private void xrPivotGrid1_CustomRowHeight(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs e)
        {
            e.RowHeight = 22;
        }

    }
}
