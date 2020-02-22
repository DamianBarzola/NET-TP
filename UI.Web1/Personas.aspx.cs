using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Util;

namespace UI.Web
{
    public partial class Personas : System.Web.UI.Page
    {
        private Business.Entities.Persona Entity { get; set; }

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
            List<Persona> per = personas.GetAll();
            gridView.DataSource = GenerarListas.GenerarPersona(per);
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
            dTipo.SelectedValue= ((int)Entity.Tipo).ToString();

            desp.SelectedValue = ((int)Entity.Id_especialidad).ToString();


            // tbidesp.Text = Entity.Id_especialidad.ToString();
            // planTextBox1.Text = Entity.IDPlan.ToString();
            // tipoTextBox1.Text = Entity.Tipo.ToString();
        }
        private void ClearForm()
        {
            Entity = null;
            nombreTextBox.Text = string.Empty;
          //  tbidesp.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            FechaNacTextBox.Text = string.Empty;
            legajoTextBox.Text = string.Empty;
            apellidoTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            desp.SelectedValue = 0.ToString();

            //  tipoTextBox1.Text = string.Empty;
            //planTextBox1.Text = string.Empty;
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
                Entity = new Business.Entities.Persona();
                Entity = personas.GetOne(SelectedID);
                Entity.State = BusinessEntity.States.Deleted;
                personas.Delete(Entity);
                LoadGrid();
                
            }
        }

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            CargarCombo();
            FormMode = FormModes.Alta;
            ClearForm();
        }
        private void LoadEntity(Business.Entities.Persona persona)
        {
            persona.Nombre = nombreTextBox.Text;
            persona.Apellido = apellidoTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;
            persona.Telefono = TelefonoTextBox.Text;
            persona.Id_especialidad = Convert.ToInt32(desp.SelectedValue);
            persona.FechaNacimiento = DateTime.Parse(FechaNacTextBox.Text);
            persona.Legajo = Convert.ToInt32(legajoTextBox.Text);
            
            if (dTipo.SelectedValue == "1") persona.Tipo = Business.Entities.Persona.TipoPersona.Alumno;
            if (dTipo.SelectedValue == "2") persona.Tipo = Business.Entities.Persona.TipoPersona.Docente;
            if (dTipo.SelectedValue == "3") persona.Tipo = Business.Entities.Persona.TipoPersona.Administrador;
           // persona.IDPlan = Convert.ToInt32(planTextBox1.Text);
        }
        private void SaveEntity(Business.Entities.Persona persona)
        {
            personas.Save(persona);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {

            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = new Business.Entities.Persona();
                    Entity = personas.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Deleted;
                    personas.Delete(Entity);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Business.Entities.Persona();
                    Entity = personas.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    LoadGrid();
                    formPanel.Visible = false;

                    break;
                case FormModes.Alta:
                    Entity = new Business.Entities.Persona();
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
        public void CargarCombo()
        {
            desp.DataSource = GenerarCombo.getEspecialidades();

            desp.DataValueField = "id_especialidad";
            desp.DataTextField = "descripcion";
            desp.DataBind();
        }
    }
}