﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CxCEntities1 : DbContext
    {
        public CxCEntities1()
            : base("name=CxCEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CXC_CLIENTE> CXC_CLIENTE { get; set; }
        public virtual DbSet<CXC_CREDITO> CXC_CREDITO { get; set; }
        public virtual DbSet<CXC_DETALLEFACTURA> CXC_DETALLEFACTURA { get; set; }
        public virtual DbSet<CXC_DIASCREDITO> CXC_DIASCREDITO { get; set; }
        public virtual DbSet<CXC_EMPRESA> CXC_EMPRESA { get; set; }
        public virtual DbSet<CXC_ESTADOCREDITO> CXC_ESTADOCREDITO { get; set; }
        public virtual DbSet<CXC_FACTURA> CXC_FACTURA { get; set; }
        public virtual DbSet<CXC_FORMAPAGO> CXC_FORMAPAGO { get; set; }
        public virtual DbSet<CXC_PERSONA> CXC_PERSONA { get; set; }
        public virtual DbSet<CXC_PRODUCTO> CXC_PRODUCTO { get; set; }
        public virtual DbSet<CXC_PROYECCIONPAGO> CXC_PROYECCIONPAGO { get; set; }
        public virtual DbSet<CXC_RECUPERACION> CXC_RECUPERACION { get; set; }
        public virtual DbSet<CXC_TIPO_PERSONA> CXC_TIPO_PERSONA { get; set; }
        public virtual DbSet<CXC_TIPOPAGO> CXC_TIPOPAGO { get; set; }
        public virtual DbSet<CXC_TIPOTRANSACCION> CXC_TIPOTRANSACCION { get; set; }
        public virtual DbSet<RRH_EMPLEADO> RRH_EMPLEADO { get; set; }
        public virtual DbSet<RRH_PUESTO> RRH_PUESTO { get; set; }
        public virtual DbSet<SEG_ROL> SEG_ROL { get; set; }
        public virtual DbSet<SEG_USUARIO> SEG_USUARIO { get; set; }
    
        public virtual ObjectResult<SP_RPT_CLIENTES_X_REGION_Result> SP_RPT_CLIENTES_X_REGION(string vTipPago)
        {
            var vTipPagoParameter = vTipPago != null ?
                new ObjectParameter("vTipPago", vTipPago) :
                new ObjectParameter("vTipPago", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_CLIENTES_X_REGION_Result>("SP_RPT_CLIENTES_X_REGION", vTipPagoParameter);
        }
    
        public virtual ObjectResult<SP_RPT_Facturacion_x_Fecha_TipoPago_Result> SP_RPT_Facturacion_x_Fecha_TipoPago(Nullable<System.DateTime> vFechaInicial, Nullable<System.DateTime> vFechaFinal, string vTipPago)
        {
            var vFechaInicialParameter = vFechaInicial.HasValue ?
                new ObjectParameter("vFechaInicial", vFechaInicial) :
                new ObjectParameter("vFechaInicial", typeof(System.DateTime));
    
            var vFechaFinalParameter = vFechaFinal.HasValue ?
                new ObjectParameter("vFechaFinal", vFechaFinal) :
                new ObjectParameter("vFechaFinal", typeof(System.DateTime));
    
            var vTipPagoParameter = vTipPago != null ?
                new ObjectParameter("vTipPago", vTipPago) :
                new ObjectParameter("vTipPago", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_Facturacion_x_Fecha_TipoPago_Result>("SP_RPT_Facturacion_x_Fecha_TipoPago", vFechaInicialParameter, vFechaFinalParameter, vTipPagoParameter);
        }
    
        public virtual ObjectResult<spConsulta_Result> spConsulta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsulta_Result>("spConsulta");
        }
    
        public virtual ObjectResult<spConsultaUno_Result> spConsultaUno(string iDNIT)
        {
            var iDNITParameter = iDNIT != null ?
                new ObjectParameter("IDNIT", iDNIT) :
                new ObjectParameter("IDNIT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultaUno_Result>("spConsultaUno", iDNITParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual ObjectResult<SP_RPT_Clientes_EstadoCredito_Result> SP_RPT_Clientes_EstadoCredito(Nullable<System.DateTime> vFechaInicial, Nullable<System.DateTime> vFechaFinal, Nullable<int> vEstado)
        {
            var vFechaInicialParameter = vFechaInicial.HasValue ?
                new ObjectParameter("vFechaInicial", vFechaInicial) :
                new ObjectParameter("vFechaInicial", typeof(System.DateTime));
    
            var vFechaFinalParameter = vFechaFinal.HasValue ?
                new ObjectParameter("vFechaFinal", vFechaFinal) :
                new ObjectParameter("vFechaFinal", typeof(System.DateTime));
    
            var vEstadoParameter = vEstado.HasValue ?
                new ObjectParameter("vEstado", vEstado) :
                new ObjectParameter("vEstado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_Clientes_EstadoCredito_Result>("SP_RPT_Clientes_EstadoCredito", vFechaInicialParameter, vFechaFinalParameter, vEstadoParameter);
        }
    
        public virtual ObjectResult<SP_RPT_CREDITOS_X_REGION_Result> SP_RPT_CREDITOS_X_REGION(Nullable<System.DateTime> fechaInicial, Nullable<System.DateTime> fechaFinal)
        {
            var fechaInicialParameter = fechaInicial.HasValue ?
                new ObjectParameter("FechaInicial", fechaInicial) :
                new ObjectParameter("FechaInicial", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_CREDITOS_X_REGION_Result>("SP_RPT_CREDITOS_X_REGION", fechaInicialParameter, fechaFinalParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<SP_RPT_CREDITOS_X_PAGAR_Result> SP_RPT_CREDITOS_X_PAGAR(Nullable<System.DateTime> fechaInicial, Nullable<System.DateTime> fechaFinal)
        {
            var fechaInicialParameter = fechaInicial.HasValue ?
                new ObjectParameter("FechaInicial", fechaInicial) :
                new ObjectParameter("FechaInicial", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_CREDITOS_X_PAGAR_Result>("SP_RPT_CREDITOS_X_PAGAR", fechaInicialParameter, fechaFinalParameter);
        }
    }
}
