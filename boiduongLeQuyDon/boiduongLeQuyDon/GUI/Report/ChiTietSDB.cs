using System;
using System.Data;

namespace boiduongLeQuyDon.GUI.Report
{
    public partial class ChiTietSDB : DevExpress.XtraReports.UI.XtraReport
    {
       BUS.BUSThoiKhoaBieu bus = new BUS.BUSThoiKhoaBieu();
        BUS.BUSChiTietTKB ck = new BUS.BUSChiTietTKB();
        public ChiTietSDB(string id, string tungay)
        {
            InitializeComponent();
            this.id = id;
            this.tungay = tungay;
            load();
        }
        string id;
        string tungay;
        private void load()
        {
            DataSet ds = new DataSet();
            ds = bus.getinf(ck.get2(id).Tables[0].Rows[0]["idTKB"].ToString());
            string ngaybatdau;
            ngaybatdau = ds.Tables[0].Rows[0][0].ToString();          
            int sotuan = 0;
            DateTime tu=Convert.ToDateTime(ngaybatdau);
            DateTime den = Convert.ToDateTime(tungay);
            bd.Text = den.ToShortDateString();
            sotuan = (-tu.Year * 365 - tu.Month * 30 - tu.Day + den.Year * 365 + den.Month * 30 + den.Day) / 7;
            kt.Text = den.AddDays(7).ToShortDateString();
            st.Text = (sotuan+1).ToString();
        }

    }
}
