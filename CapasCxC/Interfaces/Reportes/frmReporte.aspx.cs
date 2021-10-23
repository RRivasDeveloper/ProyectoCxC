using Capa.Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapasCxC.Interfaces.Reportes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static int opcion = 0;
        private static int menu = 0;
        private static int bind = 0;
        private static DateTime FechaInicial = DateTime.Today;
        private static DateTime FechaFinal = DateTime.Today;


        CrudClientes obj = new CrudClientes();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                limpiarGv();
                BindGrid();
                ocultarParabuscar();
            }

        }

        private void BindGrid()
        {
            switch (bind)
            {
                case 11:
                    gvClientes.DataSource = obj.Consultar_spClientesRegionFecha(FechaInicial, FechaFinal);
                    break;
                case 12:
                    gvClientes.DataSource = obj.Consultar_spRptCreditosXpagar(FechaInicial, FechaFinal);
                    break;
                case 21:
                    gvClientes.DataSource = obj.Consultar_SpRptClientesPorRegion("co");
                    break;
                default:
                    gvClientes.DataSource = null;
                    break;
            }
            // gvClientes.DataSource = obj.Consultar_spDatosPrincipales();//por sp
            //gvClientes.DataSource = obj.consultarClientes();//por clase
            //gvClientes.DataSource = obj.ConsultarUno("44050879");//por unico
            // gvClientes.DataSource = obj.Consultar_spClientesRegionFecha();
            gvClientes.DataBind();
        }

        public void mostrarParabuscar()
        {
            BtnFechaInicial.Visible = true;
            BtnFechaFinal.Visible = true;
            btnBuscar.Visible = true;
            TxtFechaFinal.Visible = true;
            TxtFechaFinal.Text = FechaFinal.ToShortDateString();
            TxtFechaInicial.Text = FechaInicial.ToShortDateString();
            TxtFechaInicial.Visible = true;
            TxtFechaInicial.ReadOnly = true;
            TxtFechaFinal.ReadOnly = true;
        }
        public void ocultarParabuscar()
        {
            BtnFechaInicial.Visible = false;
            BtnFechaFinal.Visible = false;
            btnBuscar.Visible = false;
            TxtFechaFinal.Visible = false;
            TxtFechaInicial.Visible = false;
            TxtFechaInicial.ReadOnly = false;
            TxtFechaFinal.ReadOnly = false;
        }

        //        protected void SubmitAppraisalGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        protected void cambiodDePagina(object sender, GridViewPageEventArgs e)
        //con este metodo se controla el cambio de pagina en el gridview
        {
            gvClientes.PageIndex = e.NewPageIndex;

            BindGrid();
            //gvClientes.DataBind();
        }

        protected void OrdenarPagina(object sender, GridViewSortEventArgs e)
        {

        }
        //-----------------------------------------------------



        protected void btnFactura_Click(object sender, ImageClickEventArgs e)
        {
            menu = 2;
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/factura.png";
            cambiarLateral(menu);
        }

        protected void btnCreditos_Click(object sender, ImageClickEventArgs e)
        {
            menu = 1;
            cambiarLateral(menu);
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/credit.png";

        }

        protected void btnClientes_Click(object sender, ImageClickEventArgs e)
        {
            menu = 3;
            cambiarLateral(menu);
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/clients.jpg";
        }
        private void cambiarLateral(int a)
        {
            switch (a)//cambia el diseño lateral segun opcion de menu
            {
                case 1://creditos;
                    sideBar1.Text = "Consulta Por Region Geografica";
                    btnSidebar1.ImageUrl = "~/img/gt.png";
                    sideBar1.Text = "Consulta Por Region Geografica";
                    btnSidebar2.ImageUrl = "~/img/pendientePago.png";
                    sideBar1.Text = "Consulta Por Region Geografica";
                    btnSidebar3.ImageUrl = "~/img/credit.png";
                    break;
                case 2://factura
                    ;
                    break;
                case 3://clientes
                    sideBar1.Text = "Clientes por Region Contado";
                    btnSidebar1.ImageUrl = "~/img/clientesContado2.png";
                    sideBar1.Text = "Clientes por Region Credito";
                    btnSidebar2.ImageUrl = "~/img/gt.png";
                    sideBar1.Text = "Clientes por Region Contado y Credito ";
                    btnSidebar3.ImageUrl = "~/img/gt.png";
                    ;
                    break;
                default:
                    ;
                    break;
            }
        }
        protected void btnReporte3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnReporte4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void inicioLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("../Clientes/frmInicio.aspx", true);
            limpiarGv();
        }
        private void limpiarGv()
        {
            opcion = 0;
            BindGrid();
        }
        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btn_Imprimir_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            FechaInicial = Calendar1.SelectedDate;

            Calendar1.Visible = false;
            TxtFechaInicial.Text = FechaInicial.ToShortDateString();


        }
        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            FechaFinal = Calendar2.SelectedDate;

            Calendar2.Visible = false;
            TxtFechaFinal.Text = FechaFinal.ToShortDateString();
        }
        protected void BtnFechaInicial_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;

        }

        protected void BtnFechaFinal_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = true;

        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)//binoculares
        {
            gvClientes.DataSource = null;
            switch (menu)//por 1credito 2 factura 3 cliente
            {
                case 1:
                    switch (opcion)//Menu credito segun sidebar
                    {
                        case 1:
                            gvClientes.DataSource = obj.Consultar_spClientesRegionFecha(FechaInicial, FechaFinal);
                            break;
                        case 2:
                            gvClientes.DataSource = obj.Consultar_spRptCreditosXpagar(FechaInicial, FechaFinal);
                            break;
                        case 3://falta esta opción;
                            break;
                        default:
                            break;
                    }

                    break;
                case 2:
                    break;
               /* case 3:
                    switch (opcion)//Menu Clientes segun sideBar
                    {
                        case 1:
                            gvClientes.DataSource = obj.Consultar_SpRptClientesPorRegion("CO");
                            break;
                        case 2:
                            gvClientes.DataSource = obj.Consultar_spRptCreditosXpagar(FechaInicial, FechaFinal);
                            break;
                        case 3://falta esta opción;
                            break;
                        default:
                            break;
                    }
                    break;*/

                default:
                    break;
            }


            gvClientes.DataBind();
        }
        /*public void btnConsultaRegionG_Click(object sender, ImageClickEventArgs e)
        {

            limpiarGv();
            opcion = 1;
            mostrarParabuscar();
        }*/
        protected void btnCreditoPenPago_Click(object sender, ImageClickEventArgs e)
        {
            limpiarGv();
            opcion = 2;
            mostrarParabuscar();

        }
        #region SideBar
        ///----------------------------------------------------------------------------///
        protected void btnSidebar1_Click(object sender, ImageClickEventArgs e)//
        {
            limpiarGv();
            opcion = 1;
            switch (menu)
            {
                case 1:
                    bind = 11;//Creditos sp1
                    mostrarParabuscar();
                    break;
                case 2 :;
                    break;
                case 3:
                    bind = 21;
                    // ocultarParabuscar();
                    gvClientes.DataSource = obj.Consultar_SpRptClientesPorRegion("co");
                    gvClientes.DataBind();
                    //gvClientes.Visible = true;
                    //BindGrid();
                    
                    break;
                default:
                    break;
            }

        }

        protected void btnSidebar2_Click(object sender, ImageClickEventArgs e)
        {
            limpiarGv();
            opcion = 2;
            switch (menu)
            {
                case 1:
                    bind = 12;//Creditos sp2
                    mostrarParabuscar();
                    break;
                default:
                    break;
            }

        }

        protected void btnSidebar3_Click(object sender, ImageClickEventArgs e)
        {
            limpiarGv();
            opcion = 3;
            switch (menu)
            {
                case 1:
                    bind = 13;//creditos sp3
                    mostrarParabuscar();
                    break;
                default:
                    break;
            }
        }

        protected void btnSidebar4_Click(object sender, ImageClickEventArgs e)
        {
            limpiarGv();
            opcion = 4;
        }
        #endregion
    }
}