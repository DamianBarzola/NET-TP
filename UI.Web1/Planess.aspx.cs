using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Util;

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
            if ((int)Session["tipo"] == 3)
            {
                LoadGrid();


            }
            else if ((int)Session["tipo"] == 2)
            {
                Response.Redirect("/Default.aspx");
            }
            else if ((int)Session["tipo"] == 1)
            {
                Response.Redirect("/Default.aspx");
            }

        }
        private void LoadGrid()
        {
            List<Plan> plan = planes.GetAll();
            gridView.DataSource = GenerarListas.GenerarPlan(plan);

            gridView.DataBind();
        }






        protected void lbEditar_Click(object sender, EventArgs e)
        {

            if (gridView.SelectedValue != null)
            {
                this.formPanel.Visible = true;
               
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                CargarCombo();
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
            dpespe.SelectedValue = ((int)Entity.IDEspecialidad).ToString();

            //  ideso.Text = Entity.IDEspecialidad.ToString();

        }

        private void ClearForm()
        {
            Entity = null;
            descripcionTextBoxa.Text = string.Empty;
            dpespe.SelectedValue = 0.ToString();
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
            CargarCombo();
            FormMode = FormModes.Alta;
            CargarCombo();
            ClearForm();
        }
        private void LoadEntity(Plan plan)
        {
            if (descripcionTextBoxa.Text.Length > 0)
            {
                plan.DescripcionPlan = descripcionTextBoxa.Text;
                plan.IDEspecialidad = Convert.ToInt32(dpespe.SelectedValue);
                dpespe.SelectedValue = ((int)Entity.IDEspecialidad).ToString();
            }
        }


        private void SaveEntity(Plan plan)
        {
            planes.Save(plan);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
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
            catch(Exception) { lblError.Visible = true; }
        }

        protected void lbCancelar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            formPanel.Visible = false;
        }

        public void CargarCombo()
        {
            dpespe.DataSource = GenerarCombo.getEspecialidades();
           
            dpespe.DataValueField = "id_especialidad";
            dpespe.DataTextField = "descripcion";
            dpespe.DataBind();
        }
    }
}