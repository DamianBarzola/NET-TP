<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>

<asp:Content ID="aa" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click"> Editar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbEliminar" runat="server" OnClick="lbEliminar_Click" >Eliminar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbNuevo" runat="server" OnClick="lbNuevo_Click" >Nuevo</asp:LinkButton>
        <br />
        <br />
        <asp:GridView ID="gridView" runat="server" 
            AutoGenerateColumns="False" DataKeyNames="ID" 
            SelectedRowStyle-BackColor="LightGray" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="DescripcionEspecialidad" HeaderText="Descripción" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="LightGray" />
        </asp:GridView>
        <asp:Label ID="lblError" runat="server" BackColor="#CC0000" Visible="False">Error de Servidor</asp:Label>
        <br />
        <asp:Panel ID="formPanel" Visible="false" runat="server">
            Completar:<br />
            <asp:Label ID="descripcionLabel" runat="server" Text="Descripción:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox CssClass="form-control" ID="descripcionTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click" >Aceptar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click" >Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>