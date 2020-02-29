<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Anota.aspx.cs" Inherits="UI.Web1.Anota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="chABM" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="chMaterias" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="chProfesor" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <br />
    Comision&nbsp;<asp:DropDownList ID="ddComision" runat="server" OnSelectedIndexChanged="ddComision_SelectedIndexChanged">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    Alumno&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddAlumno" runat="server">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Buscar</asp:LinkButton>
    <br />
    <asp:Panel ID="formPanel" runat="server" Visible="false">
   
        <br />
        <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
        <br />
<asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
&nbsp;
<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
         <br />
         </asp:Panel>
</asp:Content>
