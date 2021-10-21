<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFacturaResultado.aspx.cs" Inherits="CapasCxC.Interfaces.Factura.frmFacturaResultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../css/misEstilos.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../../img/LogoIcon.ico" type="image/x-icon" />
    <title>Facturas</title>
</head>
<body>
    <form id="frmFacturaRestultado" runat="server">
        <header class="p-3 bg-dark text-white">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <asp:ImageButton runat="server" ID="inicioLogo" ImageUrl="~/img/Logo.jpeg" AlternateText="Inicio" class="iconos" />
                <a href="frmInicio.aspx" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a>
                <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    
                    <li>
                        <asp:ImageButton
                            ImageAlign="AbsMiddle"
                            ID="imbNuevo"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/nuevo.png"
                            CommandName="Select"
                            ToolTip="Nueva Factura"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="#" class="nav-link px-2 text-white">Reportes</a>
                    </li>
                    <li>
                        <asp:ImageButton
                            ID="imbImprimir"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/imprimir.png"
                            CommandName="Select"
                            ToolTip="Imprimir factura"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="#" class="nav-link px-2 text-white">Pagos</a>
                    </li>
                    <li>
                        <asp:ImageButton
                            ID="imbActualizar"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/actualizar.png"
                            CommandName="Select"
                            ToolTip="Actualizar factura"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="#" class="nav-link px-2 text-white">Reportes</a>
                    </li>
                    <li>
                        <asp:ImageButton
                            ID="imbCancelar"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/cancel.png"
                            CommandName="Select"
                            ToolTip="Cancelar Factura"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="#" class="nav-link px-2 text-white">Cancelar</a>
                    </li>
                    <li>
                        <asp:ImageButton
                            ID="imbCredito"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/credit.png"
                            CommandName="Select"
                            ToolTip="Ver Credito"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="#" class="nav-link px-2 text-white">Reportes</a>
                    </li>
                </ul>
            </div>
            </header>

        <div class="bg-image align-items-center bg-dark fondo filaTitle">
            <div>
                <asp:Label ID="lblFactura" runat="server" Text="Factura"></asp:Label>   
                <asp:TextBox ID="txtFactura" runat="server" BackColor="#FFF7E7" Placeholder="Serie-Numero" Enabled="false" />
                <asp:Label ID="lblAutorizacion" runat="server" Text="Número de Autorización"></asp:Label>
                <asp:TextBox ID="txtAutorizacion" runat="server" BackColor="#FFF7E7" Placeholder="Autorizacion"></asp:TextBox>
                <asp:Label ID="lblFecha" runat="server" Text="Fecha de emision"></asp:Label>
                <asp:TextBox ID="txtEmision" runat="server" BackColor="#FFF7E7" Placeholder="Fecha" Enabled="false" />
                <asp:Label ID="lblNit" runat="server" Text="Dias de plazo"></asp:Label>
                <asp:TextBox ID="txtNit" runat="server" BackColor="#FFF7E7" Placeholder="NIT" Enabled="false" />
                <asp:Label ID="lblCliente" runat="server" Text="Nombre completo"></asp:Label>
                <asp:TextBox ID="txtCliente" runat="server" BackColor="#FFF7E7" Placeholder="Nombre completo" Enabled="false" />
            </div>

            <div>
                <asp:GridView ID="gvDetalle" runat="server"
                    ShowHeaderWhenEmpty="true"
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"
                    >
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>

                <asp:Label ID="lblSubTotal" runat="server" Text="Sub Total"></asp:Label>
                <asp:TextBox ID="txtSubTotal" runat="server" BackColor="#FFF7E7" Placeholder="SubTotal" style="width:200px;" Enabled="false" />
                <br />
                <asp:Label ID="lblIVA" runat="server" Text="IVA"></asp:Label>
                <asp:TextBox ID="txtIVA" runat="server" BackColor="#FFF7E7" Placeholder="IVA" style="width:200px;" Enabled="false" />
                <br />
                <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>
                <asp:TextBox ID="txtTotal" runat="server" BackColor="#FFF7E7" Placeholder="Total" style="width:200px;" Enabled="false" />
            </div>


        </div>

        <

    </form>
</body>
</html>
