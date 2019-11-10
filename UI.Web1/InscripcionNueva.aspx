<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InscripcionNueva.aspx.cs" Inherits="UI.Web.InscripcionNueva" %>
<asp:Content ID="bodyContent" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Label ID="lbmsj" runat="server" Text="Mensaje" Visible="False"></asp:Label>

    <br />
    <asp:GridView CssClass="table table-striped" ID="gridView" runat="server" AutoGenerateColumns="False" OnRowDataBound="gridView_RowDataBound" OnRowCommand="gridView_RowCommand" ViewStateMode="Enabled" DataKeyNames="ID" >
        <Columns>
            <asp:TemplateField HeaderText="Materia"><ItemTemplate> <asp:Label runat="server" ID="materiaLabel"></asp:Label> </ItemTemplate> </asp:TemplateField>
            <asp:TemplateField HeaderText="Comisión"> <ItemTemplate><asp:Label runat="server" ID="comisionLabel"></asp:Label></ItemTemplate> </asp:TemplateField>
            <asp:TemplateField HeaderText="Especialidad"> <ItemTemplate>  <asp:Label runat="server" ID="especialidadLabel"></asp:Label> </ItemTemplate>  

            </asp:TemplateField>
            <asp:ButtonField Text="Inscribirse" CommandName="Inscribirse" />
        </Columns>
    </asp:GridView>

    </asp:Content>
