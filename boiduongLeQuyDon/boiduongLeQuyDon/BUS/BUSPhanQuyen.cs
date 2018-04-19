using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;
namespace boiduongLeQuyDon.BUS
{
    class BUSPhanQuyen
    {
        DALPhanQuyen dal = new DALPhanQuyen();
        public DataSet get()
        {
            return dal.get();
        }
        public DataSet get(string id)
        {
            return dal.get(id);
        }
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insert(string idnv, string nv, string hv, string kq, string pq)
        {
            return dal.insert(idnv,nv,hv,kq,pq);
        }
        public int updatepq(string nv, string hv, string kq, string pq, string id)
        {
            return dal.updatepq(nv,hv,kq,pq,id);
        }
    }
}
