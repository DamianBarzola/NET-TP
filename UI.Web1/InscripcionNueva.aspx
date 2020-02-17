<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InscripcionNueva.aspx.cs" Inherits="UI.Web.InscripcionNueva" %>
<asp:Content ID="bodyContent" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

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
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="lbaceptar" runat="server" OnClick="lbNuevo_Click">Aceptar</asp:LinkButton>
        
    </asp:Content>
