﻿using System;
using DevExpress.XtraPivotGrid;
using boiduongLeQuyDon.BUS;
using System.Data;

namespace boiduongLeQuyDon.GUI.Report
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        BUSChiTietTKB bus = new BUSChiTietTKB();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();

        int de,  lop;     
        public XtraReport1(string lop,string tenlop,int de,string made,  DataTable data1, DataTable data2, DataTable data3, int sotrang)
        {
            InitializeComponent();                  
            lbtende.Text = made;            
            this.de = de;
            this.lop = Convert.ToInt32(lop);      
            xrPivotGrid1.DataSource = data1;
            xrPivotGrid2.DataSource = data2;
            xrPivotGrid3.DataSource = data3;   
            string giangvien = bus.getgv(lop).Tables[0].Rows[0]["Giáo viên"].ToString();   
            lbgv.Text = "Giáo viên:" + giangvien;
            string namhoc = bus.getgv(lop).Tables[0].Rows[0]["Giáo viên"].ToString();
            lblop.Text = "Lớp: " + tenlop; 
            if(sotrang==1)
            {
                xrPivotGrid2.Visible=false;
                xrPivotGrid3.Visible=false;
            }
            else if (sotrang==2)
                xrPivotGrid3.Visible = false;
            
        }
      
     
        private void xrPivotGrid1_FieldValueDisplayText(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotFieldDisplayTextEventArgs e)
        {
         
        }
        private void xrPivotGrid2_CustomRowHeight(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs e)
        {
            e.RowHeight = 20;
        }

        private void xrPivotGrid1_CustomRowHeight(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs e)
        {
          
            e.RowHeight = 20;
        }
    }
}
