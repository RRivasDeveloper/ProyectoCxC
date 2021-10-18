<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapasCxC.Interfaces.Inicio.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../css/misEstilos.css" rel="stylesheet" />
    <title></title>
</head>
<body class="text-center" style="background-color: #212529">
    <div class="bg-image align-items-center bg-dark fondo">


        <form id="form1" runat="server" class="">
            <div class="centrarvertical">


                <main class="login">

                    <img class="mb-4" src="../../img/Login.png"  width="" height="150px">
                    <h1 class="h3 mb-3 fw-normal" style="color:white">Ingreso a CxC</h1>

                    <div class="form-floating">
                        <asp:TextBox ID="txtUsuario" CssClass="form-control"    placeholder=" Ingrese su Usuario"   runat="server"></asp:TextBox>
                        <asp:Label ID="LbUsuario" AssociatedControlID="txtUsuario"  Text="Ingrese su Usuario" runat="server" ></asp:Label>
                    </div>
                    <div class="form-floating">
                        <input runat="server"  type="password" class="form-control"  id="txtPassword" placeholder="Password" />
                        <asp:Label ID="Label2" AssociatedControlID="txtPassword"  Text="Ingrese su Contraseña" runat="server" ></asp:Label>
                        <!--label for="floatingPassword">Ingrese su Contraseña</label-->
                    </div>


                   
                    <br />
                    <asp:Button ID="Button1" CssClass="w-75 btn btn-lg btn-secondary"  runat="server" Text="Button" />
                    <p class="mt-5 mb-3 text-muted">Analisis de Sistemas 2 - © 2021</p>

                </main>
            </div>
        </form>
    </div>
</body>
</html>
