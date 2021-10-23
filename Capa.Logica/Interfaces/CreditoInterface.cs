using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Interfaces
{
    public class CreditoInterface
    {
        public int Credito { get; set; }
        public int Factura { get; set; }
        public int DiasCredito { get; set; }
        public DateTime FechaCredito { get; set; }
        public decimal MontoCredito { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Recargos { get; set; }
        public int Estado { get; set; }
    }
}
