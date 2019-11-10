<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Body" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Panel ID="gridPanel" runat="server">
        <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbEliminar" runat="server" OnClick="lbEliminar_Click">Eliminar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lbNuevo" runat="server" OnClick="lbNuevo_Click">Nuevo</asp:LinkButton>
        <br />
        <asp:GridView CssClass="table table-striped" ID="gridView" runat="server" 
            AutoGenerateColumns="False" DataKeyNames="ID" 
            OnSelectedIndexChanged="gridView_SelectedIndexChanged"
            SelectedRowStyle-BackColor="LightGray">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Materia" ReadOnly="True" SortExpression="Descripcion" />
                <asp:BoundField DataField="IDPlan" HeaderText="Plan" ReadOnly="True" SortExpression="Plan" />
                <asp:BoundField DataField="HSSemanales" HeaderText="Horas Semanales" ReadOnly="True" SortExpression="HSSemanales" />
                <asp:BoundField DataField="HSTotales" HeaderText="Horas Totales" ReadOnly="True" SortExpression="HSTotales" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="LightGray" />
        </asp:GridView>
        <asp:Panel ID="formPanel" runat="server" Visible="false">
            <br />
            Completar<br />
            <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
            <asp:TextBox ID="descripcionTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="hsSemanalesLabel" runat="server" Text="Horas Semanales: "></asp:Label>
            <asp:TextBox ID="hsSemanalesTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="hsTotalesLabel" runat="server" Text="Horas Totales: "></asp:Label>
            <asp:TextBox ID="hsTotalesTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="planLabel" runat="server" Text="Plan: "></asp:Label>
            <asp:TextBox ID="tbidplan" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
            <br />
        </asp:Panel>
    </asp:Panel>

</asp:Content>
