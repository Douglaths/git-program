using System.Data.SqlClient;


namespace ConexionBD
{
    public partial class Form1 : Form
    {
        static string Conexionstring = "data source=holamundodev.eastus2.cloudapp.azure.com; initial catalog=DouglathsDB; user id=douglathscarrascal; password=Dougl@ths1";
        SqlConnection conexion = new SqlConnection(Conexionstring);
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectionOn_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La conexión a la BD: " + conexion.Database + "ha sido exitosa");

        }

        private void ConnectionOff_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("se ha desconectado correctamente bro");
        }
    }
}
