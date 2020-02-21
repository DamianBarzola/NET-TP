using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Business.Logic;
using Business.Entities;

namespace Util
{
    public class GenerarCombo
    {

        public static DataTable getEspecialidades()
        {
            DataTable dtEspecialidades = new DataTable();
            dtEspecialidades.Columns.Add("id_especialidad", typeof(int));
            dtEspecialidades.Columns.Add("descripcion", typeof(string));
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> especialidades = el.GetAll();
            dtEspecialidades.Rows.Add(new object[] { 0, string.Empty });
            foreach (Especialidad esp in especialidades)
            {
                    dtEspecialidades.Rows.Add(new object[] { esp.ID, esp.DescripcionEspecialidad });
            }
            return dtEspecialidades;
        }


        public static DataTable getPlanes()
        {
            DataTable dtPlanes = new DataTable();
            dtPlanes.Columns.Add("id_plan", typeof(int));
            dtPlanes.Columns.Add("descripcion", typeof(string));
            PlanLogic pl = new PlanLogic();
            List<Plan> planes = pl.GetAll();
            dtPlanes.Rows.Add(new object[] { 0, string.Empty });
            foreach (Plan plan in planes)
            {
                    dtPlanes.Rows.Add(new object[] { plan.ID, plan.DescripcionPlan });
            }
            return dtPlanes;
        }

        public static DataTable getMaterias()
        {
            DataTable dtMaterias = new DataTable();
            dtMaterias.Columns.Add("id_materia", typeof(int));
            dtMaterias.Columns.Add("descripcion", typeof(string));
            MateriaLogic ml = new MateriaLogic();
            List<Materia> materias = ml.GetAll();
            dtMaterias.Rows.Add(new object[] { 0, string.Empty });
            foreach (Materia m in materias)
            {
                dtMaterias.Rows.Add(new object[] { m.ID, m.Descripcion});
            }
            return dtMaterias;
        }

        public static DataTable getProfesores()
        {
            DataTable dtProfesores = new DataTable();
            dtProfesores.Columns.Add("id_persona", typeof(int));
            dtProfesores.Columns.Add("apellido", typeof(string));
            PersonaLogic pl = new PersonaLogic();
            List<Persona> personas = pl.GetProfesores();
            dtProfesores.Rows.Add(new object[] { 0, string.Empty });
            foreach (Persona p in personas)
            {
                dtProfesores.Rows.Add(new object[] { p.ID, p.Apellido });
            }
            return dtProfesores;
        }

        public static DataTable getPersona()
        {
            DataTable dtProfesores = new DataTable();
            dtProfesores.Columns.Add("id_persona", typeof(int));
            dtProfesores.Columns.Add("apellido", typeof(string));
            PersonaLogic pl = new PersonaLogic();
            List<Persona> personas = pl.GetAll();
            dtProfesores.Rows.Add(new object[] { 0, string.Empty });
            foreach (Persona p in personas)
            {
                dtProfesores.Rows.Add(new object[] { p.ID, p.Apellido });
            }
            return dtProfesores;
        }




    }
}
