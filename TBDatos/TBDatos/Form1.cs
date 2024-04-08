using System.Windows.Forms;
using System;
using System.IO;
using System.Security.Policy;


namespace TBDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EscribirBtn_Click(object sender, EventArgs e)
        {
            TextWriter Escribe = new StreamWriter("Test.txt");
            Escribe.WriteLine("Hola Mundo!");
            Escribe.Close();

            StreamWriter agregar = File.AppendText("Test.txt");
            agregar.WriteLine("NUEVA LINEA MIJOOOOOO");
            agregar.Close();
        }
        private void LeerBtn_Click(object sender, EventArgs e)
        {
            TextReader Leer = new StreamReader("Test.txt");
            MessageBox.Show(Leer.ReadLine());
            MessageBox.Show(Leer.ReadToEnd());

            Leer.Close();


        }

        private void AbrirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Busca Tu archivo bro";
                openFileDialog1.ShowDialog();
                string Texto = openFileDialog1.FileName;

                if (File.Exists(openFileDialog1.FileName))
                {

                    TextReader Leer = new StreamReader(openFileDialog1.FileName);
                    rtxt_Contenido.Text = Leer.ReadToEnd();
                    Leer.Close();
                }
                txt_direccion.Text = Texto;
            }
            catch (Exception)
            {
                MessageBox.Show("error al abrir sorry papito");
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoaguardar = File.CreateText(txt);
                        textoaguardar.Write(rtxt_Contenido.Text);
                        textoaguardar.Close();
                        txt_direccion.Text = txt;
                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoaguardar = File.CreateText(txt);
                        textoaguardar.Write(rtxt_Contenido.Text);
                        textoaguardar.Close();
                        txt_direccion.Text = txt;
                    }
                    
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("men eso esta mal, revisa pues");
            }
        }
    }
}
