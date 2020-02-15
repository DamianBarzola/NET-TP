<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body class="text-center">
    <form id="form1" runat="server">
        <div style="border: medium groove #000066; font-family: 'Arial Black'; font-size: medium; color: #000000; text-align: center;">
             <br />
             ¡Bienvenido al Sistema!
            <br />
 Por favor digite su información de Ingreso.<br />

            <br />
Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtUsuario" type="text" runat="server" TabIndex="1"></asp:TextBox>
             <br />
Contraseña
            <asp:TextBox ID="txtPass" type="password" runat="server" TabIndex="2"></asp:TextBox>
             <br />
               
                    <div class="text-danger">
                        <asp:Label ID="lblBadLogin" runat="server" Visible="False" BackColor="#CC0000">Usuario o Contraseña incorrecto</asp:Label>
                        &nbsp;&nbsp;
                        <asp:Label ID="lblError" runat="server" Visible="False" BackColor="#CC0000">Error de Servidor</asp:Label>
                    </div>

             <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btIngresar" runat="server" OnClick="btIngresar_Click" Text="Ingresar" style="margin-left: 0px" TabIndex="4" Width="104px" />
             <br />
             <br />
        </div>
        Damian Barzola - Agustin Etcheverry</form>
</body>
</html>
