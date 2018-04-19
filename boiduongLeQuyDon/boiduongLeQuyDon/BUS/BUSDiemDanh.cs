using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;

namespace boiduongLeQuyDon.BUS
{
    class BUSDiemDanh
    {
        DALDiemDanh dal = new DALDiemDanh();
        public DataSet get()
        {
            return dal.get();
        }
        public DataSet get(string id)
        {
            return dal.get(id);
        }
        public DataSet get(string id,string ngay)
        {
            return dal.get(id,ngay);
        }
        public DataSet getinfo(string id)
        {
            return dal.getinfo(id);
        }
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insertp(string idhocvien, string cophep, string lop, string ghiChu)
        {
            return dal.insertp(idhocvien,cophep,lop, ghiChu);
        }
        public int inserttre(string idhocvien,string ngay, string tre, string lop, string ghiChu)
        {
            return dal.inserttre(idhocvien,ngay, tre, lop, ghiChu);
        }
        public int insertk(string idhocvien, string kphep, string lop, string ghiChu)
        {
            return dal.insertk(idhocvien,kphep, lop, ghiChu);
        }
        public int update(string ghiChu, string id)
        {
            return dal.update(ghiChu, id);
        }
    }
}
