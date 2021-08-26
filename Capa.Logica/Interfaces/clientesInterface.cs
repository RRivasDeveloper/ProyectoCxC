using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Interfaces
{
    public class clientesInterface
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Identificacion { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Direccion { get; set; }
        public string NIT { get; set; }
    }
}
