using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Clases
{
    public class CrudTipoPago
    {
        #region Consultar uno
        public Interfaces.TipoPagoInterface getTipoPago(int id)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Interfaces.TipoPagoInterface objConsulta = (from q in objEntidad.CXC_TIPOPAGO
                                                                where q.TPA_TipoPago == id
                                                                select new Interfaces.TipoPagoInterface
                                                                {
                                                                    TipoPago = q.TPA_TipoPago,
                                                                    Descripcion = q.TPA_Descripcion

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

        #region Consultar todos
        public List<Interfaces.TipoPagoInterface> getTipoPago()
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    List<Interfaces.TipoPagoInterface> objConsulta = (from q in objEntidad.CXC_TIPOPAGO
                                                                select new Interfaces.TipoPagoInterface
                                                                {
                                                                    TipoPago = q.TPA_TipoPago,
                                                                    Descripcion = q.TPA_Descripcion

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
    }
}
