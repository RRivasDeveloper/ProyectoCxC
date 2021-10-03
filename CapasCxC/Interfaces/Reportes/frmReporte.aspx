<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmReporte.aspx.cs" Inherits="CapasCxC.Interfaces.Reportes.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/misEstilos.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../../img/LogoIcon.ico" type="image/x-icon" />
    <title>Reportes</title>

</head>
<body>
    <form id="form1" runat="server">

        <header class="p-3 bg-dark text-white">

            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <a href="/" class="d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none"></a>

                <asp:ImageButton runat="server" ID="inicioLogo" ImageAlign="Left" ImageUrl="~/img/Logo.jpeg" AlternateText="Inicio" OnClick="inicioLogo_Click" class="iconos" />
                <a href="frmInicio.aspx" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a>

                <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">

                    <li>
                        <asp:ImageButton runat="server" ID="btnCreditos" ImageUrl="~/img/credit.png" AlternateText="Creditos" OnClick="btnCreditos_Click" class="iconos" /></li>

                    <li><a href="#" class="nav-link px-2 text-white">Creditos</a></li>
                    <li>
                        <asp:ImageButton runat="server" ID="btnFactura" ImageUrl="~/img/factura.png" AlternateText="Factura" OnClick="btnFactura_Click" class="iconos" /></li>

                    <li><a href="#" class="nav-link px-2 text-white">Facturas</a></li>
                    <li>
                        <asp:ImageButton runat="server" ID="btnClientes" ImageUrl="~/img/clients.jpg" AlternateText="Clientes" OnClick="btnClientes_Click" class="iconos" /></li>

                    <li><a href="#" class="nav-link px-2 text-white">Clientes</a></li>

                </ul>





                <asp:ImageButton runat="server" ID="btnSalir" ImageAlign="Right" ImageUrl="~/img/Salir.png" AlternateText="Salir" OnClick="btnSalir_Click" class="iconos" />
                <a href="#" class="nav-link px-2 text-white">Salir</a>

            </div>

        </header>

        <div class="bg-image align-items-center bg-dark fondo">
            <!--este es el div del sidebar-->
            <div visible="false" runat="server" id="Lateral" class=" p-3 text-white bg-dark barralateral ">
                <span class="fs-4 ">Cuentas por Cobrar</span>
                <hr />
                <label><strong>Reportes por:</strong></label>
                <div class="container-fluid">
                    <a href="#" class="nav-link d-flex align-items-center text-white text-decoration-none dropdown-toggle" id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false">

                        <asp:Image ID="btnSidebar" runat="server" CssClass="iconos" />
                        <strong></strong>
                    </a>
                    <ul class="dropdown-menu dropdown-menu-dark text-small shadow" aria-labelledby="dropdownUser1">
                        <li>

                            <asp:HyperLink ID="sideBar1" runat="server" Visible="false" CssClass="dropdown-item" href="#">HyperLink</asp:HyperLink>
                            <asp:ImageButton runat="server" ID="btnSidebar1" Visible="false" AlternateText="Reporte1" OnClick="btnSidebar1_Click" CssClass="iconos fondoicono" />

                        </li>
                        <li>
                            <asp:HyperLink ID="sideBar2" runat="server" Visible="false" CssClass="dropdown-item" href="#">HyperLink</asp:HyperLink>
                            <asp:ImageButton runat="server" ID="btnSidebar2" Visible="false" AlternateText="Reporte2" OnClick="btnSidebar2_Click" CssClass="iconos fondoicono" />

                        </li>
                        <li>
                            <asp:HyperLink ID="sideBar3" runat="server" Visible="false" CssClass="dropdown-item" href="#">HyperLink</asp:HyperLink>
                            <asp:ImageButton runat="server" ID="btnSidebar3" Visible="false" AlternateText="Reporte3" OnClick="btnSidebar3_Click" CssClass="iconos fondoicono" />

                        </li>
                        <li>
                            <asp:HyperLink ID="sideBar4" runat="server" Visible="false" CssClass="dropdown-item" href="#">HyperLink</asp:HyperLink>
                            <asp:ImageButton runat="server" ID="btnSidebar4" Visible="false" AlternateText="Reporte4" OnClick="btnSidebar4_Click" CssClass="iconos fondoicono" />

                        </li>
                        <li>
                            <asp:HyperLink ID="sideBar5" runat="server" Visible="false" CssClass="dropdown-item" href="#">HyperLink</asp:HyperLink>
                            <asp:ImageButton runat="server" ID="btnSidebar5" Visible="false" AlternateText="Reporte5" OnClick="btnSidebar5_Click" CssClass="iconos fondoicono" />

                        </li>
                        <li>
                            <hr class="dropdown-divider">
                        </li>
                        <li><a class="dropdown-item" href="#">Imprimir</a>
                            <asp:ImageButton runat="server" ID="btn_Imprimir" ImageUrl="~/img/imprimir.png" AlternateText="Consulta de Clientes" OnClick="btn_Imprimir_Click" class="iconos" />


                        </li>
                    </ul>
                </div>
            </div>
            <!--este es el div del cuerpo-->
            <div>
                <!--Agrego los rangos de fecha-->
                <table>
                    <tr>
                        <td>
                            <asp:Calendar Visible="False" ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px" NextPrevFormat="FullMonth">
                                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#333333" Font-Bold="True" VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                <TitleStyle BackColor="White" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" BorderColor="Black" BorderWidth="4px" />
                                <TodayDayStyle BackColor="#CCCCCC" />
                            </asp:Calendar>
                        </td>
                        <td>
                            <asp:Calendar Visible="False" ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" OnSelectionChanged="Calendar2_SelectionChanged" Width="350px" NextPrevFormat="FullMonth">
                                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#333333" Font-Bold="True" VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                <TitleStyle BackColor="White" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" BorderColor="Black" BorderWidth="4px" />
                                <TodayDayStyle BackColor="#CCCCCC" />
                            </asp:Calendar>
                        </td>
                    </tr>
                    <tr>


                        <td>
                            <asp:Button Visible="false" ID="BtnFechaInicial" runat="server" Text="Fecha Inicial" OnClick="BtnFechaInicial_Click" />
                        </td>


                        <td>
                            <asp:Button Visible="false" ID="BtnFechaFinal" runat="server" Text="Fecha Final" OnClick="BtnFechaFinal_Click" />
                        </td>


                        <td>
                            <asp:ImageButton
                                Visible="false"
                                ID="btnBuscar"
                                runat="server"
                                Width="100"
                                ImageUrl="~/img/buscar.png"
                                CommandName="Select"
                                ToolTip="Buscar Rango"
                                Style="display: block;" OnClick="btnBuscar_Click"></asp:ImageButton></td>

                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox Visible="false" ID="TxtFechaInicial" runat="server" BackColor="#FFF7E7" Placeholder="Fecha Inicial" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox></td>
                        <td>
                            <asp:TextBox Visible="false" ID="TxtFechaFinal" runat="server" BackColor="#FFF7E7" Placeholder="Fecha Final" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox></td>

                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddOpciones" AutoPostBack="true" OnSelectedIndexChanged="ddOpciones_SelectedIndexChanged" Visible="false" runat="server"></asp:DropDownList>
                        </td>


                    </tr>
                </table>
                <div>
                    <br />
                    <br />
                    <asp:Label ID="gvTitulo" Font-Size="X-Large" ForeColor="White" runat="server" Text=""></asp:Label>

                    <br />
                    <div style="overflow-x: auto; width: auto; margin-right: 50px;">
                        <asp:GridView ID="gvClientes" CssClass="transparente" runat="server"
                            AllowPaging="True" OnPageIndexChanging="cambiodDePagina"
                            OnSorting="OrdenarPagina"
                            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                            CellPadding="3" CellSpacing="2" AllowSorting="True" PageSize="8" Width="60%">
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
            </div>

            </div>
        </div>
    </form>
    <script src="../../js/bootstrap.bundle.min.js"></script>
</body>
</html>
