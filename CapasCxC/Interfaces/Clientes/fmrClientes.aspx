<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fmrClientes.aspx.cs" Inherits="CapasCxC.Interfaces.Clientes.fmrClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/misEstilos.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../../img/LogoIcon.ico" type="image/x-icon" />
    <title>Cuentas por Cobrar</title>

</head>
<body>
    <form id="form1" runat="server">
        <header class="p-3 bg-dark text-white">

            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <a href="/" class="d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none"></a>
                <asp:ImageButton runat="server" ID="inicioLogo" ImageUrl="~/img/Logo.jpeg" AlternateText="Inicio" OnClick="inicioLogo_Click" class="iconos" />
                <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <li><a href="frmInicio.aspx" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a></li>

                    <li>
                        <asp:ImageButton runat="server" ID="Consultas" ImageUrl="~/img/Consulta.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos" /></li>

                    <li><a href="#" class="nav-link px-2 text-white">Consultas</a></li>
                    <li>
                        <asp:ImageButton runat="server" ID="btnPagos" ImageUrl="~/img/pagos.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos" /></li>

                    <li><a href="#" class="nav-link px-2 text-white">Pagos</a></li>
                    <li>
                        <asp:ImageButton runat="server" ID="btnIngreso" ImageUrl="~/img/ingreso.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos" /></li>

                    <li><a href="#" class="nav-link px-2 text-white">Ingresos</a></li>
                    <li>
                        <asp:ImageButton runat="server" ID="btn_CrudClientes" ImageUrl="~/img/ingresarCliente.png" AlternateText="Consulta de Clientes" OnClick="btn_CrudClientes_Click" class="iconos" /></li>

                    <li><a href="frmCrudCliente.aspx" class="nav-link px-2 text-white">Clientes</a></li>
                </ul>

                <asp:ImageButton runat="server" ID="ImageButton2" ImageAlign="Right" ImageUrl="~/img/Salir.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos" />
                <a href="#" class="nav-link px-2 text-white">Salir</a>

            </div>

        </header>
        <div class="bg-image align-items-center bg-dark fondo">
            <!--este es el div del sidebar-->
            <div class=" p-3 text-white bg-dark barralateral ">
                <span class="fs-4 ">Cuentas Por Cobrar</span>
                <hr />
                <label><strong>Consulta</strong></label>
                <div class="container-fluid">
                    <a href="#" class="nav-link d-flex align-items-center text-white text-decoration-none dropdown-toggle" id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false">
                        <img src="/img/cpc.png" alt="" class="iconos">
                        <strong></strong>
                    </a>
                    <ul class="dropdown-menu dropdown-menu-dark text-small shadow" aria-labelledby="dropdownUser1">
                        <li>
                            <a class="dropdown-item" href="#">Región Geografica</a>
                            <asp:ImageButton runat="server" ID="ImageButton3" ImageUrl="~/img/gt.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos fondoicono" />

                        </li>
                        <li>
                            <a class="dropdown-item" href="#">Vigentes Al Día</a>
                            <asp:ImageButton runat="server" ID="ImageButton4" ImageUrl="~/img/Vigente.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos fondoicono" />

                        </li>
                        <li><a class="dropdown-item" href="#">En Mora</a>
                            <asp:ImageButton runat="server" ID="ImageButton5" ImageUrl="~/img/moroso.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos fondoicono" />

                        </li>
                        <li><a class="dropdown-item" href="#">Sin Deuda</a>
                            <asp:ImageButton runat="server" ID="ImageButton6" ImageUrl="~/img/sindeuda.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos fondoicono" />

                        </li>
                        <li>
                            <hr class="dropdown-divider">
                        </li>
                        <li><a class="dropdown-item" href="#">Imprimir</a>
                            <asp:ImageButton runat="server" ID="btn_Imprimir" ImageUrl="~/img/imprimir.png" AlternateText="Consulta de Clientes" OnClick="Consultas_Click" class="iconos" />


                        </li>
                    </ul>
                </div>
            </div>
            <!--este es el div del cuerpo-->
            <div>
                <div>
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TxtBusqueda" runat="server" BackColor="#FFF7E7" Placeholder="Buscar por Dpi/nit" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox></td>
                                <td>
                                    <asp:ImageButton
                                        ID="ImageButton1"
                                        runat="server"
                                        Width="50"
                                        ImageUrl="~/img/buscar.png"
                                        CommandName="Select"
                                        ToolTip="Seleccionar"
                                        Style="display: block;" OnClick="ImageButton1_Click"></asp:ImageButton></td>

                            </tr>
                        </table>

                    </div>
                    <asp:GridView ID="gvClientes" runat="server" EmptyDataText="No hay Registros"
                        AllowPaging="True" OnPageIndexChanging="cambiodDePagina"
                        OnSorting="OrdenarPagina"
                        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                        CellPadding="3" CellSpacing="2" AllowSorting="True" PageSize="20">
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
    </form>
    <script src="../../js/bootstrap.bundle.min.js"></script>
</body>
</html>
