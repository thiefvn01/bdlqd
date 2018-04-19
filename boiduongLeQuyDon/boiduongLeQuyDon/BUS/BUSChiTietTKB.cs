using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;
namespace boiduongLeQuyDon.BUS
{
    class BUSChiTietTKB
    {
        DALChitietTKB dalCaHoc = new DALChitietTKB();
        public DataSet get()
        {
            return dalCaHoc.get();
        }
        public DataSet getlop(string id)
        {
            return dalCaHoc.getlop(id);
        }
        public DataSet getgv(string lop)
        {
            return dalCaHoc.getgv(lop);
        }
        public DataSet get(int a)
        {
            return dalCaHoc.get(a);
        }
        public DataSet get2(string id)
        {
            return dalCaHoc.get2(id);
        }
        public DataSet gettkb(string id)
        {
            return dalCaHoc.gettkb(id);
        }
        public DataSet get(string id)
        {
            return dalCaHoc.get(id);
        }
        public DataSet gett(string id)
        {
            return dalCaHoc.gett(id);
        }
        public DataSet get1(string id)
        {
            return dalCaHoc.get1(id);
        }
        public int delete(string id)
        {
            return dalCaHoc.delete(id);
        }
        public int insert(string stt, string monhoc, string lop, string giaovien, string thu, string thoigian, string hocphi,  string idTKB)
        {
            return dalCaHoc.insert(stt, monhoc,lop,giaovien,thu,thoigian,hocphi,idTKB);
        }
        public int update(string stt, string monhoc, string lop, string giaovien, string thu, string thoigian, string hocphi, string id)
        {
            return dalCaHoc.update(stt, monhoc,lop, giaovien,thu,thoigian,hocphi,id);
        }
    }
}