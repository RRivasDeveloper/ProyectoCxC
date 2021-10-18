using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Clases
{
    public class CrudDiasCredito
    {
        #region Consultar uno
        public Interfaces.DiasCreditoInterface getDiasCredito(int id)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Interfaces.DiasCreditoInterface objConsulta = (from q in objEntidad.CXC_DIASCREDITO
                                                                where q.DCR_DiasCredito == id
                                                                select new Interfaces.DiasCreditoInterface
                                                                {
                                                                    DiasCredito = q.DCR_DiasCredito,
                                                                    CantidadDias = (int)q.DCR_CantidadDias,
                                                                    Descripcion = q.DCR_Descripcion

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
        public List<Interfaces.DiasCreditoInterface> getDiasCredito()
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    List<Interfaces.DiasCreditoInterface> objConsulta = (from q in objEntidad.CXC_DIASCREDITO
                                                                   select new Interfaces.DiasCreditoInterface
                                                                   {
                                                                       DiasCredito = q.DCR_DiasCredito,
                                                                       CantidadDias = (int)q.DCR_CantidadDias,
                                                                       Descripcion = q.DCR_Descripcion

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
