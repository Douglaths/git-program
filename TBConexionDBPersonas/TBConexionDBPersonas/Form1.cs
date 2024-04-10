using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace TBConexionDBPersonas
{
    public partial class Form1 : Form
    {

        static string Conexionstring = "data source=holamundodev.eastus2.cloudapp.azure.com; initial catalog=DouglathsDB; user id=douglathscarrascal; password=Dougl@ths1";
        SqlConnection Conexion = new SqlConnection(Conexionstring);
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            MessageBox.Show("The connection has been sucesfully connect");
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            Conexion.Close();
            MessageBox.Show("The connection has been sucesfully Disconnect");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (CountryBoxTxt.Text == "")
            {
                string query = "Select * from Personas";
                SqlCommand comando = new SqlCommand(query, Conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridViewTable.DataSource = tabla;

            }
            else
            {
                string query = "Select * from Personas where Pais ='"+CountryBoxTxt.Text+"'";
                SqlCommand comando = new SqlCommand(query, Conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridViewTable.DataSource = tabla;
            }
        }
        public void Search()
        {
            string query = "Select * from Personas";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridViewTable.DataSource = tabla;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string cadena = "Insert into Personas ([Nombre] , [Edad], [Pais], [NID]) values ('"+NameTxt.Text+"', '"+AgeTxt.Text+"', '"+CountryTxt.Text+"', '"+NIDTxt.Text+"')";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("The person: "+NameTxt.Text+"has been added sucesfully");

            NameTxt.Text= "";
            AgeTxt.Text= "";
            CountryTxt.Text= "";
            NIDTxt.Text= "";

            Search();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            MessageBox.Show(flag.ToString());
            string cadena = "Delete from Personas Where Nombre = '"+NameTxt.Text+"'";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            flag = comando.ExecuteNonQuery();
            MessageBox.Show(flag.ToString());

            if (flag == 1)
            {
                MessageBox.Show("The person: "+NameTxt.Text+" has been DELETE ");

            }
            else
            {
                MessageBox.Show("The person: "+NameTxt.Text+" couldn't be DELETE ");
            }
            NameTxt.Text = "";
            Search();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            MessageBox.Show(flag.ToString());
            string cadena = "Update Personas set Nombre = '"+NameTxt.Text+"', Edad= '"+AgeTxt.Text+"', Pais= '"+CountryTxt.Text+"' , NID= '"+NIDTxt.Text+"' Where Nombre='"+NametoUpdateBox.Text+"'";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            flag = comando.ExecuteNonQuery();
            MessageBox.Show(flag.ToString());

            if (flag == 0)
            {
                MessageBox.Show("The person: "+NameTxt.Text+" couldn't be Update ");
            }
            else
            {
                MessageBox.Show("The person: "+NametoUpdateBox.Text+" has been Update "+" for the new name: "+NameTxt.Text);
            }
            NameTxt.Text= "";
            AgeTxt.Text= "";
            CountryTxt.Text= "";
            NIDTxt.Text= "";
            NameTxt.Text = "";
            NametoUpdateBox.Text =  "";
            Search();
        }
    }
}
