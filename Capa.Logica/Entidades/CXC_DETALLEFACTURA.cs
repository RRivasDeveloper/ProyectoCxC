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
    
    public partial class CXC_DETALLEFACTURA
    {
        public int DTF_DetalleFactura { get; set; }
        public Nullable<decimal> DTF_Cantidad { get; set; }
        public Nullable<int> FAC_Factura { get; set; }
        public Nullable<int> PRD_Producto { get; set; }
        public Nullable<decimal> PRD_PrecioVentan { get; set; }
    
        public virtual CXC_FACTURA CXC_FACTURA { get; set; }
        public virtual CXC_PRODUCTO CXC_PRODUCTO { get; set; }
    }
}
