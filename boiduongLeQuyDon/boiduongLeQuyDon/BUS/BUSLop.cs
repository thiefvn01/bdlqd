using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;
namespace boiduongLeQuyDon.BUS
{
    class BUSLop
    {
        DALLop dal = new DALLop();
        public DataSet get()
        {
            return dal.get();
        }
        public DataSet getlg(string id)
        {
            return dal.getlg(id);
        }
        public DataSet getlg()
        {
            return dal.getlg();
        }
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insert(string idHV, string lop, string ghiChu,string sbl, string ngaydk, int sotien)
        {
            return dal.insert(idHV,lop,ghiChu,sbl, ngaydk, sotien);
        }
        public int insert(string idHV, string lop, string ghiChu, string sbl,string lopcu, string lopgoc)
        {
            return dal.insert(idHV, lop, ghiChu, sbl,lopcu,lopgoc);
        }
        public int update(string sbl, string ghiChu, string id, string trangthai)
        {
            return dal.update(sbl,ghiChu,trangthai, id);
        }
        public int updatenew(string lc, string lg, string trangthai)
        {
            return dal.updatenew(lc, lg, trangthai);
        }
        public int updateold(string id, string ht, string trangthai)
        {
            return dal.updateold(id, ht, trangthai);
        }
        public int updateold1(string id, string ht, string trangthai)
        {
            return dal.updateold1(id, ht, trangthai);
        }
    }
}
