using System;
using System.Collections.Generic;
using System.Drawing;
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
        public String fac_factura
        {
            get
            {
                if (HttpContext.Current.Session["fac_factura"] == null)
                {
                    HttpContext.Current.Session["fac_factura"] = '0';
                }
                return HttpContext.Current.Session["fac_factura"] as String;
            }
            set
            {
                HttpContext.Current.Session["fac_factura"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.EnableEventValidation = false;


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

        protected void imbRegresar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmFacturaNueva.aspx", true);
        }

        protected void gvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (GridViewRow row in gvFacturas.Rows)
            {
                if (row.RowIndex == gvFacturas.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }

        }

        protected void gvFacturas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gvFacturas, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click para abrir.";
            }
        }
    }
}