using System;
using System.Collections.Generic;
using System.Text;

namespace CapasCxC.HttpsClientService
{
    public class Afiliado
    {
        public String NIT { get; set; }
        public String NOMBRE_JURIDICO { get; set; }
        public String PRIMER_NOMBRE { get; set; }
        public String SEGUNDO_NOMBRE { get; set; }
        public String PRIMER_APELLIDO { get; set; }
        public String SEGUNDO_APELLIDO { get; set; }
        public String DIRECCION { get; set; }
        public String DPI { get; set; }
        public int EMISOR { get; set; }
        public int ACTIVO { get; set; }
        public int CERTIFICADOR { get; set; }
    }
}
