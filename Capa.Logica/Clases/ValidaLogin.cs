
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Clases
{
    public class ValidaLogin
    {

        public Boolean spValidaLogin(string user, string pass)
        {
            try
            {
                List<String> respuesta;
                using (Entidades.CxCEntities1 objEntidad = new Entidades.CxCEntities1())
                {
                    //List<Entidades.SP_LOGIN1_Result>
                    respuesta = objEntidad.SP_LOGIN(user,pass).ToList();
                    if (respuesta!=null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        
    }
}
