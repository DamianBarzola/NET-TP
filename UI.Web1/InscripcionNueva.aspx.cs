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
    public partial class InscripcionNueva : System.Web.UI.Page
    {
        ComisionLogic com = new ComisionLogic();
      

        AlumnoInscripcion al = new AlumnoInscripcion();

        AlumnoInscripcionLogic alumnos = new AlumnoInscripcionLogic();
        private Comision Entity { get; set; }
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
            lblError.Visible = false;
            LoadGrid();
        }
        public void LoadGrid()
        {
            lblError.Visible = false;
            List<Comision> a = new List<Comision>();
            a = com.GetPorAnio();
            if (a.Count == 0)
            {
               // Panel1.Visible = true;
                lbaceptar.Visible = false;
            }
            else {
                
                lbaceptar.Visible = true;
                //Panel1.Visible = false;
                gridView.DataSource = com.GetPorAnio();
                gridView.DataBind();
            }

        }

        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {


        }

     

        protected void lbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                Entity = new Comision();
                Entity.State = BusinessEntity.States.New;



                Entity = com.GetOne(SelectedID);
                if (Entity != null)
                {


                    al.IDAlumno = Convert.ToInt32(Session["idPersona"]);
                    al.IDComision = Entity.ID;
                    alumnos.Insert(al);
                    //gridView.visible = false;
                    lbaceptar.Visible = false;
                    //Panel2.visible = true;
                }
            }
            catch (Exception) { lblError.Visible = true; }
            
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
            SelectedID = (int)gridView.SelectedValue;
            
        }
    }
}
