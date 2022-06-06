using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trillo.Gonzalo._2C.TPFINAL
{
    public class Cortina : Producto
    {
        private float alto;
        private float ancho;

        public Cortina(string codigoProducto, TipoTela tela, Color color, string nombreProducto, float largo, float ancho, double precioProducto)
            : base(codigoProducto, tela, color, nombreProducto, precioProducto)
        {
            this.alto = largo;
            this.ancho = ancho;
        }
        public override string mostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.mostrarInformacion());
            sb.AppendLine($" - Alto: {this.alto} - Ancho: {this.ancho}");
            return sb.ToString();
        }
    }
}
