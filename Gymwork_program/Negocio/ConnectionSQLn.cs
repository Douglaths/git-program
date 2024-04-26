using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ConnectionSQLn
    {
        ConnectionSQL cn = new ConnectionSQL();

        public int conSQL(string user, string pass)
        {
            return cn.consultLogin(user, pass);
        }
    }
}
