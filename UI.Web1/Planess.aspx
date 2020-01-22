<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planess.aspx.cs" Inherits="UI.Web1.asd" %>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click"> Editar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbEliminar" runat="server" OnClick="lbEliminar_Click">Eliminar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbNuevo" runat="server" OnClick="lbNuevo_Click">Nuevo</asp:LinkButton>
        <br />
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" SelectedRowStyle-BackColor="LightGray">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="DescripcionPlan" HeaderText="Descripción" />
                <asp:BoundField DataField="IDEspecialidad" HeaderText="Especialidad" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="LightGray" />
        </asp:GridView>
        <br />
        <asp:Panel ID="formPanel" Visible="false" runat="server">
            Completar:<br />&nbsp;<asp:Label ID="descripcionLabel" runat="server" Text="Descripción:"></asp:Label>
            &nbsp;<asp:TextBox ID="descripcionTextBoxa" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="EspecialidadLabel" runat="server" Text="Especialidad:"></asp:Label>
            <asp:TextBox ID="ideso" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
            <br />
            <br />
        </asp:Panel>
    </asp:Panel>
</asp:Content>