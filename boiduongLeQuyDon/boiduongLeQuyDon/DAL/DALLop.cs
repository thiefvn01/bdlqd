using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;


namespace boiduongLeQuyDon.DAL
{
    class DALLop
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT Lop.ID,ChiTietTKB.STT AS [STT TKB], \"Họ tên lót\" + ' ' + \"Tên\" as [Họ và tên],ChiTietTKB.\"Lớp\", SBL FROM Lop INNER JOIN hocVien on Lop.idHocVien=hocVien.ID, ChiTietTKB WHERE ChiTietTKB.ID=Lop.idLop and lophientai=1 ORDER BY ChiTietTKB.IDTKB, ChiTietTKB.STT", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getlg(string id)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT idLop, lopgoc, idHocVien from lop WHERE id="+id, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getlg()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT id,idLop from lop WHERE id=(SELECT max(id) from lop)", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int update(string sbl, string ghiChu, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE Lop SET SBL='" + sbl + "',\"Ghi chú\"='" + ghiChu + "'  WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updatenew(string lc, string lg)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE Lop SET lopCu="+lc+" ,lopGoc="+lg+" WHERE id=(SELECt MAX(ID) FROM LOP)", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updateold(string id, string ht)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE Lop SET lophientai="+ht+"  WHERE id=(SELECT max(ID) from lop", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updateold1(string id, string ht)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE Lop SET lophientai=" + ht + "  WHERE id="+id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string idHV, string lop, string ghichu,string sbl, string ngaydk)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO Lop(idHocVien, idLop,\"Ghi chú\",SBL, lophientai, ngayDK) values ('" + idHV + "','" + lop + "','" + ghichu + "','"+sbl+"',1, '"+ngaydk +"')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string idHV, string lop, string ghichu, string sbl,string lopcu, string lopgoc)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO Lop(idHocVien, idLop,\"Ghi chú\",SBL, lophientai,lopcu, lopgoc) values ('" + idHV + "','" + lop + "','" + ghichu + "','" + sbl + "',1,"+lopcu+","+lopgoc+")", conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM Lop WHERE id=" + id, conn);
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
