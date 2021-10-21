using System;
using Capa.Logica.Interfaces;
using Capa.Logica.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapasCxC.Interfaces.Factura
{
    public partial class frmFacturaResultado : System.Web.UI.Page
    {
        private CrudFactura crudFactura = new CrudFactura();
        private CrudFacturaDet crudFacturaDet = new CrudFacturaDet();

        private FacturaInterface factura;
        private List<FacturaDetInterface> listDet;

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
            initForm();
        }

        //public frmFacturaResultado(FacturaInterface factura)
        //{

        //}

        public void initForm()
        {
            factura = crudFactura.getFactura(2);

            txtFactura.Text = factura.Serie + '-' + factura.Numero;
            txtAutorizacion.Text = factura.FirmaElectronica;
            txtEmision.Text = factura.Fecha.ToString();
            //txtNit.Text = factura.Cliente
            txtCliente.Text = factura.Cliente.ToString();
            BindGrid();
        }

        private void BindGrid()
        {
            listDet = crudFacturaDet.getFacturaDetByFac(263);
            gvDetalle.DataSource = listDet;
            gvDetalle.DataBind();

            decimal subTotal = 0;
            decimal iva = 0;
            decimal total = 0;
            foreach (FacturaDetInterface detalle in listDet)
            {
                total += detalle.PrecioVenta * detalle.Cantidad;
                iva += total * (decimal)0.12;
                subTotal += total - iva;
            }
            txtSubTotal.Text = subTotal.ToString();
            txtIVA.Text = iva.ToString();
            txtTotal.Text = total.ToString();
        }

    }
}