using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormularioRegistro : Form
    {
        public FormularioRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (ValidarCampos())
            {
                GimnasioRobles.DatosUsuario gimnasioRobles = new GimnasioRobles.DatosUsuario();
                gimnasioRobles.Identificador = txtIdentificacion.Text;
                gimnasioRobles.Nombre = txtNombre.Text;
                gimnasioRobles.Sueldo = int.Parse(txtSueldo.Text);
                gimnasioRobles.Estrato = int.Parse(txtEstrato.Text);

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            // Validar que los campos no estén vacíos y cumplan con los formatos esperados

            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSueldo.Text) ||
                string.IsNullOrWhiteSpace(txtEstrato.Text))
            {
                return false;
            }

            if (!decimal.TryParse(txtSueldo.Text, out _))
            {
                return false;
            }

            if (!int.TryParse(txtEstrato.Text, out _) || int.Parse(txtEstrato.Text) < 1 || int.Parse(txtEstrato.Text) > 6)
            {
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtSueldo.Text = string.Empty;
            txtEstrato.Text = string.Empty;
        }

        private void FormularioRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            GimnasioRobles.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            GimnasioRobles.SoloLetras(e);
        }

        private void txtEstrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            GimnasioRobles.SoloNumeros(e);
        }
    }
}
