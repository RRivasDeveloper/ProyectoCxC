//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa.Logica.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class CXC_PERSONA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CXC_PERSONA()
        {
            this.CXC_CLIENTE = new HashSet<CXC_CLIENTE>();
        }
    
        public int PER_Persona { get; set; }
        public string PER_PrimerNombre { get; set; }
        public string PER_SegundoNombre { get; set; }
        public string PER_PrimerApellido { get; set; }
        public string PER_SegundoApellido { get; set; }
        public string PER_Identificacion { get; set; }
        public Nullable<System.DateTime> PER_FechaNacimiento { get; set; }
        public string PER_Telefono { get; set; }
        public string PER_Departamento { get; set; }
        public string PER_Municipio { get; set; }
        public string PER_Direccion { get; set; }
        public string PER_NIT { get; set; }
        public string PER_Region { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXC_CLIENTE> CXC_CLIENTE { get; set; }
    }
}
