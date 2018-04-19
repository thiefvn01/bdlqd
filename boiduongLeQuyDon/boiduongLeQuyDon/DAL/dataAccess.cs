using System.Data.Odbc;
namespace boiduongLeQuyDon.DAL
{
    class dataAccess
    {
        
        public OdbcConnection AccessData()
        {
            OdbcConnection conn = new OdbcConnection();
      //      XDocument doc = XDocument.Load("Config.xml");
    //        string password = doc.Element("connect").Elements("password").FirstOrDefault().Value.ToString();
       //     string path = doc.Element("connect").Elements("path").FirstOrDefault().Value.ToString();

            conn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb)};Dbq=coSoBoiDuong.mdb;Pwd=iSolution;";
            return conn;
        }
    }
}
