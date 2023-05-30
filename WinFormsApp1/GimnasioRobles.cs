using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class GimnasioRobles
    {
        public class DatosUsuario
        {
            public string Identificador { get; set; }
            public string Nombre { get; set; }
            public int Sueldo { get; set; }
            public int Estrato { get; set; }
            public string Genero { get; set; }


            public DatosUsuario(string pIdentificador, string pNombre, int pSueldo, int pEstrato, string pGenero)
            {
                this.Identificador = pIdentificador; ;
                this.Nombre = pNombre;
                this.Sueldo = pSueldo;
                this.Estrato = pEstrato;
                this.Genero = pGenero;
            }


#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            public DatosUsuario()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            {

            }

        }


        //METODOS VALIDADORES



        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
    }
}
