using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        private Usuario usuarioActual;
        public Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }

        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null) { _logic = new UsuarioLogic(); }
                return _logic;
            }
        }
        public enum FormModes { Alta, Baja, Modificacion }
        public FormModes FormMode
        {
            get { return (FormModes)ViewState["FormMode"]; }
            set { ViewState["FormMode"] = value; }
        }
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else return 0;
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (SelectedID != 0) UsuarioActual = Logic.GetOne(SelectedID);
            if (!IsPostBack)
            {
                LoadGrid();
            }

        }



        private Usuario Entity
        {
            get;
            set;
        }




        private bool isEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }
        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            Entity = Logic.GetOne(id);
           
            cbHabilitado.Checked = Entity.Habilitado;
            tbEmail.Text = Entity.Email;
            tbNombreUsuario.Text = Entity.NombreUsuario;

        }

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        private void LoadEntity(Usuario usuario)
        {

           
            usuario.Email = tbEmail.Text;
            usuario.NombreUsuario = tbNombreUsuario.Text;
            usuario.Clave = tbClave.Text;

            usuario.Habilitado = cbHabilitado.Checked;

        }
        private void SaveEntity(Usuario usuario)
        {
            Logic.Save(usuario);

        }

        private void EnableForm(bool a)
        {
          
            tbClave.Enabled = a;
            tbRepetirClave.Enabled = a;
            
            tbNombreUsuario.Enabled = a;
            cbHabilitado.Enabled = a;
            tbEmail.Enabled = a;
        }

        private void DeteleteEntity(Usuario usuario)
        {
            Logic.Delete(usuario.ID);
        }
        private void ClearForm()
        {
         
            tbEmail.Text = string.Empty;
            tbNombreUsuario.Text = string.Empty;
            cbHabilitado.Checked = false;
            tbClave.Text = string.Empty;
            tbRepetirClave.Text = string.Empty;
        }



        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {
                if (formPanel.Visible == true) formPanel.Visible = false;
                this.FormMode = FormModes.Baja;
                EnableForm(false);
                LoadForm(SelectedID);

            }
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
            this.EnableForm(true);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = Logic.GetOne(SelectedID);
                    Logic.Delete(Entity.ID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Usuario();
                    Entity = Logic.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
                case FormModes.Alta:
                    Entity = new Usuario();
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
            }

            formPanel.Visible = false;
        }

        protected void lbCancelar_Click(object sender, EventArgs e)
        {
            formPanel.Visible = false;

        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridView.SelectedValue;

        }
    }
}