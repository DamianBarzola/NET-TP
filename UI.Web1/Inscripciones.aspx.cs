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
            GridViewRow a = gvIns.SelectedRow;
            SelectedID = (int)gvIns.SelectedValue;
            
            
        }


        private void LoadGrid()
        {

            gvIns.DataSource = alins.GetAllFromUser(Convert.ToInt32(Session["id"]));
            gvIns.DataBind();
        }

        /*private void LoadForm(int id)
        {
            Entity = alins.GetOne(id);
             
            txA.Text = Entity.IDAlumno.ToString();
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

        }*/

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            if (gvIns.SelectedValue != null)
            {
                lblError.Visible = false;
                Parciales.Visible = true;
                lbAceptar.Visible = true;
                lbCancelar.Visible = true;
                this.FormMode = FormModes.Modificacion;
              //this.LoadForm(this.SelectedID);
            }
        }

        private void LoadEntity(AlumnoInscripcion al)
        {
           
            al.Parcial1 = Parciales.SelectedID1;
            al.Parcial2 = Parciales.SelectedID2;
            al.Parcial3 = Parciales.SelectedID3;
            al.Notafinal = Parciales.SelectedID4;

        }
        private void SaveEntity(AlumnoInscripcion al)
        {
            alins.Save(al);
        }

        protected void lbCancelar_Click(object sender, EventArgs e)
        {
            Parciales.Visible = false;
            lbAceptar.Visible = false;
            lbCancelar.Visible = false;
            lblError.Visible = false;
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            try
            {
                Entity = new AlumnoInscripcion();
             //   Entity = alins.GetOne(SelectedID);
                Entity.State = BusinessEntity.States.Modified;
                LoadEntity(Entity);
                SaveEntity(Entity);
                LoadGrid();
                Parciales.Visible = false;
                lbAceptar.Visible = false;
                lbCancelar.Visible = false;
            }
            catch (Exception) { lblError.Visible = true; }
        }
    }
}