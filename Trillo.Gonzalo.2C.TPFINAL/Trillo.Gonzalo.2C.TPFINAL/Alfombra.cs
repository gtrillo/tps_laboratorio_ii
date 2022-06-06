using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trillo.Gonzalo._2C.TPFINAL
{
    public class Alfombra : Producto
    {
        private float largo;
        private float ancho;

        public Alfombra (string codigoProducto, TipoTela tela, Color color, string nombreProducto, float largo, float ancho, double precioProducto)
            :base(codigoProducto,tela,color,nombreProducto, precioProducto)
        {
            this.largo = largo;
            this.ancho = ancho;
        }
        public override string mostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.mostrarInformacion());
            sb.AppendLine($" - Largo: {this.largo} - Ancho: {this.ancho}");
            return sb.ToString();
        }
    }
}
