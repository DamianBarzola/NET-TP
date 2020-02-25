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

       /* private void LoadEntity(Especialidad especialidad)
        {
            especialidad.DescripcionEspecialidad = descripcionTextBox.Text;
        }*/

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {
                this.formPanel.Visible = true;
            this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                 }
        }

        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {

                if (formPanel.Visible) formPanel.Visible = false;

                FormMode = FormModes.Baja;
                Entity = new Especialidad();
                Entity = especialidades.GetOne(SelectedID);

                Entity.State = BusinessEntity.States.Deleted;
                especialidades.Delete(Entity.ID);
                LoadGrid();
                
            }

        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
        }
       /* private void SaveEntity(Especialidad especialidad)
        {
            especialidades.Save(especialidad);
        }*/

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                switch (FormMode)

                {
                    case FormModes.Baja:
                        Entity = new Especialidad();
                        Entity = especialidades.GetOne(SelectedID);

                        Entity.State = BusinessEntity.States.Deleted;
                        especialidades.Delete(Entity.ID);
                        LoadGrid();
                        /*EspecialidadActual.ID = SelectedID;
                        EspecialidadActual.State = BusinessEntity.States.Deleted;*/
                        break;

                    case FormModes.Modificacion:
                        Entity = new Especialidad();
                        Entity = especialidades.GetOne(SelectedID);
                        Entity.State = BusinessEntity.States.Modified;
                        if (descripcionTextBox.Text.Length > 0)
                        {
                            Entity.DescripcionEspecialidad = descripcionTextBox.Text;
                        }
                        especialidades.Save(Entity);

                        /*LoadEntity(Entity);
                        SaveEntity(Entity);*/
                        LoadGrid();
                        formPanel.Visible = false;

                        break;
                    case FormModes.Alta:
                        Entity = new Especialidad();
                        Entity.State = BusinessEntity.States.New;
                        //LoadEntity(Entity);
                        Entity.DescripcionEspecialidad = descripcionTextBox.Text;
                        // SaveEntity(Entity);
                        especialidades.Save(Entity);
                        LoadGrid();
                        formPanel.Visible = false;


                        break;
                }
                formPanel.Visible = false;
            }
            catch (Exception) { lblError.Visible = true; }

          
        }

        protected void lbCancelar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            formPanel.Visible = false;

        }

    }
}