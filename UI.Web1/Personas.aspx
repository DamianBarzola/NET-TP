<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbEliminar" runat="server" OnClick="lbEliminar_Click">Eliminar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbNuevo" runat="server" OnClick="lbNuevo_Click">Nuevo</asp:LinkButton>
        <asp:GridView CssClass="table table-striped" DataKeyNames="ID" ID="gridView" runat="server" AutoGenerateColumns="False"
            OnSelectedIndexChanged="gridView_SelectedIndexChanged" SelectedRowStyle-BackColor="LightGray">
            <SelectedRowStyle BackColor="LightGray" />
            <Columns>
                 <asp:BoundField HeaderText="ID" DataField="ID" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Dirección" DataField="Direccion" />
                <asp:BoundField HeaderText="Teléfono" DataField="Telefono" />
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento" />
               
                <asp:BoundField HeaderText="IDEspecialidad" DataField="Id_especialidad" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <br />
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        Completar:<br />
        <asp:Label ID="emailLabel" runat="server" Text="Legajo: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="legajoTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="tipoLabel" runat="server" Text="Tipo:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="dTipo" runat="server">
            <asp:ListItem Value="2">Alumno</asp:ListItem>
            <asp:ListItem Value="2">Docente</asp:ListItem>
            <asp:ListItem Value="3">Admin</asp:ListItem>
        </asp:DropDownList>
        &nbsp;(1-Alumno 2-Docente 3-Admin)<br />
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nombreTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="apellidoTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="TelefonoLabel" runat="server" Text="Telefono:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TelefonoTextBox" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
        <br />
        <asp:Label ID="DireccionLabel" runat="server" Text="Dirección:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="DireccionTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="FechaNacLabel" runat="server" Text="Fecha Nacimiento:"></asp:Label>
        <asp:TextBox ID="FechaNacTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
        <br />
        <asp:Label ID="idesp" runat="server" Text="IDEspecialidad:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="desp" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
        <br />
    </asp:Panel>
    </asp:Panel>
</asp:Content>
