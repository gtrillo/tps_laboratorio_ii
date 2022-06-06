using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "" && this.txtContraseña.Text == "")
            {
                FormularioMenu menuInicio = new FormularioMenu();
                MessageBox.Show("Bienvenido :D");
                menuInicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto intente nuevamente");
                this.txtContraseña.Text = string.Empty;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormularioInicio formularioInicio = new FormularioInicio();
            formularioInicio.Show();
            this.Hide();
        }
    }
}
