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
    public partial class Especialidades : System.Web.UI.Page
    {
        private Especialidad Entity { get; set; }

        private EspecialidadLogic especialidades = new EspecialidadLogic();
        protected enum FormModes
        {
            Alta, Baja, Modificacion
        }
        protected FormModes FormMode
        {
            get
            {
                return (FormModes)ViewState["FormMode"];
            }
            set
            {
                ViewState["FormMode"] = value;
            }
        }

        protected int SelectedID
        {
            get
            {
                if (ViewState["SelectedID"] != null)
                {
                    return (int)ViewState["SelectedID"];
                }
                else return 0;
            }
            set
            {
                ViewState["SelectedID"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();

        }
        private void LoadGrid()
        {
            gridView.DataSource = especialidades.GetAll();
            gridView.DataBind();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridView.SelectedValue;
            if (formPanel.Visible)
            {
                LoadForm(SelectedID);
            }
        }
        private void LoadForm(int id)
        {
            Entity = especialidades.GetOne(id);
            descripcionTextBox.Text = Entity.DescripcionEspecialidad;
        }
        private void ClearForm()
        {
            Entity = null;
            descripcionTextBox.Text = string.Empty;
        }

        private void LoadEntity(Especialidad especialidad)
        {
            especialidad.DescripcionEspecialidad = descripcionTextBox.Text;
        }

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                    }

        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {
                if (formPanel.Visible) formPanel.Visible = false;
                FormMode = FormModes.Baja;
                LoadGrid();
            }
            
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
        }
        private void SaveEntity(Especialidad especialidad)
        {
            especialidades.Save(especialidad);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = especialidades.GetOne(SelectedID);
                    especialidades.Delete(Entity);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Especialidad();
                    Entity = especialidades.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
                case FormModes.Alta:
                    Entity = new Especialidad();
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

    }
}