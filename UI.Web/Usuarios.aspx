<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="formActionsPanel" runat="server" Height="33px" Font-Underline="False" ValidateRequestMode="Disabled">
                <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbEliminar" runat="server" OnClick="lbEliminar_Click">Eliminar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbNuevo" runat="server" OnClick="lbNuevo_Click">Nuevo</asp:LinkButton>
            </asp:Panel>
                <asp:GridView ID="gridView" runat="server" 
            AutoGenerateColumns="False"  SelectedRowStyle-BackColor="Black"
SelectedRowStyle-ForeColor="White"
DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField  HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Persona" DataField="IDPersona" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
		<asp:BoundField  HeaderText="Usuario" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>            
        </asp:GridView>
              
                <br />
              
            <asp:Panel ID="formPanel" runat="server" Visible="false" Height="323px">
                <br />
                Completar:<br />
                <br />
                <asp:Label ID="nombrelbl" runat="server" Text="Nombre:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="apellidolbl" runat="server" Text="Apellido:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="emaillbl" runat="server" Text="Email:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="habilitadolbl" runat="server" Text="Habilitado:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbHabilitado" runat="server" />
                <br />
                <br />
                <asp:Label ID="nombreusuariolbl" runat="server" Text="Nombre Usuario:"></asp:Label>
                &nbsp;<asp:TextBox ID="tbNombreUsuario" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="clavelbl" runat="server" Text="Clave:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbClave" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="repetirclavelbl" runat="server" Text="Repetir clave:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbRepetirClave" runat="server"></asp:TextBox>
                <br />

        </asp:Panel>
            <asp:Panel ID="gridActionsPanel" runat="server" Height="40px">
                <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
            </asp:Panel>
</asp:Content>
