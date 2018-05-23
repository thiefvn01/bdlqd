using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.GUI
{
    public partial class ChangeSource : SplashScreen
    {
        public ChangeSource()
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
                doc.Load("app.xml");
                XmlNode root = doc.DocumentElement;
                XmlNode myNode = doc.DocumentElement["IP"];
                myNode.FirstChild.InnerText = txtIP.Text;
                myNode = doc.DocumentElement["USER"];
                myNode.FirstChild.InnerText = txtUname.Text;
                myNode = doc.DocumentElement["PASS"];
                myNode.FirstChild.InnerText = txtPasswd.Text;               
                doc.Save("app.xml");
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch { }
        }

        private void ChangeSource_Load(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("app.xml");
            txtIP.Text = doc.Element("sets").Elements("IP").FirstOrDefault().Value.ToString();
            txtUname.Text = doc.Element("sets").Elements("USER").FirstOrDefault().Value.ToString();
            txtPasswd.Text = doc.Element("sets").Elements("PASS").FirstOrDefault().Value.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            var connection = "Data Source=" + txtIP.Text + ";Initial Catalog= bdlqd ;UID=" + txtUname.Text + ";password=" + txtPasswd.Text + ";Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();                    
                    conn.Close();
                    MessageBox.Show("Kết nối thành công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Có lỗi kết nối");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}