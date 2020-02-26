using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web1
{
    public partial class AgNota : System.Web.UI.Page
    {

        public enum FormModes { Alta, Baja, Modificacion }
        private AlumnoInscripcion _AlumnoInscripcionActual;
        private AlumnoInscripcionLogic alins;
        int a, b, c;
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
            formPanel.Visible = false;
           
            
            lblError.Visible = false;
            LoadGrid();
        }

        protected void lbEditar_Click(object sender, EventArgs e)
        {
            if (gvIns.SelectedValue != null)
            {
                formPanel.Visible = true;
                lblError.Visible = false;
            //    Parciales.Visible = true;
              
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
        protected void gvIns_SelectedIndexChanged(object sender, EventArgs e)//
        {
           

            a = (int)gvIns.SelectedIndex;
            b= Convert.ToInt32(gvIns.Rows[a].Cells[1].Text);
            c= Convert.ToInt32(gvIns.Rows[a].Cells[2].Text);


        }
        private void LoadGrid()//
        {

            //  gvIns.DataSource = alins.GetAllFromUser(Convert.ToInt32(Session["id"]));
            gvIns.DataSource = AlumnoInscripcionLogic.GetAllProf(Convert.ToInt32(Session["idPersona"]));
            gvIns.DataBind();
        }

        protected void lbCancelar_Click(object sender, EventArgs e)
        {
        //    Parciales.Visible = false;

            lblError.Visible = false;
        }

        protected void lbAceptar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            try
           {
                Entity = new AlumnoInscripcion();
                Entity = alins.GetOne(b,c);
                Entity.State = BusinessEntity.States.Modified;
                LoadEntity(Entity);
                SaveEntity(Entity);
                LoadGrid();
                //   Parciales.Visible = false;
                formPanel.Visible = false;
              
            }            catch (Exception) { lblError.Visible = true; }
        }
        private void SaveEntity(AlumnoInscripcion al)
        {
            alins.Save(al);
        }
    }
}