using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALSoDauBai
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT s.ID, [Nội dung], [Bài tập về nhà],[Nhận xét],[Ngày],[Lớp], idlop as lid FROM soDauBai s inner join chitiettkb c on s.idlop=c.id order by [Ngày]", conn);
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
            OdbcCommand cmd = new OdbcCommand("SELECT s.ID, [Nội dung], [Bài tập về nhà],[Nhận xét],[Ngày],[Lớp], idlop as lid FROM soDauBai s inner join chitiettkb c on s.idlop=c.id WHERE idlop="+id+" order by [Ngày]", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //public DataSet get(string id)
        //{
        //    OdbcConnection conn = access.AccessData();
        //    conn.Open();
        //    OdbcCommand cmd = new OdbcCommand("SELECT * FROM nguyenVongHocVien WHERE idHocVien=" + id, conn);
        //    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
        //    DataSet dt = new DataSet();
        //    da.Fill(dt);
        //    conn.Close();
        //    return dt;
        //}
        public int update(string noidung, string baitap, string nhanxet, string ngay, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE soDauBai SET \"Nội dung\"='" + noidung + "',\"Bài tập về nhà\"='" + baitap + "',\"Nhận xét\"='" + nhanxet + "',\"Ngày\"='" + ngay + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string noidung, string baitap, string nhanxet, string ngay, string lop)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO soDauBai (\"Nội dung\", \"Bài tập về nhà\",\"Nhận xét\", \"Ngày\",idLop) values ('" + noidung + "','" + baitap + "','" + nhanxet + "','" + ngay + "',"+lop+")", conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM soDauBai WHERE id=" + id, conn);
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
