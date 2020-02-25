<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>
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
                <asp:BoundField DataField="ID" HeaderText="Comision" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="AnioEspecialidad" HeaderText="Año de Especialidad" ReadOnly="True" SortExpression="AñoEspecialidad" />
                <asp:BoundField DataField="IDMateria" HeaderText="Materia" ReadOnly="True" SortExpression="IDMateria" />
                <asp:BoundField DataField="IdProfesor" HeaderText="Profesor" ReadOnly="True" SortExpression="IdProfesor" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="LightGray" />
        </asp:GridView>
        <asp:Label ID="lblError" runat="server" BackColor="#CC0000" Visible="False">Error de Servidor</asp:Label>
        <br />
        <asp:Panel ID="formPanel" runat="server" Visible="false">
            Completar:<br />
            Materia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="dmate" runat="server" Height="18px" Width="124px">
            </asp:DropDownList>
            <br />
            <asp:Label ID="añoEspecialidadLabel" runat="server" Text="Año Especialidad: "></asp:Label>
            <asp:TextBox ID="añoEspecialidadTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            Profesor&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="dprofe" runat="server" Height="18px" Width="126px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
            <br />
            <br />
        </asp:Panel>
    </asp:Panel>

</asp:Content>
