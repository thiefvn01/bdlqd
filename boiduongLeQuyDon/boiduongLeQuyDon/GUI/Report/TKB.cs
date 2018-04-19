using System;
using System.Linq;
using System.Xml.Linq;
namespace boiduongLeQuyDon.GUI.Report
{
    public partial class TKB : DevExpress.XtraReports.UI.XtraReport
    {
        public TKB(int id,string ten, string namhoc, DateTime khaigiang,string gc1, string gc2, string gc3, string gc4 , string ngay)
        {
            InitializeComponent();
            chiTietTKBAdapter1.GetData(id);
            this.gc1 = gc1;
            this.gc2 = gc2;
            this.gc3 = gc3;
            this.gc4 = gc4;
            this.ten = ten;
            this.namhoc = namhoc;
            this.khaigiang = khaigiang;
            this.ngay = ngay;
            load();
        }
        string gc1, gc2, gc3, gc4, ten, namhoc, ngay;
        DateTime khaigiang;
        private void load()
        {
            XDocument doc = XDocument.Load("config.xml");
            d1.Text = doc.Element("sets").Elements("dong1").FirstOrDefault().Value.ToString();
            d2.Text = doc.Element("sets").Elements("dong2").FirstOrDefault().Value.ToString();
            d3.Text = doc.Element("sets").Elements("dong3").FirstOrDefault().Value.ToString();
            d4.Text = doc.Element("sets").Elements("dong4").FirstOrDefault().Value.ToString();
            d5.Text = doc.Element("sets").Elements("dong5").FirstOrDefault().Value.ToString();
            d6.Text = doc.Element("sets").Elements("dong6").FirstOrDefault().Value.ToString();
            lb1.Text = gc1;
            lb2.Text = gc2;
            lb3.Text = gc3;
            lb4.Text = gc4;
            tiltle1.Text = ten.ToUpper() + " - " + "NĂM HỌC " + namhoc;
            title2.Text = "KHAI GIẢNG NGÀY   "  + khaigiang.ToShortDateString();
            Ngay.Text = ngay;
        }

    }
}
