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
    public partial class FormularioInicio : Form
    {
        public FormularioInicio()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"/img/aladdin-copyright-walt-disney-mp14np.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormularioCLientes formularioClientes = new FormularioCLientes();
            formularioClientes.Show();
            this.Hide();
        }

        private void bntPersonal_Click(object sender, EventArgs e)
        {
            FormularioLogin formularioLogin = new FormularioLogin();
            formularioLogin.Show();
            this.Hide();
        }
    }
}
