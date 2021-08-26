<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fmrClientes.aspx.cs" Inherits="CapasCxC.Interfaces.Clientes.fmrClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/misEstilos.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../img/LogoIcon.ico" type="image/x-icon" />
    <title>Cuentas por Cobrar</title>

</head>
<body>
    <header class="p-3 bg-dark text-white">
        <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
            <a href="/" class="d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none"></a>
            <img src="/img/Logo.jpeg" alt="" class="rounded-circle me-2" width="32" height="32" />
            <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                <li><a href="#" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a></li>

                <li><a href="#" class="nav-link px-2 text-white">Consultas</a></li>
                <li><a href="#" class="nav-link px-2 text-white">Pagos</a></li>
                <li><a href="#" class="nav-link px-2 text-white">Ingresos</a></li>
                <li><a href="#" class="nav-link px-2 text-white">Cancelaciones</a></li>
            </ul>
            <!--div class="text-end">
                <a href="login.html">
                    <button type="button" class="btn btn-outline-light me-2">Salir</button></a>
                <button type="button" class="btn btn-warning">Salir</button>
            </div-->
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
                    <img src="/img/cpc.png" alt="" class="rounded-circle me-2" width="32" height="32">
                    <strong></strong>
                </a>
                <ul class="dropdown-menu dropdown-menu-dark text-small shadow" aria-labelledby="dropdownUser1">
                    <li><a class="dropdown-item" href="#">Por Cliente</a></li>
                    <li><a class="dropdown-item" href="#">Por Saldo</a></li>
                    <li><a class="dropdown-item" href="#">Por Mora</a></li>
                    <li>
                        <hr class="dropdown-divider">
                    </li>
                    <li><a class="dropdown-item" href="#">Imprimir</a></li>
                </ul>
            </div>
        </div>
        <div>




            <form id="form1" runat="server">
                <div>
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TxtBusqueda" runat="server" BackColor="#FFF7E7" Placeholder="Buscar por Dpi/nit"></asp:TextBox></td>
                                <td>
                                    <asp:ImageButton
                                        ID="ImageButton1"
                                        runat="server"
                                        Width="32px"
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
                        CellPadding="3" CellSpacing="2">
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
                </div>
            </form>
        </div>
    </div>
    <script src="../../js/bootstrap.bundle.min.js"></script>
</body>
</html>
