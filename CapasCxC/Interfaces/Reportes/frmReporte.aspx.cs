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
        private static bool lleno, lleno2 = false;
        private static string ddcliente, ddTipoTransac, crcotd = "";
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

        private void BindGrid()//Esta funcion es necesaria para que funcione el indexado de pagina
        {
            switch (bind)
            {
                case 11:
                    gvClientes.DataSource = obj.Consultar_spClientesRegionFecha(FechaInicial, FechaFinal);
                    break;
                case 12:
                    gvClientes.DataSource = obj.Consultar_spRptCreditosXpagar(FechaInicial, FechaFinal);
                    break;
                case 13:
                    gvClientes.DataSource = obj.spConsultaCreditosCancelados(FechaInicial, FechaFinal);
                    break;
                case 21:
                    gvClientes.DataSource = obj.Consulta_spFactura_CR_CO(FechaInicial, FechaFinal, "");
                    break;
                case 22:
                    gvClientes.DataSource = obj.Consulta_spFactura_CR_CO(FechaInicial, FechaFinal, "CR");
                    break;
                case 23:
                    gvClientes.DataSource = obj.Consulta_spFactura_CR_CO(FechaInicial, FechaFinal, "CO");
                    break;
                case 31:
                    gvClientes.DataSource = obj.Consultar_SpRptClientesPorRegion(ddcliente);
                    break;
                case 32:
                    gvClientes.DataSource = obj.Consulta_spClientesEstadoCredito(FechaInicial, FechaFinal, 1);
                    break;
                case 33:
                    gvClientes.DataSource = obj.Consulta_spClientesEstadoCredito(FechaInicial, FechaFinal, 3);
                    break;
                case 34:
                    gvClientes.DataSource = obj.Consulta_spClientesEstadoCredito(FechaInicial, FechaFinal, 2);
                    break;
                case 35:
                    gvClientes.DataSource = obj.Consultar_spHistoricodePagos(FechaInicial, FechaFinal);
                    break;
                case 41:
                    gvClientes.DataSource = obj.spConsultaRangoFecha(FechaInicial, FechaFinal, "CO");
                    break;
                case 42:
                    gvClientes.DataSource = obj.spConsultaRangoFecha(FechaInicial, FechaFinal, "CR");
                    break;
                case 43:
                    gvClientes.DataSource = obj.spConsultaRangoFecha(FechaInicial, FechaFinal, "TO");
                    break;
                case 51:
                    gvClientes.DataSource = obj.Consulta_spOtrosTransac(FechaInicial, FechaFinal, ddTipoTransac);
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
            LblBuscar.Visible = true;
            TxtFechaFinal.Visible = true;
            TxtFechaFinal.Text = FechaFinal.ToShortDateString();
            TxtFechaInicial.Text = FechaInicial.ToShortDateString();
            TxtFechaInicial.Visible = true;
            TxtFechaInicial.ReadOnly = true;
            TxtFechaFinal.ReadOnly = true;
            ddOpciones.Visible = false;
        }
        public void ocultarParabuscar()
        {
            BtnFechaInicial.Visible = false;
            BtnFechaFinal.Visible = false;
            btnBuscar.Visible = false;
            LblBuscar.Visible = false;
            TxtFechaFinal.Visible = false;
            TxtFechaInicial.Visible = false;
            TxtFechaInicial.ReadOnly = false;
            TxtFechaFinal.ReadOnly = false;
            ddOpciones.Visible = false;
            gvClientes.Visible = false;
            gvTitulo.Visible = false;
        }
        public void ocultarBtnSidebar()
        {
            sideBar1.Visible = false;
            btnSidebar1.Visible = false;
            sideBar2.Visible = false;
            btnSidebar2.Visible = false;
            sideBar3.Visible = false;
            btnSidebar3.Visible = false;
            sideBar4.Visible = false;
            btnSidebar4.Visible = false;
            sideBar5.Visible = false;
            btnSidebar5.Visible = false;
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

        protected void btnCreditos_Click(object sender, ImageClickEventArgs e)
        {
            ocultarParabuscar();
            menu = 1;
            cambiarLateral(menu);
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/credit.png";

        }

        protected void btnFactura_Click(object sender, ImageClickEventArgs e)
        {
            ocultarParabuscar();
            menu = 2;
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/factura.png";
            cambiarLateral(menu);
        }



        protected void btnClientes_Click(object sender, ImageClickEventArgs e)
        {
            ocultarParabuscar();
            menu = 3;
            cambiarLateral(menu);
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/clients.jpg";
        }
        protected void btnPagos_Click(object sender, ImageClickEventArgs e)
        {

            ocultarParabuscar();
            menu = 4;
            cambiarLateral(menu);
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/pagos.png";
        }

        protected void btnOtrasTransacciones_Click(object sender, ImageClickEventArgs e)
        {

            ocultarParabuscar();
            menu = 5;
            cambiarLateral(menu);
            Lateral.Visible = true;
            btnSidebar.ImageUrl = "~/img/OtrasTransacciones.png";
        }
        private void cambiarLateral(int a)
        {
            switch (a)//cambia el diseño lateral segun opcion de menu
            {
                case 1://creditos;
                    ocultarBtnSidebar();
                    sideBar1.Text = "Consulta Por Region Geografica";
                    sideBar1.Visible = true;
                    btnSidebar1.ImageUrl = "~/img/gt.png";
                    btnSidebar1.Visible = true;
                    
                    sideBar2.Text = "Creditos Pendientes de Pago";
                    btnSidebar2.Visible = true;
                    btnSidebar2.ImageUrl = "~/img/pendientePago.png";
                    sideBar2.Visible = true;

                    sideBar3.Text = "Creditos Cancelados ";
                    btnSidebar3.ImageUrl = "~/img/cancelados.png";
                    btnSidebar3.Visible = true;
                    sideBar3.Visible = true;
                    break;
                case 2://factura
                    ocultarBtnSidebar();
                    sideBar1.Text = "Facturas por Rango de Fecha";
                    btnSidebar1.ImageUrl = "~/img/rangoFecha.png";
                    sideBar2.Text = "Facturas Credito";
                    btnSidebar2.ImageUrl = "~/img/moroso.png";
                    sideBar3.Text = "Facturas Contado ";
                    btnSidebar3.ImageUrl = "~/img/pagos.png";
                    sideBar1.Visible = true;
                    btnSidebar1.Visible = true;
                    sideBar2.Visible = true;
                    btnSidebar2.Visible = true;
                    sideBar3.Visible = true;
                    btnSidebar3.Visible = true;
                    break;
                case 3://clientes
                    ocultarBtnSidebar();
                    sideBar1.Text = "Listado de Clientes por Region";
                    btnSidebar1.ImageUrl = "~/img/clientesporregion.png";
                    sideBar2.Text = "Clientes Vigentes al Día";
                    btnSidebar2.ImageUrl = "~/img/Vigente.png";
                    sideBar3.Text = "Clientes en Mora ";
                    btnSidebar3.ImageUrl = "~/img/enmora2.png";
                    sideBar4.Text = "Clientes al Día";
                    btnSidebar4.ImageUrl = "~/img/cancelados.png";
                    sideBar5.Text = "Historial Pagos Fuera de Tiempo ";
                    btnSidebar5.ImageUrl = "~/img/fueradeTiempo.png";
                    sideBar1.Visible = true;
                    btnSidebar1.Visible = true;
                    sideBar2.Visible = true;
                    btnSidebar2.Visible = true;
                    sideBar3.Visible = true;
                    btnSidebar3.Visible = true;
                    sideBar4.Visible = true;
                    btnSidebar4.Visible = true;
                    sideBar5.Visible = true;
                    btnSidebar5.Visible = true;
                    break;
                case 4://Reporte de pagos
                    ocultarBtnSidebar();
                    sideBar1.Text = "Pagos al Contado";
                    btnSidebar1.ImageUrl = "~/img/pagos.png";
                    sideBar2.Text = "Pagos al Credito";
                    btnSidebar2.ImageUrl = "~/img/moroso.png";
                    sideBar3.Text = "Listado de pagos ";
                    btnSidebar3.ImageUrl = "~/img/sindeuda.png";

                    sideBar1.Visible = true;
                    btnSidebar1.Visible = true;
                    sideBar2.Visible = true;
                    btnSidebar2.Visible = true;
                    sideBar3.Visible = true;
                    btnSidebar3.Visible = true;

                    ;
                    break;
                case 5:
                    ocultarBtnSidebar();
                    sideBar1.Text = "Reporte Por Transacción";
                    sideBar1.Visible = true;
                    btnSidebar1.ImageUrl = "~/img/creditcontado.png";
                    btnSidebar1.Visible = true;

                    ;
                    break;
                default:
                    ;
                    break;
            }
        }

        protected void inicioLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("../Clientes/frmInicio.aspx", true);
            limpiarGv();
        }
        private void limpiarGv()
        {
            gvTitulo.Text = "";
            opcion = 0;
            //BindGrid();
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

            // gvClientes.DataSource = null;
            switch (menu)//por 1credito 2 factura 3 cliente
            {
                case 1://Menu credito segun sidebar
                    switch (opcion)//posicion dentr del sidebar
                    {
                        case 1:
                            gvTitulo.Text = "Consulta de Creditos-Clientes por Region Geografica";
                            gvClientes.DataSource = obj.Consultar_spClientesRegionFecha(FechaInicial, FechaFinal);
                            // gvTitulo.Visible = true;
                            //gvClientes.Visible = true;
                            break;
                        case 2:
                            gvTitulo.Text = "Consulta de Creditos por Pagar";
                            gvClientes.DataSource = obj.Consultar_spRptCreditosXpagar(FechaInicial, FechaFinal);
                            //gvTitulo.Visible = true;
                            //gvClientes.Visible = true;
                            break;
                        case 3://falta esta opción;
                            gvTitulo.Text = "Consulta de Creditos Cancelados";
                            gvClientes.DataSource = obj.spConsultaCreditosCancelados(FechaInicial, FechaFinal);

                            break;
                        default:

                            break;
                    }
                    gvTitulo.Visible = true;
                    break;
                case 2://Menu Facturas segun sidebar Consulta_spFactura_CR_CO
                    switch (opcion)
                    {
                        case 1:
                            gvTitulo.Text = "Consulta de Facturas por fecha";
                            gvClientes.DataSource = obj.Consulta_spFactura_CR_CO(FechaInicial, FechaFinal, "");
                            //gvClientes.DataBind();
                            //gvClientes.Visible = true;
                            break;
                        case 2://///////////////////////////////////////////////////////////////////////////////////////////////77
                            gvTitulo.Text = "Consulta de Facturas por fecha Credito";
                            gvClientes.DataSource = obj.Consulta_spFactura_CR_CO(FechaInicial, FechaFinal, "CR");
                            //gvClientes.Visible = true;
                            break;
                        case 3:
                            gvTitulo.Text = "Consulta de Facturas por fecha Contado";
                            gvClientes.DataSource = obj.Consulta_spFactura_CR_CO(FechaInicial, FechaFinal, "CO");
                            break;

                        default:
                            break;
                    }
                    gvTitulo.Visible = true;
                    break;
                case 3://Menu Clientes segun sideBar
                    switch (opcion)
                    {
                        case 1:
                            gvTitulo.Text = "Consulta de Clientes por Región";
                            gvClientes.DataSource = obj.Consultar_SpRptClientesPorRegion(ddcliente);
                            //gvClientes.DataBind();
                            //gvClientes.Visible = true;
                            break;
                        case 2://///////////////////////////////////////////////////////////////////////////////////////////////77
                            gvTitulo.Text = "Consulta de Creditos-Clientes según estado Vigente ";
                            gvClientes.DataSource = obj.Consulta_spClientesEstadoCredito(FechaInicial, FechaFinal, 1);
                            //gvClientes.Visible = true;
                            break;
                        case 3:
                            gvTitulo.Text = "Consulta de Creditos-Clientes según estdo en Mora";
                            gvClientes.DataSource = obj.Consulta_spClientesEstadoCredito(FechaInicial, FechaFinal, 3);
                            break;
                        case 4:
                            gvTitulo.Text = "Consulta de Creditos-Clientes según Clientes Cancelados";
                            gvClientes.DataSource = obj.Consulta_spClientesEstadoCredito(FechaInicial, FechaFinal, 2);
                            break;
                        case 5:
                            gvTitulo.Text = "Consulta de Creditos-Clientes Historico";
                            gvClientes.DataSource = obj.Consultar_spHistoricodePagos(FechaInicial, FechaFinal);

                            break;
                        default:
                            break;
                    }

                    gvTitulo.Visible = true;
                    break;
                case 4://menu de Pagos por rango de fecha
                    switch (crcotd)
                    {
                        case "CO":
                            gvTitulo.Text = "Consulta de Pagos Contado";
                            gvClientes.DataSource = obj.spConsultaRangoFecha (FechaInicial, FechaFinal, crcotd);
                            break;
                        case "CR":
                            
                            gvTitulo.Text = "Consulta de Pagos Credito";
                            gvClientes.DataSource = obj.spConsultaRangoFecha(FechaInicial, FechaFinal, crcotd);
                            break;
                            
                        case "TD":;
                            gvTitulo.Text = "Consulta de Todos los Pagos";
                            gvClientes.DataSource = obj.spConsultaRangoFecha(FechaInicial, FechaFinal, crcotd);

                            break;
                        default:
                            break;
                    }
                    gvTitulo.Visible = true;
                    break;
                case 5:
                    switch (opcion)
                    {
                        case 1:
                            gvTitulo.Text = "Consulta Por Diferentes Tipos de Transacciones";
                            gvClientes.DataSource = obj.Consulta_spOtrosTransac(FechaInicial, FechaFinal, ddTipoTransac);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


            gvClientes.DataBind();
            gvClientes.Visible = true;
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
        public void llenarDDclientes()
        {
            ddTipoTransact.Visible = false;
            btnBuscar.Visible = true;
            LblBuscar.Visible = true;
            ddOpciones.Visible = true;
            if (lleno == false)
            {

                ddOpciones.AppendDataBoundItems = true;
                //clientes por region geografica COntado CRedito TD
                ddOpciones.Items.Add("Seleccione estado de Credito");
                ddOpciones.Items.Add("Contado");
                ddOpciones.Items.Add("Credito");
                ddOpciones.Items.Add("TD");
                lleno = true;
               
            }



        }

        public void llenarddTipoTransact()
        {
            mostrarParabuscar();
            //btnBuscar.Visible = true;
            ddOpciones.Visible = false;
            ddTipoTransact.Visible = true;
            if (lleno2 == false)
            {

                ddTipoTransact.AppendDataBoundItems = true;
                //clientes por region geografica COntado CRedito TD
                ddTipoTransact.Items.Add("Seleccione tipo de Transacción");
                ddTipoTransact.Items.Add("Pago de Credito");
                ddTipoTransact.Items.Add("Nota de Debito");
                ddTipoTransact.Items.Add("Nota de Credito");
                ddTipoTransact.Items.Add("Cargos por Mora");
                ddTipoTransact.Items.Add("Cargos por Cheque Rechazado");
                lleno2 = true;
            }



        }

        protected void ddOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // limpiarGv();
            gvClientes.Visible = false;
            ddcliente = ddOpciones.SelectedItem.ToString();
            switch (ddcliente)
            {
                case "Contado":
                    gvTitulo.Text = "Clientes con estado Contado";
                    ddcliente = "CO";
                    //gvClientes.Visible = false;
                    break;
                case "Credito":
                    gvTitulo.Text = "Clientes con estado Credito";
                    ddcliente = "CR";
                    //gvClientes.Visible = false;
                    break;
                case "TD":
                    gvTitulo.Text = "Clientes con Credito TD";
                    ddcliente = "TD";
                    //gvClientes.Visible = false;
                    break;

                default:
                    gvTitulo.Text = "Necesita seleccionar una Opcion";
                    ddcliente = "";
                    //gvClientes.Visible = false;
                    break;
            }
            gvTitulo.Visible = true;
        }
        protected void ddTipoTransact_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvClientes.Visible = false;
            ddTipoTransac = ddTipoTransact.SelectedItem.ToString();
            switch (ddTipoTransac)
            {
                case "Pago de Credito":
                    gvTitulo.Text = "1-Pago de Credito";
                    ddTipoTransac = "1";
                    //gvClientes.Visible = false;
                    break;
                case "Nota de Debito":
                    gvTitulo.Text = "2-Nota de Debito";
                    ddTipoTransac = "2";
                    //gvClientes.Visible = false;
                    break;
                case "Nota de Credito":
                    gvTitulo.Text = "3-Nota de Credito";
                    ddTipoTransac = "3";
                    //gvClientes.Visible = false;
                    break;
                case "Cargos por Mora":
                    gvTitulo.Text = "4-Cargos por Mora";
                    ddTipoTransac = "4";
                    //gvClientes.Visible = false;
                    break;
                case "Cargos por Cheque Rechazado":
                    gvTitulo.Text = "5-Cargos por Cheque Rechazado";
                    ddTipoTransac = "5";
                    //gvClientes.Visible = false;
                    break;
                default:
                    gvTitulo.Text = "Necesita seleccionar una Opcion";
                    ddTipoTransac = "";
                    //gvClientes.Visible = false;
                    break;
            }
            gvTitulo.Visible = true;
        }

        #region SideBar
        ///----------------------------------------------------------------------------///
        protected void btnSidebar1_Click(object sender, ImageClickEventArgs e)//
        {
            gvClientes.Visible = false;
            limpiarGv();
            opcion = 1;
            switch (menu)
            {
                case 1:
                    bind = 11;//Creditos sp1
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    mostrarParabuscar();
                    break;
                case 2:
                    bind = 21;
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    mostrarParabuscar();
                    break;
                case 3:
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    ocultarParabuscar();
                    bind = 31;
                    llenarDDclientes();

                    // ocultarParabuscar();
                    //--gvClientes.DataSource = obj.Consultar_SpRptClientesPorRegion("co");
                    //gvClientes.DataBind();
                    //gvClientes.Visible = true;
                    //BindGrid();
                    break;
                case 4:
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    mostrarParabuscar();
                    bind = 41;//Reporte de pagos Contado
                    crcotd = "CO";
                    break;
                case 5:
                    bind = 51;
                    gvClientes.Visible = false;
                    llenarddTipoTransact();
                    break;



                default:
                    break;
            }

        }

        protected void btnSidebar2_Click(object sender, ImageClickEventArgs e)
        {
            gvClientes.Visible = false;
            limpiarGv();
            opcion = 2;
            switch (menu)//segun menu 
            {
                case 1:
                    bind = 12;//Creditos sp2
                    gvClientes.Visible = false;
                    mostrarParabuscar();
                    break;
                case 2:
                    bind = 22;
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    mostrarParabuscar();
                    break;
                case 3:
                    bind = 32;//viene de Clienters - Clientes vigentes al dia
                    gvClientes.Visible = false;
                    mostrarParabuscar();
                    break;
                case 4:
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    mostrarParabuscar();
                    bind = 42;//Reporte de pagos CREDITO
                    crcotd = "CR";
                    break;
                default:
                    break;
            }

        }

        protected void btnSidebar3_Click(object sender, ImageClickEventArgs e)
        {
            gvClientes.Visible = false;
            limpiarGv();
            opcion = 3;
            switch (menu)
            {
                case 1:
                    bind = 13;//creditos sp3
                    gvClientes.Visible = false;
                    mostrarParabuscar();
                    break;
                case 2:
                    bind = 23;//esto siginifica menu 2 sidebar boton 3
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    mostrarParabuscar();
                    break;
                case 3:
                    bind = 33;//viene de Clienters - Clientes en mora
                    gvClientes.Visible = false;
                    mostrarParabuscar();
                    break;
                case 4:
                    gvClientes.Visible = false;//AGREGUE ESTO CUANDO YA FUNCIONABA BIEN
                    mostrarParabuscar();
                    bind = 43;//Reporte de pagos TD
                    crcotd= "TD"; 
                    break;
                default:
                    break;
            }
        }

        protected void btnSidebar4_Click(object sender, ImageClickEventArgs e)
        {
            gvClientes.Visible = false;
            limpiarGv();
            opcion = 4;
            switch (menu)
            {
                case 3://Clientes Cancelados
                    bind = 34;//viene de Clienters - Clientes en mora
                    gvClientes.Visible = false;
                    mostrarParabuscar();
                    break;
                default:
                    break;
            }
        }
      


        protected void btnSidebar5_Click(object sender, ImageClickEventArgs e)
        {
            gvClientes.Visible = false;
            limpiarGv();
            opcion = 5;
            switch (menu)
            {
                case 3://Clientes Cancelados
                    bind = 35;//viene de Clienters - Clientes historico
                    gvClientes.Visible = false;
                    mostrarParabuscar();
                    break;
                default:
                    break;
            }
        }
        #endregion
         }
}