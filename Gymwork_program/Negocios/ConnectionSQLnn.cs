using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
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

        public DataTable ConsultDGV()
        {
            return cn.ConsultUsersDGV();
        }
        public DataTable ConsultProducts()
        {
            return cn.ConsultProduct();
        }

        public int InsertUser(decimal id, string name, string lastname, decimal phone, string user, string password)
        {
            return cn.InsertUser(id, name, lastname, phone, user, password);
        }

        public int ModifyUser(decimal id, string name, string lastname, decimal phone, string user, string password)
        {
            return cn.ModifyUser(id, name, lastname, phone, user, password);
        }

        public int DeleteUser(decimal id)
        {
            return cn.DeleteUser(id);
        }

        /////////////
        public int AddProduct(decimal IdProduct, string Product, string Category, float Price, int Quantity)
        {
            return cn.AddProduct(IdProduct, Product, Category, Price, Quantity);
        }
        public int ModifyProduct(decimal IdProduct, string Product, string Category, float Price, int Quantity)
        {
            return cn.ModifyProduct(IdProduct, Product, Category, Price, Quantity);
        }
        public int DeleteProduct(decimal IdProduct)
        {
            return cn.DeleteProduct(IdProduct);
        }
        public string SearchBill()
        {
            return cn.SearchBill();
        }

        public Tuple <string, string> SearchStock(string IdProduct)
        {
            return cn.SearchStock(IdProduct);
        }
    }

}
