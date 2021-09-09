using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa.Logica.Clases;
namespace CapasCxC.Interfaces.Clientes
{
    public partial class frmCrudCliente : System.Web.UI.Page
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
        protected void cambiodDePagina(object sender, GridViewPageEventArgs e)
        //con este metodo se controla el cambio de pagina en el gridview
        {
            gvClientes.PageIndex = e.NewPageIndex;
            BindGrid();
            //gvClientes.DataBind();
        } 

        protected void inicioLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmInicio.aspx", true);

        }

        public void btnConsultas_Click(object sender, ImageClickEventArgs e)
        {
            txtBuscarCliente.Attributes.Add("style", "visibility: visible");//muestro la etiqueta oculta
            btnBuscar.Attributes.Add("style", "visibility: visible ");
        }

        protected void btnConsultas2_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Attributes.Add("style", "visibility: visible");//muestro la etiqueta oculta
            btnBuscar.Attributes.Add("style", "visibility: visible ");
        }

        protected void btnAgregar_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btn_Editar_Click(object sender, ImageClickEventArgs e)
        {

        }


        protected void BtnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        protected void BtnBorrarCliente_Click(object sender, EventArgs e)
        {

        }

        protected void BtnConsultarCliente_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            //string buscar = TxtBusqueda.Text;
            if (string.IsNullOrEmpty(txtBuscarCliente.Text))
            {


                /*if (buscar=="" || buscar==null)
                {*/
                BindGrid();
            }
            else
            {
                gvClientes.DataSource = obj.ConsultarUno(txtBuscarCliente.Text);
                gvClientes.DataBind();
                gvClientes.Attributes.Add("style", "visibility: visible");
            }

        }
    }
}