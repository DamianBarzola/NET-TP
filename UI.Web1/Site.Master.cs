﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;


namespace UI.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        PersonaLogic persLog = new PersonaLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            Business.Entities.Persona a = persLog.GetOne((int)Session["idPersona"]);
            Session["tipo"] = a.Tipo;
            Session["id"] = a.ID;

            if (Session["username"] == null || Session["tipo"] == null)
            {
                Response.Redirect("/login.aspx");
            }
            else
            {
                nombreUsu.Text = Session["username"].ToString();
                if ((int)Session["tipo"] == 3)
                {
                    chABM.Visible = true;
                    chProfesor.Visible = false;
                    chMaterias.Visible = false;
                   

                }
                else if ((int)Session["tipo"] == 2)
                {
                    chABM.Visible = false;
                    chMaterias.Visible = false;
                    chProfesor.Visible = true;
                    
                  
                }
                else if ((int)Session["tipo"] == 1)
                {
                    chABM.Visible = false;
                    chMaterias.Visible = true;
                    chProfesor.Visible = false;
                   
                }

            }

        }
        protected void lbCerrarSesion_Click1(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("/login.aspx");
        }

        protected void lbInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void lbAgregInscrip_Click(object sender, EventArgs e)
        {

        }

      

        /*  protected void btnAceptar_Click(object sender, EventArgs e)
          {
              Business.Entities.Persona a = persLog.GetOne((int)Session["idPersona"]);
              if (txtEspecialidad.Text.Length != 0)
              {
                  a.Id_especialidad = Convert.ToInt32(txtEspecialidad.Text);
                  a.State = BusinessEntity.States.Modified;
                  persLog.Save(a);
              }
          }*/
    }
}
