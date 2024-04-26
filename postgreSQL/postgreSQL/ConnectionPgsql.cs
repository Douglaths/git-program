using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace postgreSQL
{
    public class ConnectionPgsql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Dougl@ths1; Database = postgres");

        public void Connect()
        {
            conn.Open();
            MessageBox.Show("ready bro");
        }
        public void disConnect()
        {
            conn.Close();
            MessageBox.Show("Turned off connection bro");
        }
        public DataTable Search()
        {
            string query = "select * from \"personas\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable Table = new DataTable();
            datos.Fill(Table);
            return Table;
        }
        public DataTable Search(string NameSearchTxt)
        {
            string query = "select * from \"personas\" where \"nombre\" = '"+NameSearchTxt+"'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable Table = new DataTable();
            datos.Fill(Table);
            return Table;
        }

        public void Insert(string nid, string name, string lastname, string country, string visa)
            {
            
            string query = "Insert into public.personas(nid, nombre, apellido, pais, visa) values ('"+ nid +"','"+ name +"','"+ lastname +"','"+ country +"','"+ visa +"')";
            try
            {
                NpgsqlCommand ejecuter = new NpgsqlCommand(query, conn);
                ejecuter.ExecuteNonQuery();
                MessageBox.Show("ready, ya se inserto mi rey");
            }
            catch (Exception x )
            {
                MessageBox.Show("mijo, hay un error: " + x);
                throw;
            }
            
            MessageBox.Show("ready bby!");
        }

        public void Delete(string n)
        {
            string query = "DELETE FROM public.personas WHERE \"nombre\" ='"+n+"'";
            NpgsqlCommand ejecuter= new NpgsqlCommand(query, conn);

            ejecuter.ExecuteNonQuery();
            MessageBox.Show("deleted daddy");

        }
        
    }

}
