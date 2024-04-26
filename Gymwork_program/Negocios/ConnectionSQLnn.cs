using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ConnectionSQLnn
    {
        ConnectionSQL cn = new ConnectionSQL();

        public int conSQL(string user, string pass)
        {
            return cn.consultLogin(user, pass);
        }
    }
}
