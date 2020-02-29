using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Util;

namespace UI.Web1
{
    public partial class Anota : System.Web.UI.Page
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
            ddComision.DataSource = GenerarCombo.getComisiones();

            ddComision.DataValueField = "id_comision";
            ddComision.DataTextField = "id_comision";
            ddComision.DataBind();
        }

        protected void lbCancelar_Click(object sender, EventArgs e)
        {
            formPanel.Visible = false;

        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {

            //Entity = new AlumnoInscripcion();
            // Entity = alins.GetOne(b, c);
            AlumnoInscripcionActual.State = BusinessEntity.States.Modified;
            LoadEntity(AlumnoInscripcionActual);
            AlumnoInscripcionLogic.Save(AlumnoInscripcionActual);
            formPanel.Visible = false;

        }

        private void LoadEntity(AlumnoInscripcion al)
        {

            al.Parcial1 = WebUserControl11.SelectedID1;
            al.Parcial2 = WebUserControl11.SelectedID2;
            al.Parcial3 = WebUserControl11.SelectedID3;
            al.Notafinal = WebUserControl11.SelectedID4;


        }


        protected void ddComision_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddAlumno.DataSource = GenerarCombo.getAlumno(Convert.ToInt32(ddComision.SelectedValue));

            ddAlumno.DataValueField = "id_persona";
            ddAlumno.DataTextField = "apellido";
            ddAlumno.DataBind();

        }

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            if (ddAlumno.SelectedValue != null && ddComision.SelectedValue != null)
            {
                WebUserControl11.Visible = true;

                //  this.FormMode = FormModes.Modificacion;
                AlumnoInscripcionActual = AlumnoInscripcionLogic.GetOne(Convert.ToInt32(ddComision.SelectedValue), Convert.ToInt32(ddAlumno.SelectedValue));
                this.LoadForm(AlumnoInscripcionActual);
            }
        }
        protected void LoadForm(AlumnoInscripcion a)
        {
            WebUserControl11.SelectedID1 = a.Parcial1;
            WebUserControl11.SelectedID2 = a.Parcial2;
            WebUserControl11.SelectedID3 = a.Parcial3;
            WebUserControl11.SelectedID4 = a.Notafinal;
        }

     
    }
}