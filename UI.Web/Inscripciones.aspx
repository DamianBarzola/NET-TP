<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

        <!-- Modal para cargar, editar o eliminar -->    
    <div class="modal fade" id="ModalInscripciones" tabindex="-1" role="dialog" >
        <div class="modal-dialog modal-dialog-centered" role="document">

            <div class="modal-content">                
            </div>
        </div>
    </div>

    <div class="grid-view">
        <asp:UpdatePanel ID="UpdatePanelGrid" runat="server" UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAceptar"/>
            </Triggers>

            <ContentTemplate>
                <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lbEliminar" runat="server" OnClick="lbEliminar_Click">Eliminar</asp:LinkButton>
                <asp:GridView ID="gvIns" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="white"
                    DataKeyNames="ID" 
                    CssClass="table table-bordered table-sm table-responsive table-hover" 
                    OnSelectedIndexChanged="gvIns_SelectedIndexChanged" >
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="Id" />
                    <asp:BoundField HeaderText="Alumno" DataField="Alumno" ItemStyle-Width="40%"/>
                    <asp:BoundField HeaderText="Curso" DataField="Curso" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Nota" DataField="Nota" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Condicion" DataField="Condicion" ItemStyle-Width="20%"/>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
                <HeaderStyle CssClass="thead-light" />
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <div runat="server" id="divSinIns" visible="false">
        <asp:Panel ID="formPanel" runat="server" Visible="false">
            <br />
            Completar<br /> Alumno<asp:TextBox ID="txAlumno" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            Curso<asp:TextBox ID="txCurso" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            Nota<asp:TextBox ID="txNota" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            Condicion<asp:TextBox ID="txCondi" runat="server"></asp:TextBox>
            (Regular = 1, Aprobado = 2, Cursando = 3, Libre = 4)<br />&nbsp;<br /><asp:LinkButton ID="lbAceptar" runat="server" OnClick="lbAceptar_Click">Aceptar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lbCancelar" runat="server" OnClick="lbCancelar_Click">Cancelar</asp:LinkButton>
            <br />
        </asp:Panel>
        <br />
    </div>
</asp:Content>
