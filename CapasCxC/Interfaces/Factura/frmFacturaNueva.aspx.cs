using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa.Logica.Clases;
using Capa.Logica.Interfaces;

namespace CapasCxC.Interfaces.Factura
{
    public partial class frmCrudFactura : System.Web.UI.Page
    {
        private CrudFactura crudFactura = new CrudFactura();
        private CrudProducto crudProducto = new CrudProducto();
        private CrudClientes crudClientes = new CrudClientes();
        private CrudTipoPago crudTipoPago = new CrudTipoPago();
        private CrudDiasCredito crudDias = new CrudDiasCredito();

        private clientesInterface objCliente;
        private FacturaInterface objFactura;
        private List<FacturaDetInterface> listFacDetalle;
        private List<ProductoInterface> listProducto;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                initProductos();
                initMetodoPago();
                initDiasPlazo();
            }
        }

        protected void inicioLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmInicio.aspx", true);
        }

        protected void initProductos()
        {
            listProducto = new List<ProductoInterface>();
            listProducto.Add(new ProductoInterface());

            gvProductos.DataSource = listProducto;
            gvProductos.DataBind();
        }

        protected void getCliente(String nit)
        {
            this.objCliente = crudClientes.consultarUnClienteXNit(txtNit.Text);
            txtCliente.Text = this.objCliente.nombreCompleto();
        }

        protected decimal totalFactura()
        {
            decimal total = 0;
            foreach(FacturaDetInterface detalle in this.listFacDetalle)
            {
                total =+ detalle.PrecioVenta * detalle.Cantidad;
            }

            return total;
        }
        protected decimal totalFacturaNeto()
        {
            decimal total = 0;
            foreach (FacturaDetInterface detalle in this.listFacDetalle)
            {
                decimal sinIva = detalle.PrecioVenta - (detalle.PrecioVenta * (decimal) 0.12) ;
                total =+ sinIva * detalle.Cantidad;
            }

            return total;
        }

        protected void initMetodoPago()
        {

            dpdMetodoPago.DataSource = crudTipoPago.getTipoPago();
            dpdMetodoPago.DataTextField = "Descripcion";
            dpdMetodoPago.DataValueField = "TipoPago";
            dpdMetodoPago.DataBind();

        }
        
        protected void initDiasPlazo()
        {

            dpdDias.DataSource = crudDias.getDiasCredito();
            dpdDias.DataTextField = "CantidadDias";
            dpdDias.DataValueField = "DiasCredito";
            dpdDias.DataBind();

        }

        protected void buildFactura()
        {
            //Llenar las fac det del grid y sacar totales.
            objFactura = new FacturaInterface();



        }
        protected void limpiarFormulario() {
            Response.Redirect("frmFacturaNueva.aspx", true);
        }
        protected void btnBusqueda_Click(object sender, ImageClickEventArgs e)
        {
                Response.Redirect("frmFacturaBusqueda.aspx", true);
        }
        protected void crearCliente() { }
        protected void buscarCliente() {
            if (!string.IsNullOrEmpty(txtNit.Text))
            {
                this.objFactura = crudFactura.getFactura(int.Parse(txtNit.Text));
                txtCliente.Text = this.objFactura.Certificado;
            }
        }

        /**
         * 
         */
        protected void BtnLimpiar_Click(object sender, ImageClickEventArgs e)
        {
            limpiarFormulario();
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            buscarCliente();
        }


        protected void imgBtnCliente_Click(object sender, ImageClickEventArgs e)
        {
            crearCliente();
        }


        public static void getAfiliados(int http){
            
        }

    }
}