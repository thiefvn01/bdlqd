using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;
namespace boiduongLeQuyDon.BUS
{
    class BUSThoiKhoaBieu
    {
        DALThoiKhoaBieu dal = new DALThoiKhoaBieu();
        public DataSet get()
        {
            return dal.get();
        }
        public DataSet get(int id)
        {
            return dal.get(id);
        }
        public DataSet gettt()
        {
            return dal.gettt();
        }
        public DataSet getinf(string id)
        {
            return dal.getinf(id);
        }
        public DataSet get(string id)
        {
            return dal.get(id);
        }
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insert(string ten, string lop, string namhoc, string khaigiang,string ngayketthuc)
        {
            return dal.insert(ten, lop, namhoc,khaigiang,ngayketthuc);
        }
        public int update(string ten, string lop, string namhoc, string khaigiang,string ngayketthuc, string id)
        {
            return dal.update(ten, lop, namhoc,khaigiang,ngayketthuc,id);
        }
        public int update(string ten, string lop, string namhoc, string khaigiang, string id)
        {
            return dal.update(ten, lop, namhoc, khaigiang, id);
        }
    }
}
