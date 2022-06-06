using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trillo.Gonzalo._2C.TPFINAL
{
    public class Tienda
    {
        private List<Producto> productos;
        public Tienda()
        {
           productos = new List<Producto>();
        }
        public List<Producto> Productos
        {
            get { return productos; }
        }
        public static bool operator + (Tienda tienda, Producto producto)
        {
            if (tienda is not null && producto is not null)
            {
                if(tienda.Productos.Count == 0)
                {
                    tienda.Productos.Add(producto);
                }
                else
                {
                    foreach (Producto item in tienda.Productos)
                    {
                        if (item != producto)
                        {
                            break;
                        }
                        else
                        {
                            item.Stock++;
                        }
                    }
                    tienda.Productos.Add(producto);
                }
                return true;
            }
            return false;
        }
        public static bool operator - (Tienda tienda, string codigoProducto)
        {
            Producto auxProducto = null;
            if (tienda is not null)
            {
                foreach (Producto item in tienda.Productos)
                {
                    if (item.CodigoProducto == codigoProducto)
                    {
                        auxProducto = item;
                    }
                }
                tienda.Productos.Remove(auxProducto);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string InformacionProductos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto producto in productos)
            {
                sb.Append(producto.ToString());
            }
            return sb.ToString();
        }

    }
}
