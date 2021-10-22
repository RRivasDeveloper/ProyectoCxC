using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Logica.Interfaces;

namespace Capa.Logica.Clases
{
    public class CrudProducto
    {
        #region Consultar uno
        public Interfaces.ProductoInterface getProducto(int id)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Interfaces.ProductoInterface objConsulta = (from q in objEntidad.CXC_PRODUCTO
                                                               where q.PRD_Producto == id
                                                               select new Interfaces.ProductoInterface
                                                               {
                                                                   Producto = q.PRD_Producto,
                                                                    Marca = q.PRD_Marca,
                                                                    Modelo = q.PRD_Modelo,
                                                                    Anio = (int)q.PRD_Anio,
                                                                    Tipo = q.PRD_Tipo,
                                                                    Estado = q.PRD_Estado,
                                                                    Existencia = (int)q.PRD_Existencia,
                                                                    Costo = (int)q.PRD_Costo,
                                                                    PrecioVenta = (int)q.PRD_PrecioVenta

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

        #region Consultar uno
        public Interfaces.ProductoInterface getProducto(ProductoInterface producto)
        {
            try
            {
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    Interfaces.ProductoInterface objConsulta = (from q in objEntidad.CXC_PRODUCTO
                                                                where q.PRD_Marca == producto.Marca && 
                                                                 q.PRD_Modelo == producto.Modelo

                                                                select new Interfaces.ProductoInterface
                                                                {
                                                                    Producto = q.PRD_Producto,
                                                                    Marca = q.PRD_Marca,
                                                                    Modelo = q.PRD_Modelo,
                                                                    Anio = (int)q.PRD_Anio,
                                                                    Tipo = q.PRD_Tipo,
                                                                    Estado = q.PRD_Estado,
                                                                    Existencia = (int)q.PRD_Existencia,
                                                                    Costo = (int)q.PRD_Costo,
                                                                    PrecioVenta = (int)q.PRD_PrecioVenta

                                                                }).First();
                    return objConsulta;
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion

    }

}
