using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConnectionSQL
    {
        static string connectionstring = "Data Source=holamundodev.eastus2.cloudapp.azure.com;Initial Catalog=DouglathsDB;User Id=douglathscarrascal;Password=Dougl@ths1;integrated security = false; TrustServerCertificate = true";
        SqlConnection conn = new SqlConnection(connectionstring);
        
        public int consultLogin (string  username, string password)
        {
            conn.Open ();
            int count;
            string Query = "Select Count(*) from UsuariosGym where [user]='"+username+"' AND [password]='"+password+"';";
            SqlCommand cmd = new SqlCommand(Query, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close ();
            return count;
        }
    }
}
