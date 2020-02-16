<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
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
                
                &nbsp;<asp:LinkButton ID="lbEliminar" runat="server" OnClick="lbEliminar_Click">Eliminar</asp:LinkButton>
                <asp:GridView ID="gvIns" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="white"
                    DataKeyNames="ID" 
                    CssClass="table table-bordered table-sm table-responsive table-hover" 
                    OnSelectedIndexChanged="gvIns_SelectedIndexChanged" >
                <Columns>
                    
                    <asp:BoundField HeaderText="Alumno" DataField="id_persona" ItemStyle-Width="40%"/>
                    <asp:BoundField HeaderText="Comision" DataField="id_comision" ItemStyle-Width="20%"/>
                   
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
                <HeaderStyle CssClass="thead-light" />
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <div runat="server" id="divSinIns" visible="false">
        <br />
    </div>
</asp:Content>
