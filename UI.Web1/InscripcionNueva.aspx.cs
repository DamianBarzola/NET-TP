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
        CursoLogic cursos = new CursoLogic();
        MateriaLogic materias = new MateriaLogic();
        PlanLogic planes = new PlanLogic();
        AlumnoInscripcionLogic alumnos = new AlumnoInscripcionLogic();

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
            LoadGrid();
        }
        public void LoadGrid()
        {
            gridView.DataSource = cursos.GetPorAnio(Convert.ToInt32(DateTime.Now.Year));
            gridView.DataBind();
        }

        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {


        }

        protected void gridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }

    }
}
