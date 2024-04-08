using POOpractica1;

namespace POOpractica1
{
    public partial class Form1 : Form
    {

        Telefono Movistar = new Telefono();
        //Telefono Claro = new Telefono("Samsung");
        //Telefono Kolby = new Telefono("Moto", "green", "unknown type");

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Llamar_Click(object sender, EventArgs e)
        {
            //Movistar.Llamar();

            MessageBox.Show(Movistar.MandarMensaje("Douglaths", "Oye nenita, eu te quero muito"));
            MessageBox.Show(Operaciones.Suma(1,2).ToString());

        }
    }
}
