using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using boiduongLeQuyDon.DAL;
using System.Data;

namespace boiduongLeQuyDon.BUS
{
    class BUSDongTien
    {
        DALThuTien dal = new DALThuTien();
        public DataSet get()
        {
            return dal.get();
        }
        //public int updatestt(string idlop)
        //{
        //    return dal.updatestt( idlop);
        //}
        public DataSet get(string id)
        {
            return dal.get(id);
        }
        public int delete(string id)
        {
            return dal.delete(id);
        }
        public int insert(string idnhanvien, string idhocvien, string idlophoc, string sotien,string giam,string sbl, string ghiChu)
        {
            return dal.insert(idnhanvien,idhocvien,idlophoc,sotien, DateTime.Now.ToShortDateString(), giam,sbl, ghiChu);
        }
        public int update( string donglan1,string donglan2, string giam,string ghiChu,string sbl,string id)
        {
            return dal.update(donglan1,donglan2,giam,ghiChu,sbl,id);
        }
        public int updatelan2(string idnhanvien,  string donglan2, string ghiChu, string sbl,string id)
        {
            return dal.updatelan2(idnhanvien, donglan2, DateTime.Now.ToShortDateString(), ghiChu,sbl, id);
        }
    }
}
