<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="CapasCxC.Interfaces.Clientes.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../css/misEstilos.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../../img/LogoIcon.ico" type="image/x-icon" />

    <title>Inicio</title>

</head>
<body>
    <form id="formInicio" runat="server">
        <header class="p-3 bg-dark text-white">
            <center>
                <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">

                    <ul style="margin-left: auto; margin-right: auto; margin-top: auto; margin-bottom: auto" class="nav col-21 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                        <li>
                            <asp:ImageButton
                                ID="ImageButtonReporte"
                                runat="server"
                                class="iconos"
                                ImageUrl="~/img/Consulta.png"
                                CommandName="Select"
                                ToolTip="Seleccionar"
                                OnClick="btnReporte_Click"></asp:ImageButton>
                            <a href="fmrClientes.aspx" class="nav-link px-2 text-white">Reportes</a>
                        </li>
                        <li>
                            <asp:ImageButton
                                ID="ImageButton1"
                                runat="server"
                                class="iconos"
                                ImageUrl="~/img/pagos.png"
                                CommandName="Select"
                                ToolTip="Seleccionar"
                                OnClick="btnPagos_Click"></asp:ImageButton>
                            <a href="#" class="nav-link px-2 text-white">Pagos</a>
                        </li>

                        <li>
                            <asp:ImageButton
                                ID="ImageButton2"
                                runat="server"
                                class="iconos"
                                ImageUrl="~/img/ingreso.png"
                                CommandName="Select"
                                ToolTip="Seleccionar"
                                OnClick="btnIngreso_Click"></asp:ImageButton>
                            <a href="#" style="align-content: center" class="nav-link px-2 text-white">Ingresos</a>
                        </li>

                        <li>
                            <asp:ImageButton
                                ID="ImageButton5"
                                runat="server"
                                class="iconos"
                                ImageUrl="~/img/ingresarCliente.png"
                                CommandName="Select"
                                ToolTip="Seleccionar"
                                OnClick="bntIngresoCliente_Click"></asp:ImageButton>
                            <a href="frmCrudCliente.aspx" class="nav-link px-2 text-white">Clientes</a>
                        </li>

                    </ul>


                    <asp:ImageButton runat="server" ID="ImageButton3" ImageAlign="Right" ImageUrl="~/img/Salir.png" AlternateText="Salir del Sistema" OnClick="ImageButton3_Click" class="iconos" />
                    <a href="http://www.google.com" class="nav-link px-2 text-white">Salir</a>

                </div>
            </center>

        </header>

        <div class="bg-image letrasBlancas bg-dark fondo" style="display: flex; align-items: center;">
            <div style="margin: 0 auto;">
               
              
            </div>
        </div>
    </form>
</body>
</html>
