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
    public partial class MisInscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {

            AlumnoInscripcionLogic insl = new AlumnoInscripcionLogic();
            UsuarioLogic ul = new UsuarioLogic();
            Usuario user = ul.GetOne(Session["username"].ToString());

            List<AlumnoInscripcion> inscripciones = insl.GetAll().Where(x => x.IDAlumno == user.ID).ToList();
            if (inscripciones.Count == 0)
            {
                divSinIns.Visible = true;
            }
            else
            {
                this.gvMisIns.DataSource = inscripciones;
                gvMisIns.DataBind();
            }


        }
    }
}