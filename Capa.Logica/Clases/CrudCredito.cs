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
    }
}
