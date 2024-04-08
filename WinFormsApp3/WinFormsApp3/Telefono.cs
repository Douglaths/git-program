using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica1
{
    internal class Telefono
    {
        private string Marca;
        private string Color;
        private string Tipo;

        public Telefono()
        {
            Marca="GUAGUEI";
            Color= "NEGRO";
            Tipo="Demano";
        }

        public Telefono(string M)
        {
            Marca=M;
            Color= "gris";
            Tipo="Debolso";
        }

        public Telefono(string M, string C, string T)
        {
            Marca=M;
            Color= C;
            Tipo=T;
        }

        public void Llamar()
        {
            //System.Windows.Forms.MessageBox.Show("Tu celular es un: " + Marca + "De color:" + Color + "y de tipo " + Tipo) ;
        }

        public string MandarMensaje(string N, string Msj)
        {

            string Mensaje = Msj;
            string Nombre = N;

            string MsjFinal = "El mensaje: '" + Msj + "'" + " Fue enviado por: " + N;

            return MsjFinal;
        }
    
    }
}
