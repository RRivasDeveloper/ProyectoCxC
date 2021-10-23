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
    <form id="frmFacturaNueva" runat="server">
        <header class="p-3 bg-dark text-white">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <asp:ImageButton runat="server" ID="inicioLogo" ImageUrl="~/img/Logo.jpeg" AlternateText="Inicio" OnClick="inicioLogo_Click" class="iconos" />
                <a href="frmInicio.aspx" class="nav-link px-2 text-secondary"><strong>Inicio</strong></a>
                <ul class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <li>
                        <asp:ImageButton
                            ID="imbLimpiar"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/limpiar.png"
                            CommandName="Select"
                            ToolTip="Limpiar formulario"
                            OnClick="BtnLimpiar_Click"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="#" class="nav-link px-2 text-white">Limpiar</a>
                    </li>
                    <li>
                        <asp:ImageButton
                            ID="imbBuscar"
                            runat="server"
                            class="iconos"
                            ImageUrl="~/img/buscar.png"
                            CommandName="Select"
                            ToolTip="Buscar factura"
                            OnClick="btnBusqueda_Click"
                            Width="50px"
                            Height="50px"
                            />
                        <a href="#" class="nav-link px-2 text-white">Buscar</a>
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
                                <td>
                                    <asp:ImageButton
                                        ID="imbButtonCliente"
                                        runat="server"
                                        ImageUrl="~/img/nuevo.png"
                                        CommandName="Select"
                                        ToolTip="Validar" 
                                        Width="30px" 
                                        Height="30px" 
                                        Style="display: block;" OnClick="imgBtnCliente_Click"></asp:ImageButton>
                                </td>
                                <td>
                                    <asp:Label ID="lblCliente" runat="server" Text="Validar" ></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblNomCliente" runat="server" Text="Cliente "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCliente" runat="server" BackColor="#FFF7E7" Placeholder="Nombre completo del cliente" style="width:700px;" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    
                    </div>

                    <div>
                        <asp:GridView ID="gvProductos" runat="server" ShowFooter="true" DataKeyNames="Producto"
                            OnRowCommand="gvProducto_RowCommand" AutoGenerateColumns="false"
                            OnRowEditing="gvProductos_RowEditing" OnRowCancelingEdit="gvProductos_RowCancelingEdit"
                            OnRowUpdating="gvProductos_RowUpdating" OnRowDeleting="gvProductos_RowDeleting"
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
                                <asp:TemplateField HeaderText="Cantidad">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("Cantidad") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtCantidad" Text='<%# Eval("Cantidad") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtCantidadFooter" runat="server" />
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Producto">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("Producto") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtProduct" Text='<%# Eval("Producto") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtProductFooter" runat="server" Enabled="false"/>
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Marca">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("Marca") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtMarca" Text='<%# Eval("Marca") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtMarcaFooter" runat="server" />
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Modelo">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("Modelo") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtModelo" Text='<%# Eval("Modelo") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtModeloFooter" runat="server" />
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Precio">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("PrecioVenta") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtPrecio" Text='<%# Eval("PrecioVenta") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtPrecioFooter" runat="server" Enabled="false"/>
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Total">
                                    <ItemTemplate>
                                        <asp:Label Text='<%# Eval("Total") %>' runat="server"/>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtTotal" Text='<%# Eval("Total") %>' runat="server" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtTotalFooter" runat="server" Enabled="false"/>
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:ImageButton ImageUrl="~/img/actualizar.png"  runat="server" CommandName="Edit" ToolTip="Editar" Width="30px" Height="30px" />
                                        <asp:ImageButton ImageUrl="~/img/borrar.png"  runat="server" CommandName="Delete" ToolTip="Eliminar" Width="30px" Height="30px" />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:ImageButton ImageUrl="~/img/guardar.png"  runat="server" CommandName="Update" ToolTip="Editar" Width="30px" Height="30px" />
                                        <asp:ImageButton ImageUrl="~/img/cancel.png"  runat="server" CommandName="Cancel" ToolTip="Eliminar" Width="30px" Height="30px" />
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:ImageButton ImageUrl="~/img/nuevo.png"  runat="server" CommandName="AddNew" ToolTip="Nuevo" Width="30px" Height="30px" />
                                    </FooterTemplate>
                                </asp:TemplateField>
                            </Columns>

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

                    <div>

                    </div>

                    <div>
                        <asp:Label ID="lblMetodo" runat="server" Text="Método de pago"></asp:Label>
                        <asp:DropDownList ID="dpdMetodoPago" runat="server"></asp:DropDownList>
                        <asp:Label ID="lblDias" runat="server" Text="Dias de plazo"></asp:Label>
                        <asp:DropDownList ID="dpdDias" runat="server"></asp:DropDownList>
                    </div>
                    
                    <div>
                        <asp:ImageButton
                            ID="ibtNuevaFactura"
                            runat="server"
                            ImageUrl="~/img/okay.png"
                            CommandName="Select"
                            ToolTip="Guardar factura" 
                            Width="50px" 
                            Height="50px" 
                            Style="display: block;" OnClick="ibtNuevaFactura_Click"></asp:ImageButton>
                        <asp:Label ID="lblNuevaFactura" runat="server" Text="Guardar Factura" Enabled="false"></asp:Label>
                    </div>

                </div>
            </div>
        </div>

    </form>
</body>
</html>
