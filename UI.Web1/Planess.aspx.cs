using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web1
{
    public partial class asd : System.Web.UI.Page
    {
        private Plan Entity { get; set; }

        private PlanLogic planes = new PlanLogic();

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
            gridView.DataSource = planes.GetAll();
            gridView.DataBind();
        }






        protected void lbEditar_Click(object sender, EventArgs e)
        {

            if (gridView != null)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
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
            Entity = planes.GetOne(id);
            descripcionTextBoxa.Text = Entity.DescripcionPlan;
            ideso.Text = Entity.IDEspecialidad.ToString();

        }
        private void ClearForm()
        {
            Entity = null;
            descripcionTextBoxa.Text = string.Empty;
        }

        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {
                if (formPanel.Visible) formPanel.Visible = false;
                FormMode = FormModes.Baja;
                Entity = new Plan();
                Entity = planes.GetOne(SelectedID);

                Entity.State = BusinessEntity.States.Deleted;
                planes.Delete(Entity.ID);
                LoadGrid();
            }
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
        }
        private void LoadEntity(Plan plan)
        {
            plan.DescripcionPlan = descripcionTextBoxa.Text;
            plan.IDEspecialidad = Convert.ToInt32(ideso.Text);
        }


        private void SaveEntity(Plan plan)
        {
            planes.Save(plan);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = planes.GetOne(SelectedID);
                    planes.Delete(Entity);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Plan();
                    Entity = planes.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
                case FormModes.Alta:
                    Entity = new Plan();
                    Entity.State = BusinessEntity.States.New;
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