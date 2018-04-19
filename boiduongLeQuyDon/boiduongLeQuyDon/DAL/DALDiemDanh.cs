using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALDiemDanh
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT diemDanh.ID,[Mã học viên], [Họ tên lót] +' ' +[Tên] AS [Họ tên], [Lớp], [Có phép],[Không phép],[Ngày] as [Ngày trễ],[Trễ] as [Số phút], diemDanh.[Ghi chú] FROM (diemDanh inner join hocVien on diemDanh.idHocVien=hocVien.id) INNER JOIN chitietTKB on chitietTKB.id=diemdanh.tkbID", conn);
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
            OdbcCommand cmd = new OdbcCommand("SELECT diemDanh.ID,[Mã học viên], [Họ tên lót] +' ' +[Tên] AS [Họ tên], [Lớp], [Có phép],[Không phép],[Ngày] as [Ngày trễ],[Trễ] as [Số phút], diemDanh.[Ghi chú] FROM (diemDanh inner join hocVien on diemDanh.idHocVien=hocVien.id) INNER JOIN chitietTKB on chitietTKB.id=diemdanh.tkbID WHERE tkbID=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string id, string ngay)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT diemDanh.ID, [Mã  học viên], [Họ tên lót] +' ' +[Tên] AS [Họ tên], [Có phép],[Không phép], [Trễ], diemDanh.[Ghi chú] FROM diemDanh inner join hocVien on diemDanh.idHocVien=hocVien.id WHERE tkbID=" + id + " and( [Có phép]=#" + ngay + "# OR [Không phép]=#" + ngay + "# OR [Ngày]=#" + ngay + "#)", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getinfo(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM diemDanh WHERE idHocVien="+id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string ghiChu, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE diemDanh SET \"Ghi chú\"='" + ghiChu + "'  WHERE id=" + id, conn);
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
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO diemDanh (idHocVien, \"Có phép\", \"Ghi chú\",tkbID) values ('" + idhocvien + "','" + cophep + "','" + ghiChu + "'," + lop + ")", conn);
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
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO diemDanh (idHocVien, \"Không phép\", \"Ghi chú\",tkbID) values ('" + idhocvien + "','" + kphep + "','" + ghiChu + "'," + lop + ")", conn);
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
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO diemDanh (idHocVien, \"Trễ\", \"Ghi chú\",\"Ngày\",tkbID) values ('" + idhocvien + "','" + tre + "','" + ghiChu + "','"+ngay+"'," + lop + ")", conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM diemDanh WHERE id=" + id, conn);
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
