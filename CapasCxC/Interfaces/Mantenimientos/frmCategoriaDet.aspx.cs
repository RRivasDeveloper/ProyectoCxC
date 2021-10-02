using Capa.Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapasCxC.Interfaces.Mantenimientos
{
    public partial class frmCategoriaDet : System.Web.UI.Page
    {
        CrudClientes obj = new CrudClientes();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                BindGrid();
            }
        }

        private void BindGrid()
        {

            gvClientes.DataSource = obj.Consultar_spDatosPrincipales();//por sp
            //gvClientes.DataSource = obj.consultarClientes();//por clase
            //gvClientes.DataSource = obj.ConsultarUno("44050879");//por unico
            gvClientes.DataBind();
        }


        //        protected void SubmitAppraisalGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        protected void cambiodDePagina(object sender, GridViewPageEventArgs e)
        //con este metodo se controla el cambio de pagina en el gridview
        {
            gvClientes.PageIndex = e.NewPageIndex;
            BindGrid();
            //gvClientes.DataBind();
        }
        //-----------------------------------------------------
        protected void OrdenarPagina(object sender, GridViewSortEventArgs e)
        {






        }
        protected void btnActualizar_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void inicioLogo_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}