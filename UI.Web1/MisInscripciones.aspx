<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisInscripciones.aspx.cs" Inherits="UI.Web.MisInscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <div>
        <br />
    </div>

    <hr />

    <div class="grid-view">
        <asp:GridView ID="gvMisIns" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="white"
            DataKeyNames="ID" 
            CssClass="table table-bordered table-sm table-responsive table-hover">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="ID" />
            <asp:BoundField HeaderText="Año" DataField="AnioEspecialidad" />
            <asp:BoundField HeaderText="Materia" DataField="IDMateria" />
            <asp:BoundField HeaderText="Profesor" DataField="IdProfesor" />
        </Columns>
        </asp:GridView>
    </div>
    <div runat="server" id="divSinIns" visible="false">
        <br />
    </div>
</asp:Content>
