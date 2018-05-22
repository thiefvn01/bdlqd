using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Linq;
using System.Xml.Linq;
using System.Configuration;
//using ICSharpCode.SharpZipLib.Core;
//using ICSharpCode.SharpZipLib.Zip;
namespace boiduongLeQuyDon.GUI
{
    public partial class Login : SplashScreen
    {
        BUSgiaoVien bus = new BUSgiaoVien();
        public Login()
        {
            InitializeComponent();
            load();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }
        void load()
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["boiduongLeQuyDon.Properties.Settings.bdlqdConnectionString1"].ConnectionString;
            int temp = 0;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    temp = 1;
                }
                catch (SqlException)
                {
                    temp = 0;
                }
            }
            string d1, d2, d3, d4;
            if (temp == 0)
            {
                XDocument doc = XDocument.Load("app.xml");
                d1 = doc.Element("sets").Elements("IP").FirstOrDefault().Value.ToString();
                d2 = doc.Element("sets").Elements("USER").FirstOrDefault().Value.ToString();
                d3 = doc.Element("sets").Elements("PASS").FirstOrDefault().Value.ToString();
                d4 = doc.Element("sets").Elements("cat").FirstOrDefault().Value.ToString();
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["boiduongLeQuyDon.Properties.Settings.bdlqdConnectionString1"].ConnectionString = "Data Source="+d1 + ";Initial Catalog="+d4+";UID="+d2+";password="+d3 + ";Integrated Security=True";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
            }
                    
        }
        #endregion
        
        public enum SplashScreenCommand
        {
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string a="";
            try
            {
                a = bus.login(txtUname.Text).Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
            if (a == txtPasswd.Text.ToString())
            {
              //  TextWriter tx = new StreamWriter("tmp.txt");
             //   tx.WriteLine(txtUname.Text.ToString());
             //   tx.Close();
                Form1 fr = new Form1(bus.login1(txtUname.Text).Tables[0].Rows[0][0].ToString(),txtUname.Text);
                fr.Show();
                this.Visible = false;
           //     MessageBox.Show(this.ParentForm.Name.ToString());
            }
            else
                XtraMessageBox.Show("Có lỗi xảy ra");
           
               
        }
        string filein;
        private void Login_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = @"Data Source=KURT;Initial Catalog=bdlqd;User ID=sa;Password=Expelliarmus@1;";
            //    conn.Open();
            //    conn.Close();
            //}
            //catch
            //{
            //    if (MessageBox.Show("Hệ thống chưa có cơ sở dữ liệu, bạn có muốn import từ file Back up", "Có", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //    {
                
            //    }
            //    else
            //    {
            //        MessageBox.Show("Hệ thống chưa có dữ liệu, phải đóng lại");
            //    this.Close();
            //    }
            //}
            txtUname.Focus();
            this.TopLevel = true;
        }
        public void ExtractZipFile(string archiveFilenameIn, string password, string outFolder)
        {
            //ZipFile zf = null;
            //try
            //{
            //    FileStream fs = File.OpenRead(archiveFilenameIn);
            //    zf = new ZipFile(fs);
            //    if (!String.IsNullOrEmpty(password))
            //    {
            //        zf.Password = password;     // AES encrypted entries are handled automatically
            //    }
            //    foreach (ZipEntry zipEntry in zf)
            //    {
            //        if (!zipEntry.IsFile)
            //        {
            //            continue;           // Ignore directories
            //        }
            //        String entryFileName = zipEntry.Name;
            //        // to remove the folder from the entry:- entryFileName = Path.GetFileName(entryFileName);
            //        // Optionally match entrynames against a selection list here to skip as desired.
            //        // The unpacked length is available in the zipEntry.Size property.

            //        byte[] buffer = new byte[4096];     // 4K is optimum
            //        Stream zipStream = zf.GetInputStream(zipEntry);

            //        // Manipulate the output filename here as desired.
            //        String fullZipToPath = Path.Combine(outFolder, entryFileName);
            //        string directoryName = Path.GetDirectoryName(fullZipToPath);
            //        if (directoryName.Length > 0)
            //            Directory.CreateDirectory(directoryName);

            //        // Unzip file in buffered chunks. This is just as fast as unpacking to a buffer the full size
            //        // of the file, but does not waste memory.
            //        // The "using" will close the stream even if an exception occurs.
            //        using (FileStream streamWriter = File.Create(fullZipToPath))
            //        {
            //            StreamUtils.Copy(zipStream, streamWriter, buffer);
            //        }
            //    }
            //}
            //finally
            //{
            //    if (zf != null)
            //    {
            //        zf.IsStreamOwner = true; // Makes close also shut the underlying stream
            //        zf.Close(); // Ensure we release resources
            //    }
            //}
        }
        private void labelControl3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            //Bck ck = new Bck();
            //ck.Show();
        }
    }
}