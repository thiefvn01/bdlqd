using System.Data.SqlClient;
namespace boiduongLeQuyDon.DAL
{
    class dataAccess
    {
        
        public SqlConnection AccessData()
        {
            SqlConnection conn = new SqlConnection();
            //      XDocument doc = XDocument.Load("Config.xml");
            //        string password = doc.Element("connect").Elements("password").FirstOrDefault().Value.ToString();
            //     string path = doc.Element("connect").Elements("path").FirstOrDefault().Value.ToString();
            var connection =
         System.Configuration.ConfigurationManager.
         ConnectionStrings["boiduongLeQuyDon.Properties.Settings.bdlqdConnectionString1"].ConnectionString;
            conn.ConnectionString = connection;
            return conn;
        }
    }
}
