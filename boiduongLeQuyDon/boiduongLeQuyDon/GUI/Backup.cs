using System;
using System.Linq;
using System. Xml.Linq;
using DevExpress.XtraSplashScreen;
using System.Xml;
using DevExpress.XtraEditors;
namespace boiduongLeQuyDon.GUI
{
    public partial class Backup : SplashScreen
    {
        public Backup()
        {
            InitializeComponent();
            
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config.xml");
                XmlNode root = doc.DocumentElement;
                XmlNode myNode = doc.DocumentElement["dong1"];
                myNode.FirstChild.InnerText = txtd1.Text;
                myNode = doc.DocumentElement["dong2"];
                myNode.FirstChild.InnerText = txtd2.Text;
                myNode = doc.DocumentElement["dong3"];
                myNode.FirstChild.InnerText = txtd3.Text;
                myNode = doc.DocumentElement["dong4"];
                myNode.FirstChild.InnerText = txtd4.Text;
                myNode = doc.DocumentElement["dong5"];
                myNode.FirstChild.InnerText = txtd5.Text;
                myNode = doc.DocumentElement["dong6"];
                myNode.FirstChild.InnerText = txtd6.Text;
                myNode = doc.DocumentElement["canbo"];
                myNode.FirstChild.InnerText = txtcb.Text;
                doc.Save("config.xml");
                XtraMessageBox.Show("Đã cập nhật thành công");
            }
            catch { }
        //    load();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
    //        OdbcConnection conn = new OdbcConnection();
            XDocument doc = XDocument.Load("config.xml");

            txtd1.Text = doc.Element("sets").Elements("dong1").FirstOrDefault().Value.ToString();
            txtd2.Text = doc.Element("sets").Elements("dong2").FirstOrDefault().Value.ToString();
            txtd3.Text = doc.Element("sets").Elements("dong3").FirstOrDefault().Value.ToString();
            txtd4.Text = doc.Element("sets").Elements("dong4").FirstOrDefault().Value.ToString();
            txtd5.Text = doc.Element("sets").Elements("dong5").FirstOrDefault().Value.ToString();
            txtd6.Text = doc.Element("sets").Elements("dong6").FirstOrDefault().Value.ToString();
            txtcb.Text = doc.Element("sets").Elements("canbo").FirstOrDefault().Value.ToString();
        }
        private void load(){
            XDocument doc = XDocument.Load("config.xml");
            txtd1.Text = doc.Element("sets").Elements("dong1").FirstOrDefault().Value.ToString();
            txtd2.Text = doc.Element("sets").Elements("dong2").FirstOrDefault().Value.ToString();
            txtd3.Text = doc.Element("sets").Elements("dong3").FirstOrDefault().Value.ToString();
            txtd4.Text = doc.Element("sets").Elements("dong4").FirstOrDefault().Value.ToString();
            txtd5.Text = doc.Element("sets").Elements("dong5").FirstOrDefault().Value.ToString();
            txtd6.Text = doc.Element("sets").Elements("dong6").FirstOrDefault().Value.ToString();
            txtcb.Text = doc.Element("sets").Elements("canbo").FirstOrDefault().Value.ToString();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}