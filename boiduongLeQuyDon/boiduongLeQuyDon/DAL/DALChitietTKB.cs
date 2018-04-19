using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALChitietTKB
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,STT,\"Môn học\", \"Lớp\", \"Giáo Viên\",\"Thứ\", \"Thời gian\", \"Học phí\" FROM ChiTietTKB WHERE idTKB>=(SELECT MAX(id) FROM ThoiKhoaBieu)", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(int a)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,\"Lớp\", \"Giáo Viên\" FROM ChiTietTKB WHERE idTKB>=(SELECT MAX(id) FROM ThoiKhoaBieu)", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getgv(string lop)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT \"Giáo Viên\",[Thứ],[Lớp],[Thời gian] FROM ChiTietTKB WHERE ID="+lop+"", conn);
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
            OdbcCommand cmd = new OdbcCommand("SELECT ID, \"Lớp\", [Thứ],[Thời gian] FROM ChiTietTKB WHERE idTKB=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet gettkb(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID,STT,\"Môn học\", \"Lớp\", \"Giáo Viên\",\"Thứ\", \"Thời gian\", \"Học phí\" FROM ChiTietTKB WHERE idTKB=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet gett(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT \"Học phí\" FROM ChiTietTKB WHERE ID=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getlop(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT \"Lớp\" FROM ChiTietTKB WHERE ID=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get2(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT idTKB FROM ChiTietTKB WHERE id=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //public DataSet getlop(string id)
        //{
        //    OdbcConnection conn = access.AccessData();
        //    conn.Open();
        //    OdbcCommand cmd = new OdbcCommand("SELECT id FROM ChiTietTKB WHERE \"Lớp\"=" + id, conn);
        //    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
        //    DataSet dt = new DataSet();
        //    da.Fill(dt);
        //    conn.Close();
        //    return dt;
        //}
        public DataSet get1(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID, \"Môn học\", \"Lớp\" FROM ChiTietTKB WHERE idTKB=" + id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string stt, string monhoc, string lop, string giaovien, string thu, string thoigian, string hocphi,  string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE ChiTietTKB SET STT=" + stt + ",\"Môn học\"='" + monhoc + "',\"Lớp\"='" + lop + "',\"Giáo viên\"='" + giaovien + "',\"Thứ\"='" + thu + "',\"Thời gian\"='"+thoigian+"',\"Học phí\"='"+hocphi+"'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string stt, string monhoc, string lop, string giaovien, string thu, string thoigian, string hocphi,string idTKB)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO ChiTietTKB (STT, \"Môn học\",\"Lớp\",\"Giáo viên\",\"Thứ\",\"Thời gian\",\"Học phí\",idTKB) values (" + stt + ",'" + monhoc + "','" + lop + "','" + giaovien + "','" + thu + "','"+thoigian+"','"+hocphi+"',"+idTKB+")", conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM ChiTietTKB WHERE id=" + id, conn);
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
