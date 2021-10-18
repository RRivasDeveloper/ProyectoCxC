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

        private FacturaInterface factura;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            initForm();
        }

        //public frmFacturaResultado(FacturaInterface factura)
        //{

        //}

        public void initForm()
        {
            factura = crudFactura.getFacturaXCliente(2);

            txtFactura.Text = factura.Serie + '-' + factura.Numero;
            txtAutorizacion.Text = factura.FirmaElectronica;
            txtEmision.Text = factura.Fecha.ToString();
            //txtNit.Text = factura.Cliente
            txtCliente.Text = factura.Cliente.ToString();
        }
    }
}