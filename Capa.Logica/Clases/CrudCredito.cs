using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Clases
{
    public class CrudCredito
    {
        #region Consultar uno
        public Interfaces.CreditoInterface getCreditoByFac(int factura_id)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Interfaces.CreditoInterface objConsulta = (from q in objEntidad.CXC_CREDITO
                                                                where q.FAC_Factura == factura_id
                                                               select new Interfaces.CreditoInterface
                                                                {
                                                                   Credito = q.CRE_Credito,
                                                                    Factura = (int)q.FAC_Factura,
                                                                    DiasCredito = (int)q.DCR_DiasCredito,
                                                                    FechaCredito = (DateTime)q.CRE_FechaCredito,
                                                                    MontoCredito = (decimal)q.CRE_MontoCredito,
                                                                    MontoPagado = (decimal)q.CRE_MontoPagado,
                                                                    Recargos = (decimal)q.CRE_Recargos,
                                                                    Estado = (int)q.EST_Estado

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

        #region Actualizar monto
        public string actualizarMonto(int factura, decimal total)//se ingresan lo datos que se guardaran en la bd
        {
            try
            {//se utiliza la entidad de base de datos
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Entidades.CXC_CREDITO obtcredito = (from q in objEntidad.CXC_CREDITO
                                                        where q.FAC_Factura == factura
                                                        select q).First();

                    obtcredito.CRE_MontoCredito = total;

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
        #region Actualizar plazo
        public string actualizarPlazo(int factura, int plazo)//se ingresan lo datos que se guardaran en la bd
        {
            try
            {//se utiliza la entidad de base de datos
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Entidades.CXC_CREDITO obtcredito = (from q in objEntidad.CXC_CREDITO
                                                        where q.FAC_Factura == factura
                                                        select q).First();

                    obtcredito.CXC_DIASCREDITO.DCR_DiasCredito = plazo;

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
    }
}
