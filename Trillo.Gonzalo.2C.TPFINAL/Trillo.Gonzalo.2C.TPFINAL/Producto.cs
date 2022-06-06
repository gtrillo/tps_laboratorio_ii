using System;
using System.Text;
namespace Trillo.Gonzalo._2C.TPFINAL
{
    public enum TipoTela
    {
        Algodon,
        Seda,
        Lana,
        Sisal

    }
    public enum Color
    {
        Rojo,
        Blanco,
        Gris,
        Verde,
        Rosa,
        Negro
    }
    public abstract class Producto
    {
        protected string codigoProducto;
        protected TipoTela tipoTela;
        protected Color color;
        protected string nombreProducto;
        protected int stock;
        protected double precio;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string CodigoProducto
        {
            get 
            { 
                return codigoProducto; 
            }
            set
            {
                codigoProducto = value;
            }
        }

        public Producto(string codigoProducto, TipoTela tela, Color color, string nombreProducto, double precioProducto)
        {
            this.tipoTela = tela;
            this.color = color;
            stock = 1;
            this.nombreProducto = nombreProducto;
            this.codigoProducto = codigoProducto;
            this.precio = precioProducto;
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad, dos productos seran iguales cuando posean un mismo codigo de producto
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns></returns>
        public static bool operator == (Producto producto1, Producto producto2)
        {
            if(producto1 is not null && producto2 is not null)
            {
                return producto1.codigoProducto == producto2.codigoProducto;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador de desigualdad, dos productos seran distintos cuando posean un codigo de producto diferente
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1.codigoProducto == producto2.codigoProducto);
        }

        public virtual string mostrarInformacion ()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Producto: {this.nombreProducto}");
            sb.Append($" - Codigo del producto: {this.codigoProducto}");
            sb.Append($" - Tipo de tela: {this.tipoTela}");
            sb.Append($" - Color: {this.color}");
            sb.Append($" - Precio:$ {this.precio}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return mostrarInformacion();            
        }

     }
}
