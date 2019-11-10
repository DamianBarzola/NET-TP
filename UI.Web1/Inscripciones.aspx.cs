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
    public partial class Inscripciones : System.Web.UI.Page
    {
        public enum FormModes { Alta, Baja, Modificacion }
        private AlumnoInscripcion _AlumnoInscripcionActual;
        private AlumnoInscripcionLogic alins;
        private AlumnoInscripcion Entity { get; set; }

        public FormModes FormMode
        {
            get { return (FormModes)ViewState["FormMode"]; }
            set { ViewState["FormMode"] = value; }
        }
        public AlumnoInscripcion AlumnoInscripcionActual { get => _AlumnoInscripcionActual; set => _AlumnoInscripcionActual = value; }
        public AlumnoInscripcionLogic AlumnoInscripcionLogic
        {
            get
            {
                if (alins == null) { alins = new AlumnoInscripcionLogic(); }
                return alins;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
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

        protected void gvIns_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gvIns.SelectedValue;
            if (formPanel.Visible)
            {
                LoadForm(SelectedID);
            }
        }


        private void LoadGrid()
        {
            gvIns.DataSource = alins.GetAllFromUser(Convert.ToInt32(Session["id"].ToString()));
            gvIns.DataBind();
        }

        private void LoadForm(int id)
        {
            Entity = alins.GetOne(id);

            txAlumno.Text = Entity.IDAlumno.ToString();
            txCondi.Text = Entity.Condicion.ToString();
            txCurso.Text = Entity.IDCurso.ToString();
            txNota.Text = Entity.Nota.ToString();
        }
        private void ClearForm()
        {
            Entity = null;
            txAlumno.Text = string.Empty;
            txCondi.Text = string.Empty;
            txCurso.Text = string.Empty;
            txNota.Text = string.Empty;

        }

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            if (gvIns.SelectedValue != null)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            if (gvIns.SelectedValue != null)
            {
                if (formPanel.Visible) formPanel.Visible = false;

                this.FormMode = FormModes.Alta;
            }
        }

        private void LoadEntity(AlumnoInscripcion al)
        {
            al.Nota = Convert.ToInt32(txNota.Text);
            al.IDAlumno = Convert.ToInt32(txAlumno.Text);
            al.IDCurso = Convert.ToInt32(txCurso.Text);
            //Regular = 1, Aprobado = 2, Cursando = 3, Libre = 4
            if (txCondi.Text == "1") al.Condicion = AlumnoInscripcion.Condiciones.Regular;
            if (txCondi.Text == "2") al.Condicion = AlumnoInscripcion.Condiciones.Aprobado;
            if (txCondi.Text == "3") al.Condicion = AlumnoInscripcion.Condiciones.Cursando;
            if (txCondi.Text == "4") al.Condicion = AlumnoInscripcion.Condiciones.Libre;

        }
        private void SaveEntity(AlumnoInscripcion al)
        {
            alins.Save(al);
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)

            {
                case FormModes.Baja:
                    Entity = alins.GetOne(SelectedID);
                    alins.Delete(Entity);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new AlumnoInscripcion();
                    Entity = alins.GetOne(SelectedID);
                    Entity.State = BusinessEntity.States.Modified;
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