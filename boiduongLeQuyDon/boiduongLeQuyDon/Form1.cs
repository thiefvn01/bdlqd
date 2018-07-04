using System;
using System.Data;
using System.Windows.Forms;
using boiduongLeQuyDon.GUI;
using boiduongLeQuyDon.BUS;
using DevExpress.XtraEditors;
using System.IO;

namespace boiduongLeQuyDon
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string id;
        public Form1(string id,string uname)
        {
            
            InitializeComponent();
            this.id = id;
            this.uname = uname;
   //             if (this.uname == "admin")
   ////         MessageBox.Show(this.uname);
   //           barButtonItem28.Enabled = true;
   //               else
   //         //        MessageBox.Show(this.uname);
   //             barButtonItem28.Enabled = false;
        }
        string uname;
        
        BUSgiaoVien bus = new BUSgiaoVien();
        private void Form1_Load(object sender, EventArgs e)
        {
            
          //  barButtonItem7.Enabled = false;
            DataSet ds = new DataSet();
            ds = bus.getpq(id);
            string nv, hv, kq, pq;
            if (id != "1")
            {
                nv = ds.Tables[0].Rows[0]["Nhân viên"].ToString();
                hv = ds.Tables[0].Rows[0]["Học viên"].ToString();
                kq = ds.Tables[0].Rows[0]["Kết quả"].ToString();
                pq = ds.Tables[0].Rows[0]["Phân quyền"].ToString();
                if (nv != "1")
                    rbgv.Visible = false;
                if (hv != "1")
                    rbhv.Visible = false;
                if (kq != "1")
                    rbkq.Visible = false;
                if (pq != "1")
                    rbpq.Visible = false;
   
            }
            this.Text = "Cơ sở bồi dưỡng Trương Tứ Hải";
        }

        private void ribdmCaHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
     //       dmCaHoc ca = new dmCaHoc();
    //        ucMain.Controls.Add(ca);
            this.Text = "Ca học";
        }

        private void ribdmChucDanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
          //  dmChucDanh uc = new dmChucDanh();
         //   ucMain.Controls.Add(uc);
         //   this.Text = "Chức danh";
        }

        private void ribdmHocHam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }

        private void ribdmHocVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void ribdmLoaiTruongHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void ribdmLoaiMienGiam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            giaoVien uc = new giaoVien();
            ucMain.Controls.Add(uc);
            this.Text = "Quản lý giáo viên/nhân viên";
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            thoiKhoaBieu uc = new thoiKhoaBieu();
            ucMain.Controls.Add(uc);
            this.Text = "Thời khóa biểu";
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            hocVien uc = new hocVien();
            ucMain.Controls.Add(uc);
            this.Text = "Học viên";
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DKLop dk = new DKLop();
            //dk.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            diemDanh uc = new diemDanh();
            ucMain.Controls.Add(uc);
            this.Text = "Kết quả";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  GUI.Report.XtraReport1 tkb = new GUI.Report.XtraReport1();
          //  tkb.ShowPreview();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            soDauBai uc = new soDauBai();
            ucMain.Controls.Add(uc);
            this.Text = "Sổ đầu bài";
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            phaQuyen uc = new phaQuyen();
            ucMain.Controls.Add(uc);
            this.Text = "Phân quyền";
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            giaoVien uc = new giaoVien();
            ucMain.Controls.Add(uc);
            this.Text = "Quản lý giáo viên/nhân viên";
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            dotKiemTra uc = new dotKiemTra();
            ucMain.Controls.Add(uc);
            this.Text = "Đợt kiểm tra";
        //    XtraMessageBox.Show("Tính năng sẽ được phát triển sau");
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         //   GUI.Report.XtraReport1 report = new GUI.Report.XtraReport1();
         ////   report.ShowPreviewDialog();
         //   report.CreateDocument(false);
         //   XtraReport dummyReport = new XtraReport();
         //   dummyReport.Pages.Add(report.Pages[0]);
         //   dummyReport.ShowPreviewDialog();+
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            thietKeDe uc = new thietKeDe();
            ucMain.Controls.Add(uc);
            this.Text = "Thiết kế đề";
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            nhapDiem uc = new nhapDiem();
            ucMain.Controls.Add(uc);
            this.Text = "Thiết kế đề";
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            phieuBao uc = new phieuBao();
            ucMain.Controls.Add(uc);
            this.Text = "Phiếu báo học tập";
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Tính năng sẽ được phát triển sau");
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Tính năng sẽ được phát triển sau");
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KiemTap kt = new KiemTap();
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            ucMain.Controls.Add(kt);
            this.Text = "Sổ đầu bài";
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chamCong kt = new chamCong();
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            ucMain.Controls.Add(kt);
            this.Text = "Chấm công";
        }
    //    OpenFileDialog op = new OpenFileDialog();
   //     SaveFileDialog sv = new SaveFileDialog();
     //   string path;
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        //    sv.FileName = "";
        //    sv.Filter = "Back up files (*.gz)|*.gz|All files (*.*)|*.*";
        //    if (this.sv.ShowDialog() == DialogResult.OK)
        //    {
        //        path = sv.FileName;
        //    }
        //   // GZipStream zip = new GZipStream();
        //  //  path = @"c:\123";
            
        //    DirectoryInfo di = new DirectoryInfo(path);
        //    FileInfo sc = new FileInfo(@"C:\Program Files\iSolution\BDLQD\config.xml");
        //    FileInfo sc1 = new FileInfo(@"coSoBoiDuong.mdb");
        //    // Compress the directory's files.
        //   // foreach (FileInfo fi in di.GetFiles())
        ////    {
        //        Compress(sc, path);
        //        Compress(sc1, path);

         //   }

         //   ZipFile.CreateFromDirectory(textBox1.Text, saveFileDialog1.FileName);   

            Backup bk = new Backup();
            bk.Show();
        }
        public static void Compress(FileInfo fi, string luu)
        {
          
        //    // Get the stream of the source file.
        //    using (FileStream inFile = fi.OpenRead())
        //    {
        //        // Prevent compressing hidden and 
        //        // already compressed files.
        //        if ((File.GetAttributes(fi.FullName)
        //            & FileAttributes.Hidden)
        //            != FileAttributes.Hidden & fi.Extension != ".gz")
        //        {
        //            // Create the compressed file.
        //            using (FileStream outFile =
        //                        File.Create(luu + ".gz"))
        //            {
        //                using (GZipStream Compress =
        //                    new GZipStream(outFile,
        //                    CompressionMode.Compress))
        //                {
        //                    // Copy the source file into 
        //                    // the compression stream.
        //                    inFile.CopyTo(Compress);

        //                    Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
        //                        fi.Name, fi.Length.ToString(), outFile.Length.ToString());
        //                }
        //            }
        //        }
        //    }
        }
        //public static void Decompress(FileInfo fi)
        //{
        //    // Get the stream of the source file.
        //    using (FileStream inFile = fi.OpenRead())
        //    {
        //        // Get original file extension, for example
        //        // "doc" from report.doc.gz.
        //        string curFile = fi.FullName;
        //        string origName = @"C:\Program Files\iSolution\BDLQD\";

        //        //Create the decompressed file.
        //        using (FileStream outFile = File.Create(origName))
        //        {
        //            using (GZipStream Decompress = new GZipStream(inFile,
        //                    CompressionMode.Decompress))
        //            {
        //                // Copy the decompression stream 
        //                // into the output file.
        //                Decompress.CopyTo(outFile);

        //                Console.WriteLine("Decompressed: {0}", fi.Name);

        //            }
        //        }
        //    }
        //}

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //op.FileName = "";
            //op.Filter = "Back up files (*.gz)|*.gz|All files (*.*)|*.*";
            //if (this.op.ShowDialog() == DialogResult.OK)
            //{
            //    path = op.FileName;
            //}
            //FileInfo az=new FileInfo(path);
            //Decompress(az);
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // Bck bc = new Bck();
        //    bc.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuatLSHV x = new xuatLSHV();
            x.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            changPass cp = new changPass(this.uname);
            cp.Show();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            eXportGecs exx = new eXportGecs();
            exx.Show();
        }

        private void ucMain_Load(object sender, EventArgs e)
        {

        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.QLHocPhi xs = new GUI.QLHocPhi();
            //      GUI.QuanLyHocPhi quanLyHocPhi = new QuanLyHocPhi();
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            //      quanLyHocPhi.Dock = DockStyle.Fill;
            ucMain.Controls.Add(xs);
            this.Text = "Quản lý lớp";
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.GuiEmail xs = new GUI.GuiEmail();
            //      GUI.QuanLyHocPhi quanLyHocPhi = new QuanLyHocPhi();
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            //      quanLyHocPhi.Dock = DockStyle.Fill;
            ucMain.Controls.Add(xs);
            this.Text = "Gửi Email";
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.QLCaBiet xs = new GUI.QLCaBiet();
            //      GUI.QuanLyHocPhi quanLyHocPhi = new QuanLyHocPhi();
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            //      quanLyHocPhi.Dock = DockStyle.Fill;
            ucMain.Controls.Add(xs);
            this.Text = "Quản lý học sinh đặc biệt";
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.QuanLyPhuDao xs = new GUI.QuanLyPhuDao();
            //      GUI.QuanLyHocPhi quanLyHocPhi = new QuanLyHocPhi();
            try
            {
                ucMain.Controls.RemoveAt(0);
            }
            catch
            {
            }
            //      quanLyHocPhi.Dock = DockStyle.Fill;
            ucMain.Controls.Add(xs);
            this.Text = "Quản lý phụ đạo";
        }
    }
}
