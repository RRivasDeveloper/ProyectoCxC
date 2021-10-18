using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Interfaces
{
    public class FacturaInterface
    {

        public int Factura { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Certificado { get; set; }
        public string FirmaElectronica { get; set; }
        public int Empresa { get; set; }
        public int Cliente { get; set; }
        public int TipoPago { get; set; }
        public List<FacturaDetInterface> CXC_FACTURADETALLE { get; set; }

    }
}
