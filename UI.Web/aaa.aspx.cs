using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;
using System.Data;

namespace UI.Web
{
    public partial class Usuario : System.Web.UI.Page
    {


        #region Propiedades(tp)
        private Usuario usuarioActual;
        public Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }

        private UsuarioLogic _logic;
        public UsuarioLogic Logic
        {
            get
            {
                if (_logic == null) { _logic = new UsuarioLogic(); }
                return _logic;
            }
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        private FormModes FormMode
        {
            get
            {
                return (FormModes)this.ViewState["FormMode"];
            }
            set
            {
                this.ViewState["FormMode"] = value;
            }
        }

        private Usuario Entity
        {
            get;
            set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                { return (int)this.ViewState["SelectedID"]; }
                else return 0;
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool isEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }
        #endregion


    #region Mostrar usuario existente para modificarlo

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
                {
                    this.SelectedID = (int)this.gvUsuarios.SelectedValue;
                }

        private void LoadForm(int id)
            {
            this.usuarioActual = this.Logic.GetOne(id);

        }

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        #endregion
        private void LoadGrid()
        {
            this.gvUsuarios.DataSource = this.Logic.GetAll();
            this.gvUsuarios.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

       
    }
}