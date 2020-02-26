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
   
    <br />
            1ºParcial&nbsp;
            <asp:DropDownList ID="ddl" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            &nbsp; &nbsp;<br /> 2ºParcial&nbsp;
            <asp:DropDownList ID="ddl0" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            &nbsp; &nbsp;&nbsp;&nbsp;<br /> 3ºParcial&nbsp;
            <asp:DropDownList ID="ddl1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            &nbsp; &nbsp;&nbsp;&nbsp;<br /> Nota Final&nbsp;
            <asp:DropDownList ID="ddl2" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<uc1:WebUserControl1 ID="Parciales" runat="server" Visible="true" />
<asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
&nbsp;
<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
         </asp:Panel>
</asp:Content>
