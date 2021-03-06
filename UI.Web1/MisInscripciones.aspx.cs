﻿using System;
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
    public partial class MisInscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["tipo"] == 3)
            {
                Response.Redirect("/Default.aspx");
            }
            else if ((int)Session["tipo"] == 2)
            {
                Response.Redirect("/Default.aspx");
            }
            else if ((int)Session["tipo"] == 1)
            {
                LoadGrid();
            }
        }
        private void LoadGrid()
        {

            AlumnoInscripcionLogic insl = new AlumnoInscripcionLogic();
            UsuarioLogic ul = new UsuarioLogic();
            Usuario user = ul.GetOne(Session["username"].ToString());

           

            List<AlumnoInscripcion> inscripciones = insl.GetAll().Where(x => x.IDAlumno == user.Id_persona).ToList();
            if (inscripciones.Count == 0)
            {
                divSinIns.Visible = true;
            }
            else
            {
                List<Comision> asd = new List<Comision>();
                ComisionLogic a = new ComisionLogic();
                inscripciones.ForEach(delegate (AlumnoInscripcion alum)
                    {
                       
                        
                        asd.Add(a.GetOne(alum.IDComision));

                    });
                this.gvMisIns.DataSource = GenerarListas.GenerarComision( asd);
                gvMisIns.DataBind();
            }




        }
    }
}