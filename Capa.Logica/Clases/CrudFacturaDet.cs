using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Clases
{
    public class CrudFacturaDet
    {
        #region Consulta Factura Detalle
        public List<Interfaces.FacturaDetInterface> getFacturaDetByFac(int factura_id)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    List<Interfaces.FacturaDetInterface> objConsulta = (from q in objEntidad.CXC_DETALLEFACTURA
                                                                     where q.FAC_Factura == factura_id
                                                                     select new Interfaces.FacturaDetInterface
                                                                     {
                                                                         DetalleFactura = q.DTF_DetalleFactura,
                                                                            Cantidad = (int)q.DTF_Cantidad,
                                                                            Factura = (int)q.FAC_Factura,
                                                                            Producto = (int)q.PRD_Producto,
                                                                            PrecioVenta = (decimal)q.PRD_PrecioVentan,

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
        #region SP creacion de detalle
        #endregion
    }
}
