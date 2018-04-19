using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace boiduongLeQuyDon.DAL
{
    class DALKetQuaToan
    {
        dataAccess access = new dataAccess();
        public DataSet get()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT KetQuaToan.ID,hocVien.[Họ tên lót] +' ' + hocVien.[Tên] AS [Họ tên],[Mã đề thi],[  Tổng], [ Đại], [ Hình], [1a],[1b],[1c],[1d],[2a],[2b],[3a],[3b],[4a],[4b],[5a],[5b],[5c],[5d],[Ngày làm] FROM KetQuaToan, hocVien WHERE KetQuaToan.maHocVien=hocVien.id", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getde()
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT DISTINCT[Mã đề thi] FROM KetQuaToan", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string de)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT KetQuaToan.ID,hocVien.[Họ tên lót] +' ' + hocVien.[Tên] AS [Họ tên],[Mã đề thi],[  Tổng], [ Đại], [ Hình], [1a],[1b],[1c],[1d],[2a],[2b],[3a],[3b],[4a],[4b],[5a],[5b],[5c],[5d],[Ngày làm] FROM KetQuaToan, hocVien WHERE KetQuaToan.maHocVien=hocVien.id AND [Mã đề thi]='" + de + "'", conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet get(string de,string lop)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT KetQuaToan.ID,hocVien.[Họ tên lót] +' ' + hocVien.[Tên] AS [Họ tên],[Mã đề thi],[  Tổng], [ Đại], [ Hình], [1a],[1b],[1c],[1d],[2a],[2b],[3a],[3b],[4a],[4b],[5a],[5b],[5c],[5d],[Ngày làm] FROM KetQuaToan, hocVien WHERE KetQuaToan.maHocVien=hocVien.id AND [Mã đề thi]='" + de + "' AND idLop="+lop, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataSet getid( string lop, string de, string idhocvien)
        {
            OdbcConnection conn = access.AccessData();
            conn.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT ID FROM KetQuaToan WHERE [Mã đề thi]='" + de + "' AND idLop=" + lop + "AND [maHocVien]=" + idhocvien, conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int insert1(string cau, string diem, string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE KetQuaToan SET "+cau+"="+diem+ "WHERE id="+id,conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int insert(string mahocvien, string madethi, string lop, string a1, string b1, string c1, string d1, string a2, string b2, string a3, string b3, string a4, string b4, string a5, string b5, string c5, string d5, string ngaylam)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("INSERT INTO KetQuaToan (maHocVien, [Mã đề thi],1a,1b,1c,1d,2a,2b,3a,3b,4a,4b,5a,5b,5c,5d, [Ngày làm], idLop) values (" + mahocvien + ",'" + madethi + "'," + a1 + "," + b1 + "," + c1 + "," + d1 + "," + a2 + "," + b2 + "," + a3 + "," + b3 + "," + a4 + "," + b4 + "," + a5 + "," + b5 + "," + c5 + "," + d5 + ",'" + ngaylam + "'," + lop + ")", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int update(string a1, string b1, string c1, string d1, string a2, string b2, string a3, string b3, string a4,string b4, string a5, string b5, string c5, string d5 , string id)
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE KetQuaToan SET 1a=" + a1 + ",1b=" + b1 + ",1c=" + c1 + ",1d=" + d1 + ",2a=" + a2 + ",2b=" + b2 + ",3a=" + a3 + ",3b=" + b3 + ",4a=" + a4 + ",4b=" + b4 + ",5a=" + a5 + ",5b=" + b5 + ",5c=" + c5 + ",5d=" + d5 +" WHERE ID="+id, conn);
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
                OdbcCommand cmd = new OdbcCommand("DELETE FROM KetQuaToan WHERE id=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updatediem()
        {
            try
            {
                OdbcConnection conn = access.AccessData();
                conn.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE KetQuaToan set [  Tổng]=[1a]+[1b]+[1c]+[1d]+[2a]+[2b]+[3a]+[3b]+[4a]+[4b]+[5a]+[5b]+[5c]+[5d], [ Đại]=[1a]+[1b]+[1c]+[1d]+[2a]+[2b]+[3a]+[3b], [ Hình]=[4a]+[4b]+[5a]+[5b]+[5c]+[5d]", conn);
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
