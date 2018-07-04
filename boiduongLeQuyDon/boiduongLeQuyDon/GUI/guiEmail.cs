using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Net.Mail;
//using System.Net;
//using Limilabs.Mail;
//using Limilabs.Mail.MIME;
//using Limilabs.Mail.Headers;
//using Limilabs.Client.SMTP;
using boiduongLeQuyDon.BUS;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;


namespace boiduongLeQuyDon.GUI
{
    public partial class GuiEmail : UserControl
    {
        List<int> danhsach = new List<int>();
        List<int> danhsach_ten = new List<int>();
        List<string> email = new List<string>();
        List<string> tenhocsinh = new List<string>();
        bdlqdDataSet1TableAdapters.getHocVienEmailTableAdapter emailph = new bdlqdDataSet1TableAdapters.getHocVienEmailTableAdapter();
        bdlqdDataSet1TableAdapters.getHocVien5TableAdapter hocvien = new bdlqdDataSet1TableAdapters.getHocVien5TableAdapter();
        bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter tkb = new bdlqdDataSet1TableAdapters.getKhoaHocTableAdapter();
        
        public GuiEmail()
        {
            InitializeComponent();
            SqlConnection scon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["boiduongLeQuyDon.Properties.Settings.bdlqdConnectionString1"].ConnectionString);
            emailph.Connection = scon;
            tkb.Connection = scon;
            hocvien.Connection = scon;
            lookUpEdit1.Properties.DataSource = tkb.GetData();
            lookUpEdit1.Properties.DisplayMember = "Ten TKB";
            lookUpEdit1.Properties.ValueMember = "id";

        }
        List<MyObject> GetData(int count)
        {
            List<MyObject> list = new List<MyObject>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new MyObject() { ID = i, Name = "Name" + i, Info = "Info" + i });
            }
            return list;
        }
        public class MyObject
        {
            public MyObject() { }

            public int ID { get; set; }
            public string Name { get; set; }
            public string Info { get; set; }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string server = "";
            string from = textEdit1.Text.Trim();
           // string split8 = from.Substring(from.Length - 8, 8);
            string split9 = from.Substring(from.Length - 9, 9);
            string split12 = from.Substring(from.Length - 12, 12);
            //gửi chưa có custom nội dung
            // MailMessage mail = new MailMessage();
            try
            {
                foreach (string b in email)
                {
                    string a = "";
                    if (checkBox1.CheckState == CheckState.Checked)
                        a = textEdit3.Text;
                    else
                        a = b;
                    //9 =gmail.com
                    if (split9 == "gmail.com")
                    {
                        var fromAddress = new MailAddress(from, textEdit4.Text);
                        //  var toAddress = new MailAddress("chauquangvu@gmail.com", "QCV");
                        string fromPassword = textBox1.Text;
                        string subject = textEdit2.Text;
                        //body = txtBody.Text.Replace("\n", "<br />")
                        string body = txtNoiDung.Text.Replace("\r\n", "<br />");
                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        using (var message = new MailMessage(fromAddress.Address, a)
                        {
                            Subject = subject,
                            Body = body,
                            IsBodyHtml = true
                        })
                        {
                            smtp.Send(message);
                        }
                    }
                    else if (split9 == "yahoo.com" || split12 == "yahoo.com.vn")
                    {
                        var fromAddress = new MailAddress(from, textEdit4.Text);
                        //  var toAddress = new MailAddress("chauquangvu@gmail.com", "QCV");
                        string fromPassword = textBox1.Text;
                        string subject = textEdit2.Text;
                        string body = txtNoiDung.Text.Replace("\n", "<br />");
                        var smtp = new SmtpClient
                        {
                            Host = "smtp.mail.yahoo.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        using (var message = new MailMessage(fromAddress.Address, a)
                        {
                            Subject = subject,
                            Body = body,
                            IsBodyHtml = true
                        })
                        {
                            smtp.Send(message);
                        }
                    }

                }
                MessageBox.Show("Đã gửi xong");
            }
            catch
            {
                MessageBox.Show("Có lỗi, vui lòng kiểm tra email và mật khẩu");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            bool daxuly = false;
            int count = 0;
            // string a = txtNoiDung.Text.Replace(Environment.NewLine, "<br>"); ;
            
            //kiểm tra nút tất cả có đc check hay không
            //nếu được check
            for (int i = 0; i < cbDanhsach.Properties.Items.Count; i++)
            {
                var item = cbDanhsach.Properties.Items[i];
                if (item.CheckState == CheckState.Checked)
                {
                    if (item.Value.ToString() == "Tất cả")
                    {
                        for (int j = 0; i < cbDanhsach.Properties.Items.Count; j++)
                        {
                            danhsach.Add(Convert.ToInt32(item.Value.ToString()));
                            count++;
                        }
                        daxuly = true;
                    }
                }
            }
            //nếu không được check
            if (daxuly == false)
            {
                for (int i = 0; i < cbDanhsach.Properties.Items.Count; i++)
                {
                    var item = cbDanhsach.Properties.Items[i];
                    if (item.CheckState == CheckState.Checked)
                    {
                        danhsach.Add(Convert.ToInt32(item.Value.ToString()));
                        
                        //  danhsach_ten.Add(item.)
                        count++;
                    }
                }
                daxuly = true;
            }
            //lấy ds đối tượng
         
            //lấy email
            for(int i=0;i<count;i++)
            {
                //query lấy email
                //select tenhocsinh from hocvien where id = danhsach[i]
               // emailph.GetData(Convert.ToInt32(danhsach[i].ToString())).Rows[0][1].ToString();
                tenhocsinh.Add(emailph.GetData(Convert.ToInt32(danhsach[i].ToString())).Rows[0][0].ToString());
                email.Add(emailph.GetData(Convert.ToInt32(danhsach[i].ToString())).Rows[0][1].ToString());
            }
            //set count = 0 để có thể add liên tục
            count = 0;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            tenhocsinh.Clear();
            danhsach.Clear();
            email.Clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           // DataSet ds = new DataSet();
         //   dt.DataSet.DataSetName = "DSEmail";
            dt.Columns.Add("Thứ tự");
            dt.Columns.Add("Học viên");
            //dt.Columns.Add("Người nhận");
            dt.Columns.Add("Email nhận");
            for (int i = 0; i < danhsach.Count; i++)
            {
                DataRow r = dt.NewRow();
                r.SetField("Thứ tự", i + 1);
                //query get ten hoc vien tai day
               // string ten = "";
                r.SetField("Học viên", tenhocsinh[i]);
             //   r.SetField("Người nhận", tenhocsinh[i]);
                r.SetField("Email nhận", email[i]);
                dt.Rows.Add(r);
            }
            DS_GuiEmail ds = new DS_GuiEmail(dt);
            ds.Show();
        }
        BUSChiTietTKB ck = new BUSChiTietTKB();
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = ck.get(lookUpEdit1.EditValue.ToString()).Tables[0];
            lookUpEdit2.Properties.DisplayMember = "Lớp";
            lookUpEdit2.Properties.ValueMember = "ID";
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            cbDanhsach.Properties.DataSource = hocvien.GetData(Convert.ToInt32(lookUpEdit2.EditValue.ToString()));
            cbDanhsach.Properties.DisplayMember = "Họ tên";
            cbDanhsach.Properties.ValueMember = "ID";
        }


    }
}
