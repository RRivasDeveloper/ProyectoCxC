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
    
    public partial class SP_RPT_CREDITOS_CANCELADOS_Result
    {
        public string Region { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Identificacion { get; set; }
        public Nullable<System.DateTime> FechaCredito { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoCredito { get; set; }
        public decimal Montopagado { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public string EST_Descripcion { get; set; }
        public int EST_Estado { get; set; }
        public Nullable<decimal> MontoMora { get; set; }
        public string DCR_Descripcion { get; set; }
    }
}
