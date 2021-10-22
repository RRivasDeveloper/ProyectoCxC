using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Interfaces
{
    public class FacturaDetInterface
    {
        public int DetalleFactura { get; set; }
        public decimal Cantidad { get; set; }
        public int Factura { get; set; }
        public int Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public ProductoInterface CXC_PRODUCTO { get; set; } 
    }
}
