using Capa.Logica.Clases;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapasCxC.Interfaces.Inicio
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) 
            {
                Mensaje.Visible = false;
            }
        }



        protected void BtnIngreso_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.ToString();
            string contrasena = txtPassword.Value.ToString();
            ValidaLogin usurio = new ValidaLogin();
            Boolean acceso = usurio.spValidaLogin(user, contrasena);
            if (acceso)
            {
                Response.Redirect("../Clientes/frmInicio.aspx", true);
                Mensaje.Visible = false;
            }
            else
            {

               // Response.Redirect("../Inicio/Login.aspx", true);
                Mensaje.Visible = true;
            }
        }
    }
}