<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFacturaResultado.aspx.cs" Inherits="CapasCxC.Interfaces.Factura.frmFacturaResultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frmFacturaRestultado" runat="server">
        <header class="p-3 bg-dark text-white">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <a href="/" class="d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none"></a>
                <asp:ImageButton runat="server" ID="inicioLogo" ImageUrl="~/img/Logo.jpeg" AlternateText="Inicio" class="iconos" />
                <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <li><a href="frmInicio.aspx" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a></li>
                    
                    <li>

                        <asp:ImageButton runat="server" ID="imgButtonLimpiar" ImageUrl="~/img/limpiar.png" AlternateText="Limpiar formulario" class="iconos" /></li>
      
                    <li>
                    </li>
                    <li>
                        <asp:Button ID="BtnLimpiar" CommandName="Select"
                            ToolTip="Limpiar formulario"
                            Style="display: block;" runat="server" Text="Limpiar" />
                    </li>

                    <li>

                        <asp:ImageButton runat="server" ID="imgButtonBusqueda" ImageUrl="~/img/buscar.png" AlternateText="Consulta de Facturas" class="iconos" />

                    </li>

                    <li>

                        <asp:Button ID="btnBuscar" CommandName="Select"
                            ToolTip="Seleccionar"
                            Style="display: block;" runat="server" Text="Buscar Factura" />
                    </li>
                </ul>
            </div>
            </header>

        <div class="bg-image align-items-center bg-dark fondo filaTitle">

            <asp:Label ID="lblMetodo" runat="server" Text="Método de pago"></asp:Label>
            <asp:TextBox ID="txtFactura" runat="server" BackColor="#FFF7E7" Placeholder="Ingrese NIT"></asp:TextBox>
            <asp:Label ID="lblDias" runat="server" Text="Dias de plazo"></asp:Label>
            <asp:TextBox ID="txtAutorizacion" runat="server" BackColor="#FFF7E7" Placeholder="Ingrese NIT"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Método de pago"></asp:Label>
            <asp:TextBox ID="txtEmision" runat="server" BackColor="#FFF7E7" Placeholder="Ingrese NIT"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Dias de plazo"></asp:Label>
            <asp:TextBox ID="txtNit" runat="server" BackColor="#FFF7E7" Placeholder="Ingrese NIT"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Método de pago"></asp:Label>
            <asp:TextBox ID="txtCliente" runat="server" BackColor="#FFF7E7" Placeholder="Ingrese NIT"></asp:TextBox>
        </div>

    </form>
</body>
</html>
