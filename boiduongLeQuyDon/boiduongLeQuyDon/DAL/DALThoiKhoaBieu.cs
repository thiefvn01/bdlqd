using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALThoiKhoaBieu
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM ThoiKhoaBieu WHERE [Ngày kết thúc] IS NULL OR [Ngày kết thúc] >=now", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(int id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,[Tên TKB],[Năm học] FROM ThoiKhoaBieu ", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet gettt()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,[Tên TKB],[Năm học] FROM ThoiKhoaBieu WHERE [Ngày kết thúc] IS NULL OR [Ngày kết thúc] >=now", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getinf(string ID)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT \"Khai giảng\" FROM ThoiKhoaBieu WHERE id="+ID, conn);
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
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM ThoiKhoaBieu WHERE ID=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string ten, string lop, string namhoc, string khaigiang,string ngayketthuc, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE ThoiKhoaBieu SET \"Tên TKB\"='" + ten + "',\"Lớp\"='" + lop + "',\"Năm học\"='" + namhoc + "',\"Khai giảng\"='" + khaigiang + "',\"Ngày kết thúc\"='"+ngayketthuc+"'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int update(string ten, string lop, string namhoc, string khaigiang, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE ThoiKhoaBieu SET \"Tên TKB\"='" + ten + "',\"Lớp\"='" + lop + "',\"Năm học\"='" + namhoc + "',\"Khai giảng\"='" + khaigiang + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string ten, string lop, string namhoc, string khaigiang, string ngayketthuc)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO ThoiKhoaBieu (\"Tên TKB\", \"Lớp\",\"Năm học\",\"Khai giảng\",\"Ngày kết thúc\") values ('" + ten + "','" + lop + "','" + namhoc + "','" + khaigiang + "','"+ngayketthuc+"')", conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM ThoiKhoaBieu WHERE id=" + id, conn);
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
