<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCrudCliente.aspx.cs" Inherits="CapasCxC.Interfaces.Clientes.frmCrudCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../css/misEstilos.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../../img/LogoIcon.ico" type="image/x-icon" />

    <title>Editar Clientes</title>
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

                        <asp:ImageButton runat="server" ID="btnConsultas" ImageUrl="~/img/buscarCliente.png" AlternateText="Consulta de Clientes" OnClick="btnConsultas_Click" class="iconos" /></li>

                    <li>

                        <asp:Button ID="btnConsultas2" CommandName="Select"
                            ToolTip="Seleccionar"
                            Style="display: block;" runat="server" Text="Buscar Cliente" OnClick="btnConsultas2_Click" />
                    </li>
                    <li>
                        <asp:ImageButton runat="server" ID="btnAgregar" ImageUrl="~/img/agregarCliente.png" AlternateText="Consulta de Clientes" OnClick="btnAgregar_Click" class="iconos" /></li>

                    <li>
                        <asp:Button ID="BtnAgregarCliente" CommandName="Select"
                            ToolTip="Seleccionar"
                            Style="display: block;" runat="server" Text="Buscar Cliente" OnClick="BtnAgregarCliente_Click" />

                    </li>
                    <li>
                        <asp:ImageButton runat="server" ID="btnBorrar" ImageUrl="~/img/borrarCliente.png" AlternateText="Consulta de Clientes" OnClick="btnBorrar_Click" class="iconos" /></li>

                    <li>
                        <asp:Button ID="BtnBorrarCliente" CommandName="Select"
                            ToolTip="Seleccionar"
                            Style="display: block;" runat="server" Text="Buscar Cliente" OnClick="BtnBorrarCliente_Click" />
                    </li>
                    <li>
                        <asp:ImageButton runat="server" ID="btn_Editar" ImageUrl="~/img/editarCliente1.png" AlternateText="Consulta de Clientes" OnClick="btn_Editar_Click" class="iconos" /></li>

                    <li>
                        <asp:Button ID="BtnConsultarCliente" CommandName="Select"
                            ToolTip="Seleccionar"
                            Style="display: block;" runat="server" Text="Editar Cliente" OnClick="BtnConsultarCliente_Click" />
                    </li>
                </ul>

                <asp:ImageButton runat="server" ID="ImageButton2" ImageAlign="Right" ImageUrl="~/img/Salir.png" AlternateText="Consulta de Clientes" OnClick="btnConsultas_Click" class="iconos" />
                <a href="#" class="nav-link px-2 text-white">Salir</a>

            </div>
        </header>


        <div class="bg-image align-items-center bg-dark fondo">
            <div>


                <div>
                    <table style="margin: 0 auto; top: 0 auto">
                        <tr>
                            <td>
                                <asp:TextBox ID="txtBuscarCliente" runat="server" Style="visibility: hidden; margin-left: 267px" BackColor="#FFF7E7" Placeholder="Buscar por Dpi/nit"  onkeypress="if (event.keyCode==13) return false;"></asp:TextBox>
                            </td>
                            <td>
                                <asp:ImageButton
                                    ID="btnBuscar"
                                    runat="server"
                                    Width="100"
                                    ImageUrl="~/img/buscar.png"
                                    CommandName="Select"
                                    ToolTip="Seleccionar"
                                    Style="display: block; visibility: hidden;" OnClick="btnBuscar_Click"></asp:ImageButton>
                            </td>


                        </tr>
                    </table>


                </div>
                <div style="">
                    <center>
                        
                    <asp:GridView Style="visibility:hidden; margin-left:auto; margin-right:auto; top: 0 auto;" ID="gvClientes" runat="server" EmptyDataText="No hay Registros"
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                    CellPadding="3" CellSpacing="2" AllowSorting="True" PageSize="20" >
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
                    </center>
                </div>
                
            </div>
        </div>

    </form>
</body>
</html>
