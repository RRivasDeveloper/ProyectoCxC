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
    
    public partial class RRH_EMPLEADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RRH_EMPLEADO()
        {
            this.CXC_CLIENTE = new HashSet<CXC_CLIENTE>();
            this.SEG_USUARIO1 = new HashSet<SEG_USUARIO>();
        }
    
        public int RRH_Empleado1 { get; set; }
        public string RRH_NombreEmpleado { get; set; }
        public Nullable<System.DateTime> RRH_FechaIngreso { get; set; }
        public string RRH_Genero { get; set; }
        public string RRH_Estado { get; set; }
        public Nullable<int> PUE_Puesto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXC_CLIENTE> CXC_CLIENTE { get; set; }
        public virtual RRH_PUESTO RRH_PUESTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_USUARIO> SEG_USUARIO1 { get; set; }
    }
}
