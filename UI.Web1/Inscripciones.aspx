<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

        <!-- Modal para cargar, editar o eliminar -->    
    <div class="modal fade" id="ModalInscripciones" tabindex="-1" role="dialog" >
        <div class="modal-dialog modal-dialog-centered" role="document">

        </div>
    </div>

    <div class="grid-view">
        <asp:UpdatePanel ID="UpdatePanelGrid" runat="server" UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAceptar"/>
            </Triggers>

            <ContentTemplate>
                
                &nbsp;<asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar</asp:LinkButton>
                <asp:GridView ID="gvIns" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="white"
                    DataKeyNames="Alumno,Comision" 
                    CssClass="table table-bordered table-sm table-responsive table-hover" 
                    OnSelectedIndexChanged="gvIns_SelectedIndexChanged" >
                <Columns>
                    
                    <asp:BoundField HeaderText="Alumno" DataField="id_persona" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Comision" DataField="id_comision" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="1ºParcial" DataField="parcial1" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="2ºParcial" DataField="parcial2" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="3ºParcial" DataField="parcial3" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="Nota Final" DataField="notafinal" ItemStyle-Width="15%"/>
                   
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
                <HeaderStyle CssClass="thead-light" />
                </asp:GridView>
                <asp:Label ID="lblError" runat="server" BackColor="#CC0000" Visible="False">Error de Servidor</asp:Label>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <div runat="server" id="divSinIns" visible="false">
        <uc1:WebUserControl1 ID="Parciales" runat="server" />
    </div>
                <br />
                <asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
                &nbsp;&nbsp;&nbsp; <asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>

        <br />
</asp:Content>
