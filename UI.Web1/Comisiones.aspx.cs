using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Util;
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
            List<Comision> comi = com.GetAll();
            gridView.DataSource = GenerarListas.GenerarComision(comi);
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
            dmate.SelectedValue = ((int)Entity.IDMateria).ToString();

            dprofe.SelectedValue = ((int)Entity.IdProfesor).ToString();
            /*
            tbidprof.Text = Entity.IdProfesor.ToString();
            tbidMateria.Text = Entity.IDMateria.ToString();*/
            añoEspecialidadTextBox.Text = Entity.AnioEspecialidad.ToString();
        }
        private void ClearForm()
        {
            Entity = null;
            añoEspecialidadTextBox.Text = string.Empty;
            dmate.SelectedValue = 0.ToString();
            dprofe.SelectedValue = 0.ToString();
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

        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedValue != null)
            {
                if (formPanel.Visible) formPanel.Visible = false;

                this.FormMode = FormModes.Baja;
                Entity = new Comision();
                Entity = com.GetOne(SelectedID);
                Entity.State = BusinessEntity.States.Deleted;
                com.Delete(Entity);
                LoadGrid();

            }
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
            CargarCombo();
        }

        private void LoadEntity(Comision comision)
        {
            if (//tbidprof.Text.Length > 0 && 
                añoEspecialidadTextBox.Text.Length > 0
                //&& tbidMateria.Text.Length > 0
                )
            {
                comision.IDMateria = int.Parse(dmate.SelectedValue);
                comision.AnioEspecialidad = int.Parse(añoEspecialidadTextBox.Text);
                comision.IdProfesor = int.Parse(dprofe.SelectedValue);
            }
        }
        private void SaveEntity(Comision comision)
        {
            com.Save(comision);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                switch (FormMode)

                {
                    case FormModes.Baja:
                        Entity = new Comision();
                        Entity = com.GetOne(SelectedID);
                        Entity.State = BusinessEntity.States.Deleted;
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
                        Entity.State = BusinessEntity.States.New;
                        LoadEntity(Entity);
                        SaveEntity(Entity);
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

        public void CargarCombo()
        {
            dmate.DataSource = GenerarCombo.getMaterias();
            dmate.DataValueField = "id_materia";
            dmate.DataTextField = "descripcion";
            dmate.DataBind();


            dprofe.DataSource = GenerarCombo.getProfesores();
            dprofe.DataValueField = "id_persona";
            dprofe.DataTextField = "apellido";
            dprofe.DataBind();


        }
    }
}