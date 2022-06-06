using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trillo.Gonzalo._2C.TPFINAL;
namespace Vista
{
    public partial class FormularioMenu : Form
    {
        public Tienda tienda1 = new Tienda();
        public FormularioMenu()
        {
            InitializeComponent();
        }
        private void FormularioMenu_Load(object sender, EventArgs e)
        {
            AgregarAlComboBox();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            if (this.txtCodigoProducto.Text is not null && this.txtNombreProducto.Text is not null && this.cmbTipoTela.SelectedItem is not null && this.cmbColor.SelectedItem is not null && this.cmbTipoProducto is not null && this.txtPrecio is not null)
            {
                    Alfombra nuevaAlfombra;
                    Cortina nuevaCortina;
                    try
                    {
                        switch (cmbTipoProducto.SelectedItem)
                        {
                            case "Alfombra":
                                nuevaAlfombra = new Alfombra(this.txtCodigoProducto.Text, (TipoTela)cmbTipoTela.SelectedItem, (Trillo.Gonzalo._2C.TPFINAL.Color)cmbColor.SelectedItem, this.txtNombreProducto.Text, float.Parse(this.txtLargo.Text), float.Parse(this.txtAncho.Text), double.Parse(this.txtPrecio.Text));
                                if (tienda1 + nuevaAlfombra)
                                {
                                    MessageBox.Show("Producto agregado con exito.");
                                }
                                else
                                {
                                    MessageBox.Show("Error al cargar el producto, intente nuevamente.");
                                }
                           break;
                           case "Cortina":
                                nuevaCortina = new Cortina(this.txtCodigoProducto.Text, (TipoTela)cmbTipoTela.SelectedItem, (Trillo.Gonzalo._2C.TPFINAL.Color)cmbColor.SelectedItem, this.txtNombreProducto.Text, float.Parse(this.txtLargo.Text), float.Parse(this.txtAncho.Text), double.Parse(this.txtPrecio.Text));
                                if (tienda1 + nuevaCortina)
                                {
                                    MessageBox.Show("Producto agregado con exito.");
                                }
                                else
                                {
                                    MessageBox.Show("Error al cargar el producto, intente nuevamente.");
                                }
                           break;

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    rtbMostrar.Text = tienda1.InformacionProductos();
            }
        }
        private void cmbTipoTela_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void rtbMostrar_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(this.txtCodigoProducto is not null && this.cmbTipoProducto.SelectedItem is not null)
            {
                if (tienda1 - this.txtCodigoProducto.Text)
                {
                    MessageBox.Show("Stock descontado");
                }
                rtbMostrar.Text = tienda1.InformacionProductos();
            }
        }
        private void AgregarAlComboBox()
        {
            cmbTipoProducto.Items.Add("Alfombra");
            cmbTipoProducto.Items.Add("Cortina");
            cmbTipoTela.Items.Add(TipoTela.Lana);
            cmbTipoTela.Items.Add(TipoTela.Seda);
            cmbTipoTela.Items.Add(TipoTela.Sisal);
            cmbTipoTela.Items.Add(TipoTela.Algodon);
            cmbColor.Items.Add(Trillo.Gonzalo._2C.TPFINAL.Color.Rojo);
            cmbColor.Items.Add(Trillo.Gonzalo._2C.TPFINAL.Color.Negro);
            cmbColor.Items.Add(Trillo.Gonzalo._2C.TPFINAL.Color.Verde);
            cmbColor.Items.Add(Trillo.Gonzalo._2C.TPFINAL.Color.Gris);
            cmbColor.Items.Add(Trillo.Gonzalo._2C.TPFINAL.Color.Blanco);
            cmbColor.Items.Add(Trillo.Gonzalo._2C.TPFINAL.Color.Rosa);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
