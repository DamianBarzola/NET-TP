<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgNota.aspx.cs" Inherits="UI.Web1.AgNota" %>
<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="chABM" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="chMaterias" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="chProfesor" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar</asp:LinkButton>
<asp:GridView ID="gvIns" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="white"
                    DataKeyNames="IDAlumno,IDComision" 
                    CssClass="table table-bordered table-sm table-responsive table-hover" 
                    OnSelectedIndexChanged="gvIns_SelectedIndexChanged" >
    <Columns>
        <asp:BoundField HeaderText="Alumno" DataField="IDAlumno" ItemStyle-Width="20%"/>
        <asp:BoundField HeaderText="Comision" DataField="IDComision" ItemStyle-Width="15%"/>
        <asp:BoundField HeaderText="1ºParcial" DataField="Parcial1" ItemStyle-Width="15%"/>
        <asp:BoundField HeaderText="2ºParcial" DataField="Parcial2" ItemStyle-Width="15%"/>
        <asp:BoundField HeaderText="3ºParcial" DataField="Parcial3" ItemStyle-Width="15%"/>
        <asp:BoundField HeaderText="Nota Final" DataField="Notafinal" ItemStyle-Width="15%"/>
        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
    </Columns>
    <HeaderStyle CssClass="thead-light" />
</asp:GridView>
<asp:Label ID="lblError" runat="server" BackColor="#CC0000" Visible="False">Error de Servidor</asp:Label>
    <br />
    <asp:Panel ID="formPanel" runat="server" Visible="false">
   
            &nbsp; &nbsp;<uc1:WebUserControl1 ID="Parciales" runat="server" Visible="true" />
<asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
&nbsp;
<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
         </asp:Panel>
</asp:Content>
