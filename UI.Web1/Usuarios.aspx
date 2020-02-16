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
                <asp:BoundField  HeaderText="ID" DataField="ID" />
                <asp:BoundField HeaderText="Persona" DataField="Id_persona" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
		<asp:BoundField  HeaderText="Usuario" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>            
        </asp:GridView>
              
                <br />
              
            <asp:Panel ID="formPanel" runat="server" Visible="false" Height="323px">
                <br />
                Completa<br />
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="tbId_perasdsona" runat="server" Text="PersonaID:"></asp:Label>
                 <asp:TextBox ID="tbidPers" runat="server"></asp:TextBox>
                <br />

                <br />
                <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>

        </asp:Panel>
            <asp:Panel ID="gridActionsPanel" runat="server" Height="40px">
            </asp:Panel>
</asp:Content>
