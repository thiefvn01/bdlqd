using System;
using System.Data;
using boiduongLeQuyDon.BUS;

namespace boiduongLeQuyDon.GUI.Report
{
    public partial class kqToan : DevExpress.XtraReports.UI.XtraReport
    {
        BUSChiTietTKB bus = new BUSChiTietTKB();
        public kqToan()
        {
            InitializeComponent();
          
        }  

    }
}
