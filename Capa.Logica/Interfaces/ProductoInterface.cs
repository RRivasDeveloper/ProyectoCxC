using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Interfaces
{
    public class ProductoInterface
    {
        public int Producto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public int Existencia { get; set; }
        public int Costo { get; set; }
        public int PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public ProductoInterface()
        {
            this.Producto = 0;
        }

        public int getTotal()
        {
            return PrecioVenta * Cantidad;
        }
        public void setCantidad()
        {
            Total = PrecioVenta * Cantidad;
        }
    }
}
