using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace boiduongLeQuyDon.DAL
{
    class DALDiemDanh
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT diemDanh.ID, mahv as [Mã học viên], hotenlot +' ' +ten AS [Họ tên], lop as [Lớp], cophep as [Có phép], khongphep as[Không phép], ngay as [Ngày trễ], tre as [Số phút], diemDanh.ghichu as N'Ghi chú' FROM (diemDanh inner join hocVien on diemDanh.idHocVien=hocVien.id) INNER JOIN chitietTKB on chitietTKB.id=diemdanh.tkbID", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT diemDanh.ID, mahv as [Mã học viên], hotenlot +' ' +ten AS [Họ tên], lop as [Lớp], cophep as [Có phép], khongphep as[Không phép], ngay as [Ngày trễ], tre as [Số phút], diemDanh.ghichu as N'Ghi chú' FROM (diemDanh inner join hocVien on diemDanh.idHocVien=hocVien.id) INNER JOIN chitietTKB on chitietTKB.id=diemdanh.tkbID WHERE tkbID=" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string id, string ngay)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT diemDanh.ID, mahv as [Mã học viên], hotenlot +' ' +ten AS [Họ tên], cophep as [Có phép], khongphep as[Không phép], tre as 'Trễ', diemDanh.ghichu as N'Ghi chú'FROM diemDanh inner join hocVien on diemDanh.idHocVien=hocVien.id WHERE tkbID=" + id + " and( [Có phép]=#" + ngay + "# OR [Không phép]=#" + ngay + "# OR [Ngày]=#" + ngay + "#)", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getinfo(string id)
        {
            SqlConnection conn = access.AccessData();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM diemDanh WHERE idHocVien="+id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string ghiChu, string id)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE diemDanh SET ghichu='" + ghiChu + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insertp(string idhocvien, string cophep,string lop, string ghiChu)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO diemDanh (idHocVien, cophep, ghichu,tkbID) values ('" + idhocvien + "','" + cophep + "','" + ghiChu + "'," + lop + ")", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insertk(string idhocvien, string kphep, string lop, string ghiChu)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO diemDanh (idHocVien, khongphep, ghichu,tkbID) values ('" + idhocvien + "','" + kphep + "','" + ghiChu + "'," + lop + ")", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int inserttre(string idhocvien,string ngay, string tre, string lop, string ghiChu)
        {
            try
            {
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO diemDanh (idHocVien, tre, ghichu,ngay,tkbID) values ('" + idhocvien + "','" + tre + "','" + ghiChu + "','"+ngay+"'," + lop + ")", conn);
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
                SqlConnection conn = access.AccessData();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM diemDanh WHERE id=" + id, conn);
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
