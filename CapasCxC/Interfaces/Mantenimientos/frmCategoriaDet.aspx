<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCategoriaDet.aspx.cs" Inherits="CapasCxC.Interfaces.Mantenimientos.frmCategoriaDet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/misEstilos.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../../img/LogoIcon.ico" type="image/x-icon" />
    <title>CategoriaClientes</title>

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
                        <asp:ImageButton runat="server" ID="btnActualizar" ImageUrl="~/img/actualizar.png" AlternateText="Borrar" OnClick="btnActualizar_Click" class="iconos" /></li>

                    <li><a href="#" class="nav-link px-2 text-white">Actualizar</a></li>

                </ul>

                <asp:ImageButton runat="server" ID="btnSalir" ImageAlign="Right" ImageUrl="~/img/Salir.png" AlternateText="Salir" OnClick="btnSalir_Click" class="iconos" />
                <a href="#" class="nav-link px-2 text-white">Salir</a>

            </div>

        </header>
        <div class="bg-image align-items-center bg-dark fondo">
            <!--este es el div del cuerpo-->
            <div>
                <div>
                    <br />
                    <br />
                    <h1 style="text-align:center; color:snow;font-size:60px">Categorias de Clientes</h1>
                    <div>
                        <br />
                        <br />
                        <center>
                            <table>
                                <tr>
                                    <td style="padding: 25px">
                                        <asp:TextBox ID="TextBoxID" runat="server" BackColor="#FFF7E7" Placeholder="Id" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox>
                                    </td>
                                    <td style="padding: 25px">
                                        <asp:TextBox ID="TextBoxNombre" runat="server" BackColor="#FFF7E7" Placeholder="Nombre" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox>
                                    </td>
                                    <td style="padding: 25px">
                                        <asp:TextBox ID="TextBoxDescripcion" runat="server" BackColor="#FFF7E7" Placeholder="Descripcion" onkeypress="if (event.keyCode==13) return false;"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </center>
                        <br />
                        <br />

                    </div>
                    <center>


                        <asp:GridView ID="gvClientes" runat="server" EmptyDataText="No hay Registros"
                            AllowPaging="True" OnPageIndexChanging="cambiodDePagina"
                            OnSorting="OrdenarPagina"
                            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                            CellPadding="3" CellSpacing="2" AllowSorting="True" PageSize="20">
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#c9640a" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <SelectedRowStyle  BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
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
    <script src="../../js/bootstrap.bundle.min.js"></script>
</body>
</html>
