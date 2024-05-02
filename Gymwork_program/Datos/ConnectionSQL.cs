using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Datos
{
    public class ConnectionSQL
    {
        static string connectionstring = "Data Source=holamundodev.eastus2.cloudapp.azure.com;Initial Catalog=DouglathsDB;User Id=douglathscarrascal;Password=Dougl@ths1;integrated security = false; TrustServerCertificate = true";
        SqlConnection conn = new SqlConnection(connectionstring);

        public int consultLogin(string username, string password)
        {
            //conn.Open ();
            //int count;
            //string Query = "Select Count(*) from UsuariosGym where [user]='"+username+"' AND [password]='"+password+"';";
            //SqlCommand cmd = new SqlCommand(Query, conn);
            //count = Convert.ToInt32(cmd.ExecuteScalar());
            //conn.Close ();
            int count = 1;
            return count;
        }

        public DataTable ConsultUsersDGV()
        {
            string query = "Select * from dbo.UsuariosGym";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public int InsertUser(decimal id, string name, string lastname, decimal number, string user, string password)
        {
            conn.Open();
            int flag = 0;
            string query = "INSERT INTO [dbo].[UsuariosGym] ([id],[name],[lastname],[phone],[user],[password]) VALUES ("+id+", '"+name+"', '"+lastname+"', "+number+", '"+user+"', '"+password+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;
        }

        public int DeleteUser(decimal id)
        {
            conn.Open();
            int flag = 0;
            string query = "Delete from dbo.UsuariosGym where id= "+id+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;
        }

        public int ModifyUser(decimal id, string name, string lastname, decimal number, string user, string password)
        {
            conn.Open();
            int flag = 0;
            string query = "Update UsuariosGym set [name] = '"+name+"', lastname='"+lastname+"', phone="+number+",[user]='"+user+"', password='"+password+"' where [id]= "+id+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;
        }


        /// <summary>
        /// /////////////////////////////////
        /// </summary>
        /// <returns></returns>

        public DataTable ConsultProduct()
        {
            string query = "Select * from dbo.Stock";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }
        public int AddProduct(decimal IdProduct, string Product, string Category, float Price, int Quantity)
        {
            conn.Open();
            int flag = 0;
            string query = "INSERT INTO [dbo].[Stock] ([IdProduct],[Product],[Category],[Price],[Quantity]) VALUES ("+IdProduct+", '"+Product+"', '"+Category+"', "+Price+", '"+Quantity+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;
        }
        public int DeleteProduct(decimal IdProduct)
        {
            conn.Open();
            int flag = 0;
            string query = "Delete from dbo.Stock where IdProduct= "+IdProduct+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;
        }
        public int ModifyProduct(decimal IdProduct, string Product, string Category, float Price, int Quantity)
        {
            conn.Open();
            int flag = 0;
            string query = "Update Stock set [IdProduct] = '"+IdProduct+"', [Product]='"+Product+"', [Category]='"+Category+"',[Price]='"+Price+"', [Quantity]='"+Quantity+"' where [IdProduct]= "+IdProduct+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;

        }

        public string SearchBill()
        {
            conn.Open();
            string result = "Null";
            string query = "select(select distinct top 1 BillNumber from Billing order by BillNumber desc)+1 as BillNumber";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                
                result = reg["BillNumber"].ToString();
            }
            conn.Close();
            return result;

        }

        public Tuple<string, string> SearchStock(string IdProduct)
        {
            conn.Open();
            string result1 = "NULL";
            string result2 = "NULL";
            string query = "select * from Stock where IdProduct = '"+IdProduct+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {

                result1 = reg["Product"].ToString();
                result2 = reg["Price"].ToString();
            }
            
            conn.Close();
            return Tuple.Create(result1,result2);
            

        }

    }
}


