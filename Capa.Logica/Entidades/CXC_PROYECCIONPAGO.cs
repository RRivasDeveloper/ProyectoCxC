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
    
    public partial class CXC_PROYECCIONPAGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CXC_PROYECCIONPAGO()
        {
            this.CXC_RECUPERACION = new HashSet<CXC_RECUPERACION>();
        }
    
        public int PRP_ProyeccionPago { get; set; }
        public Nullable<int> CRE_Credito { get; set; }
        public Nullable<int> PRP_NumeroCuota { get; set; }
        public Nullable<System.DateTime> PRP_FechaProyeccion { get; set; }
        public Nullable<decimal> PRP_MontoCuota { get; set; }
        public Nullable<int> EST_Estado { get; set; }
    
        public virtual CXC_CREDITO CXC_CREDITO { get; set; }
        public virtual CXC_ESTADOCREDITO CXC_ESTADOCREDITO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXC_RECUPERACION> CXC_RECUPERACION { get; set; }
    }
}
