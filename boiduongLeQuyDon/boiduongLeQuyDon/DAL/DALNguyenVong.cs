using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALNguyenVong
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM nguyenVongHocVien", conn);
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
            OdbcCommand cmd = new OdbcCommand("SELECT n.ID, [Họ tên lót] + ' ' + [Tên] AS [Họ tên],  truong as [Trường], [Môn chuyên], ghiChu as [Ghi chú] FROM nguyenVongHocVien n inner join hocVien v on v.id=n.idhocvien WHERE idHocVien=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string truong, string ghiChu, string mon, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE nguyenVongHocVien SET truong='" + truong + "',\"Môn chuyên\"='" + mon + "',ghiChu='" + ghiChu + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string idhocvien, string truong, string ghichu, string mon)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO nguyenVongHocVien (idHocVien, truong,ghiChu, \"Môn chuyên\") values (" + idhocvien + ",'" + truong + "','" + ghichu + "','" + mon + "')", conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM nguyenVongHocVien WHERE id=" + id, conn);
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
