using Capa.Logica.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CapasCxC.Interfaces.Clientes
{
    public partial class fmrClientes : System.Web.UI.Page
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



        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //string buscar = TxtBusqueda.Text;
            if (string.IsNullOrEmpty(TxtBusqueda.Text))
            {

            
            /*if (buscar=="" || buscar==null)
            {*/
                BindGrid();
            }
            else
            {
                gvClientes.DataSource = obj.ConsultarUno(TxtBusqueda.Text);
                gvClientes.DataBind();
            }
           
        }

        protected void Consultas_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("http://www.google.com", true);
        }

        protected void inicioLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmInicio.aspx", true);
        }

        protected void btn_CrudClientes_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmCrudCliente.aspx", true); 
        }


        //-----------------------------------------------------------
        //protected void OnPaging(object sender, GridViewPageEventArgs e)
        //{
        //  gvClientes.PageIndex = e.NewPageIndex;
        // gvClientes.DataBind();
        //BindGrid(); // Bind the grid again
        //}

    }
}