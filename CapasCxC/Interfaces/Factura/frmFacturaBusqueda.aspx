<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFacturaBusqueda.aspx.cs" Inherits="CapasCxC.Interfaces.Factura.frmFacturaBusqueda" %>

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
    <form id="frmFacturaBusqueda" runat="server">
        <header class="p-3 bg-dark text-white">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <asp:ImageButton runat="server" ID="inicioLogo" ImageUrl="~/img/Logo.jpeg" AlternateText="Inicio" OnClick="inicioLogo_Click" class="iconos" />
                <a href="frmInicio.aspx" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a>
                <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <li>
                        <asp:ImageButton
                            ID="imbRegresar"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/back.png"
                            CommandName="Select"
                            ToolTip="Regresar"
                            OnClick="imbRegresar_Click"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="frmFacturaNueva.aspx" class="nav-link px-2 text-white">Reportes</a>
                    </li>
                </ul>                    
            </div>
            </header>

            <div class="bg-image align-items-center bg-dark fondo filaTitle">

                <div>
                    <table>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtDato1" runat="server" BackColor="#FFF7E7" Placeholder="[nit] [dpi] [serie] [primer nombre]" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txtDato2" runat="server" BackColor="#FFF7E7" Placeholder="[no Fac] [primer apellido]" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox></td>
                            <td>
                                <asp:ImageButton
                                    ID="ibtBusqueda"
                                    runat="server"
                                    Width="100"
                                    ImageUrl="~/img/buscar.png"
                                    CommandName="Select"
                                    ToolTip="Seleccionar"
                                    Style="display: block;" OnClick="ibtBusqueda_Click"></asp:ImageButton></td>

                        </tr>
                    </table>

                </div>
                <asp:GridView ID="gvFacturas" runat="server" EmptyDataText="No hay Registros"
                    ShowHeaderWhenEmpty="true"
                    AllowPaging="True" OnPageIndexChanging="cambiodDePagina"
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                    CellPadding="3" CellSpacing="2" AllowSorting="false" PageSize="20" OnRowDataBound="gvFacturas_RowDataBound" OnSelectedIndexChanged="gvFacturas_SelectedIndexChanged"
                     EnableEventValidation = "false">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#c9640a" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </div>
            
    </form>
    <script src="../../js/bootstrap.bundle.min.js"></script>
</body>
</html>
