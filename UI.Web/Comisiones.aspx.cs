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
    public partial class Comisiones : System.Web.UI.Page
    {
        private Comision Entity { get; set; }
        private ComisionLogic com = new ComisionLogic();

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

            gridView.DataSource = com.GetAll();
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
            Entity = com.GetOne(id);
            tbidplan.Text = Entity.IDPlan.ToString();
            descripcionTextBox.Text = Entity.Descripcion;
            añoEspecialidadTextBox.Text = Entity.AnioEspecialidad.ToString();
        }
        private void ClearForm()
        {
            Entity = null;
            añoEspecialidadTextBox.Text = string.Empty;
            descripcionTextBox.Text = string.Empty;
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
                if (formPanel.Visible) formPanel.Visible = false;

                this.FormMode = FormModes.Baja;

            }
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
        }

        private void LoadEntity(Comision comision)
        {
            if (descripcionTextBox.Text.Length > 0 && añoEspecialidadTextBox.Text.Length > 0 && tbidplan.Text.Length > 0)
                comision.Descripcion = descripcionTextBox.Text;
            comision.AnioEspecialidad = int.Parse(añoEspecialidadTextBox.Text);
             comision.IDPlan = int.Parse(tbidplan.Text);
        }
        private void SaveEntity(Comision comision)
        {
            com.Save(comision);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = com.GetOne(SelectedID);
                    com.Delete(Entity);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Comision();
                    Entity = com.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
                case FormModes.Alta:
                    Entity = new Comision();
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