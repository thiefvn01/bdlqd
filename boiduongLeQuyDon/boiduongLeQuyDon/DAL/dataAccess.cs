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

            conn.ConnectionString = @"Data Source=KURT;Initial Catalog=bdlqd;User ID=sa;Password=Expelliarmus@1";
            return conn;
        }
    }
}
