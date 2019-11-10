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
    public partial class Personas : System.Web.UI.Page
    {
        private Persona Entity { get; set; }
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

        private PersonaLogic personas = new PersonaLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gridView.SelectedValue;
            if (formPanel.Visible)
            {
                LoadForm(SelectedID);
            }
        }
        private void LoadGrid()
        {
            gridView.DataSource = personas.GetAll();
            gridView.DataBind();
        }
        private void LoadForm(int id)
        {
            Entity = personas.GetOne(id);
            nombreTextBox.Text = Entity.Nombre;
            legajoTextBox.Text = Entity.Legajo.ToString();
            DireccionTextBox.Text = Entity.Direccion;
            apellidoTextBox.Text = Entity.Apellido;
            FechaNacTextBox.Text = Entity.FechaNacimiento.ToString("yyyy-MM-dd");
            TelefonoTextBox.Text = Entity.Telefono;
            planTextBox1.Text = Entity.IDPlan.ToString();
            tipoTextBox1.Text = Entity.Tipo.ToString();
        }
        private void ClearForm()
        {
            Entity = null;
            nombreTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            FechaNacTextBox.Text = string.Empty;
            legajoTextBox.Text = string.Empty;
            apellidoTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            tipoTextBox1.Text = string.Empty;
            planTextBox1.Text = string.Empty;
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

                this.FormMode = FormModes.Alta;
            }
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
        }
        private void LoadEntity(Persona persona)
        {
            persona.Nombre = nombreTextBox.Text;
            persona.Apellido = apellidoTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;
            persona.Telefono = TelefonoTextBox.Text;
            persona.FechaNacimiento = DateTime.Parse(FechaNacTextBox.Text);
            persona.Legajo = Convert.ToInt32(legajoTextBox.Text);
            if (tipoTextBox1.Text == "1") persona.Tipo = Persona.TipoPersona.Alumno;
            if (tipoTextBox1.Text == "2") persona.Tipo = Persona.TipoPersona.Docente;
            if (tipoTextBox1.Text == "3") persona.Tipo = Persona.TipoPersona.Administrador;
            persona.IDPlan = Convert.ToInt32(planTextBox1.Text);
        }
        private void SaveEntity(Persona persona)
        {
            personas.Save(persona);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = personas.GetOne(SelectedID);
                    personas.Delete(Entity);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Persona();
                    Entity = personas.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
                case FormModes.Alta:
                    Entity = new Persona();
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