using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALThuTien
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT dongTien.ID, nhanVien.[Họ tên lót] + ' ' + nhanVien.[Tên] AS [Nhân viên], nv2.[Họ tên lót] + ' ' + nv2.[Tên] AS [Nhân viên 2],hocVien.[Họ tên lót] + ' ' + hocVien.[Tên] AS [Học viên], ChiTietTKB.[Lớp],[Đóng lần 1], [Ngày đóng lần 1],[Đóng lần 2], [Ngày đóng lần 2], [Giảm],SBL, dongTien.[Ghi chú]  FROM dongTien,hocVien,nhanVien,ChiTietTKB, nhanvien nv2 WHERE dongtien.idHocVien=hocVien.ID AND nhanVien.id=dongTien.idNhanVien AND  ChiTietTKB.id=dongTien.idLopHoc and nv2.ID=dongTien.idNhanVien2 order by [Ngày đóng lần 1],[Ngày đóng lần 1]", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM dongTien WHERE idHocVien="+id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string donglan1,string donglan2, string giam, string ghiChu,string slb, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE dongtien SET \"Đóng lần 1\"=" + donglan1 + ",\"Đóng lần 2\"=" + donglan2 + ",\"Ghi chú\"='" + ghiChu + "',\"Giảm\"=" + giam + ",SBL='"+slb+"'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        //public int updatestt(string idlop)
        //{
        //    try
        //    {
        //        OdbcConnection conn = access.AccessData();
        //        conn.Open();
        //        OdbcCommand cmd = new OdbcCommand("UPDATE dongTien SET STT=(SELECT MAX(STT)+1 from dongtien where idLopHoc="+idlop+") WHERE  ID=(SELECT MAX(ID) from dongtien)", conn);
        //        cmd.ExecuteNonQuery();
        //        conn.Close();
        //        return 1;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}
        public int updatelan2(string idnhanvien, string donglan2, string ngaythu2, string ghiChu,string slb, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE dongtien SET idNhanVien2=" + idnhanvien + ",\"Đóng lần 2\"=" + donglan2 + ",\"Ngày đóng lần 2\"='" + ngaythu2 + "',\"Ghi chú\"='" + ghiChu + "',SBL='" + slb + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string idnhanvien, string idhocvien, string idlophoc, string sotien, string ngaythu, string giam,string sbl, string ghiChu)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO dongTien(idNhanVien,idNhanVien2, idHocVien, idLopHoc,\"Đóng lần 1\",\"Ghi chú\", \"Giảm\",\"Ngày đóng lần 1\", SBL) values (" + idnhanvien + ",1," + idhocvien + "," + idlophoc + "," + sotien + ",'" + ghiChu + "',"+giam+",'"+ngaythu+"','"+sbl+"')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int delete(string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("DELETE FROM dongTien WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
