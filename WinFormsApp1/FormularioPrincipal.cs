namespace WinFormsApp1
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "123")
            {
                this.panel1.Controls.Clear();
                FormularioRegistro formaRegistro = new FormularioRegistro() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                formaRegistro.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add(formaRegistro);
                formaRegistro.Show();
            }
            else
            {
                DialogResult mensaje = MessageBox.Show("Contraseña incorrecta, intente nuevamente", "Error", MessageBoxButtons.RetryCancel);
                switch (mensaje)
                {
                    case DialogResult.Retry:
                        textBox1.Text = string.Empty;
                        textBox1.Focus();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}