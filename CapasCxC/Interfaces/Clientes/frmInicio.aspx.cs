﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapasCxC.Interfaces.Clientes
{
    public partial class frmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsult_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("fmrClientes.aspx", true);
        }

        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void bntIngresoCliente_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmCrudCliente.aspx", true);
            
        }

        protected void btnIngreso_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnPagos_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("http://www.google.com", true);
        }
    }
}