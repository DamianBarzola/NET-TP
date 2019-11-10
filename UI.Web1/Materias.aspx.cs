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
    public partial class Materias : System.Web.UI.Page
    {
        private Materia Entity { get; set; }
        private MateriaLogic materias = new MateriaLogic();

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

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();

        }

        private void LoadGrid()
        {

            gridView.DataSource = materias.GetAll();
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
            Entity = materias.GetOne(id);
            tbidplan.Text = Entity.IDPlan.ToString();
            descripcionTextBox.Text = Entity.Descripcion;
            hsSemanalesTextBox.Text = Entity.HSSemanales.ToString();
            hsTotalesTextBox.Text = Entity.HSTotales.ToString();
        }
        private void ClearForm()
        {
            Entity = null;
            hsSemanalesTextBox.Text = string.Empty;
            descripcionTextBox.Text = string.Empty;
            hsTotalesTextBox.Text = string.Empty;
            tbidplan.Text = string.Empty;
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

        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {
                this.FormMode = FormModes.Baja;
                if (formPanel.Visible) formPanel.Visible = false;
                LoadGrid();
            }
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
        }

        private void LoadEntity(Materia materia)
        {
            if (descripcionTextBox.Text.Length > 0 && hsSemanalesTextBox.Text.Length > 0 && hsTotalesTextBox.Text.Length > 0 && tbidplan.Text.Length > 0)
                materia.Descripcion = descripcionTextBox.Text;
            materia.HSSemanales = int.Parse(hsSemanalesTextBox.Text);
            materia.HSTotales = int.Parse(hsTotalesTextBox.Text);
            materia.IDPlan = int.Parse(tbidplan.Text);

        }
        private void SaveEntity(Materia materia)
        {
            materias.Save(materia);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = materias.GetOne(SelectedID);
                    materias.Delete(Entity);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Materia();
                    Entity = materias.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
                case FormModes.Alta:
                    Entity = new Materia();
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