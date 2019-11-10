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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblError.Visible = false;
                lblBadLogin.Visible = false;
                if (Session["username"] != null && Session["idPersona"] != null)
                {
                    Response.Redirect("/Default.aspx");
                }
            }
        }

        protected void btIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioLogic ul = new UsuarioLogic();
                Usuario user = ul.GetOne(txtUsuario.Text);
                if (txtUsuario.Text.Equals(user.NombreUsuario) && txtPass.Text.Equals(user.Clave))
                {
                    Session["username"] = user.NombreUsuario;
                    Session["idPersona"] = user.IDPersona;
                    Response.Redirect("/Default.aspx");
                }
                else
                {
                    lblError.Visible = false;
                    lblBadLogin.Visible = true;
                }
            }
            catch (Exception)
            {
                lblError.Visible = true;
                lblBadLogin.Visible = false;
            }
        }
    }
}