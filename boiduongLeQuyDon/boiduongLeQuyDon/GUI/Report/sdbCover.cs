using System;
using boiduongLeQuyDon.BUS;
using System.Data;
namespace boiduongLeQuyDon.GUI.Report
{
    public partial class sdbCover : DevExpress.XtraReports.UI.XtraReport
    {
        BUSChiTietTKB bus = new BUSChiTietTKB();
        BUSThoiKhoaBieu tkb = new BUSThoiKhoaBieu();
        public sdbCover(string id,string idtkb)
        {
            this.id = id;
            InitializeComponent();
            this.idtkb = idtkb;
            load();
        }
        string idtkb;
        string id;
        private void load()
        {
            DataSet ds = new DataSet();
            ds=bus.getgv(id);
            
            gio.Text = ds.Tables[0].Rows[0]["Thời gian"].ToString() + "  (Thứ" + ds.Tables[0].Rows[0]["Thứ"].ToString() +")";
            giangvien.Text = ds.Tables[0].Rows[0]["Giáo viên"].ToString();
            lop.Text = ds.Tables[0].Rows[0]["Lớp"].ToString();
            ngayhoc.Text = Convert.ToDateTime(tkb.getinf(idtkb).Tables[0].Rows[0][0].ToString()).ToShortDateString();
            tentkb.Text = tkb.get(idtkb).Tables[0].Rows[0]["Tên TKB"].ToString().ToUpper() + " - NĂM HỌC " + tkb.get(idtkb).Tables[0].Rows[0]["Năm học"].ToString().ToUpper();

        }
    }
}
