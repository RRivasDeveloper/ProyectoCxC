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
    
    public partial class SEG_USUARIO
    {
        public int USU_Usuario { get; set; }
        public string USU_UsuarioSistema { get; set; }
        public string USU_Estado { get; set; }
        public Nullable<int> ROL_Rol { get; set; }
        public Nullable<int> RRH_Empleado { get; set; }
        public byte[] USU_Passw { get; set; }
    
        public virtual RRH_EMPLEADO RRH_EMPLEADO1 { get; set; }
        public virtual SEG_ROL SEG_ROL { get; set; }
    }
}
