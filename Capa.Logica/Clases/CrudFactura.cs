using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Clases
{
    public class CrudFactura
    {
        #region insertar Factura
        public string InsertarFactura(int Factura,
            string Serie,
            string Numero,
            DateTime Fecha,
            decimal total,
            string Certificado,
            string FirmaElectronica,
            int Empresa,
            int Cliente,
            int TipoPago)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Entidades.CXC_FACTURA obtFactura = new Entidades.CXC_FACTURA
                    {
                        FAC_Factura = Factura,
                        FAC_Serie = Serie,
                        FAC_Numero = Numero,
                        FAC_Fecha = Fecha,
                        FAC_TOTAL = total,
                        FAC_Certificado = Certificado,
                        FAC_FirmaElectronica = FirmaElectronica,
                        EMP_Empresa = Empresa,
                        CLI_Cliente = Cliente,
                        TPA_TipoPago = TipoPago
                    };
                    objEntidad.CXC_FACTURA.Add(obtFactura);
                    objEntidad.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Se insertó Proceso con Exito";
        }
        #endregion
        #region Modificar Factura
        public string modificarFactura(int Factura,
            string Serie,
            string Numero,
            DateTime Fecha,
            decimal total,
            string Certificado,
            string FirmaElectronica,
            int Empresa,
            int Cliente,
            int TipoPago)//se ingresan lo datos que se guardaran en la bd
        {
            try
            {//se utiliza la entidad de base de datos
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Entidades.CXC_FACTURA objFactura = (from q in objEntidad.CXC_FACTURA
                                                        where q.FAC_Factura == Factura
                                                        select q).First();

                    objFactura.FAC_Factura = Factura;
                    objFactura.FAC_Serie = Serie;
                    objFactura.FAC_Numero = Numero;
                    objFactura.FAC_Fecha = Fecha;
                    objFactura.FAC_TOTAL = total;
                    objFactura.FAC_Certificado = Certificado;
                    objFactura.FAC_FirmaElectronica = FirmaElectronica;
                    objFactura.EMP_Empresa = Empresa;
                    objFactura.CLI_Cliente = Cliente;
                    objFactura.TPA_TipoPago = TipoPago;

                    objEntidad.SaveChanges();//solo se guardan los cambios porque ya existe
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Se Modifico con Exito";
        }
        #endregion
        #region Eliminar Factura
        public string eliminarFactura(int Factura)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Entidades.CXC_FACTURA objFactura = (from q in objEntidad.CXC_FACTURA
                                                        where q.FAC_Factura == Factura
                                                        select q).First();
                    objEntidad.CXC_FACTURA.Remove(objFactura);
                    objEntidad.SaveChanges();
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Se Elimino con Exito";
        }
        #endregion
        #region Consulta Facturas
        public List<Interfaces.FacturaInterface> getFactura()
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    List<Interfaces.FacturaInterface> objConsulta = (from q in objEntidad.CXC_FACTURA
                                                                          //where q.CXC_PERSONA1=="parametro"
                                                                      select new Interfaces.FacturaInterface
                                                                      {
                                                                          Factura = q.FAC_Factura,
                                                                          Serie = q.FAC_Serie,
                                                                          Numero = q.FAC_Numero,
                                                                          Fecha = (DateTime)q.FAC_Fecha,
                                                                          Total = (decimal)q.FAC_TOTAL,
                                                                          Certificado = q.FAC_Certificado,
                                                                          FirmaElectronica = q.FAC_FirmaElectronica,
                                                                          Empresa = (int)q.EMP_Empresa,
                                                                          Cliente = (int)q.CLI_Cliente,
                                                                          TipoPago = (int)q.TPA_TipoPago

                                                                      }).ToList();
                    return objConsulta;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        #region Consultar una
        public Interfaces.FacturaInterface getFactura(int id)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Interfaces.FacturaInterface objConsulta = (from q in objEntidad.CXC_FACTURA
                                                                     where q.FAC_Factura == id
                                                                      select new Interfaces.FacturaInterface
                                                                      {
                                                                          Factura = q.FAC_Factura,
                                                                          Serie = q.FAC_Serie,
                                                                          Numero = q.FAC_Numero,
                                                                          Fecha = (DateTime)q.FAC_Fecha,
                                                                          Total = (decimal)q.FAC_TOTAL,
                                                                          Certificado = q.FAC_Certificado,
                                                                          FirmaElectronica = q.FAC_FirmaElectronica,
                                                                          Empresa = (int)q.EMP_Empresa,
                                                                          Cliente = (int)q.CLI_Cliente,
                                                                          TipoPago = (int)q.TPA_TipoPago

                                                                      }).First();
                    return objConsulta;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        #region Consultar ultima x cliente
        public Interfaces.FacturaInterface getFacturaXCliente(int id)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Interfaces.FacturaInterface objConsulta = (from q in objEntidad.CXC_FACTURA
                                                               where q.CLI_Cliente == id
                                                               select new Interfaces.FacturaInterface
                                                               {
                                                                   Factura = q.FAC_Factura,
                                                                   Serie = q.FAC_Serie,
                                                                   Numero = q.FAC_Numero,
                                                                   Fecha = (DateTime)q.FAC_Fecha,
                                                                   Total = (decimal)q.FAC_TOTAL,
                                                                   Certificado = q.FAC_Certificado,
                                                                   FirmaElectronica = q.FAC_FirmaElectronica,
                                                                   Empresa = (int)q.EMP_Empresa,
                                                                   Cliente = (int)q.CLI_Cliente,
                                                                   TipoPago = (int)q.TPA_TipoPago

                                                               }).First();
                    return objConsulta;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        #region Consulta Facturas por documento
        public List<Entidades.SP_CNS_FACTURA_Result> getFactura(String serie, String factura) //nit ultimo creado 
        {
            try
            {
                //DateTime fechaInicial = new DateTime(2021, 01, 01);
                //DateTime fechaFinal = new DateTime(2021, 12, 31);
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    List<Entidades.SP_CNS_FACTURA_Result> respuesta = objEntidad.SP_CNS_FACTURA(serie, factura).ToList();
                    return respuesta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Insertar detalle
        public List<Entidades.SP_CNS_DETALLE_FACTURA_Result> getDetalleFactura(String serie, String factura, int noFactura)
        {
            try
            {
                //DateTime fechaInicial = new DateTime(2021, 01, 01);
                //DateTime fechaFinal = new DateTime(2021, 12, 31);
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    List<Entidades.SP_CNS_DETALLE_FACTURA_Result> respuesta = objEntidad.SP_CNS_DETALLE_FACTURA(serie, factura/*, noFactura*/).ToList();
                    return respuesta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


    }
}
