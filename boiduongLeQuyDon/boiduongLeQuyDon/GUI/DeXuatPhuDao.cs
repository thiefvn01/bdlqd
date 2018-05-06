using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace boiduongLeQuyDon.GUI
{
    public partial class DeXuatPhuDao : DevExpress.XtraReports.UI.XtraReport
    {
        public DeXuatPhuDao(string hoten, string lop, string lydo, string thoiluong, string noidung, string trogiang, string ykiengv, string ketqua, string nhanxet, int sotien)
        {
            InitializeComponent();
            txtHoTen.Text += hoten;
            txtLop.Text += lop;
            txtLyDo.Text += lydo;
            txtThoiLuong.Text += thoiluong;
            txtNoiDung.Text += noidung;
            txtTroGiang.Text += trogiang;
            txtYKien.Text += ykiengv;
            txtKetQua.Text += ketqua;
            txtNhanXet.Text += nhanxet;
            if (sotien > 0)
            {
                checkCo.Checked = true;
                checkKhong.Checked = false;
            }
            else
            {
                checkCo.Checked = false;
                checkKhong.Checked = true;
            }
        }

    }
}
