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
    
    public partial class CXC_EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CXC_EMPRESA()
        {
            this.CXC_FACTURA = new HashSet<CXC_FACTURA>();
        }
    
        public int EMP_Empresa { get; set; }
        public string EMP_Nombre { get; set; }
        public string EMP_Direccion { get; set; }
        public string EMP_Telefono { get; set; }
        public string EMP_NIT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXC_FACTURA> CXC_FACTURA { get; set; }
    }
}
