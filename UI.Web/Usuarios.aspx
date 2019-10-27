<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usuarios</title>
</head>
<body style="height: 626px">
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged" >
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" ReadOnly="True" SortExpression="nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" ReadOnly="True" SortExpression="apellido" />
                    <asp:BoundField DataField="email" HeaderText="Email" ReadOnly="True" SortExpression="email" />
                    <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" ReadOnly="True" SortExpression="NombreUsuario" />
                    <asp:BoundField DataField="habilitado" HeaderText="Habilitado" ReadOnly="True" SortExpression="habilitado" />
                    <asp:CommandField SelectText ="Seleccionar" ShowSelectButton="true"/>
                </Columns>
            </asp:GridView>
      
            <asp:Panel ID="formPanel" runat="server" Visible="false" Height="323px">
                <asp:Label ID="nombrelbl" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="apellidolbl" runat="server" Text="Apellido:"></asp:Label>
                <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="emaillbl" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="habilitadolbl" runat="server" Text="Habilitado:"></asp:Label>
                <asp:TextBox ID="tbHabilitado" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="nombreusuariolbl" runat="server" Text="Nombre Usuario:"></asp:Label>
                <asp:TextBox ID="tbNombreUsuario" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="clavelbl" runat="server" Text="Clave:"></asp:Label>
                <asp:TextBox ID="tbClave" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="repetirclavelbl" runat="server" Text="Repetir clave:"></asp:Label>
                <asp:TextBox ID="tbRepetirClave" runat="server"></asp:TextBox>
                <br />


        </asp:Panel>
            <asp:Panel ID="formActionsPanel" runat="server" Height="33px">
                <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbEliminar" runat="server">Eliminar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbNuevo" runat="server">Nuevo</asp:LinkButton>
            </asp:Panel>
            <asp:Panel ID="gridActionsPanel" runat="server" Height="40px">
                <asp:LinkButton ID="lbAceptar" runat="server">Aceptar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbCancelar" runat="server">Cancelar</asp:LinkButton>
            </asp:Panel>
        </div>
        
    </form>
</body>
</html>
