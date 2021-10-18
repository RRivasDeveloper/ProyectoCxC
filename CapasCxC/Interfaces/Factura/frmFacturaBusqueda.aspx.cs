using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa.Logica.Clases;


namespace CapasCxC.Interfaces.Factura
{
    public partial class frmFacturaBusqueda : System.Web.UI.Page
    {
        private CrudFactura crudFactura = new CrudFactura();
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        protected void inicioLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmInicio.aspx", true);
        }

        protected void cambiodDePagina(object sender, GridViewPageEventArgs e)
        {
            gvFacturas.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        private void BindGrid()
        {
            gvFacturas.DataSource = crudFactura.getFactura(txtDato1.Text, txtDato2.Text);
            gvFacturas.DataBind();
        }
        protected void ibtBusqueda_Click(object sender, ImageClickEventArgs e)
        {
            BindGrid();
        }


    }
}