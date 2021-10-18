    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFacturaNueva.aspx.cs" Inherits="CapasCxC.Interfaces.Factura.frmCrudFactura" %>

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
    <form id="form1" runat="server">
        <header class="p-3 bg-dark text-white">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <a href="/" class="d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none"></a>
                <asp:ImageButton runat="server" ID="inicioLogo" ImageUrl="~/img/Logo.jpeg" AlternateText="Inicio" OnClick="inicioLogo_Click" class="iconos" />
                <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <li>
                        <a href="frmInicio.aspx" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a>
                    </li>
                    

                </ul>
                    
            </div>
            </header>
            

            <div class="bg-image align-items-center bg-dark fondo filaTitle">
            
                <div>
                <div>
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="lblNit" runat="server" Text="NIT "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtNit" runat="server" BackColor="#FFF7E7" Placeholder="Ingrese NIT"></asp:TextBox>
                                </td>
                                <td></td>
                                <td></td>
                                <td>
                                    <asp:ImageButton
                                        ID="imbButtonCliente"
                                        runat="server"
                                        Width="100"
                                        ImageUrl="~/img/nuevo.png"
                                        CommandName="Select"
                                        ToolTip="Nuevo Cliente"
                                        Style="display: block;" OnClick="imgBtnCliente_Click"></asp:ImageButton>

                                </td>
                                <td>
                                    <asp:Label ID="lblCliente" runat="server" Text="Cliente Nuevo "></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblNomCliente" runat="server" Text="Cliente "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCliente" runat="server" BackColor="#FFF7E7" Placeholder="Nombre completo del cliente" style="width:700px;" ></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    </div>

                    <div>
                        <asp:GridView ID="gvProductos" runat="server" ShowFooter="true"
                            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FFF1D4" />
                            <SortedAscendingHeaderStyle BackColor="#B95C30" />
                            <SortedDescendingCellStyle BackColor="#F1E5CE" />
                            <SortedDescendingHeaderStyle BackColor="#93451F" />

                            <Columns>
                                <asp:TemplateField HeaderText="Producto">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("Producto") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="colId" Text='<%# Eval("Producto") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="colidFooter" runat="server" />
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Marca">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("Marca") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="colId" Text='<%# Eval("Marca") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="colidFooter" runat="server" />
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:ImageButton ImageUrl="~/img/borrar.png"  runat="server" CommandArgument="Editar" ToolTip="Editar" Width="75px" Height="75px" />
                                        <asp:ImageButton ImageUrl="~/img/cancel.png"  runat="server" CommandArgument="Eliminar" ToolTip="Eliminar" Width="75px" Height="75px" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                        </asp:GridView>
                    </div>

                    <div>
                        <asp:Label ID="lblMetodo" runat="server" Text="Método de pago"></asp:Label>
                        <asp:DropDownList ID="dpdMetodoPago" runat="server"></asp:DropDownList>
                        <asp:Label ID="lblDias" runat="server" Text="Dias de plazo"></asp:Label>
                        <asp:DropDownList ID="dpdDias" runat="server"></asp:DropDownList>
                    </div>
                    
                </div>
            </div>
        </div>

    </form>
</body>
</html>
