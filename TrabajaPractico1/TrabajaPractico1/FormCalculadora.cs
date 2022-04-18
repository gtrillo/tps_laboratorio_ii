using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace TrabajaPractico1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = 0.ToString();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private static double Operar (string numero1, string numero2, string operador)
        {
            double resultado = 0;
            char operadorAuxiliar;
            if (numero1 != null && numero2!= null && operador != null)
            {
                Operando operandoUno = new Operando(numero1);
                Operando operandoDos = new Operando(numero2);
                char.TryParse(operador, out operadorAuxiliar);
                resultado = Calculadora.Operar(operandoUno, operandoDos, operadorAuxiliar);
            }
            return resultado; 
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, cmbOperador.Text);
            this.lblResultado.Text = resultado.ToString();
            //btnConvertirABinario.Enabled = false;
            //btnConvertirADecimal.Enabled = false;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
        private void btnCovertirABinario_Click(object sender, EventArgs e)
        {

        }
    }
}
