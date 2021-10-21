using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa.Logica.Clases;
using Capa.Logica.Interfaces;

using System.Data;
using System.Web;

namespace CapasCxC.Interfaces.Factura
{
    public partial class frmCrudFactura : System.Web.UI.Page
    {
        private CrudFactura crudFactura = new CrudFactura();
        private CrudProducto crudProducto = new CrudProducto();
        private CrudClientes crudClientes = new CrudClientes();
        private CrudTipoPago crudTipoPago = new CrudTipoPago();
        private CrudDiasCredito crudDias = new CrudDiasCredito();
        private CrudCredito crudCredito = new CrudCredito();

        private clientesInterface objCliente;
        //private FacturaInterface objFactura;
        private ProductoInterface objProducto;
        //private List<FacturaDetInterface> listFacDetalle;
        private List<ProductoInterface> listProducto
        {
            get
            {
                if(HttpContext.Current.Session["listProducto"] == null)
                {
                    HttpContext.Current.Session["listProducto"] = new List<ProductoInterface>();
                }
                return HttpContext.Current.Session["listProducto"] as List<ProductoInterface>;
            }
            set
            {
                HttpContext.Current.Session["listProducto"] = value;
            }
        }
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
            if (listProducto.Count > 0)
            {
                gvProductos.DataSource = listProducto;
                gvProductos.DataBind();
            }
            else
            {
                this.listProducto = new List<ProductoInterface>();
                listProducto.Add(new ProductoInterface());

                gvProductos.DataSource = listProducto;
                gvProductos.DataBind();

                gvProductos.Rows[0].Cells.Clear();
                gvProductos.Rows[0].Cells.Add(new TableCell());//agregar un prodcutinterface
                gvProductos.Rows[0].Cells[0].ColumnSpan = 7; //cantidad de columnas del grid
                gvProductos.Rows[0].Cells[0].Text = "Ingrese productos";
                gvProductos.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void gvProducto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                objProducto = new ProductoInterface();
                objProducto.Marca = (gvProductos.FooterRow.FindControl("txtMarcaFooter") as TextBox).Text.Trim();
                objProducto.Modelo = (gvProductos.FooterRow.FindControl("txtModeloFooter") as TextBox).Text.Trim();
                objProducto = crudProducto.getProducto(objProducto);
                if (null != objProducto)
                {
                    objProducto.Cantidad = int.Parse((gvProductos.FooterRow.FindControl("txtCantidadFooter") as TextBox).Text.Trim());
                    objProducto.setCantidad();
                    listProducto.Add(objProducto);

                    initProductos();
                }
                else
                {
                    //mensaje 'no se encontro producto''
                }

                decimal subTotal = 0;
                decimal iva = 0;
                decimal total = 0;
                foreach (ProductoInterface producto in listProducto)
                {
                    total += producto.PrecioVenta * producto.Cantidad;
                    iva += total * (decimal) 0.12;
                    subTotal += total - iva;
                }

                txtSubTotal.Text = subTotal.ToString();
                txtIVA.Text = iva.ToString();
                txtTotal.Text = total.ToString();

            }
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

        protected void crearFactura()
        {
            //mejorar objetos
            //Llenar las fac det del grid y sacar totales.
            //objFactura = new FacturaInterface();
            //objFactura.Cliente = objCliente.Persona;
            //objFactura.Cliente = 4;
            //objFactura.Fecha = DateTime.Now;
            //objFactura.TipoPago = int.Parse(dpdMetodoPago.SelectedValue);

            //SP int fac_factura = SP_INS_FACTURA(objCliente.NIT, '98BA98BA', int.Parse(dpdMetodoPago.SelectedValue), int.Parse(dpdDias.SelectedValue));

            //objFactura = crudFactura.getFactura(fac_factura);
            //

            crearDetalle();
        }
        protected void crearDetalle()
        {
            foreach(ProductoInterface producto in listProducto)
            {
                crudFactura.insertarDetalle(263, producto.Cantidad, producto.Producto, producto.PrecioVenta);
            }
            int total = int.Parse(txtTotal.Text);
            crudFactura.actualizarMonto(263, total);
            //crudCredito.actualizarMonto(263, total);
            //crudCredito.actualizarPlazo(263, int.Parse(dpdDias.SelectedValue));
        }
        protected void limpiarFormulario() {
            listProducto = new List<ProductoInterface>();
            Response.Redirect("frmFacturaNueva.aspx", true);
        }
        protected void btnBusqueda_Click(object sender, ImageClickEventArgs e)
        {
                Response.Redirect("frmFacturaBusqueda.aspx", true);
        }
        protected void validarCliente() {
            if (!string.IsNullOrEmpty(txtNit.Text))
            {
                this.objCliente = crudClientes.consultarUnClienteXNit(txtNit.Text);
                txtCliente.Text = this.objCliente.nombreCompleto();
            }
        }
        protected void BtnLimpiar_Click(object sender, ImageClickEventArgs e)
        {
            limpiarFormulario();
        }


        protected void imgBtnCliente_Click(object sender, ImageClickEventArgs e)
        {
            validarCliente();
        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            initProductos();

        }

        protected void ibtNuevaFactura_Click(object sender, ImageClickEventArgs e)
        {
            crearFactura();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            initProductos();
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}